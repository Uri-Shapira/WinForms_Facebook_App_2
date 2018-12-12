using FacebookWrapper.ObjectModel;


namespace FacebookAppLogic
{
    public class GenderStatistics : IStatistic
    {
        private readonly string r_Description;
        private readonly User r_LoggedInUser;
        private double m_MaleFriends = 0;
        private double m_MalePercent;
        private double m_FemalePercent;
        private double m_FemaleFriends = 0;

        public GenderStatistics(User i_User)
        {
            r_LoggedInUser = i_User;
            r_Description = "Male/Female Statistics:";
            FillStatistic();
        }

        public string Description
        {
            get => r_Description;
        }

        public double MaleFriends
        {
            get => m_MaleFriends;
        }

        public double FemaleFriends
        {
            get => m_FemaleFriends;
        }

        public double MalePercent
        {
            get => m_MalePercent;
        }

        public double FemalePercent
        {
            get => m_FemalePercent;
        }

        public void FillStatistic()
        {       
            foreach (User friend in r_LoggedInUser.Friends)
            {
                if (friend.Gender == User.eGender.male)
                {
                    m_MaleFriends++;
                }
                else
                {
                    m_FemaleFriends++;
                }
            }
            m_MalePercent = m_MaleFriends / r_LoggedInUser.Friends.Count;
            m_FemalePercent = m_FemaleFriends / r_LoggedInUser.Friends.Count;
        }
    }
}
