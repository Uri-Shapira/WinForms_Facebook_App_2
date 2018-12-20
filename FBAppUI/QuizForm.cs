using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FacebookQuiz;
using FacebookWrapper.ObjectModel;

namespace FBAppUI
{
    public partial class QuizForm : Form
    {
        private QuizLogic Logic { get; set; }

        public QuizForm(User i_User)
        {
            Logic = new QuizLogic(i_User);
            InitializeComponent();
            initializeQuestion();
        }

        private void initializeQuestion()
        {
            Question currentQuestion = Logic.Questions[Logic.CurrentQuestion];
            labelQuestionText.Text = currentQuestion.Prompt;
            radioButtonAnswerA.Text = currentQuestion.Answers[0];
            radioButtonAnswerB.Text = currentQuestion.Answers[1];
            radioButtonAnswerC.Text = currentQuestion.Answers[2];
            radioButtonAnswerD.Text = currentQuestion.Answers[3];
            labelQuestionNumber.Text = (Logic.CurrentQuestion+1).ToString();
        }

        private void moveToNextQuestion()
        {
            if(Logic.CurrentQuestion < Logic.Questions.Count-1)
            {
                Logic.CurrentQuestion++;
                initializeQuestion();
            }
            else
            {
                finishQuiz();
            }
        }

        private void finishQuiz()
        {
            MessageBox.Show(string.Format("You answered correctly to {0} out of {1} questions", Logic.Score, Logic.Questions.Count));
            this.Close();
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            var checkedButton = groupBoxAnswers.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
            Question currentQuestion = Logic.Questions[Logic.CurrentQuestion];
            if(checkedButton == null)
            {
                MessageBox.Show("Please enter your answer");
            }else if (checkedButton.Text == currentQuestion.Answers[currentQuestion.CorrectAnswer])
            {
                Logic.Score++;
            }
            moveToNextQuestion(); 
        }
        
        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void labelQuizTitle_Click(object sender, EventArgs e)
        {

        }

        private void labelQuizTitle_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
