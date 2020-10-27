namespace CircuitAppUI.Forms
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.removeElementButton = new System.Windows.Forms.Button();
            this.editElementButton = new System.Windows.Forms.Button();
            this.addElementButton = new System.Windows.Forms.Button();
            this.typeLabel = new System.Windows.Forms.Label();
            this.valueLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.elementTypeTextBox = new System.Windows.Forms.TextBox();
            this.elementValueTextBox = new System.Windows.Forms.TextBox();
            this.elementNameTextBox = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.addFrequencyButton = new System.Windows.Forms.Button();
            this.deleteFrequencyButton = new System.Windows.Forms.Button();
            this.frequencyInputTextBox = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.frequenciesListBox = new System.Windows.Forms.ListBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.impedancesListBox = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.addSegmentButton = new System.Windows.Forms.Button();
            this.editCircuitButton = new System.Windows.Forms.Button();
            this.removeCircuitButton = new System.Windows.Forms.Button();
            this.addCircuitButton = new System.Windows.Forms.Button();
            this.circuitElementsTreeView = new System.Windows.Forms.TreeView();
            this.circuitsComboBox = new System.Windows.Forms.ComboBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.circuitPictureBox = new System.Windows.Forms.PictureBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.circuitPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1355, 699);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22F));
            this.tableLayoutPanel2.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel3, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel4, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel5, 3, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 527);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1349, 169);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(452, 163);
            this.panel2.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.removeElementButton);
            this.groupBox4.Controls.Add(this.editElementButton);
            this.groupBox4.Controls.Add(this.addElementButton);
            this.groupBox4.Controls.Add(this.typeLabel);
            this.groupBox4.Controls.Add(this.valueLabel);
            this.groupBox4.Controls.Add(this.nameLabel);
            this.groupBox4.Controls.Add(this.elementTypeTextBox);
            this.groupBox4.Controls.Add(this.elementValueTextBox);
            this.groupBox4.Controls.Add(this.elementNameTextBox);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(0, 0);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(452, 163);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Current Element";
            // 
            // removeElementButton
            // 
            this.removeElementButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.removeElementButton.Location = new System.Drawing.Point(327, 105);
            this.removeElementButton.Name = "removeElementButton";
            this.removeElementButton.Size = new System.Drawing.Size(110, 28);
            this.removeElementButton.TabIndex = 9;
            this.removeElementButton.Text = "Remove";
            this.removeElementButton.UseVisualStyleBackColor = true;
            this.removeElementButton.Click += new System.EventHandler(this.removeElementButton_Click);
            // 
            // editElementButton
            // 
            this.editElementButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.editElementButton.Location = new System.Drawing.Point(327, 66);
            this.editElementButton.Name = "editElementButton";
            this.editElementButton.Size = new System.Drawing.Size(110, 27);
            this.editElementButton.TabIndex = 8;
            this.editElementButton.Text = "Edit";
            this.editElementButton.UseVisualStyleBackColor = true;
            this.editElementButton.Click += new System.EventHandler(this.editElementButton_Click);
            // 
            // addElementButton
            // 
            this.addElementButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.addElementButton.Location = new System.Drawing.Point(327, 25);
            this.addElementButton.Name = "addElementButton";
            this.addElementButton.Size = new System.Drawing.Size(110, 28);
            this.addElementButton.TabIndex = 7;
            this.addElementButton.Text = "Add";
            this.addElementButton.UseVisualStyleBackColor = true;
            this.addElementButton.Click += new System.EventHandler(this.addElementButton_Click);
            // 
            // typeLabel
            // 
            this.typeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.typeLabel.AutoSize = true;
            this.typeLabel.Location = new System.Drawing.Point(6, 111);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(44, 17);
            this.typeLabel.TabIndex = 5;
            this.typeLabel.Text = "Type:";
            // 
            // valueLabel
            // 
            this.valueLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.valueLabel.AutoSize = true;
            this.valueLabel.Location = new System.Drawing.Point(6, 71);
            this.valueLabel.Name = "valueLabel";
            this.valueLabel.Size = new System.Drawing.Size(48, 17);
            this.valueLabel.TabIndex = 4;
            this.valueLabel.Text = "Value:";
            // 
            // nameLabel
            // 
            this.nameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(6, 31);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(49, 17);
            this.nameLabel.TabIndex = 3;
            this.nameLabel.Text = "Name:";
            // 
            // elementTypeTextBox
            // 
            this.elementTypeTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.elementTypeTextBox.Enabled = false;
            this.elementTypeTextBox.Location = new System.Drawing.Point(59, 108);
            this.elementTypeTextBox.Name = "elementTypeTextBox";
            this.elementTypeTextBox.Size = new System.Drawing.Size(262, 22);
            this.elementTypeTextBox.TabIndex = 2;
            // 
            // elementValueTextBox
            // 
            this.elementValueTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.elementValueTextBox.Enabled = false;
            this.elementValueTextBox.Location = new System.Drawing.Point(59, 68);
            this.elementValueTextBox.Name = "elementValueTextBox";
            this.elementValueTextBox.Size = new System.Drawing.Size(262, 22);
            this.elementValueTextBox.TabIndex = 1;
            // 
            // elementNameTextBox
            // 
            this.elementNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.elementNameTextBox.Enabled = false;
            this.elementNameTextBox.Location = new System.Drawing.Point(59, 28);
            this.elementNameTextBox.MaxLength = 40;
            this.elementNameTextBox.Name = "elementNameTextBox";
            this.elementNameTextBox.Size = new System.Drawing.Size(262, 22);
            this.elementNameTextBox.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.groupBox3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(461, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(290, 163);
            this.panel3.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.addFrequencyButton);
            this.groupBox3.Controls.Add(this.deleteFrequencyButton);
            this.groupBox3.Controls.Add(this.frequencyInputTextBox);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(290, 163);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Frequency Input";
            // 
            // addFrequencyButton
            // 
            this.addFrequencyButton.Location = new System.Drawing.Point(31, 66);
            this.addFrequencyButton.Name = "addFrequencyButton";
            this.addFrequencyButton.Size = new System.Drawing.Size(110, 27);
            this.addFrequencyButton.TabIndex = 4;
            this.addFrequencyButton.Text = "Add";
            this.addFrequencyButton.UseVisualStyleBackColor = true;
            this.addFrequencyButton.Click += new System.EventHandler(this.addFrequencyButton_Click);
            // 
            // deleteFrequencyButton
            // 
            this.deleteFrequencyButton.Location = new System.Drawing.Point(147, 66);
            this.deleteFrequencyButton.Name = "deleteFrequencyButton";
            this.deleteFrequencyButton.Size = new System.Drawing.Size(110, 27);
            this.deleteFrequencyButton.TabIndex = 3;
            this.deleteFrequencyButton.Text = "Delete";
            this.deleteFrequencyButton.UseVisualStyleBackColor = true;
            this.deleteFrequencyButton.Click += new System.EventHandler(this.deleteFrequencyButton_Click);
            // 
            // frequencyInputTextBox
            // 
            this.frequencyInputTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.frequencyInputTextBox.Location = new System.Drawing.Point(31, 28);
            this.frequencyInputTextBox.Name = "frequencyInputTextBox";
            this.frequencyInputTextBox.Size = new System.Drawing.Size(226, 22);
            this.frequencyInputTextBox.TabIndex = 0;
            this.frequencyInputTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frequencyInputTextBox_KeyPress);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.groupBox2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(757, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(290, 163);
            this.panel4.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.frequenciesListBox);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(290, 163);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Frequencies";
            // 
            // frequenciesListBox
            // 
            this.frequenciesListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.frequenciesListBox.FormattingEnabled = true;
            this.frequenciesListBox.ItemHeight = 16;
            this.frequenciesListBox.Location = new System.Drawing.Point(3, 21);
            this.frequenciesListBox.Name = "frequenciesListBox";
            this.frequenciesListBox.Size = new System.Drawing.Size(287, 132);
            this.frequenciesListBox.TabIndex = 1;
            this.frequenciesListBox.SelectedIndexChanged += new System.EventHandler(this.frequenciesListBox_SelectedIndexChanged);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.groupBox1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(1053, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(293, 163);
            this.panel5.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.impedancesListBox);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(293, 163);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Impedances";
            // 
            // impedancesListBox
            // 
            this.impedancesListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.impedancesListBox.FormattingEnabled = true;
            this.impedancesListBox.ItemHeight = 16;
            this.impedancesListBox.Location = new System.Drawing.Point(6, 21);
            this.impedancesListBox.Name = "impedancesListBox";
            this.impedancesListBox.Size = new System.Drawing.Size(287, 132);
            this.impedancesListBox.TabIndex = 0;
            this.impedancesListBox.SelectedIndexChanged += new System.EventHandler(this.impedancesListBox_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1349, 518);
            this.panel1.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.panel6, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.panel7, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1349, 518);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.addSegmentButton);
            this.panel6.Controls.Add(this.editCircuitButton);
            this.panel6.Controls.Add(this.removeCircuitButton);
            this.panel6.Controls.Add(this.addCircuitButton);
            this.panel6.Controls.Add(this.circuitElementsTreeView);
            this.panel6.Controls.Add(this.circuitsComboBox);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(3, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(382, 512);
            this.panel6.TabIndex = 0;
            // 
            // addSegmentButton
            // 
            this.addSegmentButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.addSegmentButton.Location = new System.Drawing.Point(257, 480);
            this.addSegmentButton.Name = "addSegmentButton";
            this.addSegmentButton.Size = new System.Drawing.Size(119, 29);
            this.addSegmentButton.TabIndex = 5;
            this.addSegmentButton.Text = "Add segment";
            this.addSegmentButton.UseVisualStyleBackColor = true;
            this.addSegmentButton.Click += new System.EventHandler(this.addSegmentButton_Click);
            // 
            // editCircuitButton
            // 
            this.editCircuitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.editCircuitButton.Location = new System.Drawing.Point(188, 480);
            this.editCircuitButton.Name = "editCircuitButton";
            this.editCircuitButton.Size = new System.Drawing.Size(63, 29);
            this.editCircuitButton.TabIndex = 4;
            this.editCircuitButton.Text = "Edit";
            this.editCircuitButton.UseVisualStyleBackColor = true;
            this.editCircuitButton.Click += new System.EventHandler(this.editCircuitButton_Click);
            // 
            // removeCircuitButton
            // 
            this.removeCircuitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.removeCircuitButton.Location = new System.Drawing.Point(108, 480);
            this.removeCircuitButton.Name = "removeCircuitButton";
            this.removeCircuitButton.Size = new System.Drawing.Size(74, 29);
            this.removeCircuitButton.TabIndex = 3;
            this.removeCircuitButton.Text = "Remove";
            this.removeCircuitButton.UseVisualStyleBackColor = true;
            this.removeCircuitButton.Click += new System.EventHandler(this.deleteCircuitButton_Click);
            // 
            // addCircuitButton
            // 
            this.addCircuitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.addCircuitButton.Location = new System.Drawing.Point(3, 480);
            this.addCircuitButton.Name = "addCircuitButton";
            this.addCircuitButton.Size = new System.Drawing.Size(99, 29);
            this.addCircuitButton.TabIndex = 2;
            this.addCircuitButton.Text = "Add circuit";
            this.addCircuitButton.UseVisualStyleBackColor = true;
            this.addCircuitButton.Click += new System.EventHandler(this.addCircuitButton_Click);
            // 
            // circuitElementsTreeView
            // 
            this.circuitElementsTreeView.AllowDrop = true;
            this.circuitElementsTreeView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.circuitElementsTreeView.Location = new System.Drawing.Point(3, 36);
            this.circuitElementsTreeView.Name = "circuitElementsTreeView";
            this.circuitElementsTreeView.Size = new System.Drawing.Size(373, 438);
            this.circuitElementsTreeView.TabIndex = 1;
            this.circuitElementsTreeView.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.circuitElementsTreeView_ItemDrag);
            this.circuitElementsTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.circuitElementsTreeView_AfterSelect);
            this.circuitElementsTreeView.DragDrop += new System.Windows.Forms.DragEventHandler(this.circuitElementsTreeView_DragDrop);
            this.circuitElementsTreeView.DragEnter += new System.Windows.Forms.DragEventHandler(this.circuitElementsTreeView_DragEnter);
            this.circuitElementsTreeView.DragOver += new System.Windows.Forms.DragEventHandler(this.circuitElementsTreeView_DragOver);
            // 
            // circuitsComboBox
            // 
            this.circuitsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.circuitsComboBox.FormattingEnabled = true;
            this.circuitsComboBox.Location = new System.Drawing.Point(3, 6);
            this.circuitsComboBox.Name = "circuitsComboBox";
            this.circuitsComboBox.Size = new System.Drawing.Size(373, 24);
            this.circuitsComboBox.TabIndex = 0;
            this.circuitsComboBox.SelectedIndexChanged += new System.EventHandler(this.circuitsComboBox_SelectedIndexChanged);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.circuitPictureBox);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(391, 3);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(955, 512);
            this.panel7.TabIndex = 1;
            // 
            // circuitPictureBox
            // 
            this.circuitPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.circuitPictureBox.Location = new System.Drawing.Point(0, 0);
            this.circuitPictureBox.Name = "circuitPictureBox";
            this.circuitPictureBox.Size = new System.Drawing.Size(955, 512);
            this.circuitPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.circuitPictureBox.TabIndex = 0;
            this.circuitPictureBox.TabStop = false;
            this.circuitPictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.circuitPictureBox_Paint);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1355, 699);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Impedance Calculation";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.circuitPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox frequenciesListBox;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox impedancesListBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TreeView circuitElementsTreeView;
        private System.Windows.Forms.ComboBox circuitsComboBox;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.PictureBox circuitPictureBox;
        private System.Windows.Forms.TextBox frequencyInputTextBox;
        private System.Windows.Forms.Button editCircuitButton;
        private System.Windows.Forms.Button removeCircuitButton;
        private System.Windows.Forms.Button addCircuitButton;
        private System.Windows.Forms.Button addFrequencyButton;
        private System.Windows.Forms.Button deleteFrequencyButton;
        private System.Windows.Forms.TextBox elementNameTextBox;
        private System.Windows.Forms.Button removeElementButton;
        private System.Windows.Forms.Button editElementButton;
        private System.Windows.Forms.Button addElementButton;
        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.Label valueLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox elementTypeTextBox;
        private System.Windows.Forms.TextBox elementValueTextBox;
        private System.Windows.Forms.Button addSegmentButton;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

