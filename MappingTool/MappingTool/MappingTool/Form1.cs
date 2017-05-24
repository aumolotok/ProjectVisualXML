using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace MappingTool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Console.WriteLine("5");
            XDocument XDoc = XDocument.Load(@"C:\GitHub\ProjectVisualXML\MappingTool\MappingTool\XMLFile1.xml");
            //Console.WriteLine(XDoc);
            XElement XEl = XDoc;
            foreach (XElement node in XDoc.Descendants())
            {
                IEnumerable<XElement> voids = node.Descendants();
                //if (node.Nodes().OfType<XElement>())
                //{
                //    Console.WriteLine(node.Value);
                //}
                Console.WriteLine(node.Name);
            }
        }
    }
}
