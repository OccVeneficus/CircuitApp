using System.Collections.Generic;
using System.Numerics;
using CircutApp;
using NUnit.Framework;

namespace CircuitAppUnitTests
{
    [TestFixture]
    public class ProjectTest
    {
        private Project _project;
        public void Initialize()
        {
            _project = new Project();
        }

        [Test(Description = "Test circuit property")]
        public void ProjectTestCircuitProperty()
        {
            Initialize();
            Circuit testCircuit = new Circuit() {Name = "Test", SubSegments = null};
            List<Circuit> expected = new List<Circuit>()
            {
                testCircuit
            };
            _project.Circuits = new List<Circuit>()
            {
                testCircuit
            };
            List<Circuit> actual = _project.Circuits;
            CollectionAssert.AreEqual(expected,actual,"Value in circuit property was corrupted on set/get");
        }

        [Test(Description = "Test impedances property")]
        public void ProjectTestImpedancesProperty()
        {
            Initialize();
            List<Complex> testImpedances = new List<Complex>()
            {
                new Complex(0,0)
            };
            List<List<Complex>> expected = new List<List<Complex>>()
            {
                testImpedances
            };
            _project.ImpedanceZ = new List<List<Complex>>()
            {
                testImpedances
            };
            List<List<Complex>> actual = _project.ImpedanceZ;
            CollectionAssert.AreEqual(expected,actual, "Value in impedances property was corrupted on set/get");
        }

        [Test(Description = "Test frequencies property")]
        public void ProjectTestFrequenciesProperty()
        {
            Initialize();
            List<double> testImpedances = new List<double>()
            {
                100.0
            };
            List<List<double>> expected = new List<List<double>>()
            {
                testImpedances
            };
            _project.Frequencies = new List<List<double>>()
            {
                testImpedances
            };
            List<List<double>> actual = _project.Frequencies;
            CollectionAssert.AreEqual(expected, actual, "Value in frequencies property was corrupted on set/get");
        }
    }
}
