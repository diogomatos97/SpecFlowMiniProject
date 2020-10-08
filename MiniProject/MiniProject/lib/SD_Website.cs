using MiniProject.lib.pages;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProject
{
    public class SD_Website
    {
        public IWebDriver SeleniumDriver { get; internal set; }
        public SD_Homepage SD_Homepage { get; set; }
        public SD_Products SD_Products { get; set; }
        public SD_Cart SD_Cart { get; set; }
        public SD_Checkout SD_Checkout { get; set; }
        public SD_CheckoutStepTwo SD_CheckoutStepTwo { get; set; }


        public SD_Website(string driverName, int pageLoadWaitInSecs = 10, int implicitWaitInSecs = 20)
        {
            SeleniumDriver = new SeleniumDriverConfig(driverName, pageLoadWaitInSecs, implicitWaitInSecs).Driver;
            SD_Homepage = new SD_Homepage(SeleniumDriver);
            SD_Products = new SD_Products(SeleniumDriver);
            SD_Cart = new SD_Cart(SeleniumDriver);
            SD_Checkout = new SD_Checkout(SeleniumDriver);
            SD_CheckoutStepTwo = new SD_CheckoutStepTwo(SeleniumDriver);

            ;
        }
    }
}
