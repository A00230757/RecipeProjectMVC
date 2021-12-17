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
        public void TestWebApiTitle()

        {
            _webDriver.Navigate().GoToUrl("https://localhost:5001/Swagger/index.html");
            Assert.IsTrue(_webDriver.Title.Contains("Swagger UI"));
           Assert.AreEqual("Swagger UI", _webDriver.Title);
            
        }

        [TestMethod]
        public void TestWebApiOpenViewRecipe()
        {
            _webDriver.Navigate().GoToUrl("https://localhost:5001/ViewRecipe");
            /* Assert.IsTrue(_webDriver.Title.Contains("Home Page - Recipe Project"));
             Assert.AreEqual("Home Page - Recipe Project", _webDriver.Title);*/
            /* IWebElement element = _webDriver.FindElement(By.LinkText("RecipeId"));
             element.Click();
             Console.WriteLine(_webDriver.FindElements(By.TagName("RecipeId")));*/
            var s = _webDriver.PageSource;
            var pos1 = s.IndexOf("{");
            var pos2 = s.IndexOf("}");
            string json = s.Substring(pos1, pos2);
            Console.WriteLine(json);
            Console.WriteLine(s);
            // return json;
        }


        [TestMethod]
        public void TestWebApiSearchRecipeJsonData()

        {
            _webDriver.Navigate().GoToUrl("https://localhost:5001/SearchRecipe?recipeid=3");
            
            //Assert.IsTrue(_webDriver.PageSource.Contains(n));
            /*  Assert.AreEqual("Home Page - Recipe Project", _webDriver.Title);*/
            var output = "<html><head></head><body><pre style=\"word-wrap: break-word; white-space: pre-wrap;\">{\"RecipeId\":3,\"Name\":\"d\",\"FoodCategory\":\"d\",\"Title\":\"d\",\"Description\":\"d\",\"PrepTime\":\"d\",\"CookTime\":\"d\",\"Ingredients\":\"d\",\"Tools\":\"d\",\"CookingSteps\":\"d\",\"Photo1\":\"d\",\"Photo2\":\"d\",\"Photo3\":\"d\",\"Ranking\":\"d\"}</pre></body></html>";

             Assert.AreEqual(output, _webDriver.PageSource);
            Console.WriteLine(output);
            Console.WriteLine(_webDriver.PageSource);


        }

        [TestMethod]
        public void TestAddUserComments()
        {
            _webDriver.Navigate().GoToUrl("https://localhost:5001/UserComments/Create");
            var searchBox1 = _webDriver.FindElement(By.Name("commentTitle"));
            searchBox1.SendKeys("Recipe details feedback");
            var searchBox2 = _webDriver.FindElement(By.Name("CommentDetail"));
            searchBox2.SendKeys("all the details are very helpful");
            var submit = _webDriver.FindElement(By.CssSelector("input[type='submit'][name='btnK']"));
            submit.Click();
            Assert.IsTrue(true);
        }

        [TestMethod]
        public void TestDeleteUserComments()
        {
            _webDriver.Navigate().GoToUrl("https://localhost:5001/UserComments/Delete/1");
           
            var submit = _webDriver.FindElement(By.CssSelector("input[type='submit'][name='btnK']"));
            submit.Click();
            Assert.IsTrue(true);
        }

        [TestMethod]
        public void TestEditUserComments()
        {
            _webDriver.Navigate().GoToUrl("https://localhost:5001/UserComments/Edit/4");
            var searchBox1 = _webDriver.FindElement(By.Name("commentTitle"));
            searchBox1.SendKeys("Recipe details feedback");
            var searchBox2 = _webDriver.FindElement(By.Name("CommentDetail"));
            searchBox2.SendKeys("all the details are very helpful but prep time is more");
            var submit = _webDriver.FindElement(By.CssSelector("input[type='submit'][name='btnK']"));
            submit.Click();
            Assert.IsTrue(true);
        }

        [TestMethod]
        public void TestAddRecipe()
        {
            _webDriver.Navigate().GoToUrl("https://localhost:5001/Recipes/Create");
            var searchBox1 = _webDriver.FindElement(By.Name("Name"));
            searchBox1.SendKeys("Fish Recipe");
            var searchBox2 = _webDriver.FindElement(By.Name("FoodCategory"));
            searchBox2.SendKeys("non veg");
            var searchBox3 = _webDriver.FindElement(By.Name("Title"));
            searchBox3.SendKeys("Fish Prepare Recipe");
            var searchBox4 = _webDriver.FindElement(By.Name("Description"));
            searchBox4.SendKeys("How to prepare fish");
            var searchBox5 = _webDriver.FindElement(By.Name("PrepTime"));
            searchBox5.SendKeys("20 minutes");
            var searchBox6 = _webDriver.FindElement(By.Name("CookTime"));
            searchBox6.SendKeys("15 minutes");
            var searchBox7 = _webDriver.FindElement(By.Name("Ingredients"));
            searchBox7.SendKeys("different kind of ingredients");
            var searchBox8 = _webDriver.FindElement(By.Name("Tools"));
            searchBox8.SendKeys("cooking device");
            var searchBox9 = _webDriver.FindElement(By.Name("CookingSteps"));
            searchBox9.SendKeys("take 5-6 steps");
            var searchBox10 = _webDriver.FindElement(By.Name("Photo1"));
            searchBox10.SendKeys("photo1 of fish recipe");
            var searchBox11 = _webDriver.FindElement(By.Name("Photo2"));
            searchBox11.SendKeys("photo2 of fish recipe");
            var searchBox12 = _webDriver.FindElement(By.Name("Photo3"));
            searchBox12.SendKeys("photo 3 of fish recipe");
            var searchBox13 = _webDriver.FindElement(By.Name("Ranking"));
            searchBox13.SendKeys("ranking of fish recipe");
            var submit = _webDriver.FindElement(By.CssSelector("input[type='submit'][name='btnK']"));
            submit.Click();
            Assert.IsTrue(true);
        }


        [TestMethod]
        public void TestDeleteRecipe()
        {
            _webDriver.Navigate().GoToUrl("https://localhost:5001/Recipes/Delete/6");

            var submit = _webDriver.FindElement(By.CssSelector("input[type='submit'][name='btnK']"));
            submit.Click();
            Assert.IsTrue(true);
        }

        [TestCleanup]
        public void Teardown()
        {
            _webDriver.Quit();
        }
    }
}
