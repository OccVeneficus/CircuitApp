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
            foreach (var element in firstCircuit.Elements)
            {
                element.ValueChanged += Element_ValueChanged;
            }
            firstCircuit.CircuitChanged += FirstCircuit_CircuitChanged;
            firstCircuit.Elements[0].Value = 31;
        }

        private void FirstCircuit_CircuitChanged(object sender, EventArgs e)
        {
            
        }

        private void Element_ValueChanged(object sender, EventArgs e)
        {

        }

        private void circuit1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            circuitPictureBox.Image = imageList1.Images[0];
        }
    }
}
