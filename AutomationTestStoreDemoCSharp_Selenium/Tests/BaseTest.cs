using AutomationTestStoreDemoCSharp_Selenium.Utils;
using NUnit.Framework;

namespace AutomationTestStoreDemoCSharp_Selenium.Tests
{
    [TestFixture]
     public class BaseTest
    {
        protected Browsers browser;
        protected AllPages Pages;

        [SetUp]
        public void StartUpTest()
        {
            browser = new Browsers();
            browser.Init();
            Pages = new AllPages(browser);
        }

        [TearDown]
        public void AfterTest()
        {
            try
            {
                // logic after test
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                browser.Close();
            }
        }
    }

}

