using System.Collections.Generic;
using FacebookWrapper.ObjectModel;


namespace FacebookAppLogic
{
    public class ClosestFriendsFilter : IFeature
    {
        private readonly User r_LoggedInUser;

        public ClosestFriendsFilter (User i_LoggedInUser)
        {
            Description = "Clicking this feature will show you the friends that are at the same location as you at any given time.";
            r_LoggedInUser = i_LoggedInUser;
            ImplementFeature();
        }

        public string Description { get; }

        public void ImplementFeature()
        {
            foreach (User friend in r_LoggedInUser.Friends)
            {
                if (friend.Location == r_LoggedInUser.Location)
                {
                    ClosestFriends.Add(friend);
                }
            }
        }

        public List<User> ClosestFriends { get; }
    }
}
