using System;
using NUnit.Framework;
using Calculator;

namespace CalculatorTesting
{
    public class CalculatorTesting
    {
        Calculations calculations;
        [SetUp]
        public void Init()
        {
            calculations = new Calculations();
        }
        [Test]
        public void TestSumTwoPositives()
        {
            Assert.AreEqual(4, calculations.Calculate(2, 2, Calculations.Operations.Add));
        }
        [Test]
        public void TestSumTwoNegatives()
        {
            Assert.AreEqual(-4, calculations.Calculate(-2, -2, Calculations.Operations.Add));
        }
        [Test]
        public void TestSumTwoDifferentSigns()
        {
            Assert.AreEqual(0, calculations.Calculate(-2, 2, Calculations.Operations.Add));
        }
        [Test]
        public void TestSubTwoPositives()
        {
            Assert.AreEqual(0, calculations.Calculate(2, 2, Calculations.Operations.Subtract));
        }
        [Test]
        public void TestSubTwoNegatives()
        {
            Assert.AreEqual(0, calculations.Calculate(-2, -2, Calculations.Operations.Subtract));
        }
        [Test]
        public void TestSubTwoDifferentSigns()
        {
            Assert.AreEqual(-4, calculations.Calculate(-2, 2, Calculations.Operations.Subtract));
        }
        [Test]
        public void TestMulTwoPositives()
        {
            Assert.AreEqual(4, calculations.Calculate(2, 2, Calculations.Operations.Multiply));
        }
        [Test]
        public void TestMulTwoNegatives()
        {
            Assert.AreEqual(4, calculations.Calculate(-2, -2, Calculations.Operations.Multiply));
        }
        [Test]
        public void TestMulTwoDifferentSigns()
        {
            Assert.AreEqual(-4, calculations.Calculate(-2, 2, Calculations.Operations.Multiply));
        }
        [Test]
        public void TestDivTwoPositives()
        {
            Assert.AreEqual(2, calculations.Calculate(4, 2, Calculations.Operations.Divide));
        }
        [Test]
        public void TestDivTwoNegatives()
        {
            Assert.AreEqual(2, calculations.Calculate(-4, -2, Calculations.Operations.Divide));
        }
        [Test]
        public void TestDivTwoDifferentSigns()
        {
            Assert.AreEqual(-2, calculations.Calculate(-4, 2, Calculations.Operations.Divide));
        }
        [Test]
        public void TestDivZeroThrowsDivisionByZeroException()
        {
            Assert.That(() => calculations.Calculate(4, 0, Calculations.Operations.Divide), Throws.InstanceOf<DivideByZeroException>());
        }
        [Test]
        public void TestWrongOperationThrowsArgumentException()
        {
            Assert.That(() => calculations.Calculate(4, 0, (Calculations.Operations)67), Throws.InstanceOf<ArgumentException>());
        }
    }
}
