using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary.Models
{
    public class PrizeModel
    {
        /// <summary>
        /// The unique identifier of the prize.
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// The number of what place the prize
        /// is set for.
        /// </summary>
        public int PlaceNumber { get; set; }

        /// <summary>
        /// The name of the place (eg. "First Place").
        /// </summary>
        public string PlaceName { get; set; }

        /// <summary>
        /// Prize amount in dollars/cents. Note: Cannot 
        /// use both 'PrizeAmount' and 'PrizePercentage'.
        /// </summary>
        public decimal PrizeAmount { get; set; }
 
        /// <summary>
        /// Prize amount as a percentage of the whole
        /// amount. Note: Cannot use both 'PrizeAmount'
        /// and 'PrizePercentage'.
        /// </summary>
        public double PrizePercentage { get; set; }

        public PrizeModel()
        {
            // Default constructor for PrizeModel
        }

        /// <summary>
        /// Constructor that turns all of the prize model input strings into their appropriate values.
        /// </summary>
        /// <param name="placeName"></param>
        /// <param name="placeNumber"></param>
        /// <param name="prizeAmount"></param>
        /// <param name="prizePercentage"></param>
        public PrizeModel(string placeName, string placeNumber, string prizeAmount, string prizePercentage)
        {
            PlaceName = placeName;

            // Parses the received data for "placeNumber" and sets the property accordingly.
            int placeNumberValue = 0;
            int.TryParse(placeNumber, out placeNumberValue);
            PlaceNumber = placeNumberValue;

            decimal prizeAmountValue = 0;
            decimal.TryParse(prizeAmount, out prizeAmountValue);
            PrizeAmount = prizeAmountValue;

            double prizePercentageValue = 0;
            double.TryParse(prizePercentage, out prizePercentageValue);
            PrizePercentage = prizePercentageValue;
        }
    }
}
