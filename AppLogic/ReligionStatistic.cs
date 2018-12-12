using FacebookWrapper.ObjectModel;
using System.Collections.Generic;


namespace FacebookAppLogic
{
    public class ReligionStatistic : Statistic
    {
        private readonly string r_Description;
        private Dictionary<string, int> m_ReligionsList = new Dictionary<string, int>();

        public ReligionStatistic(User i_User) : base(i_User)
        {
            r_Description = "Most Common Religions:";
            FillStatistic();
        }
        
        public override string Description
        {
            get => r_Description;
        }

        public Dictionary<string, int> ReligionsList
        {
            get => m_ReligionsList;
        }

        public override void FillStatistic()
        {
            if(m_ReligionsList != null)
            {
                foreach (User friend in LoggedInUser.Friends)
                {
                    if (m_ReligionsList.ContainsKey(friend.Religion))
                    {
                        m_ReligionsList[friend.Religion]++;
                    }
                    else
                    {
                        m_ReligionsList.Add(friend.Religion, 1);
                    }
                }
            }   
        }
    }
}
