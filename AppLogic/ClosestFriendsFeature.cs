using System.Collections.Generic;
using FacebookWrapper.ObjectModel;

namespace FacebookAppLogic
{
    public class ClosestFriendsFeature : Feature
    {

        public ClosestFriendsFeature (User i_LoggedInUser) : base(i_LoggedInUser)
        {
            Description = "Clicking this feature will show you the friends that are at the same location as you at any given time.";
            ImplementFeature();
        }

        public override string Description { get; }

        public override void ImplementFeature()
        {
            foreach (User friend in LoggedInUser.Friends)
            {
                if (friend.Location == LoggedInUser.Location)
                {
                    ClosestFriends.Add(friend);
                }
            }
        }

        public List<User> ClosestFriends { get; }
    }
}
