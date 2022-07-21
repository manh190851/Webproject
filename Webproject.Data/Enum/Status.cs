using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webproject.Data.Enum
{
    public enum PostStatus
    {
        Public,
        Friend,
        Private
    }

    public enum UserStatus
    {
        Availablility,
        Locked
    }

    public enum FriendStatus
    {
        Friend,
        Unfriend,
        Block
    }

    public enum FollowStatus
    {
        Following,
        UnFollowing
    }
}
