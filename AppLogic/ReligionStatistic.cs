using FacebookWrapper.ObjectModel;
using System.Collections.Generic;


namespace FacebookAppLogic
{
    public class CommonReligionStatistics : IStatisticsFeature
    {
        private readonly string r_Description;
        private readonly User r_LoggedInUser;
        private Dictionary<string, int> m_ReligionsList = new Dictionary<string, int>();

        public CommonReligionStatistics(User i_User)
        {
            r_Description = "Most Common Religions:";
            r_LoggedInUser = i_User;
            FillStatistic();
        }
        
        public string Description
        {
            get => r_Description;
        }

        public Dictionary<string, int> ReligionsList
        {
            get => m_ReligionsList;
        }

        public void FillStatistic()
        {
            if(m_ReligionsList != null)
            {
                foreach (User friend in r_LoggedInUser.Friends)
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
