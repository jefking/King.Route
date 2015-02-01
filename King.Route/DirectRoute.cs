namespace King.Route
{
    using System;
    using System.Reflection;

    /// <summary>
    /// Direct Route, no queue (default)
    /// </summary>
    public class DirectRoute : IRouteTo
    {
        #region Members
        /// <summary>
        /// Method Binding Flags
        /// </summary>
        protected static readonly BindingFlags methodFlags = BindingFlags.Public | BindingFlags.Instance | BindingFlags.InvokeMethod | BindingFlags.DeclaredOnly;
        #endregion

        #region Methods
        /// <summary>
        /// Send
        /// </summary>
        /// <param name="route">Route</param>
        /// <param name="models">Model</param>
        public virtual void Send(string route, params object[] models)
        {
            this.Invoke(route, models);
        }

        /// <summary>
        /// Get Data
        /// </summary>
        /// <typeparam name="T">Type</typeparam>
        /// <param name="route">Route</param>
        /// <param name="models">Model</param>
        /// <returns>Data</returns>
        public virtual T Get<T>(string route, params object[] models)
        {
            return (T)this.Invoke(route, models);
        }

        /// <summary>
        /// Invoke Route
        /// </summary>
        /// <param name="route">Route</param>
        /// <param name="models">Model</param>
        /// <returns>Return Value</returns>
        public virtual object Invoke(string route, params object[] models)
        {
            if (string.IsNullOrEmpty(route))
            {
                throw new InvalidOperationException("Route is empty, ensure caller is specifying a route.");
            }
            if (!RouteTable.Routes.ContainsKey(route))
            {
                throw new InvalidOperationException(string.Format("Unknown route; route not mapped in RouteTable: '{0}'.", route));
            }
            
            var entry = RouteTable.Routes[route];
            var obj = Activator.CreateInstance(entry.Type);
            return entry.Type.InvokeMember(entry.Method, methodFlags, null, obj, models);
        }
        #endregion
    }
}