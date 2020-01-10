using Dapper;
using System.Data;
using TrackerLibrary.Models;

/*	@PlaceNumber int,
	@PlaceName nvarchar(50),
	@PrizeAmount money,
    @PrizePercentage float,
	@id int = 0 output*/

namespace TrackerLibrary.DataAccess
{
    public class SqlConnector : IDataConnection
    {


        /// <summary>
        /// Saves a new prize.
        /// </summary>
        /// <param name="model">The prize information</param>
        /// <returns>The prize info, including the unique identifier.</returns>
        public PrizeModel CreatePrize(PrizeModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("Tournaments")))
            {
                var p = new DynamicParameters();
                p.Add("@PlaceNumber", model.PlaceNumber);
                p.Add("@PlaceName", model.PlaceName);
                p.Add("@PrizeAMount", model.PrizeAmount);
                p.Add("@PrizePercentage", model.PrizePercentage);
                // Parameter direction tells which direction this variable's data is going
                p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spPrizes_Insert", p, commandType: CommandType.StoredProcedure);

                model.Id = p.Get<int>("@id");
                return model;
            }
        }
    }
}