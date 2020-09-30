using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

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
        public List<double> Frequencies { get; set; } 
        
        /// <summary>
        /// All calculated impedance
        /// </summary>
        public List<Complex> ImpedanceZ { get; set; } 

        /// <summary>
        /// Constructor
        /// </summary>
        public Project()
        {
            Circuits = new List<Circuit>();
            Frequencies = new List<double>();
            ImpedanceZ = new List<Complex>();
        }
    }
}
