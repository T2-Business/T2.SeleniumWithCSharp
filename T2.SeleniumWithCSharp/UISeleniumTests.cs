using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using System;
using System.Threading.Tasks;

namespace T2.SeleniumWithCSharp
{
    [TestClass]
    public class UISeleniumTests
    {
        private TestContext testContextInstance;
        private IWebDriver driver;
        private string appURL;

        [TestMethod]
        [TestCategory("Chrome")]
        public void InboxRedirectTest_UsingChromeBrowser_SuucessLogin()
        {
            // IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl(appURL);
            Task.Delay(2000).Wait();
            driver.Manage().Window.Maximize();
            var userNameWebElement = driver.FindElement(By.Id("usernameFieldId"));
            userNameWebElement.SendKeys("UserName");

            var passwordWebElement = driver.FindElement(By.Id("passwordFieldId"));
            passwordWebElement.SendKeys("YourPortalPasswordValue");

            var LoginbtnWebElement = driver.FindElement(By.Id("loginButtonId"));
            LoginbtnWebElement.Click();
            Task.Delay(3000).Wait();
            string url = driver.Url;

            Assert.IsFalse(url.Contains("login"), "cant  login to the site ");

            var PersonalInboxWebElement = driver.FindElement(By.Id("MyInboxPage"));
            PersonalInboxWebElement.Click();
            Assert.IsFalse(url.Contains("Document/Inbox"), "cant redirect to the Inbox page  ");
        }




        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        [TestInitialize()]
        public void SetupTest()
        {



            appURL = "http://qa.ole5.sa/";

            string browser = GetMetodTestCategory();
            switch (browser)
            {
                case "Chrome":
                    driver = new ChromeDriver();
                    break;
                case "Firefox":
                    driver = new FirefoxDriver();
                    break;
                case "IE":
                    driver = new InternetExplorerDriver();
                    break;
                default:
                    driver = new ChromeDriver();
                    break;
            }

        }
        private string GetMetodTestCategory()
        {
            var method = typeof(UISeleniumTests).GetMethod(testContextInstance.TestName);
            string methodCategory = "Chrome";

            foreach (var attribute in (System.Collections.Generic.IEnumerable<TestCategoryAttribute>)method.GetCustomAttributes(typeof(TestCategoryAttribute), true))
            {
                foreach (var category in attribute.TestCategories)
                {
                    methodCategory = category;
                }
            }

            return methodCategory;

        }
        [TestCleanup()]
        public void MyTestCleanup()
        {
            driver.Close();
            driver.Quit();
        }
    }
}
