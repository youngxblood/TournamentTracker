using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary.Models
{
    public class MatchupModel
    {
        /// <summary>
        /// List of matches within a specific round.
        /// </summary>
        public List<MatchupEntryModel> Entries { get; set; } = new List<MatchupEntryModel>();

        /// <summary>
        /// The team who won the match.
        /// </summary>
        public TeamModel Winner { get; set; }

        /// <summary>
        /// The round number.
        /// </summary>
        public int MatchupRound { get; set; }
    }
}
