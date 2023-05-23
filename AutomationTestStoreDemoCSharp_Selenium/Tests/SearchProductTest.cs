using NUnit.Framework;

namespace AutomationTestStoreDemoCSharp_Selenium.Tests
{
    public class SearchProductTest:BaseTest
    {
        [Test]

        public void SearchProduct()
        {
            string searchingfor = TestData.TestData.Search.item;
            Pages.HomePage.SearchProduct(searchingfor);

            // Asertacija - ime pronadjenog proizvoda uporedjujemo sa imenom trazenog proizvoda
            string found = Pages.ProductPage.GetProductName();
            Assert.That(found, Is.EqualTo(searchingfor));
        }
    }
}
