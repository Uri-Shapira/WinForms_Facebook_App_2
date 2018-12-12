using FacebookWrapper.ObjectModel;

namespace FacebookAppLogic
{
    public abstract class Feature : IFeature
    {
        public User LoggedInUser { get; }

        public Feature(User i_user)
        {
            LoggedInUser = i_user;
        }

        public abstract string Description{ get; }

        public abstract void ImplementFeature();
    }
}
