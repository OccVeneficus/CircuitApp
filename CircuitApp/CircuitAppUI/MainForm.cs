using CircutApp;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Numerics;
using System.Security.Cryptography;
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
            circuitElementsTreeView.Nodes.Add(new TreeNode(){Tag = _project.Circuits[0], Text = @"Circuit1"});
            BuildTree(circuitElementsTreeView.Nodes[0], _project.Circuits[circuitsComboBox.SelectedIndex].SubSegments[0]);
            circuitElementsTreeView.ExpandAll();
        }

        private void Test()
        {
            _project.Circuits.Add(new Circuit() { Name = "Circuit1"});
            SerialCircuit s0 = new SerialCircuit();
            s0.SubSegments.Add(new Capacitor(){Name = "C1", Value = 6e-6});
            s0.SubSegments.Add(new ParallelCircuit());
            s0.SubSegments[1].SubSegments.Add(new Resistor(){Name = "R1", Value = 0.002});
            s0.SubSegments[1].SubSegments.Add(new Inductor(){ Name = "L2", Value = 0.012});
            _project.Circuits[0].SubSegments.Add(s0);
            _project.Circuits.Add(new Circuit() { Name = "Circuit2" });
            SerialCircuit s1 = new SerialCircuit();
            ParallelCircuit p1 = new ParallelCircuit();
            ParallelCircuit p2 = new ParallelCircuit();
            p1.SubSegments.Add(new Resistor(){Name = "R34", Value = 12.5});
            p1.SubSegments.Add(new Capacitor() { Name = "C33", Value = 3e-8 });
            p2.SubSegments.Add(new Resistor() { Name = "R2313", Value = 10 });
            p2.SubSegments.Add(new Resistor() { Name = "R3311", Value = 33.11 });
            p2.SubSegments.Add(new Inductor() { Name = "L33", Value = 0.0125 });
            s1.SubSegments.Add(p1);
            s1.SubSegments.Add(new Resistor(){Name = "R0033",Value = 5});
            s1.SubSegments.Add(p2);
            _project.Circuits[1].SubSegments.Add(s1);
            _project.Circuits.Add(new Circuit() { Name = "Circuit3" });
            _project.Circuits[2].SubSegments.Add(new SerialCircuit());
            _project.Circuits[2].SubSegments[0].SubSegments.Add(new Resistor(){Name = "R33",Value = 10});
            _project.Circuits[2].SubSegments[0].SubSegments.Add(new ParallelCircuit());
            _project.Circuits[2].SubSegments[0].SubSegments[1].SubSegments.Add(new Resistor() { Name = "R34", Value = 10 });
            _project.Circuits[2].SubSegments[0].SubSegments[1].SubSegments.Add(new Resistor() { Name = "R35", Value = 10 });
            _project.Circuits.Add(new Circuit() { Name = "Circuit4" });
            _project.Circuits.Add(new Circuit() { Name = "Circuit5" });
            for (int i = 0; i < 5; i++)
            {
                _project.ImpedanceZ[i].AddRange(_project.Circuits[i].CalculateZ(_project.Frequencies[i]));
            }
        }

        private void Initialize()
        {
            _project.Frequencies.AddRange(new List<List<double>>()
            {
                new List<double>() { 101.0, 200.0, 300.0, 50000.0 },
                new List<double>() { 102.0, 200.0, 300.0, 50000.0 },
                new List<double>() { 103.0, 200.0, 300.0, 50000.0 },
                new List<double>() { 104.0, 200.0, 300.0, 50000.0 },
                new List<double>() { 105.0, 200.0, 300.0, 50000.0 }
            });
            _project.ImpedanceZ.AddRange(new List<List<Complex>>()
            {
                new List<Complex>(),
                new List<Complex>(),
                new List<Complex>(),
                new List<Complex>(),
                new List<Complex>()
            });
        }

        private void BindDataSources()
        {
            frequenciesListBox.SelectedIndexChanged -= frequenciesListBox_SelectedIndexChanged;
            impedancesListBox.SelectedIndexChanged -= impedancesListBox_SelectedIndexChanged;
            circuitsComboBox.DataSource = _project.Circuits;
            circuitsComboBox.DisplayMember = "Name";
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

        private void circuitsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (frequenciesListBox.DataSource == null)
            {
                return;
            }

            ReBindDataSources();
            circuitElementsTreeView.Nodes.Clear();
            circuitElementsTreeView.Nodes.Add(new TreeNode());
            circuitElementsTreeView.Nodes[0].Text = _project.Circuits[circuitsComboBox.SelectedIndex].Name;
            BuildTree(circuitElementsTreeView.Nodes[0],_project.Circuits[circuitsComboBox.SelectedIndex].SubSegments[0]);
            circuitElementsTreeView.ExpandAll();
        }

        private void ReBindDataSources()
        {
            frequenciesListBox.SelectedIndexChanged -= frequenciesListBox_SelectedIndexChanged;
            impedancesListBox.SelectedIndexChanged -= impedancesListBox_SelectedIndexChanged;
            frequenciesListBox.DataSource = null;
            impedancesListBox.DataSource = null;
            frequenciesListBox.DataSource = _project.Frequencies[circuitsComboBox.SelectedIndex];
            impedancesListBox.DataSource = _project.ImpedanceZ[circuitsComboBox.SelectedIndex];
            frequenciesListBox.SelectedIndexChanged += frequenciesListBox_SelectedIndexChanged;
            impedancesListBox.SelectedIndexChanged += impedancesListBox_SelectedIndexChanged;
        }

        private void BuildTree(TreeNode currentNode, ISegment segment)
        {
            var node = new TreeNode();
            switch (segment)
            {
                case Element a:
                {
                    node.Text = a.Name;
                    node.Tag = a;
                    break;
                }
                case ParallelCircuit p:
                {
                    node.Text = @"Parallel Segment";
                    node.Tag = p;
                    break;
                }
                default:
                {
                    node.Text = @"Serial Segment";
                    node.Tag = segment;
                    break;
                }
            }
            currentNode.Nodes.Add(node);
            if (segment.SubSegments != null)
            {
                foreach (var s in segment.SubSegments)
                {
                    BuildTree(currentNode.LastNode, s);
                }
            }
        }

        private void frequencyInputTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != ','))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == ',') && (frequencyImputTextBox.Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }

        private void addFrequencyButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(frequencyImputTextBox.Text) || !double.TryParse(frequencyImputTextBox.Text, out _))
            {
                frequencyImputTextBox.BackColor = Color.LightCoral;
                MessageBox.Show(@"You can't add empty space or strings to frequencies.",
                    @"Wrong input", MessageBoxButtons.OK);
            }
            else
            {
                _project.Frequencies[circuitsComboBox.SelectedIndex].Add(Convert.ToDouble(frequencyImputTextBox.Text));
                frequencyImputTextBox.BackColor = Color.White;
                frequencyImputTextBox.Clear();
                _project.ImpedanceZ[circuitsComboBox.SelectedIndex] =
                    _project.Circuits[circuitsComboBox.SelectedIndex]
                        .CalculateZ(_project.Frequencies[circuitsComboBox.SelectedIndex]);
                ReBindDataSources();
                frequenciesListBox.SelectedIndex = frequenciesListBox.Items.Count - 1;
            }
        }

        private void circuitElementsTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            elementNameTextBox.Text = circuitElementsTreeView.SelectedNode.Text;
            switch (circuitElementsTreeView.SelectedNode.Tag)
            {
                case Element element:
                {
                    elementValueTextBox.Text = element.Value.ToString(CultureInfo.InvariantCulture);
                    switch (element)
                    {
                        case Capacitor _:
                        {
                            elementTypeTextBox.Text = @"Capacitor";
                            break;
                        }
                        case Inductor _:
                        {
                            elementTypeTextBox.Text = @"Inductor";
                            break;
                        }
                        default:
                        {
                            elementTypeTextBox.Text = @"Resistor";
                            break;
                        }
                    }
                    break;
                }
                case SerialCircuit s:
                {
                    elementTypeTextBox.Text = @"Serial segment";
                    elementTypeTextBox.Text = @"";
                    elementValueTextBox.Text = @"";
                    break;
                }
                default:
                {
                    elementTypeTextBox.Text = @"Parallel segment";
                    elementTypeTextBox.Text = @"";
                    elementValueTextBox.Text = @"";
                        break;
                }
            }
        }

        private void deleteFrequencyButton_Click(object sender, EventArgs e)
        {
            if (impedancesListBox.Items.Count == 0)
            {
                MessageBox.Show(@"You can't delete item from empty list.",
                    @"List is empty", MessageBoxButtons.OK);
                return;
            }
            _project.Frequencies[circuitsComboBox.SelectedIndex].Remove
                (Convert.ToDouble(frequenciesListBox.SelectedItem));
            _project.ImpedanceZ[circuitsComboBox.SelectedIndex].Remove((Complex)impedancesListBox.SelectedItem);
            frequenciesListBox.SelectedIndex = 0;
            ReBindDataSources();
        }

        private void circuitElementsTreeView_ItemDrag(object sender, ItemDragEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                DoDragDrop(e.Item, DragDropEffects.Move);
            }
            else if (e.Button == MouseButtons.Right)
            {
                DoDragDrop(e.Item, DragDropEffects.Copy);
            }
        }

        private void circuitElementsTreeView_DragOver(object sender, DragEventArgs e)
        {
            Point targetPoint = circuitElementsTreeView.PointToClient(new Point(e.X, e.Y));

            circuitElementsTreeView.SelectedNode = circuitElementsTreeView.GetNodeAt(targetPoint);
        }

        private void circuitElementsTreeView_DragDrop(object sender, DragEventArgs e)
        {
            Point targetPoint = circuitElementsTreeView.PointToClient(new Point(e.X, e.Y));
            TreeNode targetNode = circuitElementsTreeView.GetNodeAt(targetPoint);
            TreeNode draggedNode = (TreeNode) e.Data.GetData(typeof(TreeNode));
            TreeNode parent = draggedNode.Parent;
            if (!draggedNode.Equals(targetNode) && !ContainsNode(draggedNode, targetNode))
            {
                if (e.Effect == DragDropEffects.Move)
                {
                    (parent.Tag as ISegment).SubSegments.Remove(draggedNode.Tag as ISegment);
                    draggedNode.Remove();
                    targetNode.Nodes.Add(draggedNode);
                    ((ISegment)targetNode.Tag).SubSegments.Add((ISegment)draggedNode.Tag);
                }
                else if (e.Effect == DragDropEffects.Copy)
                {
                    targetNode.Nodes.Add((TreeNode) draggedNode.Clone());
                }
                targetNode.Expand();
                if ((parent.Tag is SerialCircuit || parent.Tag is ParallelCircuit) &&
                    parent.Nodes.Count == 0)
                {
                    parent.Remove();
                    RecursiveRemove(_project.Circuits[circuitsComboBox.SelectedIndex].SubSegments[0],
                        parent.Tag as ISegment);
                }
            }
        }

        private void RecursiveRemove(ISegment segment, ISegment toDelete)
        {
            bool isDeleted = segment.SubSegments.Remove(toDelete);
            if (!isDeleted && segment.SubSegments != null)
            {
                foreach (var s in segment.SubSegments)
                {
                    RecursiveRemove(s,toDelete);
                }
            }
        }

        private bool ContainsNode(TreeNode node1, TreeNode node2)
        {
            if (node2.Parent == null)
            {
                return false;
            }

            if (node2.Parent.Equals(node1))
            {
                return true;
            }

            return ContainsNode(node1, node2.Parent);
        }

        private void circuitElementsTreeView_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = e.AllowedEffect;
        }
    }
}
