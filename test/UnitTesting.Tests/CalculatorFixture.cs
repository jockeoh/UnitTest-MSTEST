using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTesting.Api;

namespace UnitTesting.Tests
{
    [TestClass]
    public class CalculatorFixture
    {
        [TestInitialize]
        public void OnTestInitialize()
        {
            _SystemUnderTest = null;
        }

        private Calculator _SystemUnderTest;
        public Calculator SystemUnderTest
        { get
            {
                if (_SystemUnderTest == null)
                {
                    _SystemUnderTest = new Calculator();
                }

                return _SystemUnderTest;
            }
        }

        [TestMethod]
        public void Add()
        {
            //arrange
            int value1 = 3;
            int value2 = 2;
            int expected = 5;

            //act


            int actual = SystemUnderTest.Add(value1, value2);

            //assert
            Assert.AreEqual<int>(expected, actual, "Wrong result");
        }

        [TestMethod]
        public void Subtract()
        {
            //arrange
            int value1 = 6;
            int value2 = 2;
            int expected = 4;

            //act


            int actual = SystemUnderTest.Subtract(value1, value2);

            //assert
            Assert.AreEqual<int>(expected, actual, "Wrong result");
        }
    }
}
