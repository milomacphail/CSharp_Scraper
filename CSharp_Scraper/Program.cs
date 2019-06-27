using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace CSharp_Scraper
{
    public class Scraper
    {
        static void Main(string[] args)
        {

            var scrape = new Scrape("milomacphail@gmail.com", "Pandahead1");

            scrape.Login();
            scrape.Navigate();
            scrape.ScrapeTable();
            
        }
        }
    }