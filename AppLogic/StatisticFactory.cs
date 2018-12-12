using FacebookWrapper.ObjectModel;

namespace FacebookAppLogic
{
    class StatisticFactory
    {
        private User m_user;
        public StatisticFactory(User i_user)
        {
            m_user = i_user;
        }
        public Statistic CreateStatistic(string type)
        {
            Statistic statistic = null;
            switch (type)
            {
                case "Birthday":
                    statistic = new BirthdayStatistic(m_user);
                    break;
                case "Religion":
                    statistic = new ReligionStatistic(m_user);
                    break;
                case "Gender":
                    statistic = new GenderStatistic(m_user);
                    break;
                case "Hometown":
                    statistic = new HometownStatistic(m_user);
                    break;
            }
            return statistic;
        }
    }
}
