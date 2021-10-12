namespace SrcomLib.Clients.Interfaces
{
    /// <summary>
    /// Interface for starting building a Variable request
    /// </summary>
    public interface IVariablesClient
    {
        /// <summary>
        /// Add the Variable Id to the request
        /// </summary>
        /// <param name="gameId"></param>
        /// <returns></returns>
        IVariablesClientExecutor WithId(string id);
    }
}