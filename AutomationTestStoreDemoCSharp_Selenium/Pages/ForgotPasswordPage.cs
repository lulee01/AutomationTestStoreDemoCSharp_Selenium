using OpenQA.Selenium;

namespace AutomationTestStoreDemoCSharp_Selenium.Pages
{
    public class ForgotPasswordPage:BasePage
    {
        /// <summary>
        /// Defaultni konstruktor
        /// </summary>
        public ForgotPasswordPage()
        {
            driver = null;
        }

        /// <summary>
        /// Parametrizovani konstruktor
        /// </summary>
        /// <param name="webDriver"></param>
        public ForgotPasswordPage(IWebDriver webDriver)
        {
            driver = webDriver;
        }

        //Locators
        By usernameField = By.Id("forgottenFrm_loginname");
        By emailField = By.Id("forgottenFrm_email");
        By continueButton = By.XPath("//button [contains(.,'Continue')]");
        By alertmessage = By.XPath("//div[contains(@class,'alert alert-success')]");

        /// <summary>
        /// Metoda koja unosi username u polje
        /// </summary>
        private void EnterUsername(string username)
        {
            WriteTextToElement(usernameField, username);
        }

        /// <summary>
        /// Metoda koja unosi mail u polje
        /// </summary>
        public void EnterEmail(string email)
        {
            WriteTextToElement(emailField, email);
        }

        /// <summary>
        /// Metoda koja klikce na continue button
        /// </summary>
        public void ClickOnContinue()
        {
            ClickOnElement(continueButton);
        }

        /// <summary>
        /// Metoda koja cita text iz alert box-a
        /// </summary>
        public string GetTextFromAlertBox()
        {
            Thread.Sleep(500);
            return ReadTextFromElement(alertmessage);
        }


        /// <summary>
        /// Metoda koja popunjava polja na forgot password stranici
        /// </summary>
        public void ForgotPassword(string username, string email)
        {
            EnterUsername(username);
            EnterEmail(email);
            ClickOnContinue();

        }
    }

}
