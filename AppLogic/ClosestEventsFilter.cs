using System.Collections.Generic;
using FacebookWrapper.ObjectModel;

namespace FacebookAppLogic
{
    public class ClosestEventsFilter : IFeature
    {
        private readonly string r_Description;
        private List<Event> m_HometownEvents = new List<Event>();
        private List<Event> m_LocationEvents = new List<Event>();
        private readonly User r_LoggedInUser;

        public ClosestEventsFilter(User i_User)
        {
            r_Description = "Clicking this feature will show you events at your hometown or current location that your friends are going to.";
            r_LoggedInUser = i_User;
            ImplementFeature();
        }

        public string Description
        {
            get => r_Description;
        }

        public List<Event> HometownEvents
        {
            get => m_HometownEvents;
        }

        public List<Event> LocationEvents
        {
            get => m_LocationEvents;
        }

        public void ImplementFeature()
        {
            foreach (User friend in r_LoggedInUser.Friends)
            {
                foreach(Event friendEvent in friend.Events){
                    if(friendEvent.Location == r_LoggedInUser.Location.Location.ToString())
                    {
                        m_LocationEvents.Add(friendEvent);
                    }
                    else if(r_LoggedInUser.Location != r_LoggedInUser.Hometown && friendEvent.Location == r_LoggedInUser.Hometown.Location.ToString())
                    {
                        m_HometownEvents.Add(friendEvent);
                    }
                }
                foreach(Event myEvent in r_LoggedInUser.Events)
                {
                    if(myEvent.Location == r_LoggedInUser.Location.Location.ToString())
                    {
                        m_LocationEvents.Add(myEvent);
                    }
                    else if (r_LoggedInUser.Location != r_LoggedInUser.Hometown && myEvent.Location == r_LoggedInUser.Hometown.Location.ToString())
                    {
                        m_HometownEvents.Add(myEvent);
                    }
                }
            }
        }
    }
}