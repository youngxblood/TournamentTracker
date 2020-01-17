using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary.Models
{
    public class PersonModel
    {

        public int Id { get; set; }
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
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Age of a team member.
        /// Note: Might not be utilized
        /// </summary>
        /*public int Age { get; set; }*/

        // Default contructor
        public PersonModel()
        {

        }

        public PersonModel(string firstName, string lastName, string phoneNumber, string emailAddress)
        {
            FirstName = firstName;
            LastName = lastName;

            // Parses the received data for "placeNumber" and sets the property accordingly.
            int phoneNumberValue = 0;

            if (int.TryParse(phoneNumber, out phoneNumberValue))
            {
                PhoneNumber = phoneNumber;
            }

            EmailAdress = emailAddress;
        }
    }

}

