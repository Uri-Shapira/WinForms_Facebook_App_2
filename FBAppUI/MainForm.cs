using FacebookWrapper;
using System;
using System.Drawing;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using FacebookAppLogic;
using FacebookQuiz;


namespace FBAppUI
{
    public partial class MainForm : Form
    {
        private User LoggedInUser { get; set; }
        private AppLogic m_AppLogic;
        private FriendlyStatisticsForm m_FriendlyStatisticsForm;
        private HelpForm m_HelpForm;
        private ClosestEventsForm m_ClosestEventsForm;
        private AbstractQuiz Quiz { get; set;}
        private QuizForm QuizForm { get; set; }
        private UserRankerForm UserRankerForm { get; set; }

        public MainForm()
        {
            InitializeComponent();
            FacebookWrapper.FacebookService.s_CollectionLimit = 200;
            FacebookWrapper.FacebookService.s_FbApiVersion = 2.8f;
        }

        private void loginAndInit()
        {
            LoginResult result = FacebookService.Login("2169376336723441", "public_profile"
               /*
                * We took off all other permissions to allow the application to pass the login.
                * 
              "user_education_history",
              "user_birthday",
              "user_actions.video",
              "user_actions.news",
              "user_actions.music",
              "user_actions.fitness",
              "user_actions.books",
              "user_about_me",
              "user_friends",
              "publish_actions",
              "user_events",
              "user_games_activity",
              "user_hometown",
              "user_likes",
              "user_location",
              "user_managed_groups",
              "user_photos",
              "user_posts",
              "user_relationships",
              "user_relationship_details",
              "user_religion_politics",
              "user_tagged_places",
              "user_videos",
              "user_website",
              "user_work_history",
              "read_custom_friendlists",
              "read_page_mailboxes",
              "manage_pages",
              "publish_pages",
              "publish_actions",
              "rsvp_event"
              */
               );
            if (!string.IsNullOrEmpty(result.AccessToken))
            {
                LoggedInUser = result.LoggedInUser;
                m_AppLogic = new AppLogic(LoggedInUser);
                LabelWelcomeMessage.Text = "Welcome Back " + LoggedInUser.FirstName;
                renderLoginVisibility();
                Quiz = QuizFactory.CreateQuiz(LoggedInUser);
                getProfilePicture();
            }
        }

        private void ButtonLogin_Click(object i_sender, EventArgs e)
        {
            loginAndInit();
        }

        private void getProfilePicture()
        {
            PictureBoxProfilePic.LoadAsync(LoggedInUser.PictureNormalURL);
        }

        private void renderLoginVisibility()
        {
            TextBoxAddPost.Visible = true;
            PictureBoxProfilePic.Visible = true;
            ButtonClosestEvents.Visible = true;
            ButtonPostStatus.Visible = true;
            ButtonLogout.Visible = true;
            ButtonMostLikedPic.Visible = true;
            ButtonFriendsNextToYou.Visible = true;
            ButtonShowAllFriends.Visible = true;
            LabelWelcomeMessage.Visible = true;
            ButtonHelp.Visible = true;
            ButtonFriendStats.Visible = true;
            ButtonLogin.Visible = false;
            WelcomeFacebookPlusLabel.Visible = false;
            LoginToEnterLabel.Visible = false;
            buttonQuiz.Visible = true;
            buttonUserRanker.Visible = true;
        }

        private void renderLogoutVisibility()
        {
            TextBoxAddPost.Visible = false;
            PictureBoxProfilePic.Visible = false;
            ButtonClosestEvents.Visible = false;
            ButtonPostStatus.Visible = false;
            ButtonLogout.Visible = false;
            ButtonMostLikedPic.Visible = false;
            PictureBoxMostLikedPhoto.Visible = false;
            ButtonFriendsNextToYou.Visible = false;
            FriendsNextToYou.Visible = false;
            ButtonShowAllFriends.Visible = false;
            FriendsList.Visible = false;
            LabelWelcomeMessage.Visible = false;
            ButtonHelp.Visible = false;
            ButtonFriendStats.Visible = false;
            ButtonLogin.Visible = true;
            buttonQuiz.Visible = false;
            buttonUserRanker.Visible = false;
            ButtonPostStatus.Text = "Post New Status";
            ButtonPostStatus.BackColor = SystemColors.ButtonHighlight;
            ButtonPostStatus.ForeColor = Color.Black;
        }

        private void ButtonPostStatus_Click(object i_sender, EventArgs e)
        {
            if(TextBoxAddPost.TextLength == 0)
            {
                ButtonPostStatus.Text = "Please Enter A Valid Post";
                ButtonPostStatus.BackColor = Color.Black;
                ButtonPostStatus.ForeColor = Color.Red ;
                MessageBox.Show("Cannot Post Empty Status");
            }
            else
            {
                ButtonPostStatus.Text = "Post New Status";
                ButtonPostStatus.BackColor = SystemColors.ButtonHighlight;
                ButtonPostStatus.ForeColor = Color.Black;
                LoggedInUser.PostStatus(TextBoxAddPost.Text);
            }
        }

        private void ButtonFriendsNextToYou_Click(object i_sender, EventArgs e)
        {
            PictureBoxMostLikedPhoto.Visible = false;
            FriendsNextToYou.Visible = true;
            if (m_AppLogic.ClosestFriendsFilter.ClosestFriends == null)
            {
                if (FriendsNextToYou.Items.Count == 0)
                {
                    FriendsNextToYou.Items.Add("No Friends At Your Current Location");
                }
                MessageBox.Show("No Friends At Your Current Location Found");
            }
            else
            {
                FriendsList.Items.Clear();
                foreach (User friend in m_AppLogic.ClosestFriendsFilter.ClosestFriends)
                {
                    FriendsNextToYou.Items.Add(friend);
                }
            }
        }

        private void ButtonMostLikedPic_Click(object i_sender, EventArgs e)
        {
            if (m_AppLogic.MostLikedPhotoFilter.MostLikedPhoto != null)
            {
                PictureBoxMostLikedPhoto.LoadAsync(m_AppLogic.MostLikedPhotoFilter.MostLikedPhoto.URL);
            }
            else
            {
                MessageBox.Show("No Available Photos Found");
            }
            PictureBoxMostLikedPhoto.Visible = true;
            FriendsNextToYou.Visible = false;
        }

        private void ButtonClosestEvents_Click(object sender, EventArgs e)
        {
            m_ClosestEventsForm = new ClosestEventsForm(m_AppLogic);
            m_ClosestEventsForm.ShowDialog();
        }

        private void ButtonShowAllFriends_Click(object sender, EventArgs e)
        {
            FriendsList.Visible = true;
            if (m_AppLogic.FriendsListFilter.FriendsList == null)
            {
                if (FriendsList.Items.Count == 0)
                {
                    FriendsList.Items.Add("You Have No Friends!");
                    FriendsList.Items.Add("Log Into Facebook And Make Friends");
                }
                MessageBox.Show("User Has No Friends");
            }
            else
            {
                FriendsList.Items.Clear();
                foreach (User friend in m_AppLogic.FriendsListFilter.FriendsList)
                {
                FriendsList.Items.Add(friend.FirstName + " " + friend.LastName);
                }
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            
        }

        private void ButtonLogout_Click(object sender, EventArgs e)
        {
            renderLogoutVisibility();
            FacebookService.Logout(null);
        }

        private void ButtonHelp_Click(object sender, EventArgs e)
        {
            m_HelpForm = new HelpForm(m_AppLogic);
            m_HelpForm.ShowDialog();
        }

        private void ButtonFriendStats_Click(object sender, EventArgs e)
        {
            m_FriendlyStatisticsForm = new FriendlyStatisticsForm(m_AppLogic);
            m_FriendlyStatisticsForm.ShowDialog();
        }

        private void buttonQuiz_MouseClick(object sender, MouseEventArgs e)
        {
            QuizForm = new QuizForm(LoggedInUser);
            QuizForm.ShowDialog();
        }

        private void buttonUserRanker_Click(object sender, EventArgs e)
        {
            this.UserRankerForm = new UserRankerForm(LoggedInUser);
            UserRankerForm.ShowDialog();
        }
    }
}
