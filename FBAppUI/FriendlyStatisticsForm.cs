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
            LabelStat.Text = r_AppLogic.HometownStatistic.Description;
            LabelStat.Visible = true;
            ListBoxStat.Visible = true;
            if (r_AppLogic.HometownStatistic.MostFriendlyHometowns == null)
            {
                MessageBox.Show("You currently have no friends");
            }
            else
            {
                
                foreach(KeyValuePair<City, int> entry in r_AppLogic.HometownStatistic.MostFriendlyHometowns)
                {
                    ListBoxStat.Items.Add("City: " + entry.Key + " - Amount of friends: " + entry.Value);
                } 
            }
        }

        private void ButtonGenderStatistics_Click(object sender, EventArgs e)
        {
            ListBoxStat.Items.Clear();
            LabelStat.Text = r_AppLogic.GenderStatistic.Description;
            LabelStat.Visible = true;
            ListBoxStat.Visible = true;
            if(r_AppLogic.GenderStatistic.MaleFriends == 0 && r_AppLogic.GenderStatistic.FemaleFriends == 0)
            {
                MessageBox.Show("You currently have no friends");
            }
            else
            {
                ListBoxStat.Items.Add("You have " + r_AppLogic.GenderStatistic.MaleFriends + " male friends");
                ListBoxStat.Items.Add(r_AppLogic.GenderStatistic.MalePercent + " percent male friends");
                ListBoxStat.Items.Add("You have " + r_AppLogic.GenderStatistic.FemaleFriends + " female friends");
                ListBoxStat.Items.Add(r_AppLogic.GenderStatistic.FemalePercent + " percent female friends");
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
            LabelStat.Text = r_AppLogic.BirthdayStatistic.Description;
            LabelStat.Visible = true;
            if(r_AppLogic.BirthdayStatistic.SameBirthdayList == null)
            {
                MessageBox.Show("You currently have no friends");
            }
            else
            {
                foreach(User friend in r_AppLogic.BirthdayStatistic.SameBirthdayList)
                {
                    ListBoxStat.Items.Add(friend.FirstName + " " + friend.LastName);
                }
                
            }
        }

        private void ButtonCommonReligions_Click(object sender, EventArgs e)
        {
            ListBoxStat.Items.Clear();
            ListBoxStat.Visible = true;
            LabelStat.Text = r_AppLogic.CommonReligionStatistic.Description;
            LabelStat.Visible = true;
            if (r_AppLogic.CommonReligionStatistic.ReligionsList == null)
            {
                MessageBox.Show("You currently have no friends");
            }
            else
            {
                foreach(KeyValuePair<string, int> religion in r_AppLogic.CommonReligionStatistic.ReligionsList)
                {
                    ListBoxStat.Items.Add(religion.Value + " practice " + religion.Key);
                }
                
            }
        }
    }
}
