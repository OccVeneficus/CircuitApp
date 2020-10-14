using CircutApp;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
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
            //TODO: не многовато ли методов Initialize()? Вводят путаницу в назначении. И при этом ни один из них не создаёт экземпляр проекта
            _project = new Project();
            BindDefaultCircuitsChangeEvents();
            BindDataSources();
            RebuildTree(); //TODO: Re - это не самостоятельное слово (done)
            circuitElementsTreeView.SelectedNode = circuitElementsTreeView.Nodes[0];
        }

        private void BindDefaultCircuitsChangeEvents()
        {
            //TODO: это не должно делаться в форме - сделай отдельный класс для инициализации проекта включая частоты и пр.
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
                    .CalculateZ(_project.Frequencies[circuitsComboBox.SelectedIndex]);
            RebindDataSources();
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

        private void PopulateTree(TreeNode currentNode, EventDrivenCollection subSegments)
        {
            foreach (var segment in subSegments)
            {
               DefineTreeNode(currentNode,segment);
            }
        }
        //TODO: DefineTreeNode() (done)?
        private void DefineTreeNode(TreeNode currentNode, ISegment segment)
        {
            //TODO: Если у цепей сделать дефолтное имя, то от свитча можно будет избавиться (done)
            var node = new TreeNode
            {
                Text = segment.Name,
                Tag = segment
            };
            currentNode.Nodes.Add(node);
            if (segment.SubSegments != null)
            {
                foreach (var s in segment.SubSegments)
                {
                    DefineTreeNode(currentNode.LastNode, s);
                }
            }
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
            PopulateTree(circuitElementsTreeView.Nodes[0],
                _project.Circuits[circuitsComboBox.SelectedIndex].SubSegments[0].SubSegments);
            circuitElementsTreeView.ExpandAll();
        }

        private void frequencyInputTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && (frequencyInputTextBox.Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
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
                        .CalculateZ(_project.Frequencies[circuitsComboBox.SelectedIndex]);
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

        private void MoveToElement(TreeNode targetNode, TreeNode draggedNode,
            TreeNode draggedNodeParent, TreeNode targetNodeParent)
        {
            //TODO: var (done)
            var form = new ConnectionTypeForm();
            form.ShowDialog();
            if (form.DialogResult == DialogResult.OK)
            {
                form.Type.SubSegments.Add(targetNode.Tag as ISegment);
                form.Type.SubSegments.Add(draggedNode.Tag as ISegment);
                (targetNodeParent.Tag as ISegment)?.SubSegments.Add(form.Type);
                if (draggedNodeParent.Tag is ISegment s)
                {
                    s.SubSegments.Remove(draggedNode.Tag as ISegment);
                }
                else if (draggedNodeParent.Tag is Circuit c)
                {
                    c.SubSegments.Remove(draggedNode.Tag as ISegment);
                }
                (targetNodeParent.Tag as ISegment)?.SubSegments.Remove(targetNode.Tag as ISegment);
                //TODO: здоровенный кусок кода дублируется только потому, что в качестве корня дерева используется не ISegment
                RebuildTree();
            }
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
            
            if (!draggedNode.Equals(targetNode) && !ContainsNode(draggedNode, targetNode))
            {
                if (e.Effect == DragDropEffects.Move)
                {
                    if (targetNode.Tag is Element)
                    {
                        MoveToElement(targetNode,draggedNode,draggedNodeParent,targetNodeParent);
                        return;
                    }
                    (draggedNodeParent.Tag as ISegment)?.SubSegments.Remove(draggedNode.Tag as ISegment);
                    //TODO: опять ветвление из Circuit
                    draggedNode.Remove();
                    targetNode.Nodes.Add(draggedNode);
                }

                (targetNode.Tag as ISegment)?.SubSegments.Add((ISegment)draggedNode.Tag); //TODO: и снова

                /*Remove empty segment*/
                if (draggedNodeParent.Tag is Segment && draggedNodeParent.Nodes.Count == 0)
                {
                    draggedNodeParent.Remove();
                    RecursiveRemove(_project.Circuits[circuitsComboBox.SelectedIndex].SubSegments,
                        draggedNodeParent.Tag as ISegment);
                }
                targetNode.Expand();
            }
        }

        private void RecursiveRemove(EventDrivenCollection subSegments, ISegment toDelete)
        {
            if (subSegments == null)
            {
                return;
            }
            bool isDeleted = subSegments.Remove(toDelete);
            if (!isDeleted)
            {
                foreach (var s in subSegments)
                {
                    RecursiveRemove(s.SubSegments,toDelete);
                }
            }
        }

        //TODO: мне кажется, работу с нодами надо вынести в отдельный класс. В главной форме слишком много логики. Либо бить окно на контролы
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
                RecursiveRemove(_project.Circuits[circuitsComboBox.SelectedIndex].SubSegments,
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
                //TODO: одинаковые ветки - избавиться с помощью полиморфизма}
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
                        } //TODO: избавиться от дублирования
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
            _project.Circuits[circuitsComboBox.SelectedIndex].SubSegments.Add(form.Type);
            RebuildTree();
        }

        private void editElementButton_Click(object sender, EventArgs e)
        {
            if (circuitElementsTreeView.SelectedNode.Tag is Element element)
            {
                var form = new ElementForm
                {
                    ElementType = element.GetType(),
                    ElementName = element.Name,
                    ElementValue = element.Value
                };
                form.ShowDialog();
                if (form.DialogResult == DialogResult.OK)
                {
                    var editElement = Activator.CreateInstance(form.ElementType);
                    ((Element) editElement).Value = form.ElementValue;
                    ((Element) editElement).Name = form.ElementName;
                    circuitElementsTreeView.SelectedNode.Tag = editElement;
                    ReplaceElement(circuitElementsTreeView.SelectedNode,
                        _project.Circuits[circuitsComboBox.SelectedIndex].SubSegments,
                        editElement as ISegment);
                }
            }
            else if (circuitElementsTreeView.SelectedNode.Tag is Segment segment)
            {
                ConnectionTypeForm connectionForm = new ConnectionTypeForm
                {
                    Type = segment
                };
                connectionForm.ShowDialog();
                if (connectionForm.DialogResult == DialogResult.OK)
                {
                    (connectionForm.Type as Segment).SubSegments = segment.SubSegments;
                    ReplaceElement(circuitElementsTreeView.SelectedNode,
                            _project.Circuits[circuitsComboBox.SelectedIndex].SubSegments[0].SubSegments,
                            (connectionForm.Type as Segment));
                }
            }
        }

        private (List<int>, ISegment) FindPath(TreeNode currentNode,
            EventDrivenCollection currentSegment)
        {
            var path = new List<int>();
            while (currentNode.Parent != null)
            {
                path.Insert(0, currentNode.Index);
                currentNode = currentNode.Parent;
            }

            ISegment segment = currentSegment[path[0]];

            foreach (var index in path.Skip(1))
            {
                segment = segment.SubSegments[index];
            }

            return (path, segment);
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

        private void ReplaceElement(TreeNode currentNode, EventDrivenCollection currentSegment,
            ISegment replace)
        {
            var replaceNode = currentNode;
            var pathAndItem = FindPath(currentNode, currentSegment);

            RecursiveRemove(currentSegment, pathAndItem.Item2);

            int replaceIndex = pathAndItem.Item1[pathAndItem.Item1.Count - 1];

            if (replaceNode.Parent.Parent != null)
            {
                pathAndItem.Item1.RemoveAt(pathAndItem.Item1.Count - 1);
                pathAndItem.Item2 = currentSegment[pathAndItem.Item1[0]];
                foreach (var index in pathAndItem.Item1.Skip(1))
                {
                    pathAndItem.Item2 = pathAndItem.Item2.SubSegments[index];
                }
                pathAndItem.Item2.SubSegments.Insert(replaceIndex, replace);
                pathAndItem.Item1.Add(replaceIndex);
                ChooseTreeNodeAfterReplace(pathAndItem.Item1);
                return;
            }
            currentSegment.Insert(replaceIndex, replace);
            ChooseTreeNodeAfterReplace(pathAndItem.Item1);
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
    }
}
