using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using CircutApp;
using NUnit.Framework;

namespace CircuitAppUnitTests
{
    [TestFixture]
    public class SerialCircuitTest
    {
        private SerialSegment _serialSegment;

        public void Initialize()
        {
            _serialSegment = new SerialSegment();
        }

        [Test(Description = "Serial circuit CalculateZ method test")]
        public void SerialCircuitCalculateZTest()
        {
            Initialize();
            Complex expected = new Complex(30.0, -525.80408799259965);
            Resistor R1 = new Resistor(){Value = 30.0};
            Inductor L1 = new Inductor(){Value = 0.015};
            Capacitor C1 = new Capacitor(){Value = 6e-6};
            _serialSegment.SubSegments.Add(R1);
            _serialSegment.SubSegments.Add(L1);
            _serialSegment.SubSegments.Add(C1);
            Complex actual = _serialSegment.CalculateZ(50.0);
            Assert.AreEqual(expected, actual, "Wrong impedance calculations");
        }

        [Test(Description = "Test PropertyChanged event firing")]
        public void SerialCircuitPropertyChangedEvent_Firing()
        {
            Initialize();
            var wasCalled = false;
            _serialSegment.PropertyChanged += (o, e) => wasCalled = true;
            _serialSegment.SubSegments.Add(new Resistor());
            Assert.IsTrue(wasCalled,"Event wasn't called");
        }
    }
}
