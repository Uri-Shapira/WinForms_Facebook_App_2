using System.Collections.Generic;
using FacebookWrapper.ObjectModel;

namespace FacebookAppLogic
{
    public class MostLikedPhotoFilter : IFeature
    {
        private readonly string r_Descripition;
        private readonly User r_LoggedInUser;
        private List<Photo> m_PhotoList = new List<Photo>();
        private Photo m_MostLikedPhoto;

        public Photo MostLikedPhoto
        {
            get => m_MostLikedPhoto;
        }

        public string Description
        {
            get => r_Descripition;
        }

        public MostLikedPhotoFilter(User i_User)
        {
            r_Descripition = "Clicking this feature will show you which of your photos your friends like most, and how many likes it recieved.";
            r_LoggedInUser = i_User;
            ImplementFeature();
        }

        private void aggregateUserPhotos()
        {
            foreach (Album album in r_LoggedInUser.Albums)
            {
                for (int i = 0; i < album.Count; i++)
                {
                    m_PhotoList.Add(album.Photos[i]);
                }
            }
        }

        public void ImplementFeature()
        {
            aggregateUserPhotos();
            if (m_PhotoList.Count != 0)
            {
                Photo mostLiked = m_PhotoList[0];
                foreach (Photo photo in m_PhotoList)
                {
                    if (photo.LikedBy.Count > mostLiked.LikedBy.Count)
                    {
                        mostLiked = photo;
                    }
                }
                m_MostLikedPhoto = mostLiked;
            }
        }
    }
}
