using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Chrome;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace knab
{
    public class Utilites
    {
        IWebDriver driver;
        public void NavigateToUrl(string weburl)
        {
            driver = new ChromeDriver();
            driver.Url = weburl;
        }

        public void SetValueById(string Control, string value)
        {
            string title=driver.Title;
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20); 
            driver.FindElement(By.Id("licensePlate")).SendKeys(value);
        }

        public void SendValues(string KeyPress)
        {     
            driver.FindElement(By.Id("licensePlate")).SendKeys(KeyPress);
        }

        public void Validate(string expected)
        {
            if (expected == "False")
            {
                try
                {
                    IWebElement Label = driver.FindElement(By.XPath("//*/div[1]/div/knx-card[1]/div/div[1]/div/knx-async-preview/div/knx-car-info/div/div[1]/div[1]"));
                }
                catch (NoSuchElementException ex)
                {
                    Console.WriteLine("No Such Elment found as expected");
                }
            }
            else
            {
                IWebElement Label = driver.FindElement(By.XPath("//*/div[1]/div/knx-card[1]/div/div[1]/div/knx-async-preview/div/knx-car-info/div/div[1]/div[1]"));
                Assert.IsTrue(Label.Text.Contains(expected), "Expected Value" + expected + " Not found");
            }       
            
        }
    }
}
