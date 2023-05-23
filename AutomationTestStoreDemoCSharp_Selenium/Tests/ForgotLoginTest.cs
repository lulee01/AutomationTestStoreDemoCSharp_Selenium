using AutomationTestStoreDemoCSharp_Selenium.Utils;
using NUnit.Framework;

namespace AutomationTestStoreDemoCSharp_Selenium.Tests
{
    public class ForgotLoginTest:BaseTest
    {
        string username = Methods.GenerateRandomUsername("Milan");
        string password = Methods.GeneratePassword(10000000, 100000000).ToString();
        string email = Methods.GenerateRandomemail("Milan");

        [SetUp]
        public void Setup()
        {
            Pages.HomePage.ClickOnLogin();
            Pages.LoginOrRegisterPage.Register(TestData.TestData.Registerdata.name,
                                               TestData.TestData.Registerdata.lastname,
                                               email,
                                               TestData.TestData.Registerdata.adress,
                                               TestData.TestData.Registerdata.city,
                                               TestData.TestData.Registerdata.region,
                                               TestData.TestData.Registerdata.zipcode,
                                               TestData.TestData.Registerdata.country,
                                               username,
                                               password);

            Pages.HomePage.ClickOnAccount();
            Pages.AccountPage.Logout();
        }

        [Test]
        public void ForgotLogin()
        {

            Pages.HomePage.ClickOnLogin();
            Pages.LoginOrRegisterPage.ClickOnForgotLogin();

            Pages.ForgotLoginPage.ForgotLogin(TestData.TestData.Registerdata.lastname, email);

            //Assert testa
            string message = Pages.ForgotLoginPage.GetTextFromAlertBox();
            Assert.That(message, Is.EqualTo(TestData.TestData.Messages.forgotLoginSuccsess));
        }
    }
}
