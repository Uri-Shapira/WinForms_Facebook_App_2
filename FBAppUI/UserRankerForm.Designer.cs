namespace FBAppUI
{
    partial class UserRankerForm
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
            this.SuspendLayout();
            // 
            // labelUserRankTitle
            // 
            this.labelUserRankTitle.AutoSize = true;
            this.labelUserRankTitle.Location = new System.Drawing.Point(279, 55);
            this.labelUserRankTitle.Name = "labelUserRankTitle";
            this.labelUserRankTitle.Size = new System.Drawing.Size(147, 13);
            this.labelUserRankTitle.TabIndex = 0;
            this.labelUserRankTitle.Text = "User Facebook Ranking Test";
            // 
            // buttonBackToMain
            // 
            this.buttonBackToMain.Location = new System.Drawing.Point(121, 387);
            this.buttonBackToMain.Name = "buttonBackToMain";
            this.buttonBackToMain.Size = new System.Drawing.Size(214, 52);
            this.buttonBackToMain.TabIndex = 1;
            this.buttonBackToMain.Text = "Back To Main";
            this.buttonBackToMain.UseVisualStyleBackColor = true;
            this.buttonBackToMain.Click += new System.EventHandler(this.buttonBackToMain_Click);
            // 
            // UserRankerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonBackToMain);
            this.Controls.Add(this.labelUserRankTitle);
            this.Name = "UserRankerForm";
            this.Text = "UserRanker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelUserRankTitle;
        private System.Windows.Forms.Button buttonBackToMain;
    }
}