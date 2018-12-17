using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper.ObjectModel;

namespace FacebookQuiz
{
    public abstract class AbstractQuiz
    {
        protected List<Question> Questions { get; set; }
  
        public AbstractQuiz()
        {
            Questions = new List<Question>();
        }

        public abstract void BuildQuiz();
    }
}
