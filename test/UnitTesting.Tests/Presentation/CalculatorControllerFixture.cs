using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTesting.WebUi.Controllers;
using UnitTesting.Tests;
using UnitTesting.WebUi.Models;

namespace UnitTesting.Tests.Presentation
{
    [TestClass]
    public class CalculatorControllerFixture
    {
        private CalculatorController _SystemUnderTest;

        public CalculatorController SystemUnderTest
        {
            get
            {
                if (_SystemUnderTest == null)
                    _SystemUnderTest = new CalculatorController();

                return _SystemUnderTest;
            }
        }

        [TestMethod]
        public void CalculatorController_Index_ModelIsNotNull()
        {
            var actual = 
                UnitTestUtility.GetModel<CalculatorViewModel>(
                SystemUnderTest.Index());


            Assert.IsNotNull(actual, "Model was null");
        }
    }
}