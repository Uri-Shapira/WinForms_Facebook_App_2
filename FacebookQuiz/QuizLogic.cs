using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FacebookQuiz
{
    public class QuizLogic
    {
        public int CurrentQuestion { get; set; }
        public List<Question> Questions { get; set; }
        public int Score { get; set; }
        public AbstractQuiz Quiz { get; set; }

        public QuizLogic(User i_User)
        {
            Quiz = QuizFactory.CreateQuiz(i_User);
            CurrentQuestion = 0;
            Score = 0;
            Questions = Quiz.Questions;
        }

    }
}
