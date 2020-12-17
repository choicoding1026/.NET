using System.Collections.Generic;
using System.Xml;

namespace WindowsFormsCalculation
{
    class ServerInfoManager
    {
        /// <summary>
        ///  FTP 서버 정보가 들어있는 XML 문서 READER
        /// <?xml version = "1.0" encoding="utf-8"?>
        /// <serverInfos>
	    ///    <serverInfo>
		///        <IP>ftp://192.168.0.17</IP>
		///        <ID>test</ID>
		///        <PW>test</PW>
	    ///    </serverInfo>
        /// </serverInfos>
        /// </summary>
        /// <param name="path">xml 파일 경로</param>
        /// <returns>서버 정보가 담긴 dictionary</returns>
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
