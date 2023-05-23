using OpenQA.Selenium;

namespace AutomationTestStoreDemoCSharp_Selenium.Pages
{
    public class HomePage:BasePage
    {

        /// <summary>
        /// Defaultni konstruktor
        /// </summary>
        public HomePage()
        {
            driver = null;
        }
        /// <summary>
        /// Parametrizovani konstruktor
        /// </summary>
        public HomePage(IWebDriver webDriver)
        {
            driver=webDriver;
        }

        //Locators
        By loginButton = By.XPath("//a [contains(.,'Login or register')]");
        By contactButton = By.XPath("//a[contains(.,'Contact Us')]");
        By accountLink = By.LinkText("Account");
        By cartLink = By.XPath("//ul[@id='main_menu_top']/li[@data-id='menu_cart']/a");
        By homeButton = By.XPath("//img[contains(@title,'Automation Test Store')]");
        By searchBox = By.Id("filter_keyword");
        By searchButton = By.XPath("//div[@class='button-in-search']");
        By cartNumberBadge = By.XPath("//a[@class='dropdown-toggle']/span[contains(@class,'label-orange font14')]");
        By cartTotal = By.XPath("//a[@class='dropdown-toggle']/span[contains(@class,'cart_total')]");

        /// <summary>
        /// Metoda koja klikce na login
        /// </summary>
        public void ClickOnLogin()
        {
            ClickOnElement(loginButton);
        }

        /// <summary>
        /// Metoda koja klikce na contact button
        /// </summary>
        public void ClickOnCOntactUs()
        {
            ClickOnElement(contactButton);
        }

        /// <summary>
        /// metoda koja klikce na account link
        /// </summary>
        public void ClickOnAccount()
        {
            ClickOnElement(accountLink);
        }

        /// <summary>
        /// Metoda koja klikce na cart link
        /// </summary>
        public void ClickOnCart()
        {
            ClickOnElement(cartLink);
        }

        /// <summary>
        /// Metoda koja dodaje proizvod u korpu sa homepage-a na osnovu njegovog id-a
        /// </summary>
        public void AddProductFromIndex(string itemid)
        {
            Thread.Sleep(500);
            ClickOnElement(By.XPath($"//a[@data-id='{itemid}']"));
        }

        /// <summary>
        /// Metoda koja klikce na home button
        /// </summary>
        public void ClickonHome()
        {
            ClickOnElement(homeButton);
        }

        /// <summary>
        /// Metoda koja dodaje proizvode u korpu sa indeksima na osnovu njihovih imena
        /// </summary>
        public void ClickOnProduct(string itemName = "Acqua Di Gio Pour Homme")
        {
            ClickOnElement(By.XPath($"//a[@title='{itemName}']"));
        }

        /// <summary>
        /// Metoda koja u Search Box upisuje ime proizvoda i trazi ga
        /// </summary>
        public void SearchProduct(string itemName = "New French With Ease")
        {
            Thread.Sleep(500);
            WriteTextToElement(searchBox, itemName);
            ClickOnElement(searchButton);
        }

        /// <summary>
        /// Metoda koja prosledjuje broj proizvoda u korpi
        /// </summary>
        public int CartBadgeCount()
        {
            Thread.Sleep(200);
            string totalnumber = ReadTextFromElement(cartNumberBadge);
            return int.Parse(totalnumber);
        }

        /// <summary>
        /// Metoda koja prosledjuje ukupnu cenu proizvoda iz korpe
        /// </summary>
        public string GetCartTotal()
        {
            return ReadTextFromElement(cartTotal);
        }

        /// <summary>
        /// Metoda koja uzima cenu artikla
        /// </summary>

        private string GetProductPrice(string itemId)
        {
            return ReadTextFromElement(By.XPath($"(//div[contains(@class, 'pricetag jumbotron')]/a[@data-id={itemId}]/..//div[@class='oneprice'])[1]"));
        }


        /// <summary>
        /// Metoda koja vraca ukupnu sumu proizvoda
        /// </summary>
        public string AddToTotal(string itemId)
        {
            AddProductFromIndex(itemId);
            return GetProductPrice(itemId);
        }

    }
}
