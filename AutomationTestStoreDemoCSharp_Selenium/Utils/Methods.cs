using OpenQA.Selenium;

namespace AutomationTestStoreDemoCSharp_Selenium.Utils
{
    public class Methods
    {
        /// <summary>
        /// Metoda koja generise random username
        /// </summary>
        public static string GenerateRandomUsername(string randomName)
        {
            Random random = new Random();
            int randomNumber = random.Next(20, 9999);
            string username = randomName + randomNumber;
            return username;
        }

        /// <summary>
        /// Metoda koja generise random email
        /// </summary>
        public static string GenerateRandomemail(string randomName)
        {
            Random random = new Random();
            int randomNumber = random.Next(20, 9999);
            string email = randomName + randomNumber + "@mail.com";
            return email;
        }

        /// <summary>
        /// Metoda koja generise random password
        /// </summary>

        public static int GeneratePassword(int from, int to)
        {
            Random random = new Random();
            int randomNumber = random.Next(from, to);
            return randomNumber;
        }

        /// <summary>
        /// Metoda koja proverava da li element postoji
        /// </summary>
        /// <param name="driver">driver</param>
        /// <param name="elementBy">lokator elementa By</param>
        /// <returns>Vraca true/false</returns>
        public static bool IsElementPresent(IWebDriver driver, By elementBy)
        {
            try
            {
                return driver.FindElement(elementBy).Displayed;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
