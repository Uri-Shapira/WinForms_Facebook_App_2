using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Quiz
{
    class MaleAspirationQuiz : AspirationQuiz
    {


        public MaleAspirationQuiz()
        {

        }
        protected override void CalculateScore()
        {
            
        }

        protected override List<AspirationQuestion> FullQuestionsList()
        {
            List<AspirationQuestion> fullList = new List<AspirationQuestion>();
            AspirationQuestion first = new AspirationQuestion("You have a mission in life", 7);
            AspirationQuestion second = new AspirationQuestion("You believe in yourself", 5);
            AspirationQuestion third = new AspirationQuestion("You know what you want to do when you grow up", 5);
            AspirationQuestion fourth = new AspirationQuestion("You have a clear vision of your future", 5);
            AspirationQuestion fifth = new AspirationQuestion("You find it easy to stay relaxed even when there is some pressure.", 5);
            AspirationQuestion sixth = new AspirationQuestion("You usually do things out of sheer curiousity.", 3);
            fullList.Add(first);
            fullList.Add(second);
            fullList.Add(third);
            fullList.Add(fourth);
            fullList.Add(fifth);
            fullList.Add(sixth);
            return fullList;
        }
    }
}
