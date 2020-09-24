using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CircutApp;
using System.Numerics;

namespace CircuitAppUI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            Circuit circuit = new Circuit();
            Resistor r = new Resistor() {Name = "asd", Value = 30.0};
            Capacitor c = new Capacitor() {Name = "gdfdsd", Value = 0.00000003};
            Inductor i = new Inductor() {Name = "dsd", Value = 0.005};
            ParallelCircuit c2 = new ParallelCircuit();
            c2.SubSegments.Add(c);
            c2.SubSegments.Add(i);
            SerialCircuit c1 = new SerialCircuit();
            c1.SubSegments.Add(c2);
            c1.SubSegments.Add(r);
            circuit.SubSegments.Add(c1);
            circuit.SegmentChanged += Circuit_SegmentChanged;
            r.Value = 31;
        }

        private void Circuit_SegmentChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
