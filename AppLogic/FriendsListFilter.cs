using FacebookWrapper.ObjectModel;
using System.Collections.Generic;


namespace FacebookAppLogic
{
    public class FriendsListFilter : IFeature
    {
        private readonly User r_LoggedInUser;
        private readonly string r_Description;
        private List<User> m_FriendsList = new List<User>();

        public FriendsListFilter(User i_User)
        {
            r_LoggedInUser = i_User;
            r_Description = "Clicking this feature will show you your entire list of friends.";
            ImplementFeature();
        }

        public string Description
        {
            get => r_Description;
        }

        public List<User> FriendsList
        {
            get => m_FriendsList;
        }

        public void ImplementFeature()
        {
            foreach (User friend in r_LoggedInUser.Friends)
            {
                m_FriendsList.Add(friend);
            }
        }
    }
}
