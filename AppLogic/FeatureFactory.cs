using FacebookWrapper.ObjectModel;

namespace FacebookAppLogic
{
    class FeatureFactory
    {
        private User m_user;
        public FeatureFactory(User i_user)
        {
            m_user = i_user;
        }

        public Feature CreateFeature(string type)
        {
            Feature feature = null;
            switch (type)
            {
                case "FriendsList":
                    feature = new FriendsListFeature(m_user);
                    break;
                case "ClosestEvents":
                    feature = new ClosestEventsFeature(m_user);
                    break;
                case "ClosestFriends":
                    feature = new ClosestFriendsFeature(m_user);
                    break;
                case "MostLikedPhoto":
                    feature = new MostLikedPhotoFeature(m_user);
                    break;
            }
            return feature;
        }
    }
}
