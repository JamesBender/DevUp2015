using System;
using System.Collections.Generic;

namespace GameNetworkInterfaces
{
    interface ICommonGameNetworkControl
    {
        Guid Login(string username, string password);
        bool Logout(Guid sessionToken);
        bool PostScoreToLeaderboard(Guid sessionToken, Guid gameToken, int score);
        IEnumerable<LeaderBoardEntry> GetLeaderBoard(Guid sessionToken, Guid gameToken);
        IEnumerable<Player> GetFriends(Guid sessionToken);
        bool AddFriends(Guid sessionToken, Guid playerId);
        Guid InviteFriendToMatch(Guid sessionToken, Guid invitedPlayerId, Guid gameToken);
        Guid InviteFriendToMatch(Guid sessionToken, Guid invitedPlayerId, Guid gameToken, Guid matchToken);
        Guid StartMatch(Guid sessionToken, Guid matchToken);
    }
}
