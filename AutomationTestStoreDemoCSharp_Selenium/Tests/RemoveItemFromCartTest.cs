using NUnit.Framework;

namespace AutomationTestStoreDemoCSharp_Selenium.Tests
{
    public class RemoveItemFromCartTest:BaseTest
    {
        [SetUp]
        public void SetUp()
        {
            Pages.HomePage.ClickOnLogin();

            Pages.LoginOrRegisterPage.Login(TestData.TestData.LoginData.username, TestData.TestData.LoginData.password);
            Pages.HomePage.ClickonHome();
            Pages.HomePage.AddProductFromIndex("65");
        }

        [Test]
        public void RemoveItemFromCart()
        {
           
            Pages.HomePage.ClickOnCart();
            bool isCartEmptyB = Pages.CartPage.IsCartEmpty();

            Pages.CartPage.RemoveItemsFromCart();
            bool isCartEmptyA = Pages.CartPage.IsCartEmpty();

            //Asertacija
            Assert.That(isCartEmptyA, Is.Not.EqualTo(isCartEmptyB));
        }
    }
}
