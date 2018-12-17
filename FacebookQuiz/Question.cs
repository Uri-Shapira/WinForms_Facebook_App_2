using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FacebookQuiz
{
    public class Question
    {
        public String Prompt { get; set; }
        public String[] Answers { get; set; }
        public int CorrectAnswerIndex { get; set; }

        public Question(String i_Prompt, String[] i_Answers, int i_CorrectAnswer)
        {
            Prompt = i_Prompt;
            Answers = i_Answers;
            CorrectAnswerIndex = i_CorrectAnswer;
        }
    }
}
