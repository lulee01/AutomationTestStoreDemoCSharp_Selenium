using AutomationTestStoreDemoCSharp_Selenium.Utils;
using NUnit.Framework;

namespace AutomationTestStoreDemoCSharp_Selenium.Tests
{
    public class RegistratonTest:BaseTest
    {
        string username = Methods.GenerateRandomUsername("Milan");
        string password = Methods.GeneratePassword(10000000, 100000000).ToString();
        string email = Methods.GenerateRandomemail("Milan");

        [Test]
        public void RegisterUser()
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

            //Assert testa
            string message = Pages.LoginOrRegisterPage.GetTextAfterRegistration();
            Thread.Sleep(500);
            Assert.That(message, Is.EqualTo(TestData.TestData.Messages.successfullRegistration));
        }

    }
}
