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
    }
}
