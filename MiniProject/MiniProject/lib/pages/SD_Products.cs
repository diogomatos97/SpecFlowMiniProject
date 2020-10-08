using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProject.lib.pages
{
    public class SD_Products
    {

        private IWebDriver _driver;
        private string PageURL = AppConfigReader.ProductURL;
        private IWebDriver seleniumDriver;
        private int rndProd;
        private IWebElement btnProduct => _driver.FindElement(By.CssSelector($".inventory_item:nth-child({rndProd}) .btn_primary"));
        private IWebElement cart => _driver.FindElement(By.ClassName("shopping_cart_badge"));
        private IWebElement cartBtn => _driver.FindElement(By.ClassName("shopping_cart_link"));

        public SD_Products(IWebDriver driver)
        {
            _driver = driver;

        }

        public void VisistProductPage()
        {

            _driver.Navigate().GoToUrl(PageURL);
        }
        public void ClickAddToCard()
        {
            rndProd = new Random().Next(1, 6);
            btnProduct.Click();
        }
        public string CheckCart()
        {
            return cart.Text;
        }
        public void ClickCart()
        {
            cartBtn.Click();

        }





    }
}
