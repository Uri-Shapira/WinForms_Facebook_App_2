using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper.ObjectModel;

namespace FacebookQuiz
{
    public static class QuizFactory
    {

        public static AbstractQuiz CreateQuiz(User i_User)
        {
            AbstractQuiz newQuiz = null;
            if(i_User.Hometown != null)
            {
                String userHomeTown = i_User.Hometown.Location.Country;
                if (userHomeTown.Equals("America"))
                {
                    newQuiz = new AmericanQuiz();
                }
            }
            else
            {
                newQuiz = new GenericQuiz();
            }
            return newQuiz;
        }
    }
}
