using NUnit.Framework;

namespace AutomationTestStoreDemoCSharp_Selenium.Tests
{
    public class ValidateCartCountTest:BaseTest
    {
        [Test]
        public void CartCountValidation()
        {
            Thread.Sleep(1000);
            int beforeAddition = Pages.HomePage.CartBadgeCount();

            Pages.HomePage.AddProductFromIndex("65");
            Pages.HomePage.AddProductFromIndex("52");

            Thread.Sleep(2000);
            

            int afterAddition = Pages.HomePage.CartBadgeCount();
            // Asertacija
            Assert.That(afterAddition, Is.EqualTo(beforeAddition + 3));
        }
    }
}
