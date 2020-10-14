using System;
using System.Collections.Generic;
using System.Numerics;

namespace CircutApp
{
    /// <summary>
    /// Type for storing all created circuits, added frequencies and calculated impedance 
    /// </summary>
    public class Project
    {
        /// <summary>
        /// All created circuits
        /// </summary>
        public List<Circuit> Circuits { get; set; } 
        /// <summary>
        /// All added frequencies
        /// </summary>
        public List<List<double>> Frequencies { get; set; } 
        
        /// <summary>
        /// All calculated impedance
        /// </summary>
        public List<List<Complex>> ImpedanceZ { get; set; } 

        /// <summary>
        /// Constructor
        /// </summary>
        public Project()
        {
            Circuits = new List<Circuit>();
            Frequencies = new List<List<double>>();
            ImpedanceZ = new List<List<Complex>>();
            InitializeDefaultProjectData();
        }

        private void InitializeDefaultProjectData()
        {
            var rand = new Random();
            for (int index = 0; index < 5; index++)
            {
                Circuits.Add(new Circuit{Name = "Default circuit #" + (index+1)});
                Circuits[index].SubSegments.Add(new SerialCircuit());
                ImpedanceZ.Add(new List<Complex>());
                Frequencies.Add(new List<double>()
                {
                    rand.NextDouble()*99999, rand.NextDouble()*99999,
                    rand.NextDouble()*99999,rand.NextDouble()*99999
                });
            }

            Circuits[0].SubSegments[0].SubSegments.Add(new Resistor() { Name = "R1", Value = 15.5});
            Circuits[0].SubSegments[0].SubSegments.Add(new Resistor() { Name = "R2", Value = 30.55 });
            Circuits[0].SubSegments[0].SubSegments.Add(new ParallelCircuit());
            Circuits[0].SubSegments[0].SubSegments.Add(new Resistor() { Name = "C1", Value = 6e-7 });
            Circuits[0].SubSegments[0].SubSegments[2].SubSegments.Add(new Resistor(){Name = "R3", Value = 10});
            Circuits[0].SubSegments[0].SubSegments[2].SubSegments.Add(new Inductor() { Name = "L1", Value = 0.0125});
            Circuits[0].SubSegments[0].SubSegments[2].SubSegments.Add(new SerialCircuit());
            Circuits[0].SubSegments[0].SubSegments[2].SubSegments[2].SubSegments.Add(new Resistor(){Name = "R4",Value = 12.13});
            Circuits[0].SubSegments[0].SubSegments[2].SubSegments[2].SubSegments.Add(new Resistor() { Name = "L2", Value = 0.005});
            Circuits[0].SubSegments[0].SubSegments.Add(new ParallelCircuit());
            Circuits[0].SubSegments[0].SubSegments[4].SubSegments.Add(new Resistor(){Name = "R5",Value = 90.54});
            Circuits[0].SubSegments[0].SubSegments[4].SubSegments.Add(new Resistor() { Name = "R6", Value = 13.12 });

            for (int i = 0; i < 5; i++)
            {
                ImpedanceZ[i].AddRange(Circuits[i].CalculateZ
                    (Frequencies[i]));
            }
        }
    }
}
