using OpenQA.Selenium;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProject.lib.pages
{
    public class SD_Cart
    {
        private IWebDriver _driver;
        private string PageUrl = AppConfigReader.CartUrl;
        private IWebDriver seleniumDriver;
        private int cartContainer => this._driver.FindElements(By.ClassName("cart_item")).Count();
        private IWebElement checkoutBtn => this._driver.FindElement(By.ClassName("checkout_button"));
        public SD_Cart(IWebDriver driver)
        {
            _driver = driver;
        }
        public int CheckCartItems()
        {
            return cartContainer;
        }
        public void GoToCheckout()
        {
            checkoutBtn.Click();
        }
    }

}
