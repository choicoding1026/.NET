using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ConsoleApplicationFTP
{
    class xmlReader
    {

        /*
         xml 형식
         <?xml version="1.0" encoding="utf-8"?>
         <serverInfos>
	        <serverInfo>
		        <IP>ftp://192.168.0.16</IP>
		        <ID>user2</ID>
		        <PW>user2</PW>
	        </serverInfo>
         </serverInfos>
        */

        public Dictionary<string, string> Read(string path)
        { 
            XmlDocument xml = new XmlDocument();
            xml.Load(path);

            XmlNodeList xmlList = xml.SelectNodes("/serverInfos/serverInfo");

            Dictionary<string, string> dic = new Dictionary<string, string>();

            string ftpServerIP = string.Empty;
            string ftpUserID = string.Empty;
            string ftpPassword = string.Empty;

            foreach (XmlNode i in xmlList)
            {
                ftpServerIP = i["IP"].InnerText;
                ftpUserID = i["ID"].InnerText;
                ftpPassword = i["PW"].InnerText;
            }

            dic.Add("IP", ftpServerIP);
            dic.Add("ID", ftpUserID);
            dic.Add("PW", ftpPassword);

            return dic;

        }
    }

}
