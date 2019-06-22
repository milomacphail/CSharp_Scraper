using System;


namespace CSharp_Scraper
{
    public class Stock
    {
        public DateTime TimeScraped { get; set }
        public string StockSymbol { get; set; }
        public string LastPrice { get; set; }
        public string Change { get; set; }
        public string ChangePercent { get; set; }
        public string Volume { get; set; }
        public string Shares { get; set; } 
        public string AvgVol { get; set; }
        public string MarketCap { get; set; }
        

        public Stock()
        {

        }

        public Stock(DateTime timeScraped, string stockSymbol, string lastPrice, string change,
            string changePercent, string volume, string shares, string avgVol, string marketCap)
        {
            this.TimeScraped = timeScraped;
            this.StockSymbol = stockSymbol;
            this.LastPrice = lastPrice;
            this.Change = change;
            this.ChangePercent = changePercent;
            this.Volume = volume;
            this.Shares = shares;
            this.AvgVol = avgVol;
            this.MarketCap = marketCap;
        }
    }
}

