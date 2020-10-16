using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Numerics;

namespace CircutApp
{
    /// <summary>
    /// Combination of circuit elements
    /// </summary>
    public class Circuit
    {
        /// <summary>
        /// Circuit sub segments
        /// </summary>
        public EventDrivenCollection SubSegments { get; set; }

        /// <summary>
        /// Circuit name 
        /// </summary>
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
        public List<Complex> CalculateImpedances(List<double> frequencies)
        {
            List<Complex> result = new List<Complex>();
            foreach (var frequency in frequencies)
            {
                Complex segmentResult = new Complex();
                foreach (var segment in SubSegments)
                {
                    segmentResult += segment.CalculateImpedance(frequency);
                }
                result.Add(segmentResult);
            }
            return result;
        }

        /// <summary>
        /// Circuit constructor
        /// </summary>
        public Circuit()
        {
            SubSegments = new EventDrivenCollection();
            SubSegments.CollectionChanged += OnCollectionChanged;
        }

        /// <summary>
        /// Handel CollectionChanged event of SubSegments collection
        /// </summary>
        /// <param name="sender">SubSegments</param>
        /// <param name="e">Args</param>
        private void OnCollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            CircuitChanged?.Invoke(this, e);
        }
    }
}
