﻿using System;
using System.ComponentModel;
using System.Linq;
using System.Numerics;

namespace CircutApp
{
    public class SerialCircuit : ISegment
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public Complex CalculateZ(double frequency)
        {
            return SubSegments.Aggregate<ISegment, Complex>(0, (current, segment) => 
                    current + segment.CalculateZ(frequency));
        }

        public EventDrivenCollection SubSegments { get; set; }

        public SerialCircuit()
        {
            SubSegments = new EventDrivenCollection();
            SubSegments.CollectionChanged += OnCollectionChanged;
        }

        private void OnCollectionChanged(object sender, EventArgs e)
        {
            PropertyChanged?.Invoke(this, 
                new PropertyChangedEventArgs(string.Empty));
        }
    }
}
