using System;
using TechTalk.SpecFlow;
using NUnit.Framework;

namespace MiniProject
{
    [Binding]
    public class SDLoginSteps
    {
        public SD_Website SD_Website { get; } = new SD_Website("chrome");
        [Given(@"I am on the signin page")]
        public void GivenIAmOnTheSigninPage()
        {
            SD_Website.SD_Homepage.VisistHomePage();
        }

        [Given(@"I have entered the username ""(.*)""")]
        public void GivenIHaveEnteredTheUsername(string p0)
        {
            SD_Website.SD_Homepage.InputEmail(p0);
        }

        [Given(@"I have entered the password ""(.*)""")]
        public void GivenIHaveEnteredThePassword(string p0)
        {
            SD_Website.SD_Homepage.InputPassword(p0);
        }

        [When(@"I click the login button")]
        public void WhenIClickTheLoginButton()
        {
            SD_Website.SD_Homepage.ClickSignIn();
        }

        [Then(@"I should see an alert containing the error message ""(.*)""")]
        public void ThenIShouldSeeAnAlertContainingTheErrorMessage(string p0)
        {
            Assert.That(SD_Website.SD_Homepage.GetAlertText(), Does.Contain(p0));
        }

        [Then(@"I should be on the products page")]
        public void ThenIShouldBeOnTheProductsPage()
        {
            Assert.That(SD_Website.SeleniumDriver.Url, Is.EqualTo(AppConfigReader.ProductURL));
        }


        [AfterScenario]
        public void CleanUp()
        {

            SD_Website.SeleniumDriver.Quit();
            SD_Website.SeleniumDriver.Dispose();

        }
    }
}
