namespace SrcomLib.Clients.Interfaces
{
    /// <summary>
    /// Interface for starting building a Guest request
    /// </summary>
    public interface IGuestsClient
    {
        /// <summary>
        /// Add the Guest Name to the request
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        IGuestsClientExecutor WithName(string name);
    }
}