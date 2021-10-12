namespace SrcomLib.Clients.Interfaces
{
    /// <summary>
    /// Interface for specifying the Level and/or Category for the Leaderboard request
    /// </summary>
    public interface ILeaderboardClientCategorySelection
    {
        /// <summary>
        /// Add the levelId to the request
        /// </summary>
        /// <param name="levelId"></param>
        /// <returns></returns>
        ILeaderboardClientCategorySelection WithLevelId(string levelId);

        /// <summary>
        /// Add the categoryId to the request
        /// </summary>
        /// <param name="gameId"></param>
        /// <returns></returns>
        ILeaderboardClientExecutor WithCategoryId(string gameId);
    }
}