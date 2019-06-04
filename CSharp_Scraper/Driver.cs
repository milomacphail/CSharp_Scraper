using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CSharp_Scraper
{
    public class Driver
    {
            IWebDriver driver;

            public void startBrowser()
            {
                driver = new ChromeDriver();
            }

            
            void openBrowser()
            {
                driver.Url = "https://finance.yahoo.com/";
            }


            void closeBrowser()
            {
                driver.Close();
            }


        }
    }
