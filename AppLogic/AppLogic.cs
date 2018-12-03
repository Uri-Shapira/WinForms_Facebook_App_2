using FacebookWrapper.ObjectModel;

namespace FacebookAppLogic
{
    public class AppLogic
    {
        private readonly User r_LoggedInUser;
        private FriendsListFilter m_FriendsListFilter;
        private ClosestEventsFilter m_ClosestEventsFilter;
        private MostLikedPhotoFilter m_MostLikedPhotoFilter;
        private ClosestFriendsFilter m_ClosestFriendsFilter;
        private HometownStatistics m_HometownStatistics;
        private GenderStatistics m_GenderStatistics;
        private BirthdayStatistics m_BirthdayStatistics;
        private CommonReligionStatistics m_CommonReligionStatistics;


        public AppLogic(User i_LoggedInUser)
        {
            r_LoggedInUser = i_LoggedInUser;
            initiateFeatures();
        }

        private void initiateFeatures()
        {
            m_MostLikedPhotoFilter = new MostLikedPhotoFilter(r_LoggedInUser);
            m_ClosestFriendsFilter = new ClosestFriendsFilter(r_LoggedInUser);
            m_ClosestEventsFilter = new ClosestEventsFilter(r_LoggedInUser);
            m_FriendsListFilter = new FriendsListFilter(r_LoggedInUser);
            m_HometownStatistics = new HometownStatistics(r_LoggedInUser);
            m_GenderStatistics = new GenderStatistics(r_LoggedInUser);
            m_BirthdayStatistics = new BirthdayStatistics(r_LoggedInUser);
            m_CommonReligionStatistics = new CommonReligionStatistics(r_LoggedInUser);
        }

        public MostLikedPhotoFilter MostLikedPhotoFilter
        {
            get => m_MostLikedPhotoFilter;
        }

        public ClosestFriendsFilter ClosestFriendsFilter
        {
            get => m_ClosestFriendsFilter;
        }

        public ClosestEventsFilter ClosestEventsFilter
        {
            get => m_ClosestEventsFilter;
        }

        public FriendsListFilter FriendsListFilter
        {
            get => m_FriendsListFilter;
        }

        public HometownStatistics HometownStatistics
        {
            get => m_HometownStatistics;
        }

        public GenderStatistics GenderStatistics
        {
            get => m_GenderStatistics;
        }

        public BirthdayStatistics BirthdayStatistics
        {
            get => m_BirthdayStatistics;
        }

        public CommonReligionStatistics CommonReligionStatistics
        {
            get => m_CommonReligionStatistics;
        }
    }
}
