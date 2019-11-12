using Car.Super.Market.Test.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace Car.Super.Market.Test.StepDefinitions
{
    [Binding]
    public sealed class SearchSteps : BaseClass
    {
        HomePage homePage = new HomePage();
        SearchResultPage searchResultPage = new SearchResultPage();

        [Given(@"I navigate to carsupermarket homepage")]
        public void GivenINavigateToCarsupermarketHomepage()
        {
            LaunchUrl("https://www.motors.co.uk/");
        }

        [When(@"I enter postcode as ""(.*)""")]
        public void WhenIEnterPostcodeAs(string postcode)
        {
            homePage.EnterPostcode(postcode);
        }


        [When(@"I select the car ""(.*)""")]
        public void WhenISelectTheCar(string make)
        {
            homePage.SelectCarMake(make);
        }

        [When(@"I select the corresponding car ""(.*)""")]
        public void WhenISelectTheCorrespondingCar(string model)
        {
            homePage.SelectCarModel(model);
        }

        [When(@"I click on the Search button")]
        public void WhenIClickOnTheSearchButton()
        {
            searchResultPage = homePage.ClickOnSearchButton();
        }

        [Then(@"car ""(.*)"" is displayed")]
        public void ThenCarIsDisplayed(string make)
        {

        }

    }
}
