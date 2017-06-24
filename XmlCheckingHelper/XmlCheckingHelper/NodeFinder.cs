using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Microsoft.Win32;

namespace XmlCheckingHelper
{
    static class NodeFinder
    {
        public static List<XElement> FindTheNodes (string path, string requiredNodeName)
        {
            //XDocument Xdoc = XDocument.Load(@"C:\GitHub\ProjectVisualXML\XmlCheckingHelper\XmlCheckingHelper\XmlDoc.xml");
            XDocument Xdoc = XDocument.Load(path);
            List<XElement> elementList = new List<XElement>();

            foreach (XElement element in Xdoc.Descendants())
            {
                if (element.Name == requiredNodeName)
                {
                    elementList.Add(element);
                }
            }

            return elementList;          
        }

       public static List<ElementWithQuestion> BuildQuestionObjexts(List<XElement> ellist)
        {
            List<ElementWithQuestion> objectList = new List<ElementWithQuestion>();

            foreach (XElement element in ellist)
            {
                string Code = element.Element("QuestiobCd").Value;
                string YesNo = element.Element("YesNo").Value;
                string ExtraText = element.Element("ExtraText").Value;

                ElementWithQuestion Obj = new ElementWithQuestion(Code,YesNo,ExtraText);

                objectList.Add(Obj);
            }

            return objectList;
        }

       public static string GetPath()
        {
            var dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == true)
            {
                return dialog.FileName;
            }
            return null;
        }
    }
}
