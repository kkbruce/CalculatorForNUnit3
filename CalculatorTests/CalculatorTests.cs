using NUnit.Framework;
using Calculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Tests
{
    [TestFixture()]
    public class CalculatorTests
    {
        [Test()]
        public void Add_整數5加5_得整數10()
        {
            var first = 5;
            var second = 5;
            var expected = 10;

            var target = new Calculator();
            var actual = target.Add(first, second);

            Assert.AreEqual(expected, actual);
        }

        [Test()]
        public void Add_浮點5點4加5點4_得浮點10點9()
        {
            var first = 5.4;
            var second = 5.4;
            var expected = 10.8;

            var target = new Calculator();
            var actual = target.Add(first, second);

            Assert.AreEqual(expected, actual);
        }
    }
}