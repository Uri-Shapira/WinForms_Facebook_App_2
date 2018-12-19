using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper.ObjectModel;

namespace FacebookQuiz
{
    public class AmericanQuiz : AbstractQuiz
    {
        public AmericanQuiz() : base()
        {
            quizTitle = "How well do you know America?";
            BuildQuiz();
        }

        public override void BuildQuiz()
        {
            Question q1 = new Question("How many members are there in the U.S.Senate?", new string[] { "100", "200", "50", "20" }, 0);
            Question q2 = new Question("What is the American state with the fewest counties?", new string[] { "Delaware", "Rhode Island", "Utah", "Maine" }, 0);
            Question q3 = new Question("Which American state has the most interstate highway kilometers?", new string[] { "New York", "Texas", "California", "Montana" }, 1);
            Question q4 = new Question("How many stripes does the American flag have?", new string[] { "10", "15", "13", "18" }, 2);
            Question q5 = new Question("How many states are there in the United States of America?", new string[] { "10", "40", "73", "50" }, 3);
            Questions.Add(q1);
            Questions.Add(q2);
            Questions.Add(q3);
            Questions.Add(q4);
            Questions.Add(q5);
        }

    }
}
