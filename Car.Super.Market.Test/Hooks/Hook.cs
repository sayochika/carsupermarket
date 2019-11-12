using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace Car.Super.Market.Test.Hooks
{
    [Binding]
    public sealed class Hook : BaseClass
    {
       
        [BeforeScenario]
        public void BeforeScenario()
        {
            LaunchBrowser("Chrome");
        }

        [AfterScenario]
        public void AfterScenario()
        {
            CloseBrowser();
        }
    }
}
