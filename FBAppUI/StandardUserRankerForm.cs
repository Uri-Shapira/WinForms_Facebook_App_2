using FacebookWrapper.ObjectModel;
using FullQuiz;
using System.Windows.Forms;

namespace FBAppUI
{
    public partial class StandardUserRankerForm : Form
    {
        private User LoggedInUser { get;  }
        private int UserRank { get; set; }
        private UserRanker UserRanker { get; }
        private int CurrentQuestion { get; set; }
        private int UserAnswer { get; set; }
        public StandardUserRankerForm(User i_User, IUserRankerBuilder i_UserRankerBuilder)
        {
            LoggedInUser = i_User;
            UserRanker = i_UserRankerBuilder.BuildUserRanker();
            UserRank = 0;
            InitializeComponent();
            labelUserRankTitle.Text = UserRanker.Description;
            initializeRanker();
        }

        private void buttonBackToMain_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void StandardUserRankerForm_Load(object sender, System.EventArgs e)
        {

        }

        private void initializeRanker()
        {
            CurrentQuestion = 0;
            string firstQuestion = UserRanker.KnowledgeQuiz.Questions[0].Prompt;
            string[] answers = UserRanker.KnowledgeQuiz.Questions[0].Answers;
            labelQuestionText.Text = firstQuestion;
            radioButtonAnswerA.Text = answers[0];
            radioButtonAnswerB.Text = answers[1];
            radioButtonAnswerC.Text = answers[2];
            radioButtonAnswerD.Text = answers[3];
            labelQuestionNumber.Text = "1";
            labelrankerLevel.Text = "Part 1: Knowledge Quiz";
        }

        private void buttonSubmit_Click(object sender, System.EventArgs e)
        {
            if (radioButtonAnswerA.Checked)
            {
                UserAnswer = 0;
            }
            else if (radioButtonAnswerB.Checked)
            {
                UserAnswer = 1;
            }
            else if (radioButtonAnswerC.Checked)
            {
                UserAnswer = 2;
            }
            else if (radioButtonAnswerD.Checked)
            {
                UserAnswer = 3;
            }

            if (UserAnswer == UserRanker.KnowledgeQuiz.Questions[CurrentQuestion].CorrectAnswer)
            {
                UserRank++;
            }
            moveToNextQuestion();
        }

        private void moveToNextQuestion()
        {
            if (CurrentQuestion < UserRanker.KnowledgeQuiz.Questions.Count - 1)
            {
                CurrentQuestion++;
                string Question = UserRanker.KnowledgeQuiz.Questions[CurrentQuestion].Prompt;
                string[] answers = UserRanker.KnowledgeQuiz.Questions[CurrentQuestion].Answers;
                labelQuestionText.Text = Question;
                radioButtonAnswerA.Text = answers[0];
                radioButtonAnswerB.Text = answers[1];
                radioButtonAnswerC.Text = answers[2];
                radioButtonAnswerD.Text = answers[3];
                int questionNumber = CurrentQuestion + 1;
                labelQuestionNumber.Text = questionNumber.ToString();
            }
            else
            {
                MessageBox.Show("Your current score: " + UserRank + ". Moving on to Part 2!");
                startPartTwo();
            }
        }

        private void startPartTwo()
        {
            CurrentQuestion = 5;
            string firstQuestion = UserRanker.AspirationQuiz.QuizQuestions[0].Question;
            string[] answers = UserRanker.AspirationQuiz.Answers;
            labelQuestionText.Text = firstQuestion;
            radioButtonAnswerA.Text = answers[0];
            radioButtonAnswerB.Text = answers[1];
            radioButtonAnswerC.Text = answers[2];
            radioButtonAnswerD.Text = answers[3];
            labelQuestionNumber.Text = "1";
            labelrankerLevel.Text = "Part 2: The Personality Quiz";
        }
    }
}
