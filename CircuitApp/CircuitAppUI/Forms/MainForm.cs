using CircutApp;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Numerics;
using System.Windows.Forms;
using CircuitAppUI.CircuitDraw;

namespace CircuitAppUI
{
    public partial class MainForm : Form
    {
        private readonly Project _project;

        public MainForm()
        {
            InitializeComponent();
            //TODO: не многовато ли методов Initialize()? Вводят путаницу в назначении. И при этом ни один из них не создаёт экземпляр проекта (done)
            _project = new Project();
            BindDefaultCircuitsChangeEvents();
            CircuitDrawer.CircuitPictureBox = circuitPictureBox;
            BindDataSources();
            RebuildTree(); //TODO: Re - это не самостоятельное слово (done)
            circuitElementsTreeView.SelectedNode = circuitElementsTreeView.Nodes[0];
        }

        private void BindDefaultCircuitsChangeEvents()
        {
            //TODO: это не должно делаться в форме - сделай отдельный класс для инициализации проекта включая частоты и пр.(done)
            for (int i = 0; i < 5; i++)
            {
                _project.Circuits[i].CircuitChanged += Circuit_SegmentChanged;
            }
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
            _project.ImpedanceZ[circuitsComboBox.SelectedIndex] =
                _project.Circuits[circuitsComboBox.SelectedIndex]
                    .CalculateImpedances(_project.Frequencies[circuitsComboBox.SelectedIndex]);
            RebindDataSources();
            circuitPictureBox.Invalidate();
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

            RebindDataSources();
            RebuildTree();
            circuitPictureBox.Invalidate();
            circuitElementsTreeView.SelectedNode = circuitElementsTreeView.Nodes[0];
        }

        private void RebindDataSources()
        {
            if (_project.Circuits.Count.Equals(0))
            {
                return;
            }
            frequenciesListBox.SelectedIndexChanged -= frequenciesListBox_SelectedIndexChanged;
            impedancesListBox.SelectedIndexChanged -= impedancesListBox_SelectedIndexChanged;
            frequenciesListBox.ClearSelected();
            frequenciesListBox.DataSource = null;
            impedancesListBox.DataSource = null;
            frequenciesListBox.DataSource = _project.Frequencies[circuitsComboBox.SelectedIndex];
            impedancesListBox.DataSource = _project.ImpedanceZ[circuitsComboBox.SelectedIndex];
            frequenciesListBox.SelectedIndexChanged += frequenciesListBox_SelectedIndexChanged;
            impedancesListBox.SelectedIndexChanged += impedancesListBox_SelectedIndexChanged;
        }

        private void RebuildTree()
        {
            circuitElementsTreeView.Nodes.Clear();
            if (circuitsComboBox.Items.Count == 0)
            {
                return;
            }
            circuitElementsTreeView.Nodes.Add(new TreeNode()
            { 
                Tag = _project.Circuits[circuitsComboBox.SelectedIndex].SubSegments[0],
                Text = ((Circuit)circuitsComboBox.SelectedItem).Name
            });
            TreeViewBuilder.PopulateTree(circuitElementsTreeView.Nodes[0],
                _project.Circuits[circuitsComboBox.SelectedIndex].SubSegments[0].SubSegments);
            circuitElementsTreeView.ExpandAll();
        }

        private void frequencyInputTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyPressChecking.CheckForDouble(sender,e);
        }

        private void addFrequencyButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(frequencyInputTextBox.Text) || 
                !double.TryParse(frequencyInputTextBox.Text, NumberStyles.Float,
                    CultureInfo.InvariantCulture, out _))
            {
                //TODO: грамошибка (done)
                frequencyInputTextBox.BackColor = Color.LightCoral;
                MessageBox.Show(@"You can't add empty space or strings to frequencies.",
                    @"Wrong input", MessageBoxButtons.OK);
            }
            else
            {
                _project.Frequencies[circuitsComboBox.SelectedIndex].Add
                    (Convert.ToDouble(frequencyInputTextBox.Text, CultureInfo.InvariantCulture));
                frequencyInputTextBox.BackColor = Color.White;
                frequencyInputTextBox.Clear();
                _project.ImpedanceZ[circuitsComboBox.SelectedIndex] =
                    _project.Circuits[circuitsComboBox.SelectedIndex]
                        .CalculateImpedances(_project.Frequencies[circuitsComboBox.SelectedIndex]);
                RebindDataSources();
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
                case SerialSegment _:
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
            _project.ImpedanceZ[circuitsComboBox.SelectedIndex].Remove
                ((Complex)impedancesListBox.SelectedItem);
            frequenciesListBox.SelectedIndex = 0;
            RebindDataSources();
        }

        private void circuitElementsTreeView_ItemDrag(object sender, ItemDragEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                DoDragDrop(e.Item, DragDropEffects.Move);
            }
        }

        private void circuitElementsTreeView_DragOver(object sender, DragEventArgs e)
        {
            Point targetPoint = circuitElementsTreeView.PointToClient(new Point(e.X, e.Y));

            circuitElementsTreeView.SelectedNode = circuitElementsTreeView.GetNodeAt(targetPoint);
        }

        private void circuitElementsTreeView_DragDrop(object sender, DragEventArgs e)
        {
            //TODO: var (done)
            var targetPoint = circuitElementsTreeView.PointToClient(new Point(e.X, e.Y));
            TreeNode targetNode = circuitElementsTreeView.GetNodeAt(targetPoint);
            if (targetNode == null)
            {
                return;
            }
            TreeNode draggedNode = (TreeNode) e.Data.GetData(typeof(TreeNode));
            TreeNode draggedNodeParent = draggedNode.Parent;
            TreeNode targetNodeParent = targetNode.Parent;
            
            if (!draggedNode.Equals(targetNode) && !TreeViewBuilder.ContainsNode(draggedNode, targetNode))
            {
                if (e.Effect == DragDropEffects.Move)
                {
                    if (targetNode.Tag is Element)
                    {
                        TreeViewBuilder.MoveToElement(targetNode, draggedNode, draggedNodeParent, targetNodeParent);
                        RebuildTree();
                        return;
                    }
                    (draggedNodeParent.Tag as ISegment)?.SubSegments.Remove(draggedNode.Tag as ISegment);
                    //TODO: опять ветвление из Circuit (done)
                    draggedNode.Remove();
                    targetNode.Nodes.Add(draggedNode);
                }

                (targetNode.Tag as ISegment)?.SubSegments.Add((ISegment)draggedNode.Tag); //TODO: и снова (done)

                if (draggedNodeParent.Tag is Segment && draggedNodeParent.Nodes.Count == 0)
                {
                    draggedNodeParent.Remove();
                    TreeViewBuilder.SegmentRemove(_project.Circuits[circuitsComboBox.SelectedIndex].SubSegments,
                        draggedNodeParent.Tag as ISegment);
                }
                targetNode.Expand();
            }
        }

        private void circuitElementsTreeView_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = e.AllowedEffect;
        }

        private void removeElementButton_Click(object sender, EventArgs e)
        {
            if (circuitElementsTreeView.SelectedNode==null)
            {
                MessageBox.Show(@"There is no items to delete",
                    @"Empty", MessageBoxButtons.OK);
                return;
            }
            if (circuitElementsTreeView.SelectedNode.Tag is ISegment &&
                MessageBox.Show(@"Are you sure you want to permanently delete selected item?",
                    @"Delete segment", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                TreeViewBuilder.SegmentRemove(_project.Circuits[circuitsComboBox.SelectedIndex].SubSegments,
                    circuitElementsTreeView.SelectedNode.Tag as ISegment);
                circuitElementsTreeView.Nodes.Remove(circuitElementsTreeView.SelectedNode);
            }
            else if (circuitElementsTreeView.SelectedNode.Tag is Circuit)
            {
                deleteCircuitButton_Click(this,e);
            }
        }

        private void deleteCircuitButton_Click(object sender, EventArgs e)
        {
            if (circuitsComboBox.Items.Count == 0)
            {
                MessageBox.Show(@"There is no items to delete",
                    @"Empty", MessageBoxButtons.OK);
                return;
            }
            if (MessageBox.Show(@"You sure you want to permanently delete selected circuit?",
                @"Delete circuit", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                _project.Circuits[circuitsComboBox.SelectedIndex].CircuitChanged -= Circuit_SegmentChanged;
                circuitsComboBox.SelectedIndexChanged -= circuitsComboBox_SelectedIndexChanged;
                _project.Circuits.RemoveAt(circuitsComboBox.SelectedIndex);
                _project.ImpedanceZ.RemoveAt(circuitsComboBox.SelectedIndex);
                _project.Frequencies.RemoveAt(circuitsComboBox.SelectedIndex);
                circuitElementsTreeView.Nodes.Clear();
                circuitsComboBox.DataSource = null;
                circuitsComboBox.DataSource = _project.Circuits;
                circuitsComboBox.DisplayMember = "Name";
                circuitsComboBox.SelectedIndexChanged += circuitsComboBox_SelectedIndexChanged;
                if (circuitsComboBox.Items.Count > 0)
                { 
                    circuitsComboBox.SelectedIndex = 0;
                }
                RebindDataSources();
                RebuildTree();
                if (circuitElementsTreeView.Nodes.Count != 0)
                {
                    circuitElementsTreeView.SelectedNode = circuitElementsTreeView.Nodes[0];
                }
            }
        }

        private void addElementButton_Click(object sender, EventArgs e)
        {
            if (circuitsComboBox.Items.Count == 0)
            {
                addCircuitButton_Click(sender,e);
            }
            ElementForm form = new ElementForm();
            form.ElementName = "";
            form.ElementValue = new double();
            form.ElementType = typeof(Resistor);
            form.ShowDialog();
            if (form.DialogResult == DialogResult.OK)
            {
                var newElement = Activator.CreateInstance(form.ElementType);
                ((Element) newElement).Value = form.ElementValue;
                ((Element) newElement).Name = form.ElementName;
                if (circuitElementsTreeView.SelectedNode == null)
                {
                    _project.Circuits[circuitsComboBox.SelectedIndex].SubSegments[0].SubSegments.Add
                        (newElement as ISegment);
                }
                else if (circuitElementsTreeView.SelectedNode.Tag is Segment segment)
                {
                    segment.SubSegments.Add(newElement as ISegment);
                } 
                //TODO: одинаковые ветки - избавиться с помощью полиморфизма} (done)
                else if (circuitElementsTreeView.SelectedNode.Tag is Element element)
                {
                    ConnectionTypeForm connectionForm = new ConnectionTypeForm();
                    connectionForm.ShowDialog();
                    if (connectionForm.DialogResult == DialogResult.OK)
                    {
                        if (circuitElementsTreeView.SelectedNode.Parent.Tag is Segment parentSegment)
                        {
                            connectionForm.Type.SubSegments.Add(newElement as ISegment);
                            connectionForm.Type.SubSegments.Add(element);
                            parentSegment.SubSegments.Remove(element);
                            parentSegment.SubSegments.Add(connectionForm.Type);
                        } //TODO: избавиться от дублирования (done)
                    }
                    else
                    {
                        return;
                    }
                }
                RebuildTree();
            }
        }

        private void addSegmentButton_Click(object sender, EventArgs e)
        {
            ConnectionTypeForm form = new ConnectionTypeForm();
            form.ShowDialog();
            if (form.DialogResult == DialogResult.Cancel)
            {
                return;
            }

            if (circuitElementsTreeView.SelectedNode.Tag is Element element)
            {
                (circuitElementsTreeView.SelectedNode.Parent.Tag as Segment).SubSegments.Add(form.Type);
            }
            else
            {
                (circuitElementsTreeView.SelectedNode.Tag as Segment).SubSegments.Add(form.Type);
            }
            RebuildTree();
        }

        private void editElementButton_Click(object sender, EventArgs e)
        {
            if (circuitElementsTreeView.SelectedNode.Tag is Element element)
            {
                var form = new ElementForm();
                form.ElementType = element.GetType();
                form.ElementName = element.Name;
                form.ElementValue = element.Value;
                form.ShowDialog();
                if (form.DialogResult == DialogResult.OK)
                {
                    var editElement = Activator.CreateInstance(form.ElementType);
                    ((Element) editElement).Value = form.ElementValue;
                    ((Element) editElement).Name = form.ElementName;
                    circuitElementsTreeView.SelectedNode.Tag = editElement;
                    var path = TreeViewBuilder.ReplaceElement(circuitElementsTreeView.SelectedNode,
                        _project.Circuits[circuitsComboBox.SelectedIndex].SubSegments[0].SubSegments,
                        editElement as ISegment);
                    ChooseTreeNodeAfterReplace(path);
                }
            }
            else if (circuitElementsTreeView.SelectedNode.Tag is Segment segment)
            {
                var connectionForm = new ConnectionTypeForm();
                connectionForm.Type = segment;
                connectionForm.ShowDialog();
                if (connectionForm.DialogResult == DialogResult.OK)
                {
                    (connectionForm.Type as Segment).SubSegments = segment.SubSegments;
                    var path = TreeViewBuilder.ReplaceElement(circuitElementsTreeView.SelectedNode,
                            _project.Circuits[circuitsComboBox.SelectedIndex].SubSegments[0].SubSegments,
                            (connectionForm.Type as Segment));
                    ChooseTreeNodeAfterReplace(path);
                }
            }
        }

        private void ChooseTreeNodeAfterReplace(List<int> path)
        {
            RebuildTree();
            circuitElementsTreeView.SelectedNode = circuitElementsTreeView.Nodes[0].Nodes[path[0]];
            foreach (var index in path.Skip(1))
            {
                circuitElementsTreeView.SelectedNode =
                    circuitElementsTreeView.SelectedNode.Nodes[index];
            }
        }

        private void addCircuitButton_Click(object sender, EventArgs e)
        {
            var form = new CircuitForm();
            form.Circuit = new Circuit();
            form.ShowDialog();
            if (form.DialogResult == DialogResult.OK)
            {
                form.Circuit.SubSegments.Add(new SerialSegment());
                form.Circuit.CircuitChanged += Circuit_SegmentChanged;
                _project.Circuits.Add(form.Circuit);
                circuitsComboBox.SelectedIndexChanged -= circuitsComboBox_SelectedIndexChanged;
                circuitsComboBox.DataSource = null;
                circuitsComboBox.DataSource = _project.Circuits;
                circuitsComboBox.DisplayMember = "Name";
                circuitsComboBox.SelectedIndexChanged += circuitsComboBox_SelectedIndexChanged;
                _project.ImpedanceZ.Add(new List<Complex>());
                _project.Frequencies.Add(new List<double>());
                RebuildTree();
            }

        }

        private void editCircuitButton_Click(object sender, EventArgs e)
        {
            var form = new CircuitForm();
            form.Circuit = (Circuit) circuitsComboBox.SelectedItem;
            form.ShowDialog();
            if (form.DialogResult == DialogResult.OK)
            {
                ((Circuit) circuitsComboBox.SelectedItem).Name = form.Circuit.Name;
                circuitsComboBox.SelectedIndexChanged -= circuitsComboBox_SelectedIndexChanged;
                circuitsComboBox.DataSource = null;
                circuitsComboBox.DataSource = _project.Circuits;
                circuitsComboBox.DisplayMember = "Name";
                circuitsComboBox.SelectedIndexChanged += circuitsComboBox_SelectedIndexChanged;
                RebuildTree();
            }
        }

        private void circuitPictureBox_Paint(object sender, PaintEventArgs e)
        {
            CircuitDrawer.PictureGraphics = e.Graphics;
            Circuit a = new Circuit();
            a.SubSegments.Add(new ParallelSegment());
            a.SubSegments[0].SubSegments.Add(new Resistor());
            a.SubSegments[0].SubSegments.Add(new Resistor());
            a.SubSegments[0].SubSegments.Add(new ParallelSegment());
            a.SubSegments[0].SubSegments[2].SubSegments.Add(new Resistor());
            a.SubSegments[0].SubSegments[2].SubSegments.Add(new SerialSegment());
            a.SubSegments[0].SubSegments[2].SubSegments[1].SubSegments.Add(new Resistor());
            a.SubSegments[0].SubSegments[2].SubSegments[1].SubSegments.Add(new ParallelSegment());
            a.SubSegments[0].SubSegments[2].SubSegments[1].SubSegments[1].SubSegments.Add(new Resistor());
            a.SubSegments[0].SubSegments[2].SubSegments[1].SubSegments[1].SubSegments.Add(new Resistor());
            a.SubSegments[0].SubSegments[2].SubSegments[1].SubSegments[1].SubSegments.Add(new SerialSegment());
            a.SubSegments[0].SubSegments[2].SubSegments[1].SubSegments[1].SubSegments[2].SubSegments.Add(new Resistor());
            a.SubSegments[0].SubSegments[2].SubSegments[1].SubSegments[1].SubSegments[2].SubSegments.Add(new ParallelSegment());
            a.SubSegments[0].SubSegments[2].SubSegments[1].SubSegments[1].SubSegments[2].SubSegments[1].SubSegments.Add(new Resistor());
            a.SubSegments[0].SubSegments[2].SubSegments[1].SubSegments[1].SubSegments[2].SubSegments[1].SubSegments.Add(new Resistor());
            //a.SubSegments[0].SubSegments[2].SubSegments.Add(new Resistor());
            //a.SubSegments[0].SubSegments[2].SubSegments.Add(new Resistor());
            //CircuitDrawer.DrawCircuit(new PictureNode(a.SubSegments[0]));
            CircuitDrawer.DrawCircuit(new PictureNode((circuitsComboBox.SelectedItem as Circuit).SubSegments[0]));
        }

    }
}
