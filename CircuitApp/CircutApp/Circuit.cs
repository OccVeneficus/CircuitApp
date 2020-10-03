using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Numerics;

namespace CircutApp
{
    /// <summary>
    /// Combination of circuit elements
    /// </summary>
    public class Circuit
    {
        public EventDrivenCollection SubSegments { get; set; }

        private string _name;
        public string Name
        {
            get => _name;
            set
            {
                if (value == "" || value.Length > 40)
                {
                    throw new ArgumentException("Value is empty or have more than 40" +
                                                " characters");
                }

                _name = value;
            }
        }

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
            SubSegments = new EventDrivenCollection();
            SubSegments.CollectionChanged += OnCollectionChanged;
        }

        private void OnCollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            CircuitChanged?.Invoke(this, e);
        }
    }
}
