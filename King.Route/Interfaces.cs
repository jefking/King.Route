namespace King.Route
{
    #region IRouteTo
    /// <summary>
    /// Route To Interface
    /// </summary>
    public interface IRouteTo
    {
        #region Methods
        /// <summary>
        /// Send
        /// </summary>
        /// <param name="route">Route</param>
        /// <param name="models">Model</param>
        void Send(string route, params object[] models);

        /// <summary>
        /// Get Data
        /// </summary>
        /// <typeparam name="T">Type</typeparam>
        /// <param name="route">Route</param>
        /// <param name="models">Model</param>
        /// <returns>Data</returns>
        T Get<T>(string route, params object[] models);
        #endregion
    }
    #endregion
}