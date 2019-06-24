using System;
using System.Data.SqlClient;


namespace CSharp_Scraper
{

    public class ConnectionString
    {
        public void Connector()
        {
            string connection;
            SqlConnection db;

            string[] stockFields = { "@time_scraped", "@stock_symbol", "@last_price", "@change", "@change_percent", "@volume", "@shares", "@average_volume", "@market_cap" };

            string[] stockData = { "06/22/1988", "TEST", "$", "1", "1%", "2", "2", "2", "2" };

            connection = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=StockScrapes;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            using (db = new SqlConnection(connection))
            {
                string insertion = "INSERT INTO dbo.StockScrape (Time_Scraped, Stock_Symbol, Last_Price, Change, Change_Percent, Volume, Shares, Average_Volume, Market_Cap) VALUES (@time_scraped, @stock_symbol, @last_price, @change, @change_percent, @volume, @shares, @average_volume, @market_cap)";
                
                using (SqlCommand dataToTable = new SqlCommand(insertion, db))
                {
                    dataToTable.Parameters.AddWithValue("@time_scraped", stockData[0]);
                    dataToTable.Parameters.AddWithValue("@stock_symbol", stockData[1]);
                    dataToTable.Parameters.AddWithValue("@last_price", stockData[2]);
                    dataToTable.Parameters.AddWithValue("@change", stockData[3]);
                    dataToTable.Parameters.AddWithValue("@change_percent", stockData[4]);
                    dataToTable.Parameters.AddWithValue("@volume", stockData[5]);
                    dataToTable.Parameters.AddWithValue("@shares", stockData[6]);
                    dataToTable.Parameters.AddWithValue("@average_volume", stockData[7]);
                    dataToTable.Parameters.AddWithValue("@market_cap", stockData[8]);
                    
                    db.Open();

                    Console.WriteLine("Database has been opened.");

                    var result = dataToTable.ExecuteNonQuery();
                }
                db.Close();
            }
        }
    }
}
