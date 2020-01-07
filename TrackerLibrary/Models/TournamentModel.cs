using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary.Models
{
    public class TournamentModel
    {
        /// <summary>
        /// Name of the tournament.
        /// </summary>
        public string TournamentName { get; set; }

        /// <summary>
        /// Entry fee per team in dollars/cents.
        /// </summary>
        public decimal EntryFee { get; set; }

        /// <summary>
        /// A list of the entered teams in a
        /// specific tournament.
        /// </summary>
        public List<TeamModel> EnteredTeams { get; set; } = new List<TeamModel>();

        /// <summary>
        /// List of prizes in a specific 
        /// tournament.
        /// </summary>
        public List<PrizeModel> Prizes { get; set; } = new List<PrizeModel>();

        /// <summary>
        /// The list of rounds in a specific
        /// tournament.
        /// </summary>
        public List<List<MatchupModel>> Rounds { get; set; } = new List<List<MatchupModel>>();
    }
}
