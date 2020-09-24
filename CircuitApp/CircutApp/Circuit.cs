﻿using System;
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
        private ObservableCollection<ISegment> _subSegments;
        public ObservableCollection<ISegment> SubSegments
        {
            get => _subSegments;
            set
            {
                switch (value)
                {
                    case IElement element:
                    {
                        _subSegments = value;
                        element.SegmentChanged += OnSegmentChanged;
                        break;
                    }
                    default:
                    {
                        _subSegments = value;
                        value.CollectionChanged += OnSegmentChanged;
                        break;
                    }
                }
            }
        }

        public string Name { get; set; }

        /// <summary>
        /// Event that fires whenever Elements changed
        /// </summary>
        public event EventHandler SegmentChanged;

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
            SubSegments = new ObservableCollection<ISegment>();
            SubSegments.CollectionChanged += OnSegmentChanged;
        }

        private void OnSegmentChanged(object sender, EventArgs e)
        {
            SegmentChanged?.Invoke(this,e);
        }
    }
}
