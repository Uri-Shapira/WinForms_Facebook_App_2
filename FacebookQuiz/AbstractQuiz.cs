using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper.ObjectModel;

namespace FacebookQuiz
{
    public abstract class AbstractQuiz
    {
        public List<Question> Questions { get; set; }

        public string quizTitle = "";
  
        public AbstractQuiz()
        {
            Questions = new List<Question>();
        }

        public abstract void BuildQuiz();
    }
}
