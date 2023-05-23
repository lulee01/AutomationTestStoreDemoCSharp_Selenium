using AutomationTestStoreDemoCSharp_Selenium.Utils;
using OpenQA.Selenium;

namespace AutomationTestStoreDemoCSharp_Selenium.Pages
{
    public class CartPage:BasePage
    {
        /// <summary>
        /// Defaultni konstrukor
        /// </summary>
        public CartPage()
        {
            driver = null;
        }

        /// <summary>
        /// PArametrizovani konstruktor
        /// </summary>
        public CartPage(IWebDriver webDriver)
        {
            driver = webDriver;

        }

        //Locators
        By tableTotals = By.XPath("//table[@id='totals_table']");
        By continueButton = By.XPath("//a[@title='Continue']");
        By removeButton = By.XPath("//i[contains(@class, 'fa-trash')]/..");
        By checkoutButton = By.Id("cart_checkout1");

        /// <summary>
        /// Metoda koja proverava postojanje proizvoda u korpi
        /// </summary>
        public bool IsCartEmpty()
        {
            Thread.Sleep(1000);
            return !Methods.IsElementPresent(driver, tableTotals);
        }

        /// <summary>
        /// Metoda koja klikne na Continue dugme
        /// </summary>
        private void ClickOnContinue() 
        { 
            ClickOnElement(continueButton); 
        }


        /// <summary>
        /// Metoda koja brise sve proizvode iz korpe
        /// </summary>
        public void RemoveItemsFromCart()
        {
            while (!IsCartEmpty())
            {
                ClickOnElement(removeButton);
            }
            ClickOnContinue();
        }

        /// <summary>
        /// Metoda koja klikne na checkout dugme
        /// </summary>
        public void ClickOnCheckout() 
        { 
            ClickOnElement(checkoutButton); 
        }
    }
}
