using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace S4.Tests
{
    [TestFixture]
    internal class EnviromentTests
    {
        private int _four;

        [OneTimeSetUp]
        public void SetUp()
        {
            _four = 4;
        }

        [Test]
        public void TwoPlusTwoIsFour()
        {
            Assert.AreEqual(2 + 2, _four);
        }
    }
}
