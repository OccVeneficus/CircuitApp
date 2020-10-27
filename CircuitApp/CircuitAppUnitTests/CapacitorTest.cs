using System.Numerics;
using CircutApp;
using CircutApp.Elements;
using NUnit.Framework;

namespace CircuitAppUnitTests
{
    [TestFixture]
    public class CapacitorTest
    {
        private Capacitor _capacitor;

        public void Initialize()
        {
            _capacitor = new Capacitor();
        }

        [Test(Description = "Test capacitor calculateZ method")]
        public void CapacitorCalculateZTest()
        {
            Initialize();
            _capacitor.Value = 0.0000001;
            Complex expected = new Complex(0,-31830.988618379073);
            Complex actual =_capacitor.CalculateImpedance(50.0) ;
            Assert.AreEqual(expected,actual, "Wrong impedance calculation");
        }

    }
}
