using System.Collections.Generic;
using FacebookWrapper.ObjectModel;

namespace FacebookAppLogic
{
    public class MostLikedPhotoFeature : Feature
    {
        private readonly string r_Descripition;
        private List<Photo> m_PhotoList = new List<Photo>();
        private Photo m_MostLikedPhoto;

        public Photo MostLikedPhoto
        {
            get => m_MostLikedPhoto;
        }

        public override string Description
        {
            get => r_Descripition;
        }

        public MostLikedPhotoFeature(User i_User) : base(i_User)
        {
            r_Descripition = "Clicking this feature will show you which of your photos your friends like most, and how many likes it recieved.";
            ImplementFeature();
        }

        private void aggregateUserPhotos()
        {
            foreach (Album album in LoggedInUser.Albums)
            {
                for (int i = 0; i < album.Count; i++)
                {
                    m_PhotoList.Add(album.Photos[i]);
                }
            }
        }

        public override void ImplementFeature()
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
