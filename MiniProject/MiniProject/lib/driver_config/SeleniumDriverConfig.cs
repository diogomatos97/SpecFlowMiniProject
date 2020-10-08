using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProject
{
    public class SeleniumDriverConfig
    {
        public IWebDriver Driver { get; set; }

        public SeleniumDriverConfig(string driver, int pageLoadInSecs, int implicitWaitInSecs)
        {
            DriverSetUp(driver, pageLoadInSecs, implicitWaitInSecs);
        }

        public void DriverSetUp(string driver, int pageLoadInSecs, int implicitWaitInSecs)
        {
            if (driver.ToLower() == "chrome")
            {
                SetChromeDriver();
                SetDriverConfiguration(pageLoadInSecs, implicitWaitInSecs);
            }

            else { throw new Exception("Please use 'chrome'"); }
        }

        public void SetChromeDriver()
        {   //set up incognito mode
            ChromeOptions options = new ChromeOptions();
            options.AddArguments("--incognito");
            options.AddArgument("headless");
            Driver = new ChromeDriver(options);
        }

        public void SetDriverConfiguration(int pageLoadInSecs, int implicitWaitInSecs)
        {
            Driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(pageLoadInSecs);
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(implicitWaitInSecs);
        }
    }
}
