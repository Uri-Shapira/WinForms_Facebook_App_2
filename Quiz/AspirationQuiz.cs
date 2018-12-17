using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Quiz
{
    abstract class AspirationQuiz
    {
        public List<AspirationQuestion> Questions = new List<AspirationQuestion>(); 
        public int PersonalityScore { get; set; }

        protected abstract void CalculateScore();

        protected abstract List<AspirationQuestion> FullQuestionsList();
    }
}
