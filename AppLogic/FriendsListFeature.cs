using FacebookWrapper.ObjectModel;
using System.Collections.Generic;


namespace FacebookAppLogic
{
    public class FriendsListFeature : Feature
    {
        private readonly string r_Description;
        private List<User> m_FriendsList = new List<User>();

        public FriendsListFeature(User i_User) : base(i_User)
        {
            r_Description = "Clicking this feature will show you your entire list of friends.";
            ImplementFeature();
        }

        public override string Description
        {
            get => r_Description;
        }

        public List<User> FriendsList
        {
            get => m_FriendsList;
        }

        public override void ImplementFeature()
        {
            foreach (User friend in LoggedInUser.Friends)
            {
                m_FriendsList.Add(friend);
            }
        }
    }
}
