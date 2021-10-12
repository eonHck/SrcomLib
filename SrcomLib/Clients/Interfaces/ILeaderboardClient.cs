namespace SrcomLib.Clients.Interfaces
{
    /// <summary>
    /// Interface for starting building a Leaderboard request
    /// </summary>
    public interface ILeaderboardClient
    {
        /// <summary>
        /// Add the Game Id to the request
        /// </summary>
        /// <param name="gameId"></param>
        /// <returns></returns>
        ILeaderboardClientCategorySelection WithGameId(string gameId);
    }
}