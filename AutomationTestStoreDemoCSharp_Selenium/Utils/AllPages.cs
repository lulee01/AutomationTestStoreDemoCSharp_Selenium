using AutomationTestStoreDemoCSharp_Selenium.Pages;
using SeleniumExtras.PageObjects;

namespace AutomationTestStoreDemoCSharp_Selenium.Utils
{
    public class AllPages
    {
        public AllPages(Browsers browser)
        {
            _browser = browser;
        }
        Browsers _browser { get; }
        private T GetPages<T>() where T : new()
        {
            var page = (T)Activator.CreateInstance(typeof(T), _browser.GetDriver);
            PageFactory.InitElements(_browser.GetDriver, page);
            return page;
        }
        public LoginOrRegisterPage LoginOrRegisterPage => GetPages<LoginOrRegisterPage>();
        public HomePage HomePage => GetPages<HomePage>();
        public ForgotPasswordPage ForgotPasswordPage => GetPages<ForgotPasswordPage>();
        public AccountPage AccountPage => GetPages<AccountPage>();

        public ForgotLoginPage ForgotLoginPage => GetPages<ForgotLoginPage>();
        public ContactUsPage ContactUsPage => GetPages<ContactUsPage>();
        public CartPage CartPage => GetPages<CartPage>();
        public ProductPage ProductPage => GetPages<ProductPage>();
        public CheckoutPage ChechoutPage => GetPages<CheckoutPage>();
        public CheckoutAsGuestPage CheckoutAsGuestPage => GetPages<CheckoutAsGuestPage>();    
    }
}
