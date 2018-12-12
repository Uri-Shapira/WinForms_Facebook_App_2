using FacebookWrapper.ObjectModel;
using System.Collections.Generic;


namespace FacebookAppLogic
{
    public class BirthdayStatistic : IStatistic
    {
        private readonly string r_Description;
        private readonly User r_LoggedInUser;
        private List<User> m_SameBirthdayList = new List<User>();

        public BirthdayStatistic(User i_User)
        {
            r_Description = "Friends With Your Birthday:";
            r_LoggedInUser = i_User;
            FillStatistic();
        }

        public string Description
        {
            get => r_Description;
        }
        
        public List<User> SameBirthdayList
        {
            get => m_SameBirthdayList;
        }

        public void FillStatistic()
        {
            foreach (User friend in r_LoggedInUser.Friends)
            {
                if (friend.Birthday == r_LoggedInUser.Birthday)
                {
                    m_SameBirthdayList.Add(friend);
                }
            }
        }
    }
}
