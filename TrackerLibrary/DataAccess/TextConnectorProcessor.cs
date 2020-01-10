using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;

namespace TrackerLibrary.DataAccess.TextConnector
{
    public static class TextConnectorProcessor
    {
        /// <summary>
        /// Gets the full file path, including the file name in question.
        /// </summary>
        /// <param name="fileName">
        /// </param>
        /// <returns>string</returns>
        public static string FullFilePath (this string fileName) // PrizeModel.csv
        {
            // C:\data\TournamentTracker\FILENAME
            return $" { ConfigurationManager.AppSettings["filePath"] }\\{ fileName }";
        }

        /// <summary>
        /// Loads the text file and returns a list of strings.
        /// </summary>
        /// <param name="file"></param>
        /// <returns></returns>
        public static List<string> LoadFile(this string file)
        {
            if (!File.Exists(file))
            {
                return new List<string>();
            }

            return File.ReadAllLines(file).ToList();
        }

        // TODO: Hook up the ConvertToPrizeModel method
        public static List<PrizeModel> ConvertToPrizeModel (this List<string> lines)
        {
            List<PrizeModel> output = new List<PrizeModel>();

            foreach (string line in lines)
            {

            }
        }
    }
}
