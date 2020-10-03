using CircutApp;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Windows.Forms;

namespace CircuitAppUI
{
    public partial class MainForm : Form
    {
        private Project _project;

        public MainForm()
        {
            InitializeComponent();
            _project = new Project();
            Initialize();
            Test();
            BindDataSources();
        }

        private void Test()
        {
            Circuit circuit = new Circuit();
            Resistor r = new Resistor() { Name = "asd", Value = 31.0 }; //3.1e+1
            Capacitor c = new Capacitor() { Name = "gdfdsd", Value = 0.000006 }; //6e-6
            Inductor i = new Inductor() { Name = "dsd", Value = 0.001 }; //1e-3
            Capacitor c1 = new Capacitor() { Name = "c1", Value = 2e-6 };
            Capacitor c2 = new Capacitor() { Name = "c2", Value = 6e-6 };
            ParallelCircuit p1 = new ParallelCircuit();
            SerialCircuit s1 = new SerialCircuit();
            s1.SubSegments.Add(r);
            s1.SubSegments.Add(c);
            s1.SubSegments.Add(i);
            p1.SubSegments.Add(c1);
            p1.SubSegments.Add(c2);
            circuit.SubSegments.Add(p1);
            circuit.Name = "Test";
            circuit.CircuitChanged += Circuit_SegmentChanged;
            _project.Circuits.Add(circuit);
            _project.ImpedanceZ[0] = circuit.CalculateZ(_project.Frequencies[0]);
            _project.Circuits.Add(new Circuit() { Name = "Test2" });
            _project.Circuits[1].SubSegments.Add(s1);
            _project.Frequencies.Add(new List<double>() { 100.0, 200.0, 300.0, 50000.0 });
            _project.ImpedanceZ.Add(new List<Complex>());
            _project.ImpedanceZ[1] = _project.Circuits[1].CalculateZ(_project.Frequencies[1]);
            (circuit.SubSegments[0].SubSegments[1] as IElement).Value = 21;
        }

        private void Initialize()
        {
            _project.Frequencies.Add(new List<double>() { 100.0, 200.0, 300.0, 50000.0 });
            _project.ImpedanceZ.Add(new List<Complex>());
        }

        private void BindDataSources()
        {
            frequenciesListBox.SelectedIndexChanged -= frequenciesListBox_SelectedIndexChanged;
            impedancesListBox.SelectedIndexChanged -= impedancesListBox_SelectedIndexChanged;
            circuitsListBox.DataSource = _project.Circuits;
            circuitsListBox.DisplayMember = "Name";
            frequenciesListBox.DataSource = _project.Frequencies[0];
            impedancesListBox.DataSource = _project.ImpedanceZ[0];
            frequenciesListBox.SelectedIndexChanged += frequenciesListBox_SelectedIndexChanged;
            impedancesListBox.SelectedIndexChanged += impedancesListBox_SelectedIndexChanged;
        }

        private void Circuit_SegmentChanged(object sender, EventArgs e)
        {

        }

        private void frequenciesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            impedancesListBox.SelectedIndex = frequenciesListBox.SelectedIndex;
        }

        private void impedancesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            frequenciesListBox.SelectedIndex = impedancesListBox.SelectedIndex;
        }

        private void circuitsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (frequenciesListBox.DataSource == null)
            {
                return;
            }
            ReBindDataSources();
        }

        private void ReBindDataSources()
        {
            frequenciesListBox.SelectedIndexChanged -= frequenciesListBox_SelectedIndexChanged;
            impedancesListBox.SelectedIndexChanged -= impedancesListBox_SelectedIndexChanged;
            frequenciesListBox.DataSource = null;
            impedancesListBox.DataSource = null;
            frequenciesListBox.DataSource = _project.Frequencies[circuitsListBox.SelectedIndex];
            impedancesListBox.DataSource = _project.ImpedanceZ[circuitsListBox.SelectedIndex];
            frequenciesListBox.SelectedIndexChanged += frequenciesListBox_SelectedIndexChanged;
            impedancesListBox.SelectedIndexChanged += impedancesListBox_SelectedIndexChanged;
        }

        private void BuildTreeView(TreeNode currentNode, EventDrivenCollection currentSegment)
        {
            if (currentSegment != null)
            {
                currentNode.Name = currentSegment.ToString();
                BuildTreeView(currentNode.FirstNode, currentSegment);
            }
        }

        private void frequencyInputTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != ','))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == ',') && (frequencyInputTextBox.Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }

        private void addFrequencyButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(frequencyInputTextBox.Text) || !double.TryParse(frequencyInputTextBox.Text, out _))
            {
                frequencyInputTextBox.BackColor = Color.LightCoral;
                MessageBox.Show("You can't add empty space or strings to frequencies.",
                    "Wrong input", MessageBoxButtons.OK);
            }
            else
            {
                _project.Frequencies[circuitsListBox.SelectedIndex].Add(Convert.ToDouble(frequencyInputTextBox.Text));
                frequencyInputTextBox.BackColor = Color.White;
                frequencyInputTextBox.Clear();
                _project.ImpedanceZ[circuitsListBox.SelectedIndex] =
                    _project.Circuits[circuitsListBox.SelectedIndex]
                        .CalculateZ(_project.Frequencies[circuitsListBox.SelectedIndex]);
                ReBindDataSources();
                frequenciesListBox.SelectedIndex = frequenciesListBox.Items.Count - 1;
            }
        }
    }
}
