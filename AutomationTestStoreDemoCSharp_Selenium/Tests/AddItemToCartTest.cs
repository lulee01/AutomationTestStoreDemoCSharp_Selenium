using NUnit.Framework;

namespace AutomationTestStoreDemoCSharp_Selenium.Tests
{
    public class AddItemToCartTest:BaseTest
    {
        [SetUp]
        public void Setup()
        {
            Pages.HomePage.ClickOnLogin();
            Pages.LoginOrRegisterPage.Login(TestData.TestData.LoginData.username,TestData.TestData.LoginData.password);
            Pages.HomePage.ClickOnCart();
            Pages.CartPage.RemoveItemsFromCart();
            Pages.HomePage.ClickonHome();

        }

        [Test]
        public void AddItemToCart()
        {
            Pages.HomePage.AddProductFromIndex("65");
            Pages.HomePage.ClickOnCart();
            //Asertacija
            Assert.IsFalse(Pages.CartPage.IsCartEmpty());
        }

        [Test]
        public void AddItemToCartFromProductPage()
        {
            Pages.HomePage.ClickonHome();
            Pages.HomePage.ClickOnProduct();
            Pages.ProductPage.ClickOnAddToCart();

            //Asertacija
            Assert.IsFalse(Pages.CartPage.IsCartEmpty());
        }
    }
}
