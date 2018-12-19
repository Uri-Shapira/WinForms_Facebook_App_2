using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AspirationQuiz
{
    public abstract class AbstractAspirationQuiz
    {
        public List<AspirationQuestion> QuizQuestions = new List<AspirationQuestion>(); 

        public string Description { get; set; }

        public int PersonalityScore { get; set; }

        public string[] Answers = { "strongly agree", "agree", "disagree", "strongly disagree" };

        public AbstractAspirationQuiz()
        {
            GenerateQuiz();
        }

        protected abstract List<AspirationQuestion> FullQuestionsList();

        protected void GenerateQuiz()
        {
            Random randomIndex = new Random();
            List<AspirationQuestion> AllQuestions = FullQuestionsList();
            for (int i = 0; i < 5; i++)
            {
                int index = randomIndex.Next(AllQuestions.Count);
                if (!QuizQuestions.Contains(AllQuestions[index]))
                {
                    QuizQuestions.Add(AllQuestions[index]);
                }
            }   
        }
    }
}
