using FacebookWrapper.ObjectModel;

namespace FacebookAppLogic
{
    public class AppLogic
    {
        private readonly User r_LoggedInUser;
        private FeatureFactory m_FeatureFactory;
        private StatisticFactory m_StatisticFactory;
        private FriendsListFeature m_FriendsListFeature;
        private ClosestEventsFeature m_ClosestEventsFeature;
        private MostLikedPhotoFeature m_MostLikedPhotoFeature;
        private ClosestFriendsFeature m_ClosestFriendsFeature;
        private HometownStatistic m_HometownStatistic;
        private GenderStatistic m_GenderStatistic;
        private BirthdayStatistic m_BirthdayStatistic;
        private ReligionStatistic m_ReligionStatistic;


        public AppLogic(User i_LoggedInUser)
        {
            r_LoggedInUser = i_LoggedInUser;
            m_FeatureFactory = new FeatureFactory(r_LoggedInUser);
            m_StatisticFactory = new StatisticFactory(r_LoggedInUser);
            initiateFeatures();
        }

        private void initiateFeatures()
        {
            m_MostLikedPhotoFeature = (MostLikedPhotoFeature)m_FeatureFactory.CreateFeature("MostLikedPhoto");
            m_FriendsListFeature = (FriendsListFeature)m_FeatureFactory.CreateFeature("FriendsList");
            m_ClosestFriendsFeature = (ClosestFriendsFeature)m_FeatureFactory.CreateFeature("ClosestFriends");
            m_ClosestEventsFeature = (ClosestEventsFeature)m_FeatureFactory.CreateFeature("ClosestEvents");
            m_HometownStatistic = (HometownStatistic)m_StatisticFactory.CreateStatistic("Hometown");
            m_GenderStatistic = (GenderStatistic)m_StatisticFactory.CreateStatistic("Gender");
            m_BirthdayStatistic = (BirthdayStatistic)m_StatisticFactory.CreateStatistic("Birthday");
            m_ReligionStatistic = (ReligionStatistic)m_StatisticFactory.CreateStatistic("Religion");
        }

        public MostLikedPhotoFeature MostLikedPhotoFeature
        {
            get => m_MostLikedPhotoFeature;
        }

        public ClosestFriendsFeature ClosestFriendsFilter
        {
            get => m_ClosestFriendsFeature;
        }

        public ClosestEventsFeature ClosestEventsFilter
        {
            get => m_ClosestEventsFeature;
        }

        public FriendsListFeature FriendsListFilter
        {
            get => m_FriendsListFeature;
        }

        public HometownStatistic HometownStatistic
        {
            get => m_HometownStatistic;
        }

        public GenderStatistic GenderStatistic
        {
            get => m_GenderStatistic;
        }

        public BirthdayStatistic BirthdayStatistic
        {
            get => m_BirthdayStatistic;
        }

        public ReligionStatistic CommonReligionStatistic
        {
            get => m_ReligionStatistic;
        }
    }
}
