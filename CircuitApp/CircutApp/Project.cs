using System;
using System.Collections.Generic;
using System.Numerics;
using CircutApp.Elements;
using CircutApp.Segments;

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

        /// <summary>
        /// Initializes project with five default circuits
        /// </summary>
        private void InitializeDefaultProjectData()
        {
            var rand = new Random();
            for (int index = 0; index < 5; index++)
            {
                Circuits.Add(new Circuit{Name = "Default circuit #" + (index+1)});
                Circuits[index].SubSegments.Add(new SerialSegment());
                ImpedanceZ.Add(new List<Complex>());
                Frequencies.Add(new List<double>()
                {
                    rand.NextDouble()*100, rand.NextDouble()*1000,
                    rand.NextDouble()*5000,rand.NextDouble()*9999999
                });
            }

            Circuits[0].SubSegments[0].SubSegments.Add(new Resistor() { Name = "R1", Value = 15.5});
            Circuits[0].SubSegments[0].SubSegments.Add(new Resistor() { Name = "R2", Value = 30.55 });
            Circuits[0].SubSegments[0].SubSegments.Add(new ParallelSegment());
            Circuits[0].SubSegments[0].SubSegments.Add(new Capacitor() { Name = "C1", Value = 6e-7 });
            Circuits[0].SubSegments[0].SubSegments[2].SubSegments.Add(new Resistor(){Name = "R3", Value = 10});
            Circuits[0].SubSegments[0].SubSegments[2].SubSegments.Add(new Inductor() { Name = "L1", Value = 0.0125});
            Circuits[0].SubSegments[0].SubSegments[2].SubSegments.Add(new SerialSegment());
            Circuits[0].SubSegments[0].SubSegments[2].SubSegments[2].SubSegments.Add(new Resistor(){Name = "R4",Value = 12.13});
            Circuits[0].SubSegments[0].SubSegments[2].SubSegments[2].SubSegments.Add(new Capacitor() { Name = "C2", Value = 0.005});
            Circuits[0].SubSegments[0].SubSegments.Add(new ParallelSegment());
            Circuits[0].SubSegments[0].SubSegments[4].SubSegments.Add(new Resistor(){Name = "R5",Value = 90.54});
            Circuits[0].SubSegments[0].SubSegments[4].SubSegments.Add(new Resistor() { Name = "R6", Value = 13.12 });

            Circuits[1].SubSegments[0].SubSegments.Add(new Resistor() {Name="R1", Value = 0.005});
            Circuits[1].SubSegments[0].SubSegments.Add(new Inductor() { Name = "L1", Value = 6e-5 });
            Circuits[1].SubSegments[0].SubSegments.Add(new ParallelSegment());
            Circuits[1].SubSegments[0].SubSegments[2].SubSegments.Add(new Resistor() { Name = "R2", Value = 5 });
            Circuits[1].SubSegments[0].SubSegments[2].SubSegments.Add(new Capacitor() { Name = "C1", Value = 3e-9 });
            Circuits[1].SubSegments[0].SubSegments.Add(new Resistor() { Name = "R1.1", Value = 0.005 });
            Circuits[1].SubSegments[0].SubSegments.Add(new ParallelSegment());
            Circuits[1].SubSegments[0].SubSegments[4].SubSegments.Add(new Resistor() { Name = "R3", Value = 4 });
            Circuits[1].SubSegments[0].SubSegments[4].SubSegments.Add(new Capacitor() { Name = "C2", Value = 43e-9 });
            Circuits[1].SubSegments[0].SubSegments[4].SubSegments.Add(new Inductor() { Name = "L2", Value = 11e-5 });

            Circuits[2].SubSegments[0].SubSegments.Add(new Resistor() { Name = "R1", Value = 10 });
            Circuits[2].SubSegments[0].SubSegments.Add(new Resistor() { Name = "R2", Value = 45 });
            Circuits[2].SubSegments[0].SubSegments.Add(new Resistor() { Name = "R3", Value = 15 });
            Circuits[2].SubSegments[0].SubSegments.Add(new ParallelSegment());
            Circuits[2].SubSegments[0].SubSegments[3].SubSegments.Add(new Resistor() { Name = "R4", Value = 32 });
            Circuits[2].SubSegments[0].SubSegments[3].SubSegments.Add(new Resistor() { Name = "R5", Value = 34 });
            Circuits[2].SubSegments[0].SubSegments[3].SubSegments.Add(new SerialSegment());
            Circuits[2].SubSegments[0].SubSegments[3].SubSegments[2].SubSegments.Add(new Resistor() { Name = "R6", Value = 15 });
            Circuits[2].SubSegments[0].SubSegments[3].SubSegments[2].SubSegments.Add(new Resistor() { Name = "R7", Value = 32 });

            Circuits[3].SubSegments[0].SubSegments.Add(new ParallelSegment());
            Circuits[3].SubSegments[0].SubSegments[0].SubSegments.Add(new Resistor() { Name = "R1", Value = 15 });
            Circuits[3].SubSegments[0].SubSegments[0].SubSegments.Add(new Capacitor() { Name = "C1", Value = 5e-6 });
            Circuits[3].SubSegments[0].SubSegments[0].SubSegments.Add(new Inductor() { Name = "L1", Value = 132e-3 });
            Circuits[3].SubSegments[0].SubSegments.Add(new Resistor() { Name = "R2", Value = 25 });
            Circuits[3].SubSegments[0].SubSegments.Add(new ParallelSegment());
            Circuits[3].SubSegments[0].SubSegments[2].SubSegments.Add(new Resistor() { Name = "R3", Value = 5 });
            Circuits[3].SubSegments[0].SubSegments[2].SubSegments.Add(new SerialSegment());
            Circuits[3].SubSegments[0].SubSegments[2].SubSegments[1].SubSegments.Add(new Resistor() { Name = "R4", Value = 8 });
            Circuits[3].SubSegments[0].SubSegments[2].SubSegments[1].SubSegments.Add(new Capacitor() { Name = "C2", Value = 8e-6 });

            Circuits[4].SubSegments[0].SubSegments.Add(new ParallelSegment());
            Circuits[4].SubSegments[0].SubSegments[0].SubSegments.Add(new Resistor() { Name = "R1", Value = 0.0006 });
            Circuits[4].SubSegments[0].SubSegments[0].SubSegments.Add(new Resistor() { Name = "R1", Value = 0.0006 });
            Circuits[4].SubSegments[0].SubSegments[0].SubSegments.Add(new ParallelSegment());
            Circuits[4].SubSegments[0].SubSegments[0].SubSegments[2].SubSegments.Add(new Resistor() { Name = "R1", Value = 0.0006 });
            Circuits[4].SubSegments[0].SubSegments[0].SubSegments[2].SubSegments.Add(new SerialSegment());
            Circuits[4].SubSegments[0].SubSegments[0].SubSegments[2].SubSegments[1].SubSegments.Add(new Resistor() { Name = "R1", Value = 0.0006 });
            Circuits[4].SubSegments[0].SubSegments[0].SubSegments[2].SubSegments[1].SubSegments.Add(new ParallelSegment());
            Circuits[4].SubSegments[0].SubSegments[0].SubSegments[2].SubSegments[1].SubSegments[1].SubSegments.Add(new Resistor() { Name = "R1", Value = 0.0006 });
            Circuits[4].SubSegments[0].SubSegments[0].SubSegments[2].SubSegments[1].SubSegments[1].SubSegments.Add(new Resistor() { Name = "R1", Value = 0.0006 });
            Circuits[4].SubSegments[0].SubSegments[0].SubSegments[2].SubSegments[1].SubSegments[1].SubSegments.Add(new SerialSegment());
            Circuits[4].SubSegments[0].SubSegments[0].SubSegments[2].SubSegments[1].SubSegments[1].SubSegments[2].SubSegments.Add(new Resistor() { Name = "R1", Value = 0.0006 });
            Circuits[4].SubSegments[0].SubSegments[0].SubSegments[2].SubSegments[1].SubSegments[1].SubSegments[2].SubSegments.Add(new ParallelSegment());
            Circuits[4].SubSegments[0].SubSegments[0].SubSegments[2].SubSegments[1].SubSegments[1].SubSegments[2].SubSegments[1].SubSegments.Add(new Resistor() { Name = "R1", Value = 0.0006 });
            Circuits[4].SubSegments[0].SubSegments[0].SubSegments[2].SubSegments[1].SubSegments[1].SubSegments[2].SubSegments[1].SubSegments.Add(new Resistor() { Name = "R1", Value = 0.0006 });

            for (int i = 0; i < 5; i++)
            {
                ImpedanceZ[i].AddRange(Circuits[i].CalculateImpedances
                    (Frequencies[i]));
            }
        }
    }
}
