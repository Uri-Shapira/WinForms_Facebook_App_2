using FacebookWrapper.ObjectModel;
using System.Collections.Generic;


namespace FacebookAppLogic
{
    public class BirthdayStatistic : Statistic
    {
        private readonly string r_Description;
        private List<User> m_SameBirthdayList = new List<User>();

        public BirthdayStatistic(User i_User) : base(i_User)
        {
            r_Description = "Friends With Your Birthday:";
            FillStatistic();
        }

        public override string Description
        {
            get => r_Description;
        }
        
        public List<User> SameBirthdayList
        {
            get => m_SameBirthdayList;
        }

        public override void FillStatistic()
        {
            foreach (User friend in LoggedInUser.Friends)
            {
                if (friend.Birthday == LoggedInUser.Birthday)
                {
                    m_SameBirthdayList.Add(friend);
                }
            }
        }
    }
}
