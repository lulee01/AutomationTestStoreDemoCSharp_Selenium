using OpenQA.Selenium;

namespace AutomationTestStoreDemoCSharp_Selenium.Pages
{
    public class ContactUsPage:BasePage
    {
        /// <summary>
        /// Defaultni konstruktor
        /// </summary>
        public ContactUsPage()
        {
            driver = null;
        }

        /// <summary>
        /// Parametrizovani konstruktor
        /// </summary>
        public ContactUsPage(IWebDriver webDriver)
        {
            driver = webDriver;
        }

        //Locators
        By firstnameField = By.Id("ContactUsFrm_first_name");
        By emailField = By.Id("ContactUsFrm_email");
        By messageField = By.Id("ContactUsFrm_enquiry");
        By submitButton = By.XPath("//button [contains(.,'Submit')]");
        By continueButton = By.XPath("//a[contains(.,'Continue')]");

        /// <summary>
        /// Metoda koja unosi ime
        /// </summary>
        private void EnterFirstName(string name)
        {
            WriteTextToElement(firstnameField, name);
        }

        /// <summary>
        /// Metoda koja unosi email
        /// </summary>
        private void EnterEmail(string email)
        {
            WriteTextToElement(emailField, email);
        }

        /// <summary>
        /// Metoda koja unosi poruku
        /// </summary>
        private void EnterMessage(string message)
        {
            WriteTextToElement(messageField, message);
        }

        /// <summary>
        /// Metoda koja Klikce na submit 
        /// </summary>
        private void ClickOnSubmit()
        {
            ClickOnElement(submitButton);
        }

        /// <summary>
        /// Metoda cita tekst sa button-a
        /// </summary>
        /// <returns></returns>
        public string ReadtextFromButton()
        {
           return ReadTextFromElement(continueButton);
        }

        /// <summary>
        /// Metoda koja popunjava kontakt formu
        /// </summary>
        public void ContactUs(string name, string email, string message)
        {
            EnterFirstName(name);
            EnterEmail(email);
            EnterMessage(message);
            ClickOnSubmit();
        }

    }
}
