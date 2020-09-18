using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CircutApp;
using System.Numerics;
using System.Runtime.Remoting.Channels;

namespace CircuitAppUI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            Circuit firstCircuit = new Circuit();
            firstCircuit.Elements.Add(new Resistor() { Name = "A32", Value = 32 });
            firstCircuit.Elements.Add(new Inductor() { Name = "V12", Value = 0.012 });
            firstCircuit.Elements.Add(new Capacitor() { Name = "D31", Value = 0.0000031 });
            Complex[] Z = new Complex[3];
            double[] f = new []{50.0};
            Z = firstCircuit.CalculateZ(new[] {50.0});
            firstCircuit.CircuitChanging += new CircuitElementChangedHandler((sender, args)
                => FirstCircuit_CircuitChanging(sender,args,f));
            firstCircuit.Elements[0].Value = 31;
        }

        private Complex[] FirstCircuit_CircuitChanging(object sender,
            CircuitElementChangedEventArgs e, double[] frequencies)
        {
            Circuit d = (Circuit) sender;
            e.NewResultZ = d.CalculateZ(frequencies);
            return e.NewResultZ;
        }

        private void circuit1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            circuitPictureBox.Image = imageList1.Images[0];
        }
    }
}
