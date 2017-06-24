using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace XmlCheckingHelper
{
    public class ComposedElementAndDB
    {
        public ElementWithQuestion Question { get; set; }

        public string NumberOfAcord { get; private set; }

        public string AcordText { get; private set; }

        public string Section { get; private set; }

        public int NumberInSection { get; set; }

        public string HelpText { get; private set; }


        public ComposedElementAndDB() { }

        public ComposedElementAndDB(ElementWithQuestion question,
                                    string numberOfAcord, 
                                    string acordText,
                                    string section,
                                    int numberInSection,
                                    string helpText)
        {
            Question = question;
            NumberOfAcord = numberOfAcord;
            AcordText = acordText;
            Section = section;
            NumberInSection = numberInSection;
            HelpText = helpText;
        }

        public static ComposedElementAndDB Compose(ElementWithQuestion element)
        {
            QustionCodesEntities1 contex = new QustionCodesEntities1();

            var row = (from question in contex.Questions
                       where question.QuestionCd == element.Code
                       select question).SingleOrDefault();

            ComposedElementAndDB obj = new ComposedElementAndDB(element, row.AcordNumber, row.AcordText, row.Section, row.PositionInSection, row.HelpText);
            return obj;
        }

        public static List<ComposedElementAndDB> GetComposedList (List<ElementWithQuestion> ellist)
        {
            List<ComposedElementAndDB> complist = new List<ComposedElementAndDB>();

            foreach (ElementWithQuestion element in ellist)
            {
                complist.Add(Compose(element));
            }

            return complist;
        }

        public static void ShowObjects(List<ComposedElementAndDB> compList)
        {
            foreach (ComposedElementAndDB element in compList)
            {
                Console.WriteLine(element.Question.Code + ": Code");
                Console.WriteLine(element.AcordText + ": AcordText");
                Console.WriteLine(element.NumberInSection + ": Number");
                Console.WriteLine(element.Section + ": Section");
                Console.WriteLine(element.Question.Answer + ": Answer");
                Console.WriteLine(element.Question.ExtraText + ": ExtraText");
                Console.WriteLine();
            }

        }
        
        }
    
}
