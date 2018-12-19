namespace FBAppUI
{
    partial class StandardUserRankerForm
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
            this.labelUserRankTitle = new System.Windows.Forms.Label();
            this.buttonBackToMain = new System.Windows.Forms.Button();
            this.labelQuestionNumber = new System.Windows.Forms.Label();
            this.labelQuestionText = new System.Windows.Forms.Label();
            this.labelD = new System.Windows.Forms.Label();
            this.labelC = new System.Windows.Forms.Label();
            this.labelB = new System.Windows.Forms.Label();
            this.labelA = new System.Windows.Forms.Label();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.labelQuestionNumberTitle = new System.Windows.Forms.Label();
            this.radioButtonAnswerD = new System.Windows.Forms.RadioButton();
            this.radioButtonAnswerC = new System.Windows.Forms.RadioButton();
            this.radioButtonAnswerB = new System.Windows.Forms.RadioButton();
            this.radioButtonAnswerA = new System.Windows.Forms.RadioButton();
            this.labelRankerPart = new System.Windows.Forms.Label();
            this.labelrankerLevel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelUserRankTitle
            // 
            this.labelUserRankTitle.AutoSize = true;
            this.labelUserRankTitle.Location = new System.Drawing.Point(287, 9);
            this.labelUserRankTitle.Name = "labelUserRankTitle";
            this.labelUserRankTitle.Size = new System.Drawing.Size(27, 13);
            this.labelUserRankTitle.TabIndex = 27;
            this.labelUserRankTitle.Text = "Title";
            // 
            // buttonBackToMain
            // 
            this.buttonBackToMain.Location = new System.Drawing.Point(291, 386);
            this.buttonBackToMain.Name = "buttonBackToMain";
            this.buttonBackToMain.Size = new System.Drawing.Size(214, 52);
            this.buttonBackToMain.TabIndex = 1;
            this.buttonBackToMain.Text = "Back To Main";
            this.buttonBackToMain.UseVisualStyleBackColor = true;
            this.buttonBackToMain.Click += new System.EventHandler(this.buttonBackToMain_Click);
            // 
            // labelQuestionNumber
            // 
            this.labelQuestionNumber.AutoSize = true;
            this.labelQuestionNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelQuestionNumber.ForeColor = System.Drawing.Color.DarkCyan;
            this.labelQuestionNumber.Location = new System.Drawing.Point(497, 79);
            this.labelQuestionNumber.Name = "labelQuestionNumber";
            this.labelQuestionNumber.Size = new System.Drawing.Size(36, 39);
            this.labelQuestionNumber.TabIndex = 26;
            this.labelQuestionNumber.Text = "0";
            // 
            // labelQuestionText
            // 
            this.labelQuestionText.AutoSize = true;
            this.labelQuestionText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelQuestionText.ForeColor = System.Drawing.Color.CadetBlue;
            this.labelQuestionText.Location = new System.Drawing.Point(213, 135);
            this.labelQuestionText.Name = "labelQuestionText";
            this.labelQuestionText.Size = new System.Drawing.Size(135, 25);
            this.labelQuestionText.TabIndex = 25;
            this.labelQuestionText.Text = "Question Text";
            // 
            // labelD
            // 
            this.labelD.AutoSize = true;
            this.labelD.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelD.Location = new System.Drawing.Point(464, 276);
            this.labelD.Name = "labelD";
            this.labelD.Size = new System.Drawing.Size(28, 26);
            this.labelD.TabIndex = 24;
            this.labelD.Text = "D";
            // 
            // labelC
            // 
            this.labelC.AutoSize = true;
            this.labelC.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelC.Location = new System.Drawing.Point(185, 274);
            this.labelC.Name = "labelC";
            this.labelC.Size = new System.Drawing.Size(28, 26);
            this.labelC.TabIndex = 23;
            this.labelC.Text = "C";
            // 
            // labelB
            // 
            this.labelB.AutoSize = true;
            this.labelB.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelB.Location = new System.Drawing.Point(464, 192);
            this.labelB.Name = "labelB";
            this.labelB.Size = new System.Drawing.Size(27, 26);
            this.labelB.TabIndex = 22;
            this.labelB.Text = "B";
            // 
            // labelA
            // 
            this.labelA.AutoSize = true;
            this.labelA.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelA.Location = new System.Drawing.Point(185, 192);
            this.labelA.Name = "labelA";
            this.labelA.Size = new System.Drawing.Size(27, 26);
            this.labelA.TabIndex = 21;
            this.labelA.Text = "A";
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.BackColor = System.Drawing.Color.Teal;
            this.buttonSubmit.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonSubmit.FlatAppearance.BorderSize = 7;
            this.buttonSubmit.Location = new System.Drawing.Point(339, 333);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(109, 35);
            this.buttonSubmit.TabIndex = 20;
            this.buttonSubmit.Text = "Submit";
            this.buttonSubmit.UseVisualStyleBackColor = false;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // labelQuestionNumberTitle
            // 
            this.labelQuestionNumberTitle.AutoSize = true;
            this.labelQuestionNumberTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelQuestionNumberTitle.Location = new System.Drawing.Point(283, 78);
            this.labelQuestionNumberTitle.Name = "labelQuestionNumberTitle";
            this.labelQuestionNumberTitle.Size = new System.Drawing.Size(208, 39);
            this.labelQuestionNumberTitle.TabIndex = 18;
            this.labelQuestionNumberTitle.Text = "Question n°:";
            // 
            // radioButtonAnswerD
            // 
            this.radioButtonAnswerD.AutoSize = true;
            this.radioButtonAnswerD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.radioButtonAnswerD.Location = new System.Drawing.Point(497, 276);
            this.radioButtonAnswerD.Name = "radioButtonAnswerD";
            this.radioButtonAnswerD.Size = new System.Drawing.Size(119, 24);
            this.radioButtonAnswerD.TabIndex = 17;
            this.radioButtonAnswerD.TabStop = true;
            this.radioButtonAnswerD.Text = "radioButton4";
            this.radioButtonAnswerD.UseVisualStyleBackColor = true;
            // 
            // radioButtonAnswerC
            // 
            this.radioButtonAnswerC.AutoSize = true;
            this.radioButtonAnswerC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.radioButtonAnswerC.Location = new System.Drawing.Point(218, 276);
            this.radioButtonAnswerC.Name = "radioButtonAnswerC";
            this.radioButtonAnswerC.Size = new System.Drawing.Size(119, 24);
            this.radioButtonAnswerC.TabIndex = 16;
            this.radioButtonAnswerC.TabStop = true;
            this.radioButtonAnswerC.Text = "radioButton3";
            this.radioButtonAnswerC.UseVisualStyleBackColor = true;
            // 
            // radioButtonAnswerB
            // 
            this.radioButtonAnswerB.AutoSize = true;
            this.radioButtonAnswerB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.radioButtonAnswerB.Location = new System.Drawing.Point(497, 192);
            this.radioButtonAnswerB.Name = "radioButtonAnswerB";
            this.radioButtonAnswerB.Size = new System.Drawing.Size(119, 24);
            this.radioButtonAnswerB.TabIndex = 15;
            this.radioButtonAnswerB.TabStop = true;
            this.radioButtonAnswerB.Text = "radioButton2";
            this.radioButtonAnswerB.UseVisualStyleBackColor = true;
            // 
            // radioButtonAnswerA
            // 
            this.radioButtonAnswerA.AutoSize = true;
            this.radioButtonAnswerA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.radioButtonAnswerA.Location = new System.Drawing.Point(218, 192);
            this.radioButtonAnswerA.Name = "radioButtonAnswerA";
            this.radioButtonAnswerA.Size = new System.Drawing.Size(119, 24);
            this.radioButtonAnswerA.TabIndex = 14;
            this.radioButtonAnswerA.TabStop = true;
            this.radioButtonAnswerA.Text = "radioButton1";
            this.radioButtonAnswerA.UseVisualStyleBackColor = true;
            // 
            // labelRankerPart
            // 
            this.labelRankerPart.AutoSize = true;
            this.labelRankerPart.Location = new System.Drawing.Point(288, 47);
            this.labelRankerPart.Name = "labelRankerPart";
            this.labelRankerPart.Size = new System.Drawing.Size(0, 13);
            this.labelRankerPart.TabIndex = 28;
            // 
            // labelrankerLevel
            // 
            this.labelrankerLevel.AutoSize = true;
            this.labelrankerLevel.Location = new System.Drawing.Point(287, 47);
            this.labelrankerLevel.Name = "labelrankerLevel";
            this.labelrankerLevel.Size = new System.Drawing.Size(27, 13);
            this.labelrankerLevel.TabIndex = 29;
            this.labelrankerLevel.Text = "Title";
            // 
            // StandardUserRankerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelrankerLevel);
            this.Controls.Add(this.labelRankerPart);
            this.Controls.Add(this.labelQuestionNumber);
            this.Controls.Add(this.labelQuestionText);
            this.Controls.Add(this.labelD);
            this.Controls.Add(this.labelC);
            this.Controls.Add(this.labelB);
            this.Controls.Add(this.labelA);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.labelQuestionNumberTitle);
            this.Controls.Add(this.radioButtonAnswerD);
            this.Controls.Add(this.radioButtonAnswerC);
            this.Controls.Add(this.radioButtonAnswerB);
            this.Controls.Add(this.radioButtonAnswerA);
            this.Controls.Add(this.buttonBackToMain);
            this.Controls.Add(this.labelUserRankTitle);
            this.Name = "StandardUserRankerForm";
            this.Text = "UserRanker";
            this.Load += new System.EventHandler(this.StandardUserRankerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelUserRankTitle;
        private System.Windows.Forms.Button buttonBackToMain;
        private System.Windows.Forms.Label labelQuestionNumber;
        private System.Windows.Forms.Label labelQuestionText;
        private System.Windows.Forms.Label labelD;
        private System.Windows.Forms.Label labelC;
        private System.Windows.Forms.Label labelB;
        private System.Windows.Forms.Label labelA;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.Label labelQuestionNumberTitle;
        private System.Windows.Forms.RadioButton radioButtonAnswerD;
        private System.Windows.Forms.RadioButton radioButtonAnswerC;
        private System.Windows.Forms.RadioButton radioButtonAnswerB;
        private System.Windows.Forms.RadioButton radioButtonAnswerA;
        private System.Windows.Forms.Label labelRankerPart;
        private System.Windows.Forms.Label labelrankerLevel;
    }
}