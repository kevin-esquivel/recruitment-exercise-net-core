using System;
using System.Collections.Generic;
using System.Linq;

namespace Oceans.Exercise
{
    public class User
    {
        /// <summary>
        /// The name of the user
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The user's chosen payment type
        /// </summary>
        public PaymentType PaymentType { get; set; }

        /// <summary>
        /// The user's subscriptions
        /// </summary>
        internal IEnumerable<Subscription> Subscriptions { get; }

        /// <summary>
        /// Creates a new instance of the <see cref="User" /> class.
        /// </summary>
        /// <param name="subscriptions">The subscriptions the user has.</param>
        public User(IEnumerable<Subscription> subscriptions)
        {
            this.Subscriptions = subscriptions;
        }

        /// <summary>
        /// The number of expired subscriptions the user has
        /// </summary>
        public int ExpiredSubscriptions
        {
            get
            {
                //Use LINQ to get the right number
                //return Subscriptions.Select(_ => 0).FirstOrDefault();

                List<Subscription> expiredSubscriptions = new List<Subscription>();
                foreach (var subscription in Subscriptions)
                {
                    DateTime subscriptionDate = new DateTime(subscription.ExpirationDay, subscription.ExpirationMonth, subscription.ExpirationYear);

                    if (DateTime.Now > subscriptionDate)
                    {
                        expiredSubscriptions.Add(subscription);
                    }
                }

                return expiredSubscriptions.Count;
            }
        }

        /// <summary>
        /// Rewrite this method to return a tuple of Name, PaymentType and the local variable 'codeExperts'
        /// </summary>
        public UserInfo UserInformation()
        {
            UserInfo info = new UserInfo();
            info.Name = Name;
            info.PaymentType = PaymentType;
            info.CodeExperts = true;

            return info;
        }

        /// <summary>
        /// Update the local variables by de-constructing the tuple from UserInformation
        /// Follow the suggested logic to update the User Name
        /// </summary>
        public void UpdateUserInformation()
        {
            string nameFromTuple = string.Empty;
            bool codeExpertsFromTuple = false;

            //de-construct the tuple
            UserInformation();

            if (codeExpertsFromTuple)
            {
                Name = $"Recruiting {nameFromTuple}";
            }
        }
    }
}