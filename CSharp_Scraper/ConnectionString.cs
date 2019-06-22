using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;


namespace CSharp_Scraper
{

    public class ConnectionString
    {
        public static void Connector()
        {
            string connection;
            SqlConnection db;
            SqlCommand command;

            connection = @"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = StockScrapes" + "Integrated Security = SSPI;";

            db = new SqlConnection(connection);

            using (StockScrapesEntities table = new StockScrapesEntities())
            {
                table.StockScrapes 
            }

        }

    }
}
