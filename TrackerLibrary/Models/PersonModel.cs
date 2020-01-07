using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary.Models
{
    public class PersonModel
    {
        /// <summary>
        /// The first name of a
        /// team member.
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// The last name of a 
        /// team member.
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Email address of a
        /// team member.
        /// </summary>
        public string EmailAdress { get; set; }

        /// <summary>
        /// Cell number of a
        /// team member.
        /// </summary>
        public string CellPhoneNumber { get; set; }

        /// <summary>
        /// Age of a team member.
        /// Note: Might not be utilizeds
        /// </summary>
        public int Age { get; set; }
    }
}
