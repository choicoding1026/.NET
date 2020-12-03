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
            XmlReader xml = new XmlReader();
            dic = xml.Read(@"C:\xmlFiles\serverInfos.xml");

            // 프로그램 실행
            FtpConnector ftp = new FtpConnector();
            ftp.ip = dic["IP"];
            ftp.id = dic["ID"];
            ftp.pwd = dic["PW"];
            ftp.target = @"C:\ftpShare"; // 내 PC 안에 디렉토리(다운로드 받을 파일이 저장되는 곳)
            ftp.forUpload = @"C:\ftpShare\upload";

            while (true)
            {
                Console.WriteLine("Please Enter the Key .. ");
                Console.WriteLine("1. Download 2.Upload");
                string function = Console.ReadLine();

                if (function == "1")
                {
                    ftp.DownloadFileList(ftp.ip, ftp.target); //("ftp://192.168.0.15", @"c:\ftpShare");
                    break;
                }
                else if (function == "2")
                {
                    ftp.UploadFileList(ftp.ip, ftp.forUpload); //("ftp://192.168.0.15", @"c:\ftpShare\upload");
                    break;
                }
                else
                {
                    continue;
                }

            }

            Console.WriteLine("Completed..");
            Console.ReadKey();
        }
       
    }
}
