using NUnit.Framework;

namespace AutomationTestStoreDemoCSharp_Selenium.Tests
{
    public class PurchaseTest:BaseTest
    {
        [SetUp]
        public void Setup()
        {
            Pages.HomePage.AddProductFromIndex("65");
            Pages.HomePage.AddProductFromIndex("52");
            Pages.HomePage.ClickOnCart();
        }

        [Test]
        public void UserPurchase()
        {
            Pages.CartPage.ClickOnCheckout();
            Pages.LoginOrRegisterPage.Login(TestData.TestData.LoginData.username, TestData.TestData.LoginData.password);
            Pages.ChechoutPage.SelectCurrencyForPurchase("EUR");

            Thread.Sleep(300);

            //Asertacija 
            string message = Pages.ChechoutPage.GetOrderSuccessfullyProcessedMessage();
            Assert.That(message, Is.EqualTo(TestData.TestData.Messages.successfullPurchase));
        }

        [Test]
        public void GuestPurchase()
        {
            Pages.CartPage.ClickOnCheckout();
            Pages.AccountPage.CheckoutAsGuest();
            Pages.CheckoutAsGuestPage.GuestCheckoutForm(TestData.TestData.GuestData.name,
                                                        TestData.TestData.GuestData.lastname,
                                                        TestData.TestData.GuestData.email,
                                                        TestData.TestData.GuestData.adress,
                                                        TestData.TestData.GuestData.city,
                                                        TestData.TestData.GuestData.region,
                                                        TestData.TestData.GuestData.zipcode,
                                                        TestData.TestData.GuestData.country);
            Pages.ChechoutPage.SelectCurrencyForPurchase("");
            Thread.Sleep(300);

            //Asertacija
            string message = Pages.ChechoutPage.GetOrderSuccessfullyProcessedMessage();
            Assert.That(message, Is.EqualTo(TestData.TestData.Messages.successfullPurchase));
        }
    }
}
