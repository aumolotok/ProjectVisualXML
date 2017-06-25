using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace XmlCheckingHelper
{
    public static class WorkerWithDB
    {
        public static List<XmlCheckingHelper.Questions> QuestionsFromDB { get; set; }

        public static void PullQuestionsFromDB()
        {
            QuestionCodesEntities1 context = new QuestionCodesEntities1();

            QuestionsFromDB = (from question in context.Questions
                               select question).ToList();
        }



    }
}
