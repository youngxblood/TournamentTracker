using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using TrackerLibrary.Models;

namespace TrackerLibrary.DataAccess
{
    public class SqlConnector : IDataConnection
    {
        // TODO - Make the "CreatePrize" method actually save to the database.
        /// <summary>
        /// Saves a new prize.
        /// </summary>
        /// <param name="model">The prize information</param>
        /// <returns>The prize info, including the unique identifier.</returns>
        public PrizeModel CreatePrize(PrizeModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("Tournaments")));
            {

            }
        }
    }
}
