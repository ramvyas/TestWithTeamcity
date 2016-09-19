using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using NUnit.Framework;

namespace PlaySpecflowReport
{
    [Binding]
    public class AdditionStpes
    {
        private int x;
        private int y;
        private int z;
        [Given(@"I have entered '(.*)' into the calculator")]
        public void GivenIHaveEnteredIntoTheCalculator(int num1)
        {
            x = num1;
        }
        
        [Given(@"I have entered '(.*)' into the calculator as second number")]
        public void GivenIHavendnumEnteredIntoTheCalculator(int num2)
        {
            y = num2;
        }

        [When(@"I press add")]
        public void WhenIPressAdd()
        {
            z = x + y;
        }

        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(int result)
        {
            Assert.AreEqual(z, result);
        }


    }
}
