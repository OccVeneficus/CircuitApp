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
        }
    }
}
