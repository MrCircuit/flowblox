namespace flowblox.Gates
{
    using flowblox.Data;
    using System;

    /// <summary>
    /// An interface for gates.
    /// </summary>
    public interface IGate
    {
        /// <summary>
        /// Clears the inbound queue.
        /// </summary>
        void ClearInboundQueue();
    }

    public interface IGate<T> : IGate
        where T : class
    {
        /// <summary>
        /// Gets the next inbound container.
        /// </summary>
        /// <returns>The next container in the inbound queue.</returns>
        Container<T> GetNextInboundContainer();

        /// <summary>
        /// Sends a new container.
        /// </summary>
        /// <param name="container">The container to send.</param>
        void SendContainer(Container<T> container);

        /// <summary>
        /// Gets or sets the action for inbound container reception.
        /// </summary>
        Action<Container<T>> AddInboundContainer { get; set; }
    }
}
