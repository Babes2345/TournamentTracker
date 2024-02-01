using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    public class TounamentModel
    {
        /// <summary>
        /// Represents Tournament Name
        /// </summary>
        public string TournamentName { get; set; }
        /// <summary>
        /// Represents Entry Fee for each team
        /// </summary>
        public decimal EntryFees { get; set; }
        /// <summary>
        /// Shows a list of teams that entered the tournament
        /// </summary>
        public List<TeamModel> EnteredTeams { get; set; } = new List<TeamModel>();
        /// <summary>
        /// List of Prizes 
        /// </summary>
        public List<PrizeModel> Prizes { get; set; } = new List<PrizeModel>();
        /// <summary>
        /// Shows number of rounds
        /// </summary>
        public List<List<MatchupModel>> Rounds { get; set; } = new List<List<MatchupModel>>();
    }
}
