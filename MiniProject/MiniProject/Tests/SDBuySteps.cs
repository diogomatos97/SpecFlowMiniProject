using NUnit.Framework;
using NUnit.Framework.Interfaces;
using NUnit.Framework.Internal;
using System;
using System.ComponentModel.Design;
using TechTalk.SpecFlow;

namespace MiniProject
{
    [Binding]
    public class SDBuySteps
    {
        public SD_Website SD_Website { get; } = new SD_Website("chrome");
        [Given(@"I am loged in")]
        public void GivenIAmLogedIn()
        {
            SD_Website.SD_Homepage.VisistHomePage();
            SD_Website.SD_Homepage.InputEmail("standard_user");
            SD_Website.SD_Homepage.InputPassword("secret_sauce");
            SD_Website.SD_Homepage.ClickSignIn();

        }

        [When(@"I select a product")]
        public void WhenISelectAProduct()
        {
            SD_Website.SD_Products.ClickAddToCard();
        }
        [When(@"I select two products")]
        public void WhenISelectProducts()
        {
            SD_Website.SD_Products.ClickAddToCard();
            SD_Website.SD_Products.ClickAddToCard();
        }


        [Then(@"I should see the cart icon displaying ""(.*)""")]
        public void ThenIShouldSeeTheCartIconDisplaying(int p0)
        {
            Assert.That(int.Parse(SD_Website.SD_Products.CheckCart()), Is.EqualTo(p0));
        }

        [When(@"I Click on the cart button")]
        public void WhenIClickOnTheCartButton()
        {
            SD_Website.SD_Products.ClickCart();
        }

        [Then(@"I should see the cart page")]
        public void ThenIShouldSeeTheCartPage()
        {
            Assert.That(SD_Website.SeleniumDriver.Url, Is.EqualTo(AppConfigReader.CartUrl));
        }

        [Then(@"I should have a product displaying")]
        public void ThenIShouldHaveAProductDisplaying()
        {
            Assert.That(SD_Website.SD_Cart.CheckCartItems(), Is.EqualTo(1));
        }
        [When(@"I select (.*) product")]
        public void WhenISelectProduct(int p0)
        {
            for (int i = 0; i < p0; i++)
            {
                SD_Website.SD_Products.ClickAddToCard();
            }
        }

        [Then(@"I should have (.*) product displaying")]
        public void ThenIShouldHaveProductDisplaying(string p0)
        {
            Assert.That(SD_Website.SD_Cart.CheckCartItems(), Is.EqualTo(int.Parse(p0)));
        }


        [AfterScenario]
        public void CleanUp()
        {

            SD_Website.SeleniumDriver.Quit();
            SD_Website.SeleniumDriver.Dispose();

        }
    }
}
