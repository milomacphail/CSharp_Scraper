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

            connection = @"Data Source = (localdb)\ProjectsV13; Initial Catalog = master; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False";
            db = new SqlConnection(connection);

            private static void insertCurrentData(Stock stock)
            {
                string lastScrapeData = @"IF EXISTS(SELECT * FROM Stocks WHERE Symbol = @Symbol)
            }
            db.Open();
            Console.WriteLine("Connected to database!");

            private static void ScrapeData(Stock stock)
                {
                    string lastScrapeData = @"IF EXISTS(SELEC"
                }

            }
        }
