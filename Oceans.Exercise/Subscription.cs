namespace Oceans.Exercise
{
    public class Subscription
    {
        /// <summary>
        /// The name of the subscribed service
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The month the subscription expires
        /// </summary>
        internal int ExpirationMonth { get; }

        /// <summary>
        /// The year the subscription expires
        /// </summary>
        internal int ExpirationYear { get; }

        /// <summary>
        /// The day the subscription expires
        /// </summary>
        internal int ExpirationDay { get; }

        /// <summary>
        /// Creates a new instance of the <see cref="Subscription" /> class.
        /// </summary>
        /// <param name="expirationMonth"></param>
        /// <param name="expirationDay"></param>
        /// <param name="expirationYear"></param>
        public Subscription(int expirationMonth, int expirationYear, int expirationDay = 1)
        {
            this.ExpirationDay = expirationDay;
            this.ExpirationMonth = expirationMonth;
            this.ExpirationYear = expirationYear;
        }
    }
}