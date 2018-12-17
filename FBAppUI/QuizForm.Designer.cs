namespace FBAppUI
{
    partial class QuizForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelQuizTitle = new System.Windows.Forms.Label();
            this.radioButtonAnswerA = new System.Windows.Forms.RadioButton();
            this.radioButtonAnswerB = new System.Windows.Forms.RadioButton();
            this.radioButtonAnswerC = new System.Windows.Forms.RadioButton();
            this.radioButtonAnswerD = new System.Windows.Forms.RadioButton();
            this.labelQuestionNumberTitle = new System.Windows.Forms.Label();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.labelA = new System.Windows.Forms.Label();
            this.labelB = new System.Windows.Forms.Label();
            this.labelC = new System.Windows.Forms.Label();
            this.labelD = new System.Windows.Forms.Label();
            this.labelQuestionText = new System.Windows.Forms.Label();
            this.labelQuestionNumber = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelQuizTitle
            // 
            this.labelQuizTitle.AutoSize = true;
            this.labelQuizTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelQuizTitle.ForeColor = System.Drawing.Color.DarkCyan;
            this.labelQuizTitle.Location = new System.Drawing.Point(242, 24);
            this.labelQuizTitle.Name = "labelQuizTitle";
            this.labelQuizTitle.Size = new System.Drawing.Size(0, 31);
            this.labelQuizTitle.TabIndex = 0;
            this.labelQuizTitle.TextChanged += new System.EventHandler(this.labelQuizTitle_TextChanged);
            this.labelQuizTitle.Click += new System.EventHandler(this.labelQuizTitle_Click);
            // 
            // radioButtonAnswerA
            // 
            this.radioButtonAnswerA.AutoSize = true;
            this.radioButtonAnswerA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.radioButtonAnswerA.Location = new System.Drawing.Point(194, 213);
            this.radioButtonAnswerA.Name = "radioButtonAnswerA";
            this.radioButtonAnswerA.Size = new System.Drawing.Size(119, 24);
            this.radioButtonAnswerA.TabIndex = 1;
            this.radioButtonAnswerA.TabStop = true;
            this.radioButtonAnswerA.Text = "radioButton1";
            this.radioButtonAnswerA.UseVisualStyleBackColor = true;
            // 
            // radioButtonAnswerB
            // 
            this.radioButtonAnswerB.AutoSize = true;
            this.radioButtonAnswerB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.radioButtonAnswerB.Location = new System.Drawing.Point(473, 213);
            this.radioButtonAnswerB.Name = "radioButtonAnswerB";
            this.radioButtonAnswerB.Size = new System.Drawing.Size(119, 24);
            this.radioButtonAnswerB.TabIndex = 2;
            this.radioButtonAnswerB.TabStop = true;
            this.radioButtonAnswerB.Text = "radioButton2";
            this.radioButtonAnswerB.UseVisualStyleBackColor = true;
            // 
            // radioButtonAnswerC
            // 
            this.radioButtonAnswerC.AutoSize = true;
            this.radioButtonAnswerC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.radioButtonAnswerC.Location = new System.Drawing.Point(194, 297);
            this.radioButtonAnswerC.Name = "radioButtonAnswerC";
            this.radioButtonAnswerC.Size = new System.Drawing.Size(119, 24);
            this.radioButtonAnswerC.TabIndex = 3;
            this.radioButtonAnswerC.TabStop = true;
            this.radioButtonAnswerC.Text = "radioButton3";
            this.radioButtonAnswerC.UseVisualStyleBackColor = true;
            // 
            // radioButtonAnswerD
            // 
            this.radioButtonAnswerD.AutoSize = true;
            this.radioButtonAnswerD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.radioButtonAnswerD.Location = new System.Drawing.Point(473, 297);
            this.radioButtonAnswerD.Name = "radioButtonAnswerD";
            this.radioButtonAnswerD.Size = new System.Drawing.Size(119, 24);
            this.radioButtonAnswerD.TabIndex = 4;
            this.radioButtonAnswerD.TabStop = true;
            this.radioButtonAnswerD.Text = "radioButton4";
            this.radioButtonAnswerD.UseVisualStyleBackColor = true;
            // 
            // labelQuestionNumberTitle
            // 
            this.labelQuestionNumberTitle.AutoSize = true;
            this.labelQuestionNumberTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelQuestionNumberTitle.Location = new System.Drawing.Point(232, 83);
            this.labelQuestionNumberTitle.Name = "labelQuestionNumberTitle";
            this.labelQuestionNumberTitle.Size = new System.Drawing.Size(208, 39);
            this.labelQuestionNumberTitle.TabIndex = 5;
            this.labelQuestionNumberTitle.Text = "Question n°:";
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.Teal;
            this.buttonExit.Location = new System.Drawing.Point(459, 375);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(109, 35);
            this.buttonExit.TabIndex = 6;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.BackColor = System.Drawing.Color.Teal;
            this.buttonSubmit.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonSubmit.FlatAppearance.BorderSize = 7;
            this.buttonSubmit.Location = new System.Drawing.Point(185, 375);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(109, 35);
            this.buttonSubmit.TabIndex = 7;
            this.buttonSubmit.Text = "Submit";
            this.buttonSubmit.UseVisualStyleBackColor = false;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // labelA
            // 
            this.labelA.AutoSize = true;
            this.labelA.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelA.Location = new System.Drawing.Point(161, 213);
            this.labelA.Name = "labelA";
            this.labelA.Size = new System.Drawing.Size(27, 26);
            this.labelA.TabIndex = 8;
            this.labelA.Text = "A";
            // 
            // labelB
            // 
            this.labelB.AutoSize = true;
            this.labelB.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelB.Location = new System.Drawing.Point(440, 213);
            this.labelB.Name = "labelB";
            this.labelB.Size = new System.Drawing.Size(27, 26);
            this.labelB.TabIndex = 9;
            this.labelB.Text = "B";
            // 
            // labelC
            // 
            this.labelC.AutoSize = true;
            this.labelC.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelC.Location = new System.Drawing.Point(161, 295);
            this.labelC.Name = "labelC";
            this.labelC.Size = new System.Drawing.Size(28, 26);
            this.labelC.TabIndex = 10;
            this.labelC.Text = "C";
            // 
            // labelD
            // 
            this.labelD.AutoSize = true;
            this.labelD.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelD.Location = new System.Drawing.Point(440, 297);
            this.labelD.Name = "labelD";
            this.labelD.Size = new System.Drawing.Size(28, 26);
            this.labelD.TabIndex = 11;
            this.labelD.Text = "D";
            // 
            // labelQuestionText
            // 
            this.labelQuestionText.AutoSize = true;
            this.labelQuestionText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelQuestionText.ForeColor = System.Drawing.Color.CadetBlue;
            this.labelQuestionText.Location = new System.Drawing.Point(189, 156);
            this.labelQuestionText.Name = "labelQuestionText";
            this.labelQuestionText.Size = new System.Drawing.Size(135, 25);
            this.labelQuestionText.TabIndex = 12;
            this.labelQuestionText.Text = "Question Text";
            // 
            // labelQuestionNumber
            // 
            this.labelQuestionNumber.AutoSize = true;
            this.labelQuestionNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelQuestionNumber.ForeColor = System.Drawing.Color.DarkCyan;
            this.labelQuestionNumber.Location = new System.Drawing.Point(445, 83);
            this.labelQuestionNumber.Name = "labelQuestionNumber";
            this.labelQuestionNumber.Size = new System.Drawing.Size(36, 39);
            this.labelQuestionNumber.TabIndex = 13;
            this.labelQuestionNumber.Text = "0";
            // 
            // QuizForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 456);
            this.Controls.Add(this.labelQuestionNumber);
            this.Controls.Add(this.labelQuestionText);
            this.Controls.Add(this.labelD);
            this.Controls.Add(this.labelC);
            this.Controls.Add(this.labelB);
            this.Controls.Add(this.labelA);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.labelQuestionNumberTitle);
            this.Controls.Add(this.radioButtonAnswerD);
            this.Controls.Add(this.radioButtonAnswerC);
            this.Controls.Add(this.radioButtonAnswerB);
            this.Controls.Add(this.radioButtonAnswerA);
            this.Controls.Add(this.labelQuizTitle);
            this.Name = "QuizForm";
            this.Text = "QuizForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelQuizTitle;
        private System.Windows.Forms.RadioButton radioButtonAnswerA;
        private System.Windows.Forms.RadioButton radioButtonAnswerB;
        private System.Windows.Forms.RadioButton radioButtonAnswerC;
        private System.Windows.Forms.RadioButton radioButtonAnswerD;
        private System.Windows.Forms.Label labelQuestionNumberTitle;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.Label labelA;
        private System.Windows.Forms.Label labelB;
        private System.Windows.Forms.Label labelC;
        private System.Windows.Forms.Label labelD;
        private System.Windows.Forms.Label labelQuestionText;
        private System.Windows.Forms.Label labelQuestionNumber;
    }
}