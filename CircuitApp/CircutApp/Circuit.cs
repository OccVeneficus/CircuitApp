using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace CircutApp
{
    public class Circuit
    {
        public List<IElement> _elements;
        public List<IElement> Elements { get; set; }

        public Complex[] CalculateZ(List<double> frequencies)
        {
            Complex[] resultZ = new Complex[frequencies.Count];
            int i = 0;
            foreach (double frequency in frequencies)
            {
                resultZ[i] = 0.0;
                foreach (IElement element in Elements)
                {
                    resultZ[i] = resultZ[i] + element.CalculateZ(frequency);
                }

                ++i;
            }
            return resultZ;
        }

        public Circuit()
        {
            Elements = new List<IElement>();
        }

        public event EventHandler CircuitChanged;
    }
}
