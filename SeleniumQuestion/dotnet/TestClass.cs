using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.IO;

namespace seleniumquestion
{
    public class TestClass
    {
        IWebDriver webdriver;

        [SetUp]
        public void Setup()
        {
            var options = new ChromeOptions();
            options.AddArguments("start-maximized", "no-sandbox");

            webdriver = new ChromeDriver(Path.GetDirectoryName(AppDomain.CurrentDomain.BaseDirectory), options);
            
            var relativePathToIndexFile = Path.Combine("..", "..", "..", "..", "index.html");
            var filePath = Path.GetFullPath(relativePathToIndexFile, AppDomain.CurrentDomain.BaseDirectory);
            webdriver.Navigate().GoToUrl(filePath);
        }

        [TearDown]
        public void Teardown()
        {
            webdriver.Quit();
        }

        [Test]
        public void TestPage()
        {

            Assert.IsTrue(webdriver.Title.Equals("Test me"));
        }
    }
}