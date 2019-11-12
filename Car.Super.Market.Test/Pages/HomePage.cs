using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car.Super.Market.Test.Pages
{
    public class HomePage : BaseClass
    {
        IWebElement carMake;
        IWebElement customerPostcode;
        IWebElement carModel;
        IWebElement submitButton;


        public void EnterPostcode(string pCode)
        {
            customerPostcode = GetElementByName("PostCode");
            customerPostcode.SendKeys(pCode);
        }
        public void SelectCarMake(string make)
        {
            carMake = GetElementByName("Make");
            SelectByText(carMake, make);
        }

        public void SelectCarModel(string model)
        {
            carModel = GetElementByName("Model");
            SelectByText(carModel, model);
        }

        public SearchResultPage ClickOnSearchButton()
        {
            submitButton = GetElementByCssSelector(".btn.sp__btn");
            submitButton.Click();

            return new SearchResultPage();
        }
    }
}
