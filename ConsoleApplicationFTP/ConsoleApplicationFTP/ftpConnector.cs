using System;
using System.Collections.Generic;
using System.Net;
using System.IO;
namespace ConsoleApplicationFTP
{
    public class ftpConnector
    {
        public string ip = string.Empty;
        public string id = string.Empty;
        public string pwd = string.Empty;
        public string target = string.Empty;

        public ftpConnector()
        {
        }

        // FTP 서버 접속 함수
        private FtpWebResponse Connect(string ip, string method, Action<FtpWebRequest> action = null)
        {
            // WebRequest 클래스를 이용해 접속하기 때문에 객체를 가져온다. (FtpWebRequest로 변환)
            var request = WebRequest.Create(ip) as FtpWebRequest;
            // Binary 형식으로 사용한다.
            request.UseBinary = true;
            // FTP 메소드 설정(아래에 별도 설명)
            request.Method = method;
            // 로그인 인증
            request.Credentials = new NetworkCredential(id, pwd);
            // request.GetResponse(); 함수가 호출되면 실제적으로 접속이 되기 때문에, 그전에 설정할 callback 함수 호출
            if (action != null)
            {
                action(request);
            }
            // 접속해서 WebResponse함수를 가져온다.
            return request.GetResponse() as FtpWebResponse;
        }

        // 다운로드 함수
        public void DownloadFileList(string ip, string target)
        {
            var list = new List<String>();
            // ftp에 접속해서 파일과 디렉토리 리스트를 가져온다.
            using (var res = Connect(ip, WebRequestMethods.Ftp.ListDirectory))
            {
                using (var stream = res.GetResponseStream())
                {
                    using (var rd = new StreamReader(stream))
                    {
                        while (true)
                        {
                            // binary 결과에서 개행(\r\n)의 구분으로 파일 리스트를 가져온다.
                            string buf = rd.ReadLine();
                            // null이라면 리스트 검색이 끝난 것이다.
                            if (string.IsNullOrWhiteSpace(buf))
                            {
                                break;
                            }
                            list.Add(buf);
                        }
                    }
                }
            }
            // ftp 리스트를 돌린다.
            foreach (var item in list)
            {
                try
                {
                    // 파일을 다운로드한다.
                    using (var res = Connect(ip + "/" + item, WebRequestMethods.Ftp.DownloadFile))
                    {
                        using (var stream = res.GetResponseStream())
                        {
                            // stream을 통해 파일을 작성한다.
                            using (var fs = File.Create(target + "\\" + item))
                            {
                                stream.CopyTo(fs);
                            }
                        }
                    }
                }
                catch (WebException)
                {
                    // 그러나 파일이 아닌 디렉토리의 경우는 에러가 발생한다.
                    // 로컬 디렉토리를 만든다.
                    Directory.CreateDirectory(target + "\\" + item);
                    // 디렉토리라면 재귀적 방법으로 다시 파일리스트를 탐색한다.
                    DownloadFileList(ip + "/" + item, target + "\\" + item);
                }
            }
        }
    }
}
