using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTesting.WebUi.Controllers;
using UnitTesting.Tests;
using UnitTesting.WebUi.Models;
using System.Linq;
using System.Collections.Generic;

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
                {
                    _SystemUnderTest = new CalculatorController();
                }

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

        [TestMethod]
        public void CalculatorController_Index_Model_Value1IsInitialized()
        {
            var model =
                UnitTestUtility.GetModel<CalculatorViewModel>(
                SystemUnderTest.Index());

            var actual = model.Value1;

            var expected = 0d;

            Assert.AreEqual<double>(expected, actual, "Value1 field value was wrong");
        }

        [TestMethod]
        public void CalculatorController_Index_Model_Value2IsInitialized()
        {
            var model =
                UnitTestUtility.GetModel<CalculatorViewModel>(
                SystemUnderTest.Index());

            var actual = model.Value2;

            var expected = 0d;

            Assert.AreEqual<double>(expected, actual, "Value2 field value was wrong");
        }

        [TestMethod]
        public void CalculatorController_Index_Model_OperatorIsInitialized()
        {
            var model =
                UnitTestUtility.GetModel<CalculatorViewModel>(
                SystemUnderTest.Index());

            var actual = model.Operator;

            var expected = CalculatorConstants.Message_ChooseAnOperator;

            Assert.AreEqual<string>(expected, actual, "Operator field value was wrong");
        }

        [TestMethod]
        public void CalculatorController_Index_Model_MessageIsInitialized()
        {
            var model =
                UnitTestUtility.GetModel<CalculatorViewModel>(
                SystemUnderTest.Index());

            var actual = model.Message;

            var expected = string.Empty;

            Assert.AreEqual<string>(expected, actual, "Message field value was wrong");
        }

        [TestMethod]
        public void CalculatorController_Index_Model_IsResultValidShouldBeFalse()
        {
            var model =
                UnitTestUtility.GetModel<CalculatorViewModel>(
                SystemUnderTest.Index());

            var actual = model.IsResultValid;

            var expected = false;

            Assert.AreEqual<bool>(expected, actual, "Operator field value was wrong");
        }

        [TestMethod]
        public void CalculatorController_Index_Model_OperatorsCollectionIsPopulated()
        {
            var model =
                UnitTestUtility.GetModel<CalculatorViewModel>(
                SystemUnderTest.Index());

            Assert.IsNotNull(model.Operators, "Operators collection was null");

            var actual = model.Operators.Select(x => x.Text).ToList();

            var expected = new List<string>();

            expected.Add(CalculatorConstants.Message_ChooseAnOperator);
            expected.Add(CalculatorConstants.OperatorAdd);
            expected.Add(CalculatorConstants.OperatorSubtract);
            expected.Add(CalculatorConstants.OperatorMultiply);
            expected.Add(CalculatorConstants.OperatorDivide);


            CollectionAssert.AreEqual(expected, actual, "Wrong values in operators collection");
        }
    }
}