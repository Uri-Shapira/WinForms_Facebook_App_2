using System;
using System.Windows.Forms;
using FacebookQuiz;
using FacebookWrapper.ObjectModel;

namespace FBAppUI
{
    public partial class QuizForm : Form
    {
        private AbstractQuiz Quiz { get; set; }
        private int CurrentQuestion { get; set; }
        private int UserAnswer { get; set; }
        private int Score { get; set; }

        public QuizForm(User i_User)
        {
            Quiz = QuizFactory.CreateQuiz(i_User);
            InitializeComponent();
            initializeQuiz();
        }

        private void labelQuizTitle_Click(object sender, EventArgs e)
        {

        }

        private void labelQuizTitle_TextChanged(object sender, EventArgs e)
        {

        }

        private void initializeQuiz()
        {
            CurrentQuestion = 0;
            string firstQuestion = Quiz.Questions[0].Prompt;
            string[] answers = Quiz.Questions[0].Answers;
            Console.WriteLine(firstQuestion);
            labelQuestionText.Text = firstQuestion;
            radioButtonAnswerA.Text = answers[0];
            radioButtonAnswerB.Text = answers[1];
            radioButtonAnswerC.Text = answers[2];
            radioButtonAnswerD.Text = answers[3];
            labelQuestionNumber.Text = "1";
            
        }

        private void moveToNextQuestion()
        {
            if(CurrentQuestion < Quiz.Questions.Count - 1)
            {
                CurrentQuestion++;
                string Question = Quiz.Questions[CurrentQuestion].Prompt;
                string[] answers = Quiz.Questions[CurrentQuestion].Answers;
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
                MessageBox.Show("Total score: " + Score );
                this.Close();
            }
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            if(radioButtonAnswerA.Checked)
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

            if(UserAnswer == Quiz.Questions[CurrentQuestion].CorrectAnswer)
            {
                Score++;
            }
            moveToNextQuestion();

        }
        
        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
