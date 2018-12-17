using System;
using System.Collections.Generic;
using System.Diagnostics;
using FacebookWrapper.ObjectModel;

namespace FacebookQuiz
{
    public class QuizLogic
    {
        public QuizLogic(User i_User)
        {
            Questions = new List<Question>();
            CurrentQuestion = 0;
        }

        public List<Question> Questions { get; set; }

        public byte CurrentQuestion { get; set; }

        public byte CorrectQuestions { get; set; }

        public void ResetQuiz()
        {
            Questions.Clear();
            CurrentQuestion = 0;
            CorrectQuestions = 0;
        }

        public bool CheckAnswer(string i_Answer)
        {
            bool res = false;

            if (Questions[CurrentQuestion].CorrectAnswer == i_Answer)
            {
                res = true;
                CorrectQuestions++;
            }

            return res;
        }
    }
}
