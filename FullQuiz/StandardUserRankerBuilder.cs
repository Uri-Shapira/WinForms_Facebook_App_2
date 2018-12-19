using AspirationQuiz;
using FacebookAppLogic;
using FacebookQuiz;
using FacebookWrapper.ObjectModel;

namespace FullQuiz
{
    public class StandardUserRankerBuilder : IUserRankerBuilder
    {
        public User LoggedInUser { get; }
        public StandardUserRankerBuilder(User i_User)
        {
            LoggedInUser = i_User;
        }
        public UserRanker BuildUserRanker()
        {
            UserRanker Quiz = new UserRanker();
            InitializeUserRanker(Quiz);

            return Quiz;
        }

        public void InitializeUserRanker(UserRanker i_UserRanker)
        {
            i_UserRanker.Description = "Test Yourself - Standard User Ranking Test!";
            i_UserRanker.KnowledgeQuiz = QuizFactory.CreateQuiz(LoggedInUser);
            i_UserRanker.AspirationQuiz = AspirationQuizFactory.CreateQuiz(LoggedInUser);
            i_UserRanker.MostLikedPhotoFilter = new MostLikedPhotoFilter(LoggedInUser);
            string[] feedback = { "You are terrible", "You are not bad", "You are ready for the ultimate user test!" };
            i_UserRanker.RankerFeedback = feedback;
        }
    }
}
