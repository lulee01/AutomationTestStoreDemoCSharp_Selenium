using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace AutomationTestStoreDemoCSharp_Selenium.Pages
{
    public class LoginOrRegisterPage:BasePage
    {
        /// <summary>
        /// Defaultni konstruktor
        /// </summary>
        public LoginOrRegisterPage()
        {
            driver = null;
        }

        /// <summary>
        /// Parametrizovani konstruktor
        /// </summary>
        public LoginOrRegisterPage(IWebDriver webDriver)
        {
            driver = webDriver;
            
        }


        //Locators
        By registerButton = By.XPath("//button[@title='Continue']");
        By nameField= By.Id("AccountFrm_firstname");
        By lastNameField = By.Id("AccountFrm_lastname");
        By emailField = By.Id("AccountFrm_email");
        By adressField = By.Id("AccountFrm_address_1");
        By cityField = By.Id("AccountFrm_city");
        By fromRegionDropdown = By.Id("AccountFrm_zone_id");
        By zipField = By.Id("AccountFrm_postcode");
        By fromCountryDropDown = By.Id("AccountFrm_country_id");
        By usernameField = By.Id("AccountFrm_loginname");
        By passwordField = By.Id("AccountFrm_password");
        By passwordConfirmField = By.Id("AccountFrm_confirm");
        By subscribeRadio = By.Id("AccountFrm_newsletter1");
        By agreeCheck = By.Id("AccountFrm_agree");
        By continueButton = By.XPath("//button[@title='Continue']");
        By messageField = By.XPath("//span[@class='maintext']");
        By loginUsernameField = By.Id("loginFrm_loginname");
        By loginPasswordField = By.Id("loginFrm_password");
        By lognButton = By.XPath("//button[@title='Login']");
        By loginMessageField=By.XPath("//span[contains(.,' My Account')]");
        By forgotButton = By.XPath("//a[contains(.,'Forgot your password?')]");
        By forgotLoginButton = By.XPath("//a[contains(.,'Forgot your login?')]");


        /// <summary>
        /// Metoda klikce na register button
        /// </summary>
        private void ClickOnRegister()
        {
            ClickOnElement(registerButton);
        }

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

        /// <summary>
        /// Metoda unosi username 
        /// </summary>
        private void EnterUsername(string username)
        {
            WriteTextToElement(usernameField, username);
        }

        /// <summary>
        /// Metoda unosi password i ponavlja isti u sledecem polju
        /// </summary>
        private void EnterPassword(string password)
        {
            WriteTextToElement(passwordField, password);
            WriteTextToElement(passwordConfirmField, password);
        }

        /// <summary>
        /// Metoda klikce na radiobutton vezan za subscrition 
        /// </summary>
        private void Subscribe()
        {
            ClickOnElement(subscribeRadio);
        }

        /// <summary>
        /// Metoda klikce na check box za agree with terms 
        /// </summary>
        private void Agree()
        {
            ClickOnElement(agreeCheck);
        }

        /// <summary>
        /// Metoda klikce na continue 
        /// </summary>
        private void ClickOnContinue()
        {
            ClickOnElement(continueButton);
        }

        /// <summary>
        /// Metoda izvlaci poruku o uspesnoj registraciji 
        /// </summary>
        public string GetTextAfterRegistration()
        {
            return ReadTextFromElement(messageField);
        }

        /// <summary>
        /// Metoda unosi username za login 
        /// </summary>
        private void EnterLoginUsername(string username)
        {
            WriteTextToElement(loginUsernameField, username);
        }

        /// <summary>
        /// Metoda unosi password za login 
        /// </summary>
        private void EnterLoginPassword(string password)
        {
            WriteTextToElement(loginPasswordField, password);
        }

        /// <summary>
        /// Metoda klikce na dugme Login 
        /// </summary>
        private void ClickcOnLogin()
        {
            ClickOnElement(lognButton);
        }

        /// <summary>
        /// Metoda izvlaci poruku o uspensom logovanju 
        /// </summary>
        public string GetTextAfterLogin()
        {
            return ReadTextFromElement(loginMessageField);
        }

        /// <summary>
        /// Metoda klikce na forgot password dugme
        /// </summary>
        public void ClickOnForgotPassword()
        {
            ClickOnElement(forgotButton);
        }

        /// <summary>
        /// Metoda koja klikce na forgot login dugme
        /// </summary>
        public void ClickOnForgotLogin()
        {
            ClickOnElement(forgotLoginButton);
        }

        /// <summary>
        /// Metoda koja popunjava polja na register strani
        /// </summary>
        public void Register(string name, string lastname, string email, string adress, string city, string region, string zip, string country, string username, string password)
        {
            ClickOnRegister();
            EnterName(name);
            EnterLastName(lastname);
            EnterEmail(email);
            EnterAdress(adress);
            EnterCity(city);
            SelectRegion(region);
            EnterZip(zip);
            SelectCountry(country);
            EnterUsername(username);
            EnterPassword(password);
            Subscribe();
            Agree();
            ClickOnContinue();

        }

        public void Login(string username, string password)
        {
            EnterLoginUsername(username);
            EnterLoginPassword(password);
            ClickcOnLogin();
        }
    }

}
