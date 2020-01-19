using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary.Models
{
    public class TeamModel
    {
        public int Id { get; set; }
        /// <summary>
        /// The name of a team.
        /// </summary>
        public string TeamName { get; set; }
        /// <summary>
        /// List of members on a 
        /// specific team.
        /// </summary>
        public List<PersonModel> TeamMembers { get; set; } = new List<PersonModel>();


    }
}
