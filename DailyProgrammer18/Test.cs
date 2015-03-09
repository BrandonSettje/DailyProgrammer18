using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace DailyProgrammer18
{
    [TestFixture]
    class Test
    {

        [Test, SetUp]
        public void TestExample1()
        {
            Assert.That(Program.dialerSwitcher() == "1-800-DashHit");

        }
        [Test]
        public void TestExample2()
        {
            Assert.That(Program.dialerSwitcher() == "1800FastZiP");
        }
    }
}
