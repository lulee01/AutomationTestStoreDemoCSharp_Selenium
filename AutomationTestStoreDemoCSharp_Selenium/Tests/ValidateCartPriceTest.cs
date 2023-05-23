using NUnit.Framework;

namespace AutomationTestStoreDemoCSharp_Selenium.Tests
{
    public class ValidateCartPriceTest:BaseTest
    {
        [Test]
        public void ValidatePrice()
        {

            string totalBefore = Pages.HomePage.GetCartTotal();
            totalBefore += Pages.HomePage.AddToTotal("68");
            Thread.Sleep(2000);

            string totalAfter = "$0.00" + Pages.HomePage.GetCartTotal();
            // Asertacija
            Assert.That(totalAfter, Is.EqualTo(totalBefore));
                
        }
    }
}
