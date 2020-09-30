using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Numerics;

namespace CircutApp
{
    /// <summary>
    /// Combination of circuit elements
    /// </summary>
    public class Circuit
    {
        public EventDrivenCollection<ISegment> SubSegments { get; set; }

        public string Name { get; set; }

        /// <summary>
        /// Event that fires whenever Elements changed
        /// </summary>
        public event EventHandler CircuitChanged;

        /// <summary>
        /// Method that calculates summary impedance of all circuit elements
        /// </summary>
        /// <param name="frequencies"></param>
        /// <returns></returns>
        public List<Complex> CalculateZ(List<double> frequencies)
        {
            return (from frequency in frequencies
                    from subSegment in SubSegments 
                    select subSegment.CalculateZ(frequency)).ToList();
        }

        public Circuit()
        {
            SubSegments = new EventDrivenCollection<ISegment>();
            SubSegments.CollectionChanged += OnCollectionChanged;
        }

        private void OnCollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            CircuitChanged?.Invoke(this, e);
        }
    }
}
