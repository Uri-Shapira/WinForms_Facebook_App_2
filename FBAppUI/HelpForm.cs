using FacebookAppLogic;
using System;
using System.Windows.Forms;

namespace FBAppUI
{
    public partial class HelpForm : Form
    {
        AppLogic m_AppLogic;
        public HelpForm(AppLogic i_AppLogic)
        {
            m_AppLogic = i_AppLogic;
            InitializeComponent();
        }

        private void ButtonBackToMain_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LabelMostLikedPhoto_Click(object sender, EventArgs e)
        {
            MessageBox.Show(m_AppLogic.MostLikedPhotoFeature.Description);
        }

        private void LabelClosestFriends_Click(object sender, EventArgs e)
        {
            MessageBox.Show(m_AppLogic.ClosestFriendsFilter.Description);
        }

        private void LabelClosestEvents_Click(object sender, EventArgs e)
        {
            MessageBox.Show(m_AppLogic.ClosestEventsFilter.Description);
        }

        private void LableFriendsList_Click(object sender, EventArgs e)
        {
            MessageBox.Show(m_AppLogic.FriendsListFilter.Description);
        }

        private void LabelFriendsStatistics_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Clicking this feature will show you various interesting statistics regarding your friends.");
        }

        private void HelpForm_Load(object sender, EventArgs e)
        {

        }

        private void LabelHelpChoice_Click(object sender, EventArgs e)
        {

        }
    }
}
