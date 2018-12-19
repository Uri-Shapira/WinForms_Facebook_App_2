using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AspirationQuiz
{
    public static class AspirationQuizFactory
    {
        public static AbstractAspirationQuiz CreateQuiz(User i_User)
        {
            AbstractAspirationQuiz Quiz = null;
            if (i_User.Gender != null)
            {
                if (i_User.Gender == 0)
                {
                    Quiz = new FemaleAspirationQuiz();
                }
            }
            else
            {
                Quiz = new MaleAspirationQuiz();
            }
            return Quiz;
        }
    }
}
