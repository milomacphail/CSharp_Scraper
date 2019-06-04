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
   
        using (IWebDriver driver = new ChromeDriver())
        {
            //Notice navigation is slightly different than the Java version
            //This is because 'get' is a keyword in C#
            driver.Navigate().GoToUrl("https://finance.yahoo.com/");

            // Find the text input element by its name
            IWebElement signIn = driver.FindElement(By.Id("uh-signedin"));

            //click in
            signIn.Click();

            IWebElement username = driver.FindElement(By.Id("login-username"));

            username.SendKeys("milomacphail@gmail.com");

            IWebElement userSignin = driver.FindElement(By.Id("login-signin"));
            userSignin.Submit();

            //Wait until the page loads
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);

            IWebElement password = driver.FindElement(By.Id("login-passwd"));

            password.SendKeys("Pandahead1");

            IWebElement passwordSignin = driver.FindElement(By.Id("login-signin"));
            passwordSignin.Submit();



        }
    }
}
