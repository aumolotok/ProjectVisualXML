using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XmlCheckingHelper
{
    class ElementWithQuestion
    {
        public string Code { get; set; }

        public string Answer { get; set;}

        public string ExtraText { get; set;}

        public ElementWithQuestion() { }

        public ElementWithQuestion(string Code, string Answer, string ExtraText)
        {
            this.Code = Code;
            this.Answer = Answer;
            this.ExtraText = ExtraText;
        }

    }
}
