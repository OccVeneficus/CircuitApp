using System.Numerics;
using CircutApp;
using CircutApp.Elements;
using CircutApp.Segments;
using NUnit.Framework;

namespace CircuitAppUnitTests
{
    [TestFixture]
    public class ParallelSegmentTest
    {
        private ParallelSegment _parallelSegment;

        public void Initialize()
        {
            _parallelSegment = new ParallelSegment();
        }

        [Test(Description = "Test CalculateImpedance method in parallel segment")]
        public void ParallelCircuitCalculateZTest()
        {
            Initialize();
            Capacitor c1 = new Capacitor() { Name = "C1", Value = 2e-6 };
            Capacitor c2 = new Capacitor() { Name = "C2", Value = 6e-6 };
            _parallelSegment.SubSegments.Add(c1);
            _parallelSegment.SubSegments.Add(c2);
            Complex expected = new Complex(0, -198.94367886486916);
            Complex actual = _parallelSegment.CalculateImpedance(100.0);
            Assert.AreEqual(expected, actual, "Wrong calculations");
        }

        [Test(Description = "Test CalculateImpedance method when subsegments are empty")]
        public void ParallelCircuitCalculateZWithEmptySubSegmentsTest()
        {
            Initialize();
            Complex expected = Complex.Zero;
            Complex actual = _parallelSegment.CalculateImpedance(100);
            Assert.AreEqual(expected,actual,"Return wasn't zero for empty segment");
        }

        [Test(Description = "Test PropertyChanged event firing")]
        public void ParallelCircuitPropertyChangedEvent_Firing()
        {
            Initialize();
            var wasCalled = false;
            _parallelSegment.PropertyChanged += (o, e)
                => wasCalled = true;
            _parallelSegment.SubSegments.Add(new Resistor());
            Assert.IsTrue(wasCalled,"Event wasn't called");
        }

        [Test(Description = "Test Name property")]
        public void ParallelSegmentName_Test()
        {
            Initialize();
            var expected = "Parallel segment";
            var actual = _parallelSegment.Name;
            Assert.AreEqual(expected,actual,"Wrong default segment name");
        }
    }
}
