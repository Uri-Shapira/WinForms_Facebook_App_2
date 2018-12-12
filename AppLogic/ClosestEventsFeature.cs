using System.Collections.Generic;
using FacebookWrapper.ObjectModel;

namespace FacebookAppLogic
{
    public class ClosestEventsFeature : Feature
    {
        private readonly string r_Description;
        private List<Event> m_HometownEvents = new List<Event>();
        private List<Event> m_LocationEvents = new List<Event>();

        public ClosestEventsFeature(User i_User) : base(i_User)
        {
            r_Description = "Clicking this feature will show you events at your hometown or current location that your friends are going to.";
            ImplementFeature();
        }

        public override string Description
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

        public override void ImplementFeature()
        {
            foreach (User friend in LoggedInUser.Friends)
            {
                foreach(Event friendEvent in friend.Events){
                    if(friendEvent.Location == LoggedInUser.Location.Location.ToString())
                    {
                        m_LocationEvents.Add(friendEvent);
                    }
                    else if(LoggedInUser.Location != LoggedInUser.Hometown && friendEvent.Location == LoggedInUser.Hometown.Location.ToString())
                    {
                        m_HometownEvents.Add(friendEvent);
                    }
                }
                foreach(Event myEvent in LoggedInUser.Events)
                {
                    if(myEvent.Location == LoggedInUser.Location.Location.ToString())
                    {
                        m_LocationEvents.Add(myEvent);
                    }
                    else if (LoggedInUser.Location != LoggedInUser.Hometown && myEvent.Location == LoggedInUser.Hometown.Location.ToString())
                    {
                        m_HometownEvents.Add(myEvent);
                    }
                }
            }
        }
    }
}