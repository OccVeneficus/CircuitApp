using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using CircutApp;
using CircutApp.Elements;
using NUnit.Framework;

namespace CircuitAppUnitTests
{
    [TestFixture]
    public class ResistorTest
    {
        private Resistor _resistor;

        public void Initialize()
        {
            _resistor = new Resistor();
        }

        [Test(Description = "Test resistor CalculateImpedance method")]
        public void ResistorCalculateZTest()
        {
            Initialize();
            _resistor.Value = 30.0;
            Complex expected = new Complex(30.0,0);
            Complex actual = _resistor.CalculateImpedance(32);
            Assert.AreEqual(expected,actual,"Wrong impedance calculation");
        }
    }
}
