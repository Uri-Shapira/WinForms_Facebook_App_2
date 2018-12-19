using FacebookQuiz;
using AspirationQuiz;
using FacebookAppLogic;

namespace FullQuiz
{
    public class UserRanker
    {
        public string Description { get; set; }
        public AbstractAspirationQuiz AspirationQuiz { get; set; }
        public AbstractQuiz KnowledgeQuiz { get; set; }
        public AbstractQuiz UltimateKnowledgeQuiz { get; set; }
        public MostLikedPhotoFilter MostLikedPhotoFilter { get; set; }
        public string[] RankerFeedback { get; set; } 
        /*
        public FullQuiz(AbstractQuiz i_KnowledgeQuiz, AbstractAspirationQuiz i_AspirationQuiz)
        {
            AspirationQuiz = i_AspirationQuiz;
            KnowledgeQuiz = i_KnowledgeQuiz;
        }
        */
    }
}
