using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    public class PrizeModel
    {
        /// <summary>
        /// The unique Id for the prize model
        /// </summary>
        public int Id { get; set; }
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

        public PrizeModel()
        {
        }

        /// <summary>
        /// Takes the string representation of a PrizeModel field and
        /// converts it to it's expected type
        /// </summary>
        /// <param name="placeName"></param>
        /// <param name="placeNumber"></param>
        /// <param name="prizeAmount"></param>
        /// <param name="prizePercentage"></param>
        public PrizeModel(string placeName, string placeNumber, string prizeAmount, string prizePercentage)
        {
            PlaceName = placeName;

            int.TryParse(placeNumber, out int placeNumberValue);
            PlaceNumber = placeNumberValue;

            decimal.TryParse(prizeAmount, out decimal prizeAmountValue);
            PrizeAmount = prizeAmountValue;

            double.TryParse(prizePercentage, out double prizePercentageValue);
            PrizePercentage = prizePercentageValue;
        }
    }
}
