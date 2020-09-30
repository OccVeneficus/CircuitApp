using System;
using System.Windows.Forms;
using CircutApp;

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
            //Resistor r1 = new Resistor() {Name = "r1", Value = 10.0};
            //Resistor r2 = new Resistor() { Name = "r2", Value = 4700.0 };
            //Resistor r3 = new Resistor() { Name = "r3", Value = 20000.0 };
            //Resistor r4 = new Resistor() { Name = "r4", Value = 330.0 };
            //Resistor r5 = new Resistor() { Name = "r5", Value = 27.0 };
            //Resistor r6 = new Resistor() { Name = "r6", Value = 56000.0 };
            //Resistor r7 = new Resistor() { Name = "r7", Value = 68000.0 };
            //SerialCircuit s1 = new SerialCircuit();
            //ParallelCircuit p1 = new ParallelCircuit();
            //SerialCircuit s2 = new SerialCircuit();
            //ParallelCircuit p2 = new ParallelCircuit();
            //p2.SubSegments.Add(r6);
            //p2.SubSegments.Add(r7);
            //s2.SubSegments.Add(r5);
            //s2.SubSegments.Add(p2);
            //p1.SubSegments.Add(r4);
            //p1.SubSegments.Add(s2);
            //s1.SubSegments.Add(r1);
            //s1.SubSegments.Add(r2);
            //s1.SubSegments.Add(p1);
            //s1.SubSegments.Add(r3);
            ////ParallelCircuit c2 = new ParallelCircuit();
            ////c2.SubSegments.Add(c);
            ////c2.SubSegments.Add(i);
            ////c2.SubSegments.Add(r);
            ////circuit.SubSegments.Add(c2);
            //circuit.SubSegments.Add(s1);
            //////Resistor r1 = new Resistor() {Name = "r1", Value = 5.0};
            //////Inductor l1 = new Inductor() {Name = "l1", Value = 0.05};
            //////Capacitor c1 =new Capacitor() {Name = "c1", Value = 0.01};
            //////SerialCircuit s1 = new SerialCircuit();
            //////ParallelCircuit p1 = new ParallelCircuit();
            //////p1.SubSegments.Add(r1);
            //////p1.SubSegments.Add(l1);
            //////s1.SubSegments.Add(p1);
            //////s1.SubSegments.Add(c1);
            //////circuit.SubSegments.Add(s1);
            Capacitor c1 = new Capacitor(){Name = "c1", Value = 2e-6};
            Capacitor c2 = new Capacitor(){Name = "c2", Value = 6e-6};
            ParallelCircuit p1 = new ParallelCircuit();
            p1.SubSegments.Add(c1);
            p1.SubSegments.Add(c2);
            circuit.SubSegments.Add(p1);
            circuit.Name = "Test";
            circuit.CircuitChanged += Circuit_SegmentChanged;
            _project.Circuits.Add(circuit);
            _project.ImpedanceZ = circuit.CalculateZ(_project.Frequencies);
            _project.Circuits.Add(new Circuit() { Name = "Pog" });
            (circuit.SubSegments[0].SubSegments[1] as IElement).Value = 21;
        }

        private void Initialize()
        {
            _project.Frequencies.AddRange(new double[]{100.0, 200.0, 300.0, 50000.0});
        }

        private void BindDataSources()
        {
            circuitsListBox.DataSource = _project.Circuits;
            circuitsListBox.DisplayMember = "Name";
            frequenciesListBox.DataSource = _project.Frequencies;
            impedancesListBox.DataSource = _project.ImpedanceZ;
        }

        private void Circuit_SegmentChanged(object sender, EventArgs e)
        {
            
        }
    }
}
