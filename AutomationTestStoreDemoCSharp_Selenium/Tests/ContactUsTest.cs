using NUnit.Framework;

namespace AutomationTestStoreDemoCSharp_Selenium.Tests
{
    public class ContactUsTest:BaseTest
    {
        [Test]
        public void ContactUs()
        {
            Pages.HomePage.ClickOnCOntactUs();

            Pages.ContactUsPage.ContactUs(TestData.TestData.Registerdata.name, TestData.TestData.Registerdata.email, "Ovo je test poruka");

            //Assert testa
            string message = Pages.ContactUsPage.ReadtextFromButton();
            Assert.That(message, Is.EqualTo("Continue"));
        }
    }
}
