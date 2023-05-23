using OpenQA.Selenium;

namespace AutomationTestStoreDemoCSharp_Selenium.Pages
{
    public class AccountPage:BasePage
    {
        /// <summary>
        /// Defaultni konstruktor
        /// </summary>
        public AccountPage()
        {
            driver = null;
        }

        /// <summary>
        /// Parametrizovani konstruktor
        /// </summary>
        public AccountPage(IWebDriver webDriver)
        {
            driver = webDriver;
            
        }

        //Locators
        By logutButton = By.XPath("//i[contains(@class,'fa fa-unlock')]");
        By continueButton = By.XPath("//button[@title='Continue']");
        By guestCheckout = By.Id("accountFrm_accountguest");

        /// <summary>
        /// Klik na logout dugme
        /// </summary>
        public void Logout()
        {
            ClickOnElement(logutButton);
        }

        /// <summary>
        /// Metoda koja vodi korisnika na guest checkout
        /// </summary>
        public void CheckoutAsGuest()
        {
            ClickOnElement(guestCheckout);
            ClickOnElement(continueButton);
        }
    }
}
