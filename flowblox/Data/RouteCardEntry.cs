namespace flowblox.Data
{
    using System;
    using System.Xml.Serialization;

    /// <summary>
    /// This class encapsulates entries for the data route card.
    /// </summary>
    public class RouteCardEntry
    {
        /// <summary>
        /// The time stamp, when the data arrived at the port.
        /// </summary>
        [XmlAttribute]
        public DateTime TimeStamp { get; set;}

        /// <summary>
        /// The processing port's GuID.
        /// </summary>
        [XmlAttribute]
        public Guid ProcessingPort { get; set; }

        /// <summary>
        /// Creates a new instance of <see cref="RouteCardEntry"/>.
        /// </summary>
        /// <param name="timeStamp">The time stamp, when the data arrived at the port.</param>
        /// <param name="processingPort">The processing port's GuID.</param>
        public RouteCardEntry(DateTime timeStamp, Guid processingPort)
        {
            this.TimeStamp = timeStamp;
            this.ProcessingPort = processingPort;
        }

        /// <summary>
        /// Creates a new instance of <see cref="RouteCardEntry"/>.
        /// </summary>
        public RouteCardEntry()
        {
        }
    }
}
