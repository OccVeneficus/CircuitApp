using System;
using System.Collections.Generic;
using System.Numerics;
using CircutApp;
using NUnit.Framework;

namespace CircuitAppUnitTests
{
    [TestFixture]
    public class CircuitTest
    {
        private Circuit _circuit;

        private void InitiateCircuit()
        {
            _circuit = new Circuit();
        }

        [Test(Description = "Test circuit name property get")]
        public void TestCircuitName_PositiveGetSet()
        {
            InitiateCircuit();
            string expected = "Test";
            _circuit.Name = "Test";
            Assert.AreEqual(expected,_circuit.Name,"Returned wrong value");
        }

        [TestCase("", "Exception expected when name is empty string",
            TestName = "Set empty string as circuit name")]
        [TestCase("test-test-test-test-test-test-test-test-test-test",
            "Exception expected when name is more than 40 characters",
            TestName = "Set more than 40 characters as name")]
        public void TestCircuitName_ArgumentException(string wrongName, string message)
        {
            InitiateCircuit();
            Assert.Throws<ArgumentException>(() => { _circuit.Name = wrongName; }, message);
        }

        [Test(Description = "Checking CircuitChanged event")]
        public void TestCircuitChangedEvent_EventFiring()
        {
            InitiateCircuit();
            var wasCalled = false;
            _circuit.CircuitChanged += (o, e) => wasCalled = true;
            _circuit.SubSegments.Add(new Resistor());
            Assert.IsTrue(wasCalled);
        }

        [Test(Description = "Checking CalculateZ method")]
        public void TestCircuitCalculateZ_ValidData()
        {
            InitiateCircuit();
            ParallelSegment p = new ParallelSegment();
            SerialSegment s = new SerialSegment();
            Resistor r1 = new Resistor(){Value = 30.0};
            Capacitor c1 = new Capacitor(){Name = "C1",Value = 2e-6};
            Capacitor c2 = new Capacitor(){Name = "C2",Value = 6e-6};
            p.SubSegments.Add(c1);
            p.SubSegments.Add(c2);
            s.SubSegments.Add(r1);
            s.SubSegments.Add(p);
            _circuit.SubSegments.Add(s);
            List<Complex> result = _circuit.CalculateZ(new List<double>()
                {100, 200, 300});
            List<Complex> trueResult = new List<Complex>()
            {
                new Complex(30.0,-198.94367886486916),
                new Complex(30.0,-99.471839432434578),
                new Complex(30.0,-66.314559621623062)
            };
            CollectionAssert.AreEqual(result,trueResult, "Wrong calculations");
        }

        [Test(Description = "Checking CalculateZ method with empty subsegments")]
        public void TestCalculateZ_EmptySubSegments()
        {
            InitiateCircuit();
            List<Complex> expected = new List<Complex>() {Complex.Zero};
            List<Complex> actual = _circuit.CalculateZ(new List<double>() {100.0});
            CollectionAssert.AreEqual(expected,actual, "Method return not Complex.Zero with empty subsegments");
        }
    }
}
