using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary.Models
{
    public class MatchupEntryModel
    {
        /// <summary>
        /// Represents a specific team that is competing.
        /// </summary>
        public TeamModel TeamCompeting { get; set; }

        /// <summary>
        /// The score of a specific match entry.
        /// </summary>
        public double Score { get; set; }

        /// <summary>
        /// The matchup that the team previously came from.
        /// </summary>
        public MatchupModel ParentMatchup { get; set; }
    }
}
