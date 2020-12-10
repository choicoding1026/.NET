using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace WindowsFormsCalculation
{
    class FtpManager
    {
        int count = 1;

        private FtpWebResponse connectServer(string ip, string id, string pw, string method, Action<FtpWebRequest> action = null)
        {
            var request = WebRequest.Create(ip) as FtpWebRequest;
            request.UseBinary = true;
            request.Method = method;
            request.Credentials = new NetworkCredential(id, pw);

            if (action != null)
            {
                action(request);
            }

            return request.GetResponse() as FtpWebResponse;
        }

        public void calculateAutomation(string ip, string id, string pw)
        {
            var list = new List<string>();
            var result = new List<string>();

            using (var res = connectServer(ip + "/raw", id, pw, WebRequestMethods.Ftp.ListDirectory))
            {
                using (var stream = res.GetResponseStream())
                {
                    using (var rd = new StreamReader(stream))
                    {
                        while (true)
                        {
                            string buf = rd.ReadLine();
                            if (string.IsNullOrWhiteSpace(buf))
                            {
                                break;
                            }
                            list.Add(buf);
                        }
                    }
                }
            }
            
            foreach (var fileName in list)
            {
                try
                {
                    string filePath = ip + "/raw/" + fileName;
                    string extension = Path.GetExtension(fileName);
                    string expression = string.Empty;

                    WebClient wc = new WebClient();
                    wc.Credentials = new NetworkCredential(id, pw);

                    byte[] newFileData = wc.DownloadData(filePath);
                    string fileString = Encoding.UTF8.GetString(newFileData);

                    switch (extension)
                    {
                        case ".txt":
                            {
                                expression = fileString;

                                break;
                            }
                        case ".JSON":
                            {
                                //TODOLIST
                                //JsonTextReader   
                                break;
                            }
                        case ".xml":
                            {
                                var xml = new XmlDocument() as XmlDocument;
                                xml.LoadXml(fileString);

                                XmlNodeList xmlList = xml.SelectNodes("/expressions/expression");

                                foreach (XmlNode i in xmlList)
                                {
                                    expression = i["exp"].InnerText;
                                }
                                
                                break;
                            }
                        default:
                            {
                                Console.WriteLine("지원하지 않는 형식입니다.");
                                break;
                            }
                    }

                    if (expression == string.Empty || expression == "0")
                    {
                        Console.WriteLine("올바르지 않은 수식입니다.");
                    }
                    else
                    {
                        var cal = new CalManager() as CalManager;
                        string res = cal.start(expression).ToString();
                        string value = expression + "=" +res;
                        result.Add(value);
                    }

                }
                catch (WebException)
                {
                    Console.WriteLine("접속 오류");
                }
            }
            foreach(var inputValue in result)
            {
                WebClient wc = new WebClient();
                wc.Credentials = new NetworkCredential(id, pw);

                byte[] fileContents = Encoding.UTF8.GetBytes(inputValue);
                string filePath = ip + "/" + DateTime.Now.ToString("yyMMddhhmmss-") + count.ToString() + ".txt";
                string fileName = DateTime.Now.ToString("yyMMddhhmmss-") + count.ToString() + ".txt";

                Stream stream = wc.OpenWrite(filePath);
                stream.Write(fileContents, 0, fileContents.Length);
                stream.Close();

                ///DBManager dm = new DBManager();
                ///dm.dbConncetor(fileName, inputValue);

                count++;
            }
            Console.WriteLine("complete...");
        }

    }
}
