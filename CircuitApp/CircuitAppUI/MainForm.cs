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
            Initialize();
            InitializeProject();
            BindDataSources();
            ReBuildTree(); //TODO: Re - это не самостоятельное слово
            circuitElementsTreeView.SelectedNode = circuitElementsTreeView.Nodes[0];
        }

        private void InitializeProject()
        {
            //TODO: это не должно делаться в форме - сделай отдельный класс для инициализации проекта включая частоты и пр.
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
            _project.Circuits[2].SubSegments[0].SubSegments.Add(new Resistor(){Name = "R33"
                ,Value = 10});
            _project.Circuits[2].SubSegments[0].SubSegments.Add(new ParallelCircuit());
            _project.Circuits[2].SubSegments[0].SubSegments[1].SubSegments.Add(new Resistor()
                { Name = "R34", Value = 10 });
            _project.Circuits[2].SubSegments[0].SubSegments[1].SubSegments.Add(new Resistor()
                { Name = "R35", Value = 10 });

            _project.Circuits.Add(new Circuit() { Name = "Circuit4" });
            _project.Circuits[3].SubSegments.Add(new Resistor(){Name = "R1", Value = 30.0});
            _project.Circuits[3].SubSegments.Add(new Resistor() { Name = "R2", Value = 40.0 });


            _project.Circuits.Add(new Circuit() { Name = "Circuit5" });
            for (int i = 0; i < 5; i++)
            {
                _project.ImpedanceZ[i].AddRange(_project.Circuits[i].CalculateZ
                    (_project.Frequencies[i]));
                _project.Circuits[i].CircuitChanged += Circuit_SegmentChanged;
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
            _project.ImpedanceZ[circuitsComboBox.SelectedIndex] =
                _project.Circuits[circuitsComboBox.SelectedIndex]
                    .CalculateZ(_project.Frequencies[circuitsComboBox.SelectedIndex]);
            ReBindDataSources();
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
            ReBuildTree();
            circuitElementsTreeView.SelectedNode = circuitElementsTreeView.Nodes[0];
        }

        private void ReBindDataSources()
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
               BuildTree(currentNode,segment);
            }
        }
        //TODO: DefineTreeNode()?
        private void BuildTree(TreeNode currentNode, ISegment segment)
        {
            var node = new TreeNode();
            switch (segment)
            { //TODO: IElement?
                case Element a:
                {
                    node.Text = a.Name;
                    node.Tag = a;
                    break;
                }
                //TODO: Если у цепей сделать дефолтное имя, то от свитча можно будет избавиться
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

        private void ReBuildTree()
        {
            circuitElementsTreeView.Nodes.Clear();
            if (circuitsComboBox.Items.Count == 0)
            {
                return;
            }
            circuitElementsTreeView.Nodes.Add(new TreeNode()
            { 
                Tag = _project.Circuits[circuitsComboBox.SelectedIndex],
                Text = ((Circuit)circuitsComboBox.SelectedItem).Name
            });
            PopulateTree(circuitElementsTreeView.Nodes[0],
                _project.Circuits[circuitsComboBox.SelectedIndex].SubSegments);
            circuitElementsTreeView.ExpandAll();
        }

        private void frequencyInputTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && (frequencyImputTextBox.Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void addFrequencyButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(frequencyImputTextBox.Text) || 
                !double.TryParse(frequencyImputTextBox.Text, NumberStyles.Float,
                    CultureInfo.InvariantCulture, out _))
            {
                //TODO: грамошибка
                frequencyImputTextBox.BackColor = Color.LightCoral;
                MessageBox.Show(@"You can't add empty space or strings to frequencies.",
                    @"Wrong input", MessageBoxButtons.OK);
            }
            else
            {
                _project.Frequencies[circuitsComboBox.SelectedIndex].Add
                    (Convert.ToDouble(frequencyImputTextBox.Text, CultureInfo.InvariantCulture));
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
                case SerialCircuit _:
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

        private void MoveToElement(TreeNode targetNode, TreeNode draggedNode,
            TreeNode draggedNodeParent, TreeNode targetNodeParent)
        {
            //TODO: var
            ChooseConnectionTypeForm form = new ChooseConnectionTypeForm();
            form.ShowDialog();
            if (form.DialogResult == DialogResult.OK)
            {
                if (targetNodeParent.Tag is ISegment segment)
                {
                    form.Type.SubSegments.Add(targetNode.Tag as ISegment);
                    form.Type.SubSegments.Add(draggedNode.Tag as ISegment);
                    segment.SubSegments.Add(form.Type);
                    if (draggedNodeParent.Tag is ISegment s)
                    {
                        s.SubSegments.Remove(draggedNode.Tag as ISegment);
                    }
                    else if (draggedNodeParent.Tag is Circuit c)
                    {
                        c.SubSegments.Remove(draggedNode.Tag as ISegment);
                    }
                    segment.SubSegments.Remove(targetNode.Tag as ISegment);
                }
                else if (targetNodeParent.Tag is Circuit circuit)
                {
                    //TODO: здоровенный кусок кода дублируется только потому, что в качестве корня дерева используется не ISegment
                    form.Type.SubSegments.Add(targetNode.Tag as ISegment);
                    form.Type.SubSegments.Add(draggedNode.Tag as ISegment);
                    circuit.SubSegments.Add(form.Type);
                    if (draggedNodeParent.Tag is ISegment s)
                    {
                        s.SubSegments.Remove(draggedNode.Tag as ISegment);
                    }
                    else if (draggedNodeParent.Tag is Circuit c)
                    {
                        c.SubSegments.Remove(draggedNode.Tag as ISegment);
                    }
                    circuit.SubSegments.Remove(targetNode.Tag as ISegment);
                }
                ReBuildTree();
            }
        }

        private void circuitElementsTreeView_DragDrop(object sender, DragEventArgs e)
        {
            //TODO: var
            Point targetPoint = circuitElementsTreeView.PointToClient(new Point(e.X, e.Y));
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
                    if (draggedNodeParent.Tag is ISegment s)
                    {
                        s.SubSegments.Remove(draggedNode.Tag as ISegment);
                    } //TODO: опять ветвление из Circuit
                    else if (draggedNodeParent.Tag is Circuit c)
                    {
                        c.SubSegments.Remove(draggedNode.Tag as ISegment);
                    }
                    draggedNode.Remove();
                    targetNode.Nodes.Add(draggedNode);
                }
                else if (e.Effect == DragDropEffects.Copy)
                {
                    targetNode.Nodes.Add((TreeNode) draggedNode.Clone());
                }

                if (targetNode.Tag is ISegment segment)
                {
                    segment.SubSegments.Add((ISegment)draggedNode.Tag);
                } //TODO: и снова
                else if (targetNode.Tag is Circuit circuit)
                {
                    circuit.SubSegments.Add((ISegment)draggedNode.Tag);
                }

                /*Remove empty segment*/
                if ((draggedNodeParent.Tag is SerialCircuit || 
                     draggedNodeParent.Tag is ParallelCircuit) &&
                     draggedNodeParent.Nodes.Count == 0)
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
                ReBindDataSources();
                ReBuildTree();
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
            AddEditElementForm form = new AddEditElementForm();
            form.ElementName = "";
            form.ElementValue = new double();
            form.ElementType = typeof(Resistor);
            form.ShowDialog();
            if (form.DialogResult == DialogResult.OK)
            {
                var newElement = Activator.CreateInstance(form.ElementType);
                ((Element) newElement).Value = form.ElementValue;
                ((Element) newElement).Name = form.ElementName;
                if (circuitElementsTreeView.SelectedNode == null ||
                    circuitElementsTreeView.SelectedNode.Tag is Circuit)
                {
                    _project.Circuits[circuitsComboBox.SelectedIndex].SubSegments.Add
                        (newElement as ISegment);
                }
                else if (circuitElementsTreeView.SelectedNode.Tag is ParallelCircuit parallelSegment)
                {
                    parallelSegment.SubSegments.Add(newElement as ISegment);
                }
                else if (circuitElementsTreeView.SelectedNode.Tag is SerialCircuit serialSegment)
                {
                    serialSegment.SubSegments.Add(newElement as ISegment);
                }
                else if (circuitElementsTreeView.SelectedNode.Tag is Element element)
                {
                    ChooseConnectionTypeForm chooseConnectionForm = new ChooseConnectionTypeForm();
                    chooseConnectionForm.ShowDialog();
                    if (chooseConnectionForm.DialogResult == DialogResult.OK)
                    {
                        if (circuitElementsTreeView.SelectedNode.Parent.Tag is ISegment segment)
                        {
                            chooseConnectionForm.Type.SubSegments.Add(newElement as ISegment);
                            chooseConnectionForm.Type.SubSegments.Add(element);
                            segment.SubSegments.Remove(element);
                            segment.SubSegments.Add(chooseConnectionForm.Type);
                        }
                        else if (circuitElementsTreeView.SelectedNode.Parent.Tag is Circuit circuit)
                        {
                            chooseConnectionForm.Type.SubSegments.Add(newElement as ISegment);
                            chooseConnectionForm.Type.SubSegments.Add(element);
                            circuit.SubSegments.Remove(element);
                            circuit.SubSegments.Add(chooseConnectionForm.Type);
                        }
                    }
                    else
                    {
                        return;
                    }
                }
                ReBuildTree();
            }
        }

        private void addSegmentButton_Click(object sender, EventArgs e)
        {
            ChooseConnectionTypeForm form = new ChooseConnectionTypeForm();
            form.ShowDialog();
            if (form.DialogResult == DialogResult.Cancel)
            {
                return;
            }
            _project.Circuits[circuitsComboBox.SelectedIndex].SubSegments.Add(form.Type);
            ReBuildTree();
        }

        private void editElementButton_Click(object sender, EventArgs e)
        {
            if (circuitElementsTreeView.SelectedNode.Tag is Element element)
            {
                AddEditElementForm addEditForm = new AddEditElementForm();
                addEditForm.ElementType = element.GetType();
                addEditForm.ElementName = element.Name;
                addEditForm.ElementValue = element.Value;
                addEditForm.ShowDialog();
                if (addEditForm.DialogResult == DialogResult.OK)
                {
                    var editElement = Activator.CreateInstance(addEditForm.ElementType);
                    ((Element) editElement).Value = addEditForm.ElementValue;
                    ((Element) editElement).Name = addEditForm.ElementName;
                    circuitElementsTreeView.SelectedNode.Tag = editElement;
                    ReplaceElement(circuitElementsTreeView.SelectedNode,
                        _project.Circuits[circuitsComboBox.SelectedIndex].SubSegments,
                        editElement as ISegment);
                }
            }
            else if (circuitElementsTreeView.SelectedNode.Tag is SerialCircuit serial)
            {
                ChooseConnectionTypeForm chooseConnectionForm = new ChooseConnectionTypeForm
                {
                    Type = serial
                };
                chooseConnectionForm.ShowDialog();
                if (chooseConnectionForm.DialogResult == DialogResult.OK)
                {
                    if (chooseConnectionForm.Type is ParallelCircuit parallelSegment)
                    {
                        parallelSegment.SubSegments = serial.SubSegments;
                        ReplaceElement(circuitElementsTreeView.SelectedNode,
                            _project.Circuits[circuitsComboBox.SelectedIndex].SubSegments,
                            parallelSegment);
                    }
                }
            }
            else if (circuitElementsTreeView.SelectedNode.Tag is ParallelCircuit parallel)
            {

                ChooseConnectionTypeForm chooseConnectionForm = new ChooseConnectionTypeForm
                {
                    Type = parallel
                };
                chooseConnectionForm.ShowDialog();
                if (chooseConnectionForm.DialogResult == DialogResult.OK)
                {
                    if (chooseConnectionForm.Type is SerialCircuit parallelSegment)
                    {
                        parallelSegment.SubSegments = parallel.SubSegments;
                        ReplaceElement(circuitElementsTreeView.SelectedNode,
                            _project.Circuits[circuitsComboBox.SelectedIndex].SubSegments,
                            parallelSegment);
                    }

                }
            }
            else if (circuitElementsTreeView.SelectedNode.Tag is Circuit)
            {
                editCircuitButton_Click(sender,e);
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
            ReBuildTree();
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
            AddEditCircuitForm form = new AddEditCircuitForm();
            form.Circuit = new Circuit();
            form.ShowDialog();
            if (form.DialogResult == DialogResult.OK)
            {
                _project.Circuits.Add(form.Circuit);
                circuitsComboBox.SelectedIndexChanged -= circuitsComboBox_SelectedIndexChanged;
                circuitsComboBox.DataSource = null;
                circuitsComboBox.DataSource = _project.Circuits;
                circuitsComboBox.DisplayMember = "Name";
                circuitsComboBox.SelectedIndexChanged += circuitsComboBox_SelectedIndexChanged;
                _project.ImpedanceZ.Add(new List<Complex>());
                _project.Frequencies.Add(new List<double>());
                ReBuildTree();
            }

        }

        private void editCircuitButton_Click(object sender, EventArgs e)
        {
            AddEditCircuitForm form = new AddEditCircuitForm();

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
                ReBuildTree();
            }
        }
    }
}
