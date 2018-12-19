using FacebookQuiz;
using AspirationQuiz;

namespace FullQuiz
{
    public class FullQuiz
    {
        public string Description { get; set; }
        public string ;
        public AbstractAspirationQuiz AspirationQuiz { get; set; }
        public AbstractQuiz KnowledgeQuiz { get; set; }

        public FullQuiz(AbstractQuiz i_KnowledgeQuiz, AbstractAspirationQuiz i_AspirationQuiz)
        {
            AspirationQuiz = i_AspirationQuiz;
            KnowledgeQuiz = i_KnowledgeQuiz;
        }
    }
}
