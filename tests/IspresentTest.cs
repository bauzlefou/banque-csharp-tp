// Generated by Selenium IDE
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using NUnit.Framework;


namespace banque_simple
{
    [TestFixture]
    public class IspresentTest
    {
        private IWebDriver driver;
        public IDictionary<string, object> vars { get; private set; }
        private IJavaScriptExecutor js;

        [SetUp]
        public void SetUp()
        {
            //driver = new FirefoxDriver();
            driver = new ChromeDriver();
            js = (IJavaScriptExecutor)driver;
            vars = new Dictionary<string, object>();
        }

        [TearDown]
        protected void TearDown()
        {
            driver.Quit();
        }
        [Test]
        public void ispresent()
        {
            driver.Navigate().GoToUrl("http://192.168.18.104/");
            driver.Manage().Window.Size = new System.Drawing.Size(1280, 1024);
            driver.FindElement(By.CssSelector("h2")).Click();
            driver.FindElement(By.LinkText("Accès client")).Click();
            var elements = driver.FindElements(By.Id("authIdentifiant"));
            Assert.True(elements.Count > 0);
            driver.FindElement(By.Id("authMotdepasse")).Click();
            elements = driver.FindElements(By.Id("authMotdepasse"));
            Assert.True(elements.Count > 0);
            driver.FindElement(By.Id("authIdentifiant")).Click();
            driver.FindElement(By.Id("identificationForm")).Click();
            driver.FindElement(By.CssSelector("html")).Click();
        }
    }
}