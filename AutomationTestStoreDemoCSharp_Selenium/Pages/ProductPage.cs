using OpenQA.Selenium;

namespace AutomationTestStoreDemoCSharp_Selenium.Pages
{
    public class ProductPage : BasePage
    {
        /// <summary>
        /// Defaultni konstruktor
        /// </summary>
        public ProductPage()
        {
            driver = null;
        }

        /// <summary>
        /// Parametarizovani konstruktor
        /// </summary>
        public ProductPage(IWebDriver webDriver)
        {
            driver = webDriver;
        }

        // Locators
        By addToCartButton = By.PartialLinkText("Add to Cart");
        By productName = By.XPath("//span[@class='bgnone']");

        /// <summary>
        /// Metoda koja klikne na dugme Add to cart
        /// </summary>
        public void ClickOnAddToCart()
        {
            ClickOnElement(addToCartButton);
        }

        /// <summary>
        /// Metoda koja prosledjuje ime proizvoda
        /// </summary>
        public string GetProductName()
        {
            Thread.Sleep(200);
            return ReadTextFromElement(productName);
        }
    }
}
