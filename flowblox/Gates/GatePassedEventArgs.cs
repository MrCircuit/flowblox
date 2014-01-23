namespace flowblox.Gates
{
    using flowblox.Data;
    using System;

    /// <summary>
    /// This class is used for gate-pass notifications
    /// </summary>
    /// <typeparam name="T">The type of the payload.</typeparam>
    public class GatePassedEventArgs<T> : EventArgs
        where T : class
    {
        /// <summary>
        /// The container that passed the gate.
        /// </summary>
        public Container<T> Container { get; private set; }

        /// <summary>
        /// Creates a new instance of <see cref="GatePassedEventArgs"/>.
        /// </summary>
        /// <param name="container">The container that passed gate.</param>
        public GatePassedEventArgs(Container<T> container)
        {
            this.Container = container;
        }
    }
}
