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
using System.Data;

namespace XmlCheckingHelper
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// ////
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            WorkerWithDB.PullQuestionsFromDB();

            //QustionCodesEntities1 contex = new QustionCodesEntities1();
            //QuestionFromDatabase = (DataSet)(from Questions question in contex.Questions
            //                                 select question);


        }

        private void CheckXml_Click(object sender, RoutedEventArgs e)
        {
            string path = NodeFinder.GetPath();

            if (path != null)
            {

                List<XElement> ellist = NodeFinder.FindTheNodes(path,"Question");

                List<ElementWithQuestion> questionList = NodeFinder.BuildQuestionObjexts(ellist);

                List<ComposedElementAndDB> compList = ComposedElementAndDB.GetComposedList(questionList);

                foreach (ComposedElementAndDB element in compList)
                {
                    VisualQuestionFields fields = new VisualQuestionFields(element);

                    VisualPanel.Children.Add(fields);
                }
            }

        }
    }
}
