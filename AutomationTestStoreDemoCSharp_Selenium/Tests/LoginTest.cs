using NUnit.Framework;

namespace AutomationTestStoreDemoCSharp_Selenium.Tests
{
    public class LoginTest:BaseTest
    {
        [Test]
        public void LoginUser()
        {
            Pages.HomePage.ClickOnLogin();

            Pages.LoginOrRegisterPage.Login(TestData.TestData.Registerdata.username, TestData.TestData.Registerdata.password);  


            //Assert testa
            string message = Pages.LoginOrRegisterPage.GetTextAfterLogin();
            Assert.That(message, Is.EqualTo("MY ACCOUNT"));
        }
    }
}
