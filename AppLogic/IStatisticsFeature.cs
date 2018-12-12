namespace FacebookAppLogic
{
    interface IStatisticsFeature
    {
        string Description { get; }

        void FillStatistic();
    }
}
