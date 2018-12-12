using FacebookWrapper.ObjectModel;

namespace FacebookAppLogic
{
    public abstract class Statistic : IStatistic
    {
        public User LoggedInUser { get; }

        public Statistic(User i_user)
        {
            LoggedInUser = i_user;
        }

        public abstract string Description { get; }

        public abstract void FillStatistic();
    }
}
