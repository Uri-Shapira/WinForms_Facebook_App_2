using FacebookWrapper.ObjectModel;


namespace FacebookAppLogic
{
    public class GenderStatistic : Statistic
    {
        private readonly string r_Description;
        private double m_MaleFriends = 0;
        private double m_MalePercent;
        private double m_FemalePercent;
        private double m_FemaleFriends = 0;

        public GenderStatistic(User i_User) : base(i_User)
        {
            r_Description = "Male/Female Statistics:";
            FillStatistic();
        }

        public override string Description
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

        public override void FillStatistic()
        {       
            foreach (User friend in LoggedInUser.Friends)
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
            m_MalePercent = m_MaleFriends / LoggedInUser.Friends.Count;
            m_FemalePercent = m_FemaleFriends / LoggedInUser.Friends.Count;
        }
    }
}
