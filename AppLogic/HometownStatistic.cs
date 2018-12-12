using FacebookWrapper.ObjectModel;
using System.Collections.Generic;


namespace FacebookAppLogic
{
    public class HometownStatistic: Statistic
    {
        private readonly string r_Description;
        private Dictionary<City, int> m_MostFriendlyHometowns = new Dictionary<City, int>();

        public HometownStatistic (User i_User) : base(i_User)
        {
            r_Description = "Your 3 Friendliest Cities:";
            FillStatistic();
        }

        public Dictionary<City, int> MostFriendlyHometowns
        {
            get => m_MostFriendlyHometowns;
        }

        public override string Description
        {
            get => r_Description;
        }

        public override void FillStatistic()
        {
            Dictionary<City, int> initialCitiesList = FullFriendsCityList();
            int largest = 0;
            int secondLargest = 0;
            int thirdLargest = 0;
            City largestCity = null;
            City secondLargestCity = null;
            City thirdLargestCity = null;
            if (initialCitiesList != null)
            {
                foreach (KeyValuePair<City, int> entry in initialCitiesList)
                {
                    if (entry.Value > largest)
                    {
                        thirdLargest = secondLargest;
                        thirdLargestCity = secondLargestCity;
                        secondLargest = largest;
                        secondLargestCity = largestCity;
                        largest = entry.Value;
                        largestCity = entry.Key;
                    }
                    else if (entry.Value > secondLargest)
                    {
                        thirdLargest = secondLargest;
                        thirdLargestCity = secondLargestCity;
                        secondLargest = entry.Value;
                        secondLargestCity = entry.Key;
                    }
                    else if (entry.Value > thirdLargest)
                    {
                        thirdLargest = entry.Value;
                        thirdLargestCity = entry.Key;
                    }
                }
                m_MostFriendlyHometowns.Add(largestCity, largest);
                m_MostFriendlyHometowns.Add(secondLargestCity, secondLargest);
                m_MostFriendlyHometowns.Add(thirdLargestCity, thirdLargest);
            }
        }

        private Dictionary<City, int> FullFriendsCityList()
        {
            Dictionary<City, int> result = null; 
            foreach (User friend in LoggedInUser.Friends)
            {
                if (result.ContainsKey(friend.Hometown))
                {
                    result[friend.Hometown]++;
                }
                else
                {
                    result.Add(friend.Hometown, 1);
                }
            }
            return result;
        }
    }
}
