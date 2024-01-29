using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class PrizeModel
    {
        /// <summary>
        /// Represents Place Number of each team
        /// </summary>
        public int PlaceNumber { get; set; }
        /// <summary>
        /// Represents the position of each team
        /// </summary>
        public string PlaceName { get; set; }
        /// <summary>
        /// Represents the Prize Amount 
        /// </summary>
        public decimal PrizeAmount { get; set; }

        /// <summary>
        /// Represents the Percentage of the total prize pool each team receives 
        /// </summary>
        public double PrizePercentage { get; set; }
    }
}
