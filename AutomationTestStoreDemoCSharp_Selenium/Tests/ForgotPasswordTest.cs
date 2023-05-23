using AutomationTestStoreDemoCSharp_Selenium.Utils;
using NUnit.Framework;

namespace AutomationTestStoreDemoCSharp_Selenium.Tests
{
    public class ForgotPasswordTest: BaseTest
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
        public void ForgotPassword()
        {
            Pages.HomePage.ClickOnLogin();
            Pages.LoginOrRegisterPage.ClickOnForgotPassword();
            Pages.ForgotPasswordPage.ForgotPassword(username, email);

            //Assert testa

            string message = Pages.ForgotPasswordPage.GetTextFromAlertBox();
            Assert.That(message, Is.EqualTo(TestData.TestData.Messages.forgotPasswordSuccsess));
        }

        
    }
}
