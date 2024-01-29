using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class MatchupEntryModel
    {
        /// <summary>
        /// Represents which team is competing against each other
        /// </summary>
        public TeamModel TeamCompeting { get; set; }
        /// <summary>
        /// Represents the score of each team
        /// </summary>
        public double Score { get; set; }
        /// <summary>
        /// Shows the previous matchup that the winner came from
        /// </summary>
        public MatchupModel ParentMatchup { get; set; }
    }
}
