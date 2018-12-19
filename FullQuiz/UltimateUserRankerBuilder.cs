using AspirationQuiz;
using FacebookAppLogic;
using FacebookQuiz;
using FacebookWrapper.ObjectModel;

namespace FullQuiz
{
    class UltimateUserRankerBuilder : IUserRankerBuilder
    {
        public User LoggedInUser { get; set; }

        public UltimateUserRankerBuilder(User i_User)
        {
            LoggedInUser = i_User;
        }

        public UserRanker BuildUserRanker()
        {
            return new UserRanker();
        }

        public void InitializeUserRanker(UserRanker i_UserRanker)
        {
            i_UserRanker.Description = "Test Yourself - The Ultimate Ranking For The Ultimate Users!";
            i_UserRanker.KnowledgeQuiz = QuizFactory.CreateQuiz(LoggedInUser);
            if(LoggedInUser.Hometown.Location.Country != "America")
            {
                i_UserRanker.UltimateKnowledgeQuiz = new AmericanQuiz();
            }
            else
            {
                i_UserRanker.UltimateKnowledgeQuiz = new GenericQuiz();
            }
            i_UserRanker.AspirationQuiz = AspirationQuizFactory.CreateQuiz(LoggedInUser);
            i_UserRanker.MostLikedPhotoFilter = new MostLikedPhotoFilter(LoggedInUser);
            string[] feedback = { "You are not at this level", "You are pretty good", "You are the ultimate user!" };
            i_UserRanker.RankerFeedback = feedback;
        }
    }
}
