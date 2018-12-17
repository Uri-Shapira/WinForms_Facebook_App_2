namespace FBAppUI
{
    partial class MainForm
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.TextBoxAddPost = new System.Windows.Forms.TextBox();
            this.ButtonPostStatus = new System.Windows.Forms.Button();
            this.ButtonLogin = new System.Windows.Forms.Button();
            this.FriendsNextToYou = new System.Windows.Forms.ListBox();
            this.FriendsList = new System.Windows.Forms.ListBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ButtonMostLikedPic = new System.Windows.Forms.Button();
            this.ButtonLogout = new System.Windows.Forms.Button();
            this.ButtonClosestEvents = new System.Windows.Forms.Button();
            this.ButtonFriendsNextToYou = new System.Windows.Forms.Button();
            this.ButtonShowAllFriends = new System.Windows.Forms.Button();
            this.PictureBoxMostLikedPhoto = new System.Windows.Forms.PictureBox();
            this.PictureBoxEnterImage = new System.Windows.Forms.PictureBox();
            this.PictureBoxProfilePic = new System.Windows.Forms.PictureBox();
            this.LabelWelcomeMessage = new System.Windows.Forms.Label();
            this.ButtonHelp = new System.Windows.Forms.Button();
            this.ButtonFriendStats = new System.Windows.Forms.Button();
            this.WelcomeFacebookPlusLabel = new System.Windows.Forms.Label();
            this.LoginToEnterLabel = new System.Windows.Forms.Label();
            this.buttonQuiz = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxMostLikedPhoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxEnterImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxProfilePic)).BeginInit();
            this.SuspendLayout();
            // 
            // TextBoxAddPost
            // 
            this.TextBoxAddPost.Location = new System.Drawing.Point(359, 61);
            this.TextBoxAddPost.Name = "TextBoxAddPost";
            this.TextBoxAddPost.Size = new System.Drawing.Size(279, 20);
            this.TextBoxAddPost.TabIndex = 0;
            this.TextBoxAddPost.Visible = false;
            // 
            // ButtonPostStatus
            // 
            this.ButtonPostStatus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonPostStatus.Location = new System.Drawing.Point(418, 89);
            this.ButtonPostStatus.Name = "ButtonPostStatus";
            this.ButtonPostStatus.Size = new System.Drawing.Size(143, 20);
            this.ButtonPostStatus.TabIndex = 2;
            this.ButtonPostStatus.Text = "Post New Status";
            this.ButtonPostStatus.UseVisualStyleBackColor = true;
            this.ButtonPostStatus.Visible = false;
            this.ButtonPostStatus.Click += new System.EventHandler(this.ButtonPostStatus_Click);
            // 
            // ButtonLogin
            // 
            this.ButtonLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonLogin.Location = new System.Drawing.Point(359, 400);
            this.ButtonLogin.Name = "ButtonLogin";
            this.ButtonLogin.Size = new System.Drawing.Size(279, 73);
            this.ButtonLogin.TabIndex = 3;
            this.ButtonLogin.Text = "Login";
            this.ButtonLogin.UseVisualStyleBackColor = true;
            this.ButtonLogin.Click += new System.EventHandler(this.ButtonLogin_Click);
            // 
            // FriendsNextToYou
            // 
            this.FriendsNextToYou.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FriendsNextToYou.FormattingEnabled = true;
            this.FriendsNextToYou.HorizontalScrollbar = true;
            this.FriendsNextToYou.Location = new System.Drawing.Point(12, 145);
            this.FriendsNextToYou.Name = "FriendsNextToYou";
            this.FriendsNextToYou.Size = new System.Drawing.Size(238, 238);
            this.FriendsNextToYou.TabIndex = 7;
            this.FriendsNextToYou.Visible = false;
            // 
            // FriendsList
            // 
            this.FriendsList.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FriendsList.FormattingEnabled = true;
            this.FriendsList.HorizontalScrollbar = true;
            this.FriendsList.Location = new System.Drawing.Point(711, 145);
            this.FriendsList.Name = "FriendsList";
            this.FriendsList.Size = new System.Drawing.Size(244, 238);
            this.FriendsList.TabIndex = 9;
            this.FriendsList.Visible = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // ButtonMostLikedPic
            // 
            this.ButtonMostLikedPic.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ButtonMostLikedPic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonMostLikedPic.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonMostLikedPic.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonMostLikedPic.Location = new System.Drawing.Point(12, 12);
            this.ButtonMostLikedPic.Name = "ButtonMostLikedPic";
            this.ButtonMostLikedPic.Size = new System.Drawing.Size(238, 117);
            this.ButtonMostLikedPic.TabIndex = 12;
            this.ButtonMostLikedPic.Text = "Most Liked Photo";
            this.ButtonMostLikedPic.UseVisualStyleBackColor = false;
            this.ButtonMostLikedPic.Visible = false;
            this.ButtonMostLikedPic.Click += new System.EventHandler(this.ButtonMostLikedPic_Click);
            // 
            // ButtonLogout
            // 
            this.ButtonLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonLogout.Location = new System.Drawing.Point(446, 493);
            this.ButtonLogout.Name = "ButtonLogout";
            this.ButtonLogout.Size = new System.Drawing.Size(101, 31);
            this.ButtonLogout.TabIndex = 13;
            this.ButtonLogout.Text = "Logout";
            this.ButtonLogout.UseVisualStyleBackColor = true;
            this.ButtonLogout.Visible = false;
            this.ButtonLogout.Click += new System.EventHandler(this.ButtonLogout_Click);
            // 
            // ButtonClosestEvents
            // 
            this.ButtonClosestEvents.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ButtonClosestEvents.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonClosestEvents.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonClosestEvents.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonClosestEvents.Location = new System.Drawing.Point(711, 12);
            this.ButtonClosestEvents.Name = "ButtonClosestEvents";
            this.ButtonClosestEvents.Size = new System.Drawing.Size(244, 117);
            this.ButtonClosestEvents.TabIndex = 14;
            this.ButtonClosestEvents.Text = "Closest Events";
            this.ButtonClosestEvents.UseVisualStyleBackColor = false;
            this.ButtonClosestEvents.Visible = false;
            this.ButtonClosestEvents.Click += new System.EventHandler(this.ButtonClosestEvents_Click);
            // 
            // ButtonFriendsNextToYou
            // 
            this.ButtonFriendsNextToYou.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ButtonFriendsNextToYou.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonFriendsNextToYou.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonFriendsNextToYou.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonFriendsNextToYou.Location = new System.Drawing.Point(12, 402);
            this.ButtonFriendsNextToYou.Name = "ButtonFriendsNextToYou";
            this.ButtonFriendsNextToYou.Size = new System.Drawing.Size(238, 122);
            this.ButtonFriendsNextToYou.TabIndex = 15;
            this.ButtonFriendsNextToYou.Text = "Closest Friends";
            this.ButtonFriendsNextToYou.UseVisualStyleBackColor = false;
            this.ButtonFriendsNextToYou.Visible = false;
            this.ButtonFriendsNextToYou.Click += new System.EventHandler(this.ButtonFriendsNextToYou_Click);
            // 
            // ButtonShowAllFriends
            // 
            this.ButtonShowAllFriends.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ButtonShowAllFriends.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonShowAllFriends.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonShowAllFriends.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonShowAllFriends.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ButtonShowAllFriends.Location = new System.Drawing.Point(711, 402);
            this.ButtonShowAllFriends.Name = "ButtonShowAllFriends";
            this.ButtonShowAllFriends.Size = new System.Drawing.Size(244, 119);
            this.ButtonShowAllFriends.TabIndex = 16;
            this.ButtonShowAllFriends.Text = "Friends List";
            this.ButtonShowAllFriends.UseVisualStyleBackColor = false;
            this.ButtonShowAllFriends.Visible = false;
            this.ButtonShowAllFriends.Click += new System.EventHandler(this.ButtonShowAllFriends_Click);
            // 
            // PictureBoxMostLikedPhoto
            // 
            this.PictureBoxMostLikedPhoto.Image = ((System.Drawing.Image)(resources.GetObject("PictureBoxMostLikedPhoto.Image")));
            this.PictureBoxMostLikedPhoto.InitialImage = global::FBAppUI.Properties.Resources.FBAppMostLikedPhotoCover;
            this.PictureBoxMostLikedPhoto.Location = new System.Drawing.Point(12, 168);
            this.PictureBoxMostLikedPhoto.Name = "PictureBoxMostLikedPhoto";
            this.PictureBoxMostLikedPhoto.Size = new System.Drawing.Size(238, 215);
            this.PictureBoxMostLikedPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBoxMostLikedPhoto.TabIndex = 19;
            this.PictureBoxMostLikedPhoto.TabStop = false;
            this.PictureBoxMostLikedPhoto.Visible = false;
            // 
            // PictureBoxEnterImage
            // 
            this.PictureBoxEnterImage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PictureBoxEnterImage.BackgroundImage")));
            this.PictureBoxEnterImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PictureBoxEnterImage.InitialImage = ((System.Drawing.Image)(resources.GetObject("PictureBoxEnterImage.InitialImage")));
            this.PictureBoxEnterImage.Location = new System.Drawing.Point(359, 145);
            this.PictureBoxEnterImage.Name = "PictureBoxEnterImage";
            this.PictureBoxEnterImage.Size = new System.Drawing.Size(279, 254);
            this.PictureBoxEnterImage.TabIndex = 17;
            this.PictureBoxEnterImage.TabStop = false;
            // 
            // PictureBoxProfilePic
            // 
            this.PictureBoxProfilePic.Location = new System.Drawing.Point(446, 402);
            this.PictureBoxProfilePic.Name = "PictureBoxProfilePic";
            this.PictureBoxProfilePic.Size = new System.Drawing.Size(101, 85);
            this.PictureBoxProfilePic.TabIndex = 5;
            this.PictureBoxProfilePic.TabStop = false;
            this.PictureBoxProfilePic.Visible = false;
            // 
            // LabelWelcomeMessage
            // 
            this.LabelWelcomeMessage.AutoSize = true;
            this.LabelWelcomeMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.LabelWelcomeMessage.Location = new System.Drawing.Point(409, 9);
            this.LabelWelcomeMessage.Name = "LabelWelcomeMessage";
            this.LabelWelcomeMessage.Size = new System.Drawing.Size(132, 24);
            this.LabelWelcomeMessage.TabIndex = 20;
            this.LabelWelcomeMessage.Text = "welcome label";
            this.LabelWelcomeMessage.Visible = false;
            // 
            // ButtonHelp
            // 
            this.ButtonHelp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonHelp.Location = new System.Drawing.Point(339, 493);
            this.ButtonHelp.Name = "ButtonHelp";
            this.ButtonHelp.Size = new System.Drawing.Size(101, 31);
            this.ButtonHelp.TabIndex = 21;
            this.ButtonHelp.Text = "Help";
            this.ButtonHelp.UseVisualStyleBackColor = true;
            this.ButtonHelp.Visible = false;
            this.ButtonHelp.Click += new System.EventHandler(this.ButtonHelp_Click);
            // 
            // ButtonFriendStats
            // 
            this.ButtonFriendStats.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonFriendStats.Location = new System.Drawing.Point(553, 493);
            this.ButtonFriendStats.Name = "ButtonFriendStats";
            this.ButtonFriendStats.Size = new System.Drawing.Size(101, 31);
            this.ButtonFriendStats.TabIndex = 22;
            this.ButtonFriendStats.Text = "Friendly Statistics";
            this.ButtonFriendStats.UseVisualStyleBackColor = true;
            this.ButtonFriendStats.Visible = false;
            this.ButtonFriendStats.Click += new System.EventHandler(this.ButtonFriendStats_Click);
            // 
            // WelcomeFacebookPlusLabel
            // 
            this.WelcomeFacebookPlusLabel.AutoSize = true;
            this.WelcomeFacebookPlusLabel.Font = new System.Drawing.Font("Papyrus", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WelcomeFacebookPlusLabel.Location = new System.Drawing.Point(282, 12);
            this.WelcomeFacebookPlusLabel.Name = "WelcomeFacebookPlusLabel";
            this.WelcomeFacebookPlusLabel.Size = new System.Drawing.Size(445, 51);
            this.WelcomeFacebookPlusLabel.TabIndex = 24;
            this.WelcomeFacebookPlusLabel.Text = "Welcome to Facebook Plus! ";
           
            // 
            // LoginToEnterLabel
            // 
            this.LoginToEnterLabel.AutoSize = true;
            this.LoginToEnterLabel.Font = new System.Drawing.Font("Perpetua Titling MT", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginToEnterLabel.Location = new System.Drawing.Point(322, 90);
            this.LoginToEnterLabel.Name = "LoginToEnterLabel";
            this.LoginToEnterLabel.Size = new System.Drawing.Size(350, 17);
            this.LoginToEnterLabel.TabIndex = 25;
            this.LoginToEnterLabel.Text = "Login to access new Facebook features";
            // 
            // buttonQuiz
            // 
            this.buttonQuiz.Location = new System.Drawing.Point(609, 292);
            this.buttonQuiz.Name = "buttonQuiz";
            this.buttonQuiz.Size = new System.Drawing.Size(118, 62);
            this.buttonQuiz.TabIndex = 26;
            this.buttonQuiz.Text = "Start Quiz";
            this.buttonQuiz.UseVisualStyleBackColor = true;
            this.buttonQuiz.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonQuiz_MouseClick);
            this.buttonQuiz.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(973, 533);
            this.Controls.Add(this.buttonQuiz);
            this.Controls.Add(this.LoginToEnterLabel);
            this.Controls.Add(this.WelcomeFacebookPlusLabel);
            this.Controls.Add(this.ButtonFriendStats);
            this.Controls.Add(this.ButtonHelp);
            this.Controls.Add(this.LabelWelcomeMessage);
            this.Controls.Add(this.PictureBoxMostLikedPhoto);
            this.Controls.Add(this.PictureBoxEnterImage);
            this.Controls.Add(this.ButtonShowAllFriends);
            this.Controls.Add(this.ButtonFriendsNextToYou);
            this.Controls.Add(this.ButtonClosestEvents);
            this.Controls.Add(this.ButtonLogout);
            this.Controls.Add(this.ButtonMostLikedPic);
            this.Controls.Add(this.FriendsList);
            this.Controls.Add(this.FriendsNextToYou);
            this.Controls.Add(this.PictureBoxProfilePic);
            this.Controls.Add(this.ButtonLogin);
            this.Controls.Add(this.ButtonPostStatus);
            this.Controls.Add(this.TextBoxAddPost);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Facebook Plus ";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxMostLikedPhoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxEnterImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxProfilePic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBoxAddPost;
        private System.Windows.Forms.Button ButtonPostStatus;
        private System.Windows.Forms.Button ButtonLogin;
        private System.Windows.Forms.PictureBox PictureBoxProfilePic;
        private System.Windows.Forms.ListBox FriendsNextToYou;
        private System.Windows.Forms.ListBox FriendsList;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button ButtonMostLikedPic;
        private System.Windows.Forms.Button ButtonLogout;
        private System.Windows.Forms.Button ButtonClosestEvents;
        private System.Windows.Forms.Button ButtonFriendsNextToYou;
        private System.Windows.Forms.Button ButtonShowAllFriends;
        private System.Windows.Forms.PictureBox PictureBoxEnterImage;
        private System.Windows.Forms.PictureBox PictureBoxMostLikedPhoto;
        private System.Windows.Forms.Label LabelWelcomeMessage;
        private System.Windows.Forms.Button ButtonHelp;
        private System.Windows.Forms.Button ButtonFriendStats;
        private System.Windows.Forms.Label WelcomeFacebookPlusLabel;
        private System.Windows.Forms.Label LoginToEnterLabel;
        private System.Windows.Forms.Button buttonQuiz;
    }
}

