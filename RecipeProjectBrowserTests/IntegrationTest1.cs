using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;


namespace RecipeProjectBrowserTests
{
    [TestClass]
    public class IntegrationTest1
    {
        private IWebDriver _webDriver;


        [TestMethod]
        public void TestMethod1()
        {
        }

        [TestInitialize]
        public void Setup()
        {
            new DriverManager().SetUpDriver(new ChromeConfig());
            _webDriver = new ChromeDriver();
        }

        [TestMethod]
        public void TitleTestOfIndexPage()
        {
            _webDriver.Navigate().GoToUrl("https://localhost:5001/Recipes");
            Assert.IsTrue(_webDriver.Title.Contains("Index - Recipe Project"));
            Assert.AreEqual("Index - Recipe Project", _webDriver.Title);
        }

        [TestMethod]
        public void TitleTestOfCreateRecipePage()
        {
            _webDriver.Navigate().GoToUrl("https://localhost:5001/Recipes/Create");
            Assert.IsTrue(_webDriver.Title.Contains("Create - Recipe Project"));
            Assert.AreEqual("Create - Recipe Project", _webDriver.Title);
        }

        [TestMethod]
        public void TitleTestOfEditRecipePage()
        {
            _webDriver.Navigate().GoToUrl("https://localhost:5001/Recipes/Edit/1");
            Assert.IsTrue(_webDriver.Title.Contains("Edit - Recipe Project"));
            Assert.AreEqual("Edit - Recipe Project", _webDriver.Title);
        }
        [TestMethod]
        public void TitleTestOfDeleteRecipePage()
        {
            _webDriver.Navigate().GoToUrl("https://localhost:5001/Recipes/Delete/1");
            Assert.IsTrue(_webDriver.Title.Contains("Delete - Recipe Project"));
            Assert.AreEqual("Delete - Recipe Project", _webDriver.Title);
        }
        [TestMethod]
        public void TitleTestOfDetailsRecipePage()
        {
            _webDriver.Navigate().GoToUrl("https://localhost:5001/Recipes/Details/1");
            Assert.IsTrue(_webDriver.Title.Contains("Details - Recipe Project"));
            Assert.AreEqual("Details - Recipe Project", _webDriver.Title);
            Console.WriteLine(_webDriver.Title);
        }

        [TestMethod]
        public void TitleTestOfHomeRecipePage()
        {
            _webDriver.Navigate().GoToUrl("https://localhost:5001/Recipes/Home");
            Assert.IsTrue(_webDriver.Title.Contains("Home Page - Recipe Project"));
            Assert.AreEqual("Home Page - Recipe Project", _webDriver.Title);
        }


        [TestMethod]
        public void TestWebApiOpenViewRecipe()
        {
            _webDriver.Navigate().GoToUrl("https://localhost:5001/ViewRecipe");
            /* Assert.IsTrue(_webDriver.Title.Contains("Home Page - Recipe Project"));
             Assert.AreEqual("Home Page - Recipe Project", _webDriver.Title);*/
            IWebElement element = _webDriver.FindElement(By.LinkText("RecipeId"));
            element.Click();
            Console.WriteLine(_webDriver.FindElements(By.TagName("RecipeId")));
        }


        [TestMethod]
        public void TestWebApiJsonData()
        {
            _webDriver.Navigate().GoToUrl("https://localhost:5001/SearchRecipe?recipeid=3");
            /* Assert.IsTrue(_webDriver.Title.Contains("Home Page - Recipe Project"));
             Assert.AreEqual("Home Page - Recipe Project", _webDriver.Title);*/
         
        }

        [TestCleanup]
        public void Teardown()
        {
            _webDriver.Quit();
        }
    }
}
