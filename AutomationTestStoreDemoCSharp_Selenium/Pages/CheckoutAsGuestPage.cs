using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;

namespace AutomationTestStoreDemoCSharp_Selenium.Pages
{
    public class CheckoutAsGuestPage:BasePage
    {
        /// <summary>
        /// Konstruktor bez parametara
        /// </summary>
        public CheckoutAsGuestPage()
        {
            driver = null;
        }

        /// <summary>
        /// Parametarizovani konstruktor
        /// </summary>
        /// <param name="webDriver">Driver</param>
        public CheckoutAsGuestPage(IWebDriver webDriver)
        {
            driver = webDriver;
        }

        // Locators
        By nameField = By.Id("guestFrm_firstname");
        By lastNameField = By.Id("guestFrm_lastname");
        By emailField = By.Id("guestFrm_email");
        By adressField = By.Id("guestFrm_address_1");
        By cityField = By.Id("guestFrm_city");
        By fromRegionDropdown = By.Id("guestFrm_zone_id");
        By zipField = By.Id("guestFrm_postcode");
        By fromCountryDropDown = By.Id("guestFrm_country_id");
        By continueButton = By.XPath("//button[@title='Continue']");

        /// <summary>
        /// Metoda unosi ime
        /// </summary>
        private void EnterName(string name)
        {
            WriteTextToElement(nameField, name);
        }

        /// <summary>
        /// Metoda unosi prezime
        /// </summary>
        private void EnterLastName(string lastname)
        {
            WriteTextToElement(lastNameField, lastname);
        }
        /// <summary>
        /// Metoda unosi email
        /// </summary>
        private void EnterEmail(string email)
        {
            WriteTextToElement(emailField, email);
        }

        /// <summary>
        /// Metoda unosi adresu 
        /// </summary>
        private void EnterAdress(string adress)
        {
            WriteTextToElement(adressField, adress);
        }

        /// <summary>
        /// Metoda unosi Grad
        /// </summary>
        private void EnterCity(string city)
        {
            WriteTextToElement(cityField, city);
        }

        /// <summary>
        /// Metoda iz padajuceg menija bira region
        /// </summary>
        private void SelectRegion(string region)
        {
            SelectElement select = new SelectElement(driver.FindElement(fromRegionDropdown));
            Thread.Sleep(1000);
            select.SelectByText(region);
        }

        /// <summary>
        /// Metoda unosi zip code
        /// </summary>
        private void EnterZip(string zip)
        {
            WriteTextToElement(zipField, zip);
        }

        /// <summary>
        /// Metoda iz padajuceg menija bira zemlju
        /// </summary>
        /// <param name="country"></param>
        private void SelectCountry(string country)
        {
            SelectElement select = new SelectElement(driver.FindElement(fromCountryDropDown));
            Thread.Sleep(1000);
            select.SelectByText(country);
        }
        private void ClickOnContinue()
        { 
            ClickOnElement(continueButton);
        }

        /// <summary>
        /// Metoda koja registruje korisnika sa samo neophodnim podacima
        /// </summary>
        public void GuestCheckoutForm(
           string name, string lastname, string email, string adress, string city, string region, string zip, string country)
        {
            EnterName(name);
            EnterLastName(lastname);
            EnterEmail(email);
            EnterAdress(adress);
            EnterCity(city);
            SelectRegion(region);
            EnterZip(zip);
            SelectCountry(country);
            ClickOnContinue();
        }
    }
}

