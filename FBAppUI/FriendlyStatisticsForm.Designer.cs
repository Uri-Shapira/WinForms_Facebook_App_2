namespace FBAppUI
{
    partial class FriendlyStatisticsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FriendlyStatisticsForm));
            this.ButtonHometownStat = new System.Windows.Forms.Button();
            this.ButtonGenderStatistics = new System.Windows.Forms.Button();
            this.ButtonCommonReligions = new System.Windows.Forms.Button();
            this.ButtonBirthdayStat = new System.Windows.Forms.Button();
            this.ButtonBackToMain = new System.Windows.Forms.Button();
            this.ListBoxStat = new System.Windows.Forms.ListBox();
            this.LabelStat = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ButtonHometownStat
            // 
            this.ButtonHometownStat.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ButtonHometownStat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonHometownStat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonHometownStat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonHometownStat.Location = new System.Drawing.Point(470, 48);
            this.ButtonHometownStat.Name = "ButtonHometownStat";
            this.ButtonHometownStat.Size = new System.Drawing.Size(202, 108);
            this.ButtonHometownStat.TabIndex = 0;
            this.ButtonHometownStat.Text = "Most Friendly Home Towns";
            this.ButtonHometownStat.UseVisualStyleBackColor = false;
            this.ButtonHometownStat.Click += new System.EventHandler(this.ButtonHometownStat_Click);
            // 
            // ButtonGenderStatistics
            // 
            this.ButtonGenderStatistics.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ButtonGenderStatistics.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonGenderStatistics.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonGenderStatistics.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonGenderStatistics.Location = new System.Drawing.Point(12, 48);
            this.ButtonGenderStatistics.Name = "ButtonGenderStatistics";
            this.ButtonGenderStatistics.Size = new System.Drawing.Size(202, 108);
            this.ButtonGenderStatistics.TabIndex = 1;
            this.ButtonGenderStatistics.Text = "Gender Statistics";
            this.ButtonGenderStatistics.UseVisualStyleBackColor = false;
            this.ButtonGenderStatistics.Click += new System.EventHandler(this.ButtonGenderStatistics_Click);
            // 
            // ButtonCommonReligions
            // 
            this.ButtonCommonReligions.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ButtonCommonReligions.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonCommonReligions.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonCommonReligions.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonCommonReligions.Location = new System.Drawing.Point(470, 227);
            this.ButtonCommonReligions.Name = "ButtonCommonReligions";
            this.ButtonCommonReligions.Size = new System.Drawing.Size(202, 113);
            this.ButtonCommonReligions.TabIndex = 2;
            this.ButtonCommonReligions.Text = "Most Common Religions";
            this.ButtonCommonReligions.UseVisualStyleBackColor = false;
            this.ButtonCommonReligions.Click += new System.EventHandler(this.ButtonCommonReligions_Click);
            // 
            // ButtonBirthdayStat
            // 
            this.ButtonBirthdayStat.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ButtonBirthdayStat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonBirthdayStat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonBirthdayStat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonBirthdayStat.Location = new System.Drawing.Point(12, 227);
            this.ButtonBirthdayStat.Name = "ButtonBirthdayStat";
            this.ButtonBirthdayStat.Size = new System.Drawing.Size(202, 113);
            this.ButtonBirthdayStat.TabIndex = 3;
            this.ButtonBirthdayStat.Text = "Friends With My Birthday";
            this.ButtonBirthdayStat.UseVisualStyleBackColor = false;
            this.ButtonBirthdayStat.Click += new System.EventHandler(this.ButtonBirthdayStat_Click);
            // 
            // ButtonBackToMain
            // 
            this.ButtonBackToMain.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ButtonBackToMain.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonBackToMain.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonBackToMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonBackToMain.Location = new System.Drawing.Point(241, 354);
            this.ButtonBackToMain.Name = "ButtonBackToMain";
            this.ButtonBackToMain.Size = new System.Drawing.Size(207, 41);
            this.ButtonBackToMain.TabIndex = 4;
            this.ButtonBackToMain.Text = "Back to Main Page";
            this.ButtonBackToMain.UseVisualStyleBackColor = false;
            this.ButtonBackToMain.Click += new System.EventHandler(this.ButtonBackToMain_Click);
            // 
            // ListBoxStat
            // 
            this.ListBoxStat.FormattingEnabled = true;
            this.ListBoxStat.Location = new System.Drawing.Point(241, 98);
            this.ListBoxStat.Name = "ListBoxStat";
            this.ListBoxStat.Size = new System.Drawing.Size(207, 173);
            this.ListBoxStat.TabIndex = 5;
            this.ListBoxStat.Visible = false;
            // 
            // LabelStat
            // 
            this.LabelStat.AutoSize = true;
            this.LabelStat.Location = new System.Drawing.Point(289, 62);
            this.LabelStat.Name = "LabelStat";
            this.LabelStat.Size = new System.Drawing.Size(35, 13);
            this.LabelStat.TabIndex = 6;
            this.LabelStat.Text = "label1";
            this.LabelStat.Visible = false;
            // 
            // FriendlyStatisticsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(684, 414);
            this.Controls.Add(this.LabelStat);
            this.Controls.Add(this.ListBoxStat);
            this.Controls.Add(this.ButtonBackToMain);
            this.Controls.Add(this.ButtonBirthdayStat);
            this.Controls.Add(this.ButtonCommonReligions);
            this.Controls.Add(this.ButtonGenderStatistics);
            this.Controls.Add(this.ButtonHometownStat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FriendlyStatisticsForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Friends Statistics";
            this.Load += new System.EventHandler(this.FriendlyStatisticsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ButtonGenderStatistics;
        private System.Windows.Forms.Button ButtonCommonReligions;
        private System.Windows.Forms.Button ButtonBirthdayStat;
        private System.Windows.Forms.Button ButtonBackToMain;
        private System.Windows.Forms.ListBox ListBoxStat;
        private System.Windows.Forms.Label LabelStat;
        private System.Windows.Forms.Button ButtonHometownStat;
    }
}

