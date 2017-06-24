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

namespace XmlCheckingHelper
{
    /// <summary>
    /// Логика взаимодействия для QuestionTable.xaml
    /// </summary>
    public partial class VisualQuestionFields : UserControl
    {
        public VisualQuestionFields()
        {
            InitializeComponent();
        }

        public VisualQuestionFields( ComposedElementAndDB element)
        {
            InitializeComponent();

            this.AcordTextBox.Text = element.AcordText;
            this.TagTextBox.Text = element.Question.Code;
            this.SectionTextBox.Text = element.Section;
            this.YesNoNotance.Text = element.Question.Answer;
        }
    }
}
