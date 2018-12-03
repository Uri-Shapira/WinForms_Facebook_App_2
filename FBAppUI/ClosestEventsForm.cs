using FacebookAppLogic;
using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FBAppUI
{
    public partial class ClosestEventsForm : Form
    {
        private readonly AppLogic r_AppLogic;
        public ClosestEventsForm(AppLogic i_AppLogic)
        {
            r_AppLogic = i_AppLogic;
            InitializeComponent();
        }

        private void ButtonHometownEvents_Click(object sender, EventArgs e)
        {
            DataGridCloseEvents.Visible = true;
            if (r_AppLogic.ClosestEventsFilter.HometownEvents == null)
            {
                MessageBox.Show("No Events Found In Your Hometown");
            }
            else
            {
                foreach (Event friendEvent in r_AppLogic.ClosestEventsFilter.HometownEvents)
                {
                    DataGridCloseEvents.Rows.Add(friendEvent.Name, friendEvent.Owner, friendEvent.AttendingUsers.Count, friendEvent.StartTime, friendEvent.Description);
                }
            }      
        }

        private void ButtonLocationEvents_Click(object sender, EventArgs e)
        {
            DataGridCloseEvents.Visible = true;
            if (r_AppLogic.ClosestEventsFilter.LocationEvents == null)
            {
                MessageBox.Show("No Events Found In Your Location");
            }
            else
            {
                foreach(Event friendEvent in r_AppLogic.ClosestEventsFilter.LocationEvents)
                {

                    DataGridCloseEvents.Rows.Add(friendEvent.Name, friendEvent.Owner, friendEvent.AttendingUsers.Count, friendEvent.StartTime, friendEvent.Description);
                }
            }
        }

       
        private void ButtonBackToMain_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DataGridCloseEvents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
