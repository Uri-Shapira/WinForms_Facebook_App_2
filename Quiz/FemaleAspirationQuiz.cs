using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AspirationQuiz
{
    class FemaleAspirationQuiz: AbstractAspirationQuiz
    {
        public FemaleAspirationQuiz() : base()
        {
            Description = "Are you an aspiring female?";
        }

        protected override List<AspirationQuestion> FullQuestionsList()
        {
            List<AspirationQuestion> fullList = new List<AspirationQuestion>();
            fullList.Add(new AspirationQuestion("You have a mission in life", 7));
            fullList.Add(new AspirationQuestion("When you're in a group of women, standing and talking, do all their feet kind of point to you?", 5));
            fullList.Add(new AspirationQuestion("You know what you want to do when you grow up", 5));
            fullList.Add(new AspirationQuestion("You have a clear vision of your future", 5));
            fullList.Add(new AspirationQuestion("You find it easy to stay relaxed even when there is some pressure.", 5));
            fullList.Add(new AspirationQuestion("In a social setting, are you always the person to introduce people?", 3));
            fullList.Add(new AspirationQuestion("Are you comfortable leading?", 4));
            fullList.Add(new AspirationQuestion("Whenever you leave a group, do people just keep talking like nothing happened?", 6));
            return fullList;
        }
    }
}
