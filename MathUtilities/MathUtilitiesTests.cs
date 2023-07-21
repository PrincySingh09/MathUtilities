using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using MathUtilities;

namespace MathUtilitiesTests
{
    [TestFixture]
    public class MathUtilitiesTests
    {
        private MathUtility _mathUtility;
        [SetUp]
        public void SetUp()
        {
            _mathUtility = new MathUtility();
        }
        [TestCase(1,2,3)]
        [TestCase(0,0,0)]
        [TestCase(-1,-2,-3)]
        public void AddTest(int a, int b, int expectedResult)
        {
            var result = _mathUtility.Add(a,b);
            Assert.AreEqual(expectedResult, result);
        }
        [TestCase(2,1,1)]
        [TestCase(0,0,0)]
        [TestCase(-1,-2,1)]
        public void SubtractTest(int a, int b, int expectedResult)
        {
            var result= _mathUtility.Subtract(a,b);
            Assert.AreEqual(expectedResult, result);
        }
        [TestCase(2,2,4)]
        [TestCase(0,0,0)]
        [TestCase(-1,-2,2)]
        public void MultiplyTest(int a, int b, int expectedResult)
        {
            var result=_mathUtility.Multiply(a,b);
            Assert.AreEqual(expectedResult, result);
        }
        [TestCase(4,2,2)]
        [TestCase(0,1,0)]
        public void DivideTest(int a, int b, int expectedResult)
        {
            var result=_mathUtility.Divide(a,b);
            Assert.AreEqual(expectedResult, result);
        }
        [Test]
        public void DivideByZeroTest()
        {
            Assert.Throws<System.DivideByZeroException>(()=>_mathUtility.Divide(1,0));
        }
        [TestCase(2,true)]
        [TestCase(3,true)]
        [TestCase(4,false)]
        [TestCase(0,false)]
        [TestCase(-1,false)]
        public void IsPrimeTest(int number,bool exceptedResult)
        {
            var result= _mathUtility.IsPrime(number);
            Assert.AreEqual(exceptedResult, result);
        }
    }
}
