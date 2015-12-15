using System.ComponentModel.DataAnnotations;

namespace UnattendedTest.Models
{
    /// <summary>
    /// Class which models a user
    /// </summary>
    public class User
    {
        /// <summary>
        /// Gets or sets the first name
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or sets the last name
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Gets the full name
        /// </summary>
        [Display(Name = "Customer name:")]
        public string FullName
        {
            get
            {
                return string.Format("{0} {1}", this.FirstName, this.LastName);
            }
        }

        /// <summary>
        /// Gets or sets the email address
        /// </summary>
        [Display(Name = "Customer e-mail:")]
        public string EMail { get; set; }

        /// <summary>
        /// Gets or sets the location
        /// </summary>
        [Display(Name = "Customer location:")]
        public string Location { get; set; }

        /// <summary>
        /// Gets or sets the currency code
        /// </summary>
        public string Currency { get; set; }

        /// <summary>
        /// Gets or sets the address
        /// </summary>
        public Address Address { get; set; }

    }
}