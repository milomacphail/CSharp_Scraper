using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Requires reference to WebDriver.Support.dll
using OpenQA.Selenium.Support.UI;

class GoogleSuggest
{
    static void Main(string[] args)
    {

        IWebDriver driver = new ChromeDriver();

        //Notice navigation is slightly different than the Java version
        //This is because 'get' is a keyword in C#
        driver.Navigate().GoToUrl("https://finance.yahoo.com/");

        // Find the text input element by its name
        driver.FindElement(By.Id("uh-signedin")).Click();

        //page load
        driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);

        driver.FindElement(By.Id("login-username")).SendKeys("milomacphail@gmail.com");
        driver.FindElement(By.Id("login-signin")).SendKeys(Keys.Enter);

        //Wait until the page loads
        driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);

        driver.FindElement(By.Id("login-passwd")).SendKeys("Pandahead1");
        driver.FindElement(By.Id("login-signin")).SendKeys(Keys.Enter);

        driver.FindElement(By.LinkText("My Watchlist")).SendKeys(Keys.Enter);

        driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);

        IWebElement table = driver.FindElement(By.XPath("//*[@id=\"pf-detail-table\"]/div[1]/table"));

        IList<IWebElement> table_rows = driver.FindElements(By.TagName("tr"));

        foreach (IWebElement table_row in table_rows)
        {
            Console.WriteLine(table_row);
        }

        driver.Close();
    }
}
