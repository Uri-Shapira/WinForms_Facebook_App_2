namespace FBAppUI
{
    partial class HelpForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HelpForm));
            this.ButtonBackToMain = new System.Windows.Forms.Button();
            this.LabelHelpChoice = new System.Windows.Forms.Label();
            this.LabelMostLikedPhoto = new System.Windows.Forms.Label();
            this.LabelClosestFriends = new System.Windows.Forms.Label();
            this.LabelClosestEvents = new System.Windows.Forms.Label();
            this.LableFriendsList = new System.Windows.Forms.Label();
            this.LabelFriendsStatistics = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ButtonBackToMain
            // 
            this.ButtonBackToMain.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ButtonBackToMain.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonBackToMain.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonBackToMain.Location = new System.Drawing.Point(79, 186);
            this.ButtonBackToMain.Name = "ButtonBackToMain";
            this.ButtonBackToMain.Size = new System.Drawing.Size(128, 40);
            this.ButtonBackToMain.TabIndex = 0;
            this.ButtonBackToMain.Text = "Back To Main Page";
            this.ButtonBackToMain.UseVisualStyleBackColor = false;
            this.ButtonBackToMain.Click += new System.EventHandler(this.ButtonBackToMain_Click);
            // 
            // LabelHelpChoice
            // 
            this.LabelHelpChoice.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.LabelHelpChoice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LabelHelpChoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelHelpChoice.Location = new System.Drawing.Point(13, 20);
            this.LabelHelpChoice.Name = "LabelHelpChoice";
            this.LabelHelpChoice.Size = new System.Drawing.Size(251, 18);
            this.LabelHelpChoice.TabIndex = 2;
            this.LabelHelpChoice.Text = "Please click on the feature you need help with:";
            this.LabelHelpChoice.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.LabelHelpChoice.UseCompatibleTextRendering = true;
            this.LabelHelpChoice.UseWaitCursor = true;
            this.LabelHelpChoice.Click += new System.EventHandler(this.LabelHelpChoice_Click);
            // 
            // LabelMostLikedPhoto
            // 
            this.LabelMostLikedPhoto.AutoSize = true;
            this.LabelMostLikedPhoto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LabelMostLikedPhoto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LabelMostLikedPhoto.Location = new System.Drawing.Point(26, 60);
            this.LabelMostLikedPhoto.Name = "LabelMostLikedPhoto";
            this.LabelMostLikedPhoto.Size = new System.Drawing.Size(92, 15);
            this.LabelMostLikedPhoto.TabIndex = 3;
            this.LabelMostLikedPhoto.Text = "Most Liked Photo";
            this.LabelMostLikedPhoto.Click += new System.EventHandler(this.LabelMostLikedPhoto_Click);
            // 
            // LabelClosestFriends
            // 
            this.LabelClosestFriends.AutoSize = true;
            this.LabelClosestFriends.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LabelClosestFriends.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LabelClosestFriends.Location = new System.Drawing.Point(166, 94);
            this.LabelClosestFriends.Name = "LabelClosestFriends";
            this.LabelClosestFriends.Size = new System.Drawing.Size(80, 15);
            this.LabelClosestFriends.TabIndex = 4;
            this.LabelClosestFriends.Text = "Closest Friends";
            this.LabelClosestFriends.Click += new System.EventHandler(this.LabelClosestFriends_Click);
            // 
            // LabelClosestEvents
            // 
            this.LabelClosestEvents.AutoSize = true;
            this.LabelClosestEvents.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LabelClosestEvents.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LabelClosestEvents.Location = new System.Drawing.Point(166, 60);
            this.LabelClosestEvents.Name = "LabelClosestEvents";
            this.LabelClosestEvents.Size = new System.Drawing.Size(79, 15);
            this.LabelClosestEvents.TabIndex = 5;
            this.LabelClosestEvents.Text = "Closest Events";
            this.LabelClosestEvents.Click += new System.EventHandler(this.LabelClosestEvents_Click);
            // 
            // LableFriendsList
            // 
            this.LableFriendsList.AutoSize = true;
            this.LableFriendsList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LableFriendsList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LableFriendsList.Location = new System.Drawing.Point(26, 132);
            this.LableFriendsList.Name = "LableFriendsList";
            this.LableFriendsList.Size = new System.Drawing.Size(62, 15);
            this.LableFriendsList.TabIndex = 6;
            this.LableFriendsList.Text = "Friends List";
            this.LableFriendsList.Click += new System.EventHandler(this.LableFriendsList_Click);
            // 
            // LabelFriendsStatistics
            // 
            this.LabelFriendsStatistics.AutoSize = true;
            this.LabelFriendsStatistics.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LabelFriendsStatistics.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LabelFriendsStatistics.Location = new System.Drawing.Point(26, 94);
            this.LabelFriendsStatistics.Name = "LabelFriendsStatistics";
            this.LabelFriendsStatistics.Size = new System.Drawing.Size(88, 15);
            this.LabelFriendsStatistics.TabIndex = 7;
            this.LabelFriendsStatistics.Text = "Friends Statistics";
            this.LabelFriendsStatistics.Click += new System.EventHandler(this.LabelFriendsStatistics_Click);
            // 
            // HelpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(276, 249);
            this.Controls.Add(this.LabelFriendsStatistics);
            this.Controls.Add(this.LableFriendsList);
            this.Controls.Add(this.LabelClosestEvents);
            this.Controls.Add(this.LabelClosestFriends);
            this.Controls.Add(this.LabelMostLikedPhoto);
            this.Controls.Add(this.LabelHelpChoice);
            this.Controls.Add(this.ButtonBackToMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HelpForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Application Tutorial";
            this.Load += new System.EventHandler(this.HelpForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonBackToMain;
        private System.Windows.Forms.Label LabelHelpChoice;
        private System.Windows.Forms.Label LabelMostLikedPhoto;
        private System.Windows.Forms.Label LabelClosestFriends;
        private System.Windows.Forms.Label LabelClosestEvents;
        private System.Windows.Forms.Label LableFriendsList;
        private System.Windows.Forms.Label LabelFriendsStatistics;
    }
}