using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XmlCheckingHelper
{
    class ComposedElementAndDB
    {
        public ElementWithQuestion Question { get; private set; }

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


    }
}
