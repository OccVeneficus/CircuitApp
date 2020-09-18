using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace CircutApp
{
    /// <summary>
    /// Custom EventArgs for getting recalculated Z
    /// </summary>
    public class CircuitElementChangedEventArgs : EventArgs
    {
        public Complex[] NewResultZ { get; set; }
    }

    /// <summary>
    /// Signature for recalculation method
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    /// <returns></returns>
    public delegate Complex[] CircuitElementChangedHandler(object sender,
        CircuitElementChangedEventArgs e);

    public class Circuit
    {

        /// <summary>
        /// Collection of IElement elements
        /// </summary>
        public CircuitElements<IElement> Elements
        {
            get;
            set;
        }

        public event CircuitElementChangedHandler CircuitChanging;
        public Complex[] CalculateZ(double[] frequencies)
        {
            int index = 0;
            Complex[] result = new Complex[frequencies.Length];
            foreach (var frequency in frequencies)
            {
                foreach (var element in Elements)
                {
                    result[index] = result[index] + element.CalculateZ(frequency);
                }

                index++;
            }

            return result;
        }

        public Circuit()
        {
            Elements = new CircuitElements<IElement>();
            Elements.ElementsChanged += Elements_ElementsChanged;
        }

        private void Elements_ElementsChanged(object sender, EventArgs e)
        {
            CircuitChanging?.Invoke(this, new CircuitElementChangedEventArgs());
        }
    }
}
