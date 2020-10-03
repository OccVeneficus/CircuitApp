using System.Numerics;
using CircutApp;
using NUnit.Framework;

namespace CircuitAppUnitTests
{
    [TestFixture]
    public class ParallelCircuitTest
    {
        private ParallelCircuit _parallelCircuit;

        public void Initialize()
        {
            _parallelCircuit = new ParallelCircuit();
        }

        [Test(Description = "Test CalculateZ method in parallel segment")]
        public void ParallelCircuitCalculateZTest()
        {
            Initialize();
            Capacitor c1 = new Capacitor() { Name = "C1", Value = 2e-6 };
            Capacitor c2 = new Capacitor() { Name = "C2", Value = 6e-6 };
            _parallelCircuit.SubSegments.Add(c1);
            _parallelCircuit.SubSegments.Add(c2);
            Complex expected = new Complex(0, -198.94367886486916);
            Complex actual = _parallelCircuit.CalculateZ(100.0);
            Assert.AreEqual(expected, actual, "Wrong calculations");
        }

        [Test(Description = "Test PropertyChanged event firing")]
        public void ParallelCircuitPropertyChangedEvent_Firing()
        {
            Initialize();
            var wasCalled = false;
            _parallelCircuit.PropertyChanged += (o, e)
                => wasCalled = true;
            _parallelCircuit.SubSegments.Add(new Resistor());
            Assert.IsTrue(wasCalled,"Event wasn't called");
        }
    }
}
