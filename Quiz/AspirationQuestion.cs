using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AspirationQuiz
{
    public class AspirationQuestion
    {
        public int value { get; set; }
        public string Question { get; set; }

        public AspirationQuestion(string i_question, int i_value)
        {
            value = i_value;
            Question = i_question;
        }
    }
}
