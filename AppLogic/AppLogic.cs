using FacebookWrapper.ObjectModel;

namespace FacebookAppLogic
{
    public class AppLogic
    {
        private readonly User r_LoggedInUser;
        private FeatureFactory m_FeatureFactory;
        private FriendsListFeature m_FriendsListFeature;
        private ClosestEventsFeature m_ClosestEventsFeature;
        private MostLikedPhotoFeature m_MostLikedPhotoFeature;
        private ClosestFriendsFeature m_ClosestFriendsFeature;
        private HometownStatistics m_HometownStatistics;
        private GenderStatistics m_GenderStatistics;
        private BirthdayStatistic m_BirthdayStatistics;
        private CommonReligionStatistics m_CommonReligionStatistics;


        public AppLogic(User i_LoggedInUser)
        {
            r_LoggedInUser = i_LoggedInUser;
            m_FeatureFactory = new FeatureFactory(r_LoggedInUser);
            initiateFeatures();
        }

        private void initiateFeatures()
        {
            m_MostLikedPhotoFeature = (MostLikedPhotoFeature)m_FeatureFactory.CreateFeature("MostLikedPhoto");
            m_FriendsListFeature = (FriendsListFeature)m_FeatureFactory.CreateFeature("FriendsList");
            m_ClosestFriendsFeature = (ClosestFriendsFeature)m_FeatureFactory.CreateFeature("ClosestFriends");
            m_ClosestEventsFeature = (ClosestEventsFeature)m_FeatureFactory.CreateFeature("ClosestEvents");
            m_HometownStatistics = new HometownStatistics(r_LoggedInUser);
            m_GenderStatistics = new GenderStatistics(r_LoggedInUser);
            m_BirthdayStatistics = new BirthdayStatistic(r_LoggedInUser);
            m_CommonReligionStatistics = new CommonReligionStatistics(r_LoggedInUser);
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

        public HometownStatistics HometownStatistics
        {
            get => m_HometownStatistics;
        }

        public GenderStatistics GenderStatistics
        {
            get => m_GenderStatistics;
        }

        public BirthdayStatistic BirthdayStatistics
        {
            get => m_BirthdayStatistics;
        }

        public CommonReligionStatistics CommonReligionStatistics
        {
            get => m_CommonReligionStatistics;
        }
    }
}
