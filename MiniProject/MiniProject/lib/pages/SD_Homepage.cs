using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MiniProject
{
    public class SD_Homepage
    {
        private IWebDriver _driver;
        private string HomePageUrl = AppConfigReader.BaseUrl;
        private IWebDriver seleniumDriver;
        private IWebElement _emailField => this._driver.FindElement(By.Id("user-name"));
        private IWebElement _passwordField => this._driver.FindElement(By.Id("password"));
        private IWebElement _loginButton => this._driver.FindElement(By.Id("login-button"));
        private IWebElement _alert => this._driver.FindElement(By.CssSelector("[data-test='error']"));
        public SD_Homepage(IWebDriver driver)
        {
            _driver = driver;

        }

        public void VisistHomePage()
        {

            _driver.Navigate().GoToUrl(HomePageUrl);
        }

        public void InputEmail(string v)
        {
            _emailField.SendKeys(v);
        }

        public void InputPassword(string v)
        {
            _passwordField.SendKeys(v);
        }
        public void ClickSignIn()
        {
            _loginButton.Click();
        }
        public string GetAlertText()
        {
            Thread.Sleep(3000);
            return _alert.Text;
        }
    }
}
