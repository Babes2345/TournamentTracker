using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    public class PersonModel
    {
        /// <summary>
        /// Represents First Name of each person on each team
        /// </summary>
        public string FirstName { get; set; }
        /// <summary>
        /// Represents Last Name of each person on each team
        /// </summary>
        public string LastName { get; set; }
        /// <summary>
        /// Represents Email Address of each person on each team
        /// </summary>
        public string EmailAddress { get; set; }
        /// <summary>
        /// Represents Phone Number of each person on each team
        /// </summary>
        public string PhoneNumber { get; set; }
    }
}
