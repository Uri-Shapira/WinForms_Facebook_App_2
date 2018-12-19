using FacebookWrapper.ObjectModel;
using FullQuiz;
using System.Windows.Forms;

namespace FBAppUI
{
    public partial class UserRankerForm : Form
    {
        private User LoggedInUser { get;  }
        private int UserRank { get; }
        private UserRanker UserRanker { get; }
        public UserRankerForm(User i_User)
        {
            InitializeComponent();
            LoggedInUser = i_User;
            UserRanker = new StandardUserRankerBuilder(LoggedInUser).BuildUserRanker();
        }

        private void buttonBackToMain_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
    }
}
