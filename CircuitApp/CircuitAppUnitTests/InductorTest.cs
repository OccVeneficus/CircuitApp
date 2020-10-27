using System.Numerics;
using CircutApp;
using CircutApp.Elements;
using NUnit.Framework;

namespace CircuitAppUnitTests
{
    [TestFixture]
    public class InductorTest
    {
        private Inductor _inductor;

        public void Initialize()
        {
            _inductor = new Inductor();
        }

        [Test(Description = "Test inductor calculateZ method")]
        public void InductorCalculateZTest()
        {
            Initialize();
            _inductor.Value = 0.015;
            Complex expected = new Complex(0, 9.42477796076938);
            Complex actual = _inductor.CalculateImpedance(100.0);
            Assert.AreEqual(expected,actual,"Impedance wrong calculation");
        }
    }
}
