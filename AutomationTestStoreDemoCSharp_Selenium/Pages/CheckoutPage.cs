using OpenQA.Selenium;

namespace AutomationTestStoreDemoCSharp_Selenium.Pages
{
    public class CheckoutPage:BasePage
    {
        /// <summary>
        /// Defaultni konstruktor
        /// </summary>
        public CheckoutPage()
        {
            driver = null;
        }
        /// <summary>
        /// Parametrizovani konstruktor
        /// </summary>
        public CheckoutPage(IWebDriver webDriver)
        {
            driver = webDriver;
        }

        // Locators
        By listOfCurrencies = By.XPath("//div[@class='block_6']");
        By checkoutButton = By.Id("checkout_btn");
        By orderSuccessfullMessage = By.XPath("//span[@class='maintext']");

        /// <summary>
        /// Metoda koja postavlja valutu
        /// </summary>
        public void SelectCurrency(string currency)
        {
            ClickOnElement(listOfCurrencies);
            Thread.Sleep(100);
            ClickOnElement(By.XPath($"//div[@class='block_6']//a[contains(@href, '{currency}')]"));
        }

        /// <summary>
        /// Metoda koja klikce na confirm dugme
        /// </summary>
        private void ClickOnConfirmOrder()
        { 
            ClickOnElement(checkoutButton); 
        }

        /// <summary>
        /// Metoda koja izvrsava checkout u izabranoj valuti
        /// </summary>
        public void SelectCurrencyForPurchase(string currency)
        {
            SelectCurrency(currency);
            Thread.Sleep(100);
            ClickOnConfirmOrder();
        }

        /// <summary>
        /// Metoda koja prosledjuje poruku o uspesnom narucivanju
        /// </summary>
        public string GetOrderSuccessfullyProcessedMessage()
        {
            Thread.Sleep(300);
            return ReadTextFromElement(orderSuccessfullMessage);
        }
    }
}
