namespace flowblox.Data
{
    using System.Collections.ObjectModel;
    using System.ComponentModel;

    /// <summary>
    /// A container base class.
    /// </summary>
    public abstract class Container : INotifyPropertyChanged
    {
        #region INotifyPropertyChanged Implementation
        /// <summary>
        /// Raised when a property changed.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Raises the <see cref="E:INotifyPropertyChanged.PropertyChanged"/> event.
        /// </summary>
        /// <param name="propertyName">The name of the property.</param>
        protected void RaisePropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion

        private ObservableCollection<RouteCardEntry> routeCard = null;
        /// <summary>
        /// Gets all entries on the route card.
        /// </summary>
        public ObservableCollection<RouteCardEntry> RouteCard
        {
            get
            {
                if (routeCard == null)
                    routeCard = new ObservableCollection<RouteCardEntry>();
                return routeCard;
            }
        }

        /// <summary>
        /// Hands over an existing route card to this instance.
        /// </summary>
        /// <param name="routeCard">The existing route card.</param>
        public virtual void HandoverRouteCard(ObservableCollection<RouteCardEntry> routeCard)
        {
            this.routeCard = routeCard;
        }
    }

    /// <summary>
    /// A typed base class for containers.
    /// </summary>
    /// <typeparam name="T">The payload class type.</typeparam>
    public class Container<T> : Container
        where T : class
    {
        private T payload = null;
        /// <summary>
        /// Gets or sets the payload.
        /// </summary>
        public T Payload
        {
            get { return payload; }
            set
            {
                if (payload != value)
                {
                    payload = value;
                    RaisePropertyChanged("Payload");
                }
            }
        }
    }
}
