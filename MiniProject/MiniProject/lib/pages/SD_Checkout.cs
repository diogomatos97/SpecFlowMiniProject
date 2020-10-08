using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProject.lib.pages
{
    public class SD_Checkout
    {
        private IWebDriver _driver;
        private string PageUrl = AppConfigReader.CheckoutStepOneUrl;
        private IWebDriver seleniumDriver;
        private IWebElement fName => this._driver.FindElement(By.Id("first-name"));
        private IWebElement lName => this._driver.FindElement(By.Id("last-name"));
        private IWebElement zipCode => this._driver.FindElement(By.Id("postal-code"));

        private IWebElement checkoutBtn => this._driver.FindElement(By.ClassName("cart_button"));

        public SD_Checkout(IWebDriver driver)
        {
            _driver = driver;
        }

        public void InputFirstName(string v)
        {
            fName.SendKeys(v);
        }
        public void InputLastName(string v)
        {
            lName.SendKeys(v);
        }
        public void InputZipCode(string v)
        {
            zipCode.SendKeys(v);
        }

        public void Checkout()
        {
            checkoutBtn.Click();
        }
        public void VisistPage()
        {

            _driver.Navigate().GoToUrl(PageUrl);
        }


    }
}
