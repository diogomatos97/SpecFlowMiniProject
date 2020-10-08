using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProject.lib.pages
{
    public class SD_CheckoutStepTwo
    {
        private IWebDriver _driver;
        private string PageUrl = AppConfigReader.CheckoutStepTwoUrl;
        private IWebDriver seleniumDriver;


        private IWebElement finishBtn => this._driver.FindElement(By.ClassName("cart_button"));

        public SD_CheckoutStepTwo(IWebDriver driver)
        {
            _driver = driver;
        }


        public void ClickFinish()
        {
            finishBtn.Click();
        }
        public void VisistPage()
        {

            _driver.Navigate().GoToUrl(PageUrl);
        }


    }
}
