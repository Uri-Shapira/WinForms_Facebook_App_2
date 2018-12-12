using FacebookAppLogic;
using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace FBAppUI
{
    public partial class FriendlyStatisticsForm : Form
    {
        private readonly AppLogic r_AppLogic;
        public FriendlyStatisticsForm(AppLogic i_AppLogic)
        {
            r_AppLogic = i_AppLogic;
            InitializeComponent();
        }

        private void renderVisibility()
        {

        }

        private void ButtonBackToMain_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonHometownStat_Click(object sender, EventArgs e)
        {
            ListBoxStat.Items.Clear();
            LabelStat.Text = r_AppLogic.HometownStatistics.Description;
            LabelStat.Visible = true;
            ListBoxStat.Visible = true;
            if (r_AppLogic.HometownStatistics.MostFriendlyHometowns == null)
            {
                MessageBox.Show("You currently have no friends");
            }
            else
            {
                
                foreach(KeyValuePair<City, int> entry in r_AppLogic.HometownStatistics.MostFriendlyHometowns)
                {
                    ListBoxStat.Items.Add("City: " + entry.Key + " - Amount of friends: " + entry.Value);
                } 
            }
        }

        private void ButtonGenderStatistics_Click(object sender, EventArgs e)
        {
            ListBoxStat.Items.Clear();
            LabelStat.Text = r_AppLogic.GenderStatistics.Description;
            LabelStat.Visible = true;
            ListBoxStat.Visible = true;
            if(r_AppLogic.GenderStatistics.MaleFriends == 0 && r_AppLogic.GenderStatistics.FemaleFriends == 0)
            {
                MessageBox.Show("You currently have no friends");
            }
            else
            {
                ListBoxStat.Items.Add("You have " + r_AppLogic.GenderStatistics.MaleFriends + " male friends");
                ListBoxStat.Items.Add(r_AppLogic.GenderStatistics.MalePercent + " percent male friends");
                ListBoxStat.Items.Add("You have " + r_AppLogic.GenderStatistics.FemaleFriends + " female friends");
                ListBoxStat.Items.Add(r_AppLogic.GenderStatistics.FemalePercent + " percent female friends");
            }
        }

        private void ButtonStat4_Click(object sender, EventArgs e)
        {

        }

        private void FriendlyStatisticsForm_Load(object sender, EventArgs e)
        {

        }

        private void ButtonBirthdayStat_Click(object sender, EventArgs e)
        {
            ListBoxStat.Items.Clear();
            ListBoxStat.Visible = true;
            LabelStat.Text = r_AppLogic.BirthdayStatistics.Description;
            LabelStat.Visible = true;
            if(r_AppLogic.BirthdayStatistics.SameBirthdayList == null)
            {
                MessageBox.Show("You currently have no friends");
            }
            else
            {
                foreach(User friend in r_AppLogic.BirthdayStatistics.SameBirthdayList)
                {
                    ListBoxStat.Items.Add(friend.FirstName + " " + friend.LastName);
                }
                
            }
        }

        private void ButtonCommonReligions_Click(object sender, EventArgs e)
        {
            ListBoxStat.Items.Clear();
            ListBoxStat.Visible = true;
            LabelStat.Text = r_AppLogic.CommonReligionStatistics.Description;
            LabelStat.Visible = true;
            if (r_AppLogic.CommonReligionStatistics.ReligionsList == null)
            {
                MessageBox.Show("You currently have no friends");
            }
            else
            {
                foreach(KeyValuePair<string, int> religion in r_AppLogic.CommonReligionStatistics.ReligionsList)
                {
                    ListBoxStat.Items.Add(religion.Value + " practice " + religion.Key);
                }
                
            }
        }
    }
}
