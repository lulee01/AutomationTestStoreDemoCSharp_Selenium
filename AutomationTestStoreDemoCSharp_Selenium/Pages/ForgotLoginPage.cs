using OpenQA.Selenium;

namespace AutomationTestStoreDemoCSharp_Selenium.Pages
{
    public class ForgotLoginPage:BasePage
    {
        /// <summary>
        /// Defaultni konstruktor
        /// </summary>
        public ForgotLoginPage()
        {
            driver = null;
        }

        /// <summary>
        /// Parametrizovani konstruktor
        /// </summary>
        /// <param name="webDriver"></param>
        public ForgotLoginPage(IWebDriver webDriver)
        {
            driver = webDriver;
        }

        //Locators
        By lastnameField = By.Id("forgottenFrm_lastname");
        By emailField = By.Id("forgottenFrm_email");
        By continueButton = By.XPath("//button [contains(.,'Continue')]");
        By alertmessage = By.XPath("//div[contains(@class,'alert alert-success')]");

        /// <summary>
        /// Metoda koja unosi prezime u polje
        /// </summary>
        private void EnterLastName(string lastname)
        {
            WriteTextToElement(lastnameField, lastname);
        }
        /// <summary>
        /// Metoda koja unosi email u polje
        /// </summary>
        private void EnterEmail(string email)
        {
            WriteTextToElement(emailField, email);
        }
        /// <summary>
        /// Metoda koja klikce na continue
        /// </summary>
        private void ClickOnContinue()
        {
            ClickOnElement(continueButton);
        }


        /// <summary>
        /// Metoda koja cita text iz alert box-a
        /// </summary>
        public string GetTextFromAlertBox()
        {
            return ReadTextFromElement(alertmessage);
        }

        /// <summary>
        /// Metoda koja popunjava forgot login polja
        /// </summary>
        public void ForgotLogin(string lastname, string email)
        {
            EnterLastName(lastname);
            EnterEmail(email);
            ClickOnContinue();
        }
    }
}
