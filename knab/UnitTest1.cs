using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace knab
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://mijn-verzekeren.knab.nl/car/detail";
            string title=driver.Title;
            IWebElement Label= driver.FindElement(By.ClassName("knx-form-group__label"));
            driver.FindElement(By.Id("licensePlate")).SendKeys("FD-22-31");
        }
    }
}
