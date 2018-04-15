using System;
using System.Xml;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SettingsManager
{
    public class SettingsManager
    {
        public static String Read(String key)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(filename: @"C:\Workspace C#\BookStore\settings\settings.xml");
            XmlNodeList nodes = doc.GetElementsByTagName("setting");
            foreach(XmlNode node in nodes){
                if (node.Attributes["key"].Value == key)
                {
                    return node.Attributes["value"].Value;
                }
            }
            return null;
        }
    }
}
