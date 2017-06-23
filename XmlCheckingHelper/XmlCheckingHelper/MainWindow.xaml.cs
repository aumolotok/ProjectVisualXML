using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml.Linq;

namespace XmlCheckingHelper
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CheckXml_Click(object sender, RoutedEventArgs e)
        {
            List<XElement> ellist = NodeFinder.FindTheNodes("Question");

            List<ElementWithQuestion> questionList = NodeFinder.BuildQuestionObjexts(ellist);

            List<ComposedElementAndDB> compList = ComposedElementAndDB.GetComposedList(questionList);

            ComposedElementAndDB.ShowObjects(compList);
            //foreach (ElementWithQuestion element in questionList)
            //{
            //    Console.WriteLine(element.Code);
            //    Console.WriteLine(element.Answer);
            //    Console.WriteLine(element.ExtraText);
            //    Console.WriteLine();
            //}

        }
    }
}
