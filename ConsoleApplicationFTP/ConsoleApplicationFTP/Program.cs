using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ConsoleApplicationFTP
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> dic;

            // serverInfo 데이터 가져오기
            xmlReader xml = new xmlReader();
            dic = xml.Read(@"C:\xmlFiles\serverInfos.xml");

            // 프로그램 실행
            ftpConnector ftp = new ftpConnector();
            ftp.ip = dic["IP"];
            ftp.id = dic["ID"];
            ftp.pwd = dic["PW"];
            ftp.target = @"c:\ftpShare"; // 내 PC 안에 디렉토리(다운로드 받을 파일이 저장되는 곳)
            
            ftp.DownloadFileList(ftp.ip, ftp.target); //("ftp://192.168.0.16", @"c:\ftpShare");

            // 아무 키나 누르면 종료.
            Console.WriteLine("Download completed..");
            Console.ReadKey();
        }

       
    }
}
