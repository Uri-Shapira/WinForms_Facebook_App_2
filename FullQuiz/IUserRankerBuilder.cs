using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FullQuiz
{
    public interface IUserRankerBuilder
    {
        UserRanker BuildUserRanker();

        void InitializeUserRanker(UserRanker i_UserRanker);
    }
}
