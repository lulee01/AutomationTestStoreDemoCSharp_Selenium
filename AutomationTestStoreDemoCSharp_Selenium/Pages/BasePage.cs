using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace AutomationTestStoreDemoCSharp_Selenium.Pages
{
    public class BasePage
    {
        // Driver
        public IWebDriver? driver;
        // WebDriverWait
        public WebDriverWait wait;
        /// <summary>
        /// Metoda koja ceka da element postane vidljiv
        /// </summary>
        private void WaitElementVisibility(By elementBy)
        {
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(elementBy));
        }
        /// <summary>
        /// Metoda koju koristimo da kliknemo na element
        /// </summary>
        public void ClickOnElement(By element)
        {
            WaitElementVisibility(element);
            driver.FindElement(element).Click();
        }


        /// <summary>
        /// Metoda koja upisuje vrednost u polje
        /// </summary>
        public void WriteTextToElement(By element, string text)
        {
            WaitElementVisibility(element);
            driver.FindElement(element).SendKeys(text);
        }

        /// <summary>
        /// Metoda koja upisuje string kroz parametar int
        /// </summary>
        public void WriteTextToElement(By element, long number)
        {
            WaitElementVisibility(element);
            driver.FindElement(element).SendKeys(number.ToString());
        }

        /// <summary>
        /// Metoda koja cita text iz elementa
        /// </summary>
        public string ReadTextFromElement(By element)
        {
            WaitElementVisibility(element);
            return driver.FindElement(element).Text;
        }

        /// <summary>
        /// Metoda koja cita text iz alert box-a
        /// </summary>
        public string ReadTextFromAlertBox()
        {
            Thread.Sleep(1000);
            return driver.SwitchTo().Alert().Text;
        }

        /// <summary>
        /// Metoda koja potvrdjuje alert box
        /// </summary>
        public void AcceptAlertBox()
        {
            Thread.Sleep(1000);
            driver.SwitchTo().Alert().Accept();
        }
     

    }
}

