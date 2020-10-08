using NUnit.Framework;
using TechTalk.SpecFlow;

namespace MiniProject.Tests
{
    [Binding]
    public class SDCheckoutSteps
    {
        public SD_Website SD_Website { get; } = new SD_Website("chrome");
        [Given(@"I am have selected a product")]
        public void GivenIAmHaveSelectedAProduct()
        {
            SD_Website.SD_Homepage.VisistHomePage();
            SD_Website.SD_Homepage.InputEmail("standard_user");
            SD_Website.SD_Homepage.InputPassword("secret_sauce");
            SD_Website.SD_Homepage.ClickSignIn();
            SD_Website.SD_Products.ClickAddToCard();
            SD_Website.SD_Products.ClickCart();
        }

        [Given(@"I am on the checkout page")]
        public void GivenIAmOnTheCheckoutPage()
        {
            SD_Website.SD_Checkout.VisistPage();
        }

        [Given(@"I am on the confirmation page")]
        public void GivenIAmOnTheConfirmationPage()
        {
            SD_Website.SD_CheckoutStepTwo.VisistPage();
        }

        [When(@"I click on the checkout button")]
        public void WhenIClickOnTheCheckoutButton()
        {
            SD_Website.SD_Cart.GoToCheckout();
        }

        [When(@"I fill the required field")]
        public void WhenIFillTheRequiredField()
        {
            SD_Website.SD_Checkout.InputFirstName("a");
            SD_Website.SD_Checkout.InputLastName("b");
            SD_Website.SD_Checkout.InputZipCode("c");
        }

        [When(@"I press continue")]
        public void WhenIPressContinue()
        {
            SD_Website.SD_Checkout.Checkout();
        }

        [When(@"I press finish")]
        public void WhenIPressFinish()
        {
            SD_Website.SD_CheckoutStepTwo.ClickFinish();
        }

        [Then(@"I should see the Checkout page")]
        public void ThenIShouldSeeTheCheckoutPage()
        {
            Assert.That(SD_Website.SeleniumDriver.Url, Is.EqualTo(AppConfigReader.CheckoutStepOneUrl));
        }

        [Then(@"I should be on the confirmation page")]
        public void ThenIShouldBeOnTheConfirmationPage()
        {
            Assert.That(SD_Website.SeleniumDriver.Url, Is.EqualTo(AppConfigReader.CheckoutStepTwoUrl));
        }

        [Then(@"I should see that my order has been dispatched")]
        public void ThenIShouldSeeThatMyOrderHasBeenDispatched()
        {
            Assert.That(SD_Website.SeleniumDriver.Url, Is.EqualTo(AppConfigReader.ConfirmedOrder));
        }

        [AfterScenario]
        public void CleanUp()
        {

            SD_Website.SeleniumDriver.Quit();
            SD_Website.SeleniumDriver.Dispose();

        }
    }
}
