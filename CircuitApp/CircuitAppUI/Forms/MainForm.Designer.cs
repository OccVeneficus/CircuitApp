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
            this.buttonsImageList = new System.Windows.Forms.ImageList(this.components);
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
            this.calculationsGroupBox = new System.Windows.Forms.GroupBox();
            this.calculationsTabel = new System.Windows.Forms.DataGridView();
            this.FrequenciesColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImpedancesColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.addElementToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.calculationsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.calculationsTabel)).BeginInit();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.circuitPictureBox)).BeginInit();
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
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1016, 568);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.61379F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.41586F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 59.97035F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanel2.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel3, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel4, 2, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(2, 428);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1012, 138);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(2, 2);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(285, 134);
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
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox4.Size = new System.Drawing.Size(285, 134);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Current Element";
            // 
            // removeElementButton
            // 
            this.removeElementButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.removeElementButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.removeElementButton.FlatAppearance.BorderSize = 0;
            this.removeElementButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.removeElementButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeElementButton.ImageIndex = 2;
            this.removeElementButton.ImageList = this.buttonsImageList;
            this.removeElementButton.Location = new System.Drawing.Point(232, 52);
            this.removeElementButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.removeElementButton.Name = "removeElementButton";
            this.removeElementButton.Size = new System.Drawing.Size(35, 30);
            this.removeElementButton.TabIndex = 8;
            this.addElementToolTip.SetToolTip(this.removeElementButton, "Delete selected element");
            this.removeElementButton.UseVisualStyleBackColor = true;
            this.removeElementButton.Click += new System.EventHandler(this.removeElementButton_Click);
            // 
            // buttonsImageList
            // 
            this.buttonsImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("buttonsImageList.ImageStream")));
            this.buttonsImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.buttonsImageList.Images.SetKeyName(0, "plus (3).png");
            this.buttonsImageList.Images.SetKeyName(1, "pencil.png");
            this.buttonsImageList.Images.SetKeyName(2, "minus (2).png");
            this.buttonsImageList.Images.SetKeyName(3, "git_branch_icon_151328.png");
            // 
            // editElementButton
            // 
            this.editElementButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.editElementButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editElementButton.FlatAppearance.BorderSize = 0;
            this.editElementButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.editElementButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editElementButton.ImageIndex = 1;
            this.editElementButton.ImageList = this.buttonsImageList;
            this.editElementButton.Location = new System.Drawing.Point(232, 87);
            this.editElementButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.editElementButton.Name = "editElementButton";
            this.editElementButton.Size = new System.Drawing.Size(35, 30);
            this.editElementButton.TabIndex = 9;
            this.addElementToolTip.SetToolTip(this.editElementButton, "Edit selected element");
            this.editElementButton.UseVisualStyleBackColor = true;
            this.editElementButton.Click += new System.EventHandler(this.editElementButton_Click);
            // 
            // addElementButton
            // 
            this.addElementButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.addElementButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addElementButton.FlatAppearance.BorderSize = 0;
            this.addElementButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.addElementButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addElementButton.ImageIndex = 0;
            this.addElementButton.ImageList = this.buttonsImageList;
            this.addElementButton.Location = new System.Drawing.Point(232, 18);
            this.addElementButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addElementButton.Name = "addElementButton";
            this.addElementButton.Size = new System.Drawing.Size(35, 28);
            this.addElementButton.TabIndex = 7;
            this.addElementToolTip.SetToolTip(this.addElementButton, "Add new element");
            this.addElementButton.UseVisualStyleBackColor = true;
            this.addElementButton.Click += new System.EventHandler(this.addElementButton_Click);
            // 
            // typeLabel
            // 
            this.typeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.typeLabel.AutoSize = true;
            this.typeLabel.Location = new System.Drawing.Point(8, 95);
            this.typeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(34, 13);
            this.typeLabel.TabIndex = 5;
            this.typeLabel.Text = "Type:";
            // 
            // valueLabel
            // 
            this.valueLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.valueLabel.AutoSize = true;
            this.valueLabel.Location = new System.Drawing.Point(5, 60);
            this.valueLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.valueLabel.Name = "valueLabel";
            this.valueLabel.Size = new System.Drawing.Size(37, 13);
            this.valueLabel.TabIndex = 4;
            this.valueLabel.Text = "Value:";
            // 
            // nameLabel
            // 
            this.nameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(4, 26);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(38, 13);
            this.nameLabel.TabIndex = 3;
            this.nameLabel.Text = "Name:";
            // 
            // elementTypeTextBox
            // 
            this.elementTypeTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.elementTypeTextBox.Enabled = false;
            this.elementTypeTextBox.Location = new System.Drawing.Point(46, 92);
            this.elementTypeTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.elementTypeTextBox.Name = "elementTypeTextBox";
            this.elementTypeTextBox.Size = new System.Drawing.Size(182, 20);
            this.elementTypeTextBox.TabIndex = 2;
            // 
            // elementValueTextBox
            // 
            this.elementValueTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.elementValueTextBox.Enabled = false;
            this.elementValueTextBox.Location = new System.Drawing.Point(46, 58);
            this.elementValueTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.elementValueTextBox.Name = "elementValueTextBox";
            this.elementValueTextBox.Size = new System.Drawing.Size(182, 20);
            this.elementValueTextBox.TabIndex = 1;
            // 
            // elementNameTextBox
            // 
            this.elementNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.elementNameTextBox.Enabled = false;
            this.elementNameTextBox.Location = new System.Drawing.Point(46, 24);
            this.elementNameTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.elementNameTextBox.MaxLength = 40;
            this.elementNameTextBox.Name = "elementNameTextBox";
            this.elementNameTextBox.Size = new System.Drawing.Size(182, 20);
            this.elementNameTextBox.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.groupBox3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(291, 2);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(111, 134);
            this.panel3.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.addFrequencyButton);
            this.groupBox3.Controls.Add(this.deleteFrequencyButton);
            this.groupBox3.Controls.Add(this.frequencyInputTextBox);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Size = new System.Drawing.Size(111, 134);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Frequency Input";
            // 
            // addFrequencyButton
            // 
            this.addFrequencyButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.addFrequencyButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addFrequencyButton.FlatAppearance.BorderSize = 0;
            this.addFrequencyButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.addFrequencyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addFrequencyButton.ImageIndex = 0;
            this.addFrequencyButton.ImageList = this.buttonsImageList;
            this.addFrequencyButton.Location = new System.Drawing.Point(27, 74);
            this.addFrequencyButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addFrequencyButton.Name = "addFrequencyButton";
            this.addFrequencyButton.Size = new System.Drawing.Size(25, 30);
            this.addFrequencyButton.TabIndex = 4;
            this.addElementToolTip.SetToolTip(this.addFrequencyButton, "Add new frequency");
            this.addFrequencyButton.UseVisualStyleBackColor = true;
            this.addFrequencyButton.Click += new System.EventHandler(this.addFrequencyButton_Click);
            // 
            // deleteFrequencyButton
            // 
            this.deleteFrequencyButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.deleteFrequencyButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteFrequencyButton.FlatAppearance.BorderSize = 0;
            this.deleteFrequencyButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.deleteFrequencyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteFrequencyButton.ImageIndex = 2;
            this.deleteFrequencyButton.ImageList = this.buttonsImageList;
            this.deleteFrequencyButton.Location = new System.Drawing.Point(56, 74);
            this.deleteFrequencyButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.deleteFrequencyButton.Name = "deleteFrequencyButton";
            this.deleteFrequencyButton.Size = new System.Drawing.Size(28, 30);
            this.deleteFrequencyButton.TabIndex = 3;
            this.addElementToolTip.SetToolTip(this.deleteFrequencyButton, "Delete selected frequency");
            this.deleteFrequencyButton.UseVisualStyleBackColor = true;
            this.deleteFrequencyButton.Click += new System.EventHandler(this.deleteFrequencyButton_Click);
            // 
            // frequencyInputTextBox
            // 
            this.frequencyInputTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.frequencyInputTextBox.Location = new System.Drawing.Point(4, 51);
            this.frequencyInputTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.frequencyInputTextBox.Name = "frequencyInputTextBox";
            this.frequencyInputTextBox.Size = new System.Drawing.Size(103, 20);
            this.frequencyInputTextBox.TabIndex = 0;
            this.frequencyInputTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frequencyInputTextBox_KeyPress);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.calculationsGroupBox);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(406, 2);
            this.panel4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(604, 134);
            this.panel4.TabIndex = 2;
            // 
            // calculationsGroupBox
            // 
            this.calculationsGroupBox.Controls.Add(this.calculationsTabel);
            this.calculationsGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.calculationsGroupBox.Location = new System.Drawing.Point(0, 0);
            this.calculationsGroupBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.calculationsGroupBox.Name = "calculationsGroupBox";
            this.calculationsGroupBox.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.calculationsGroupBox.Size = new System.Drawing.Size(604, 134);
            this.calculationsGroupBox.TabIndex = 0;
            this.calculationsGroupBox.TabStop = false;
            this.calculationsGroupBox.Text = "Frequencises And Impedances";
            // 
            // calculationsTabel
            // 
            this.calculationsTabel.AllowUserToAddRows = false;
            this.calculationsTabel.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.calculationsTabel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.calculationsTabel.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FrequenciesColumn,
            this.ImpedancesColumn});
            this.calculationsTabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.calculationsTabel.Location = new System.Drawing.Point(2, 15);
            this.calculationsTabel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.calculationsTabel.Name = "calculationsTabel";
            this.calculationsTabel.RowHeadersWidth = 51;
            this.calculationsTabel.RowTemplate.Height = 24;
            this.calculationsTabel.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.calculationsTabel.Size = new System.Drawing.Size(600, 117);
            this.calculationsTabel.TabIndex = 0;
            // 
            // FrequenciesColumn
            // 
            this.FrequenciesColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FrequenciesColumn.HeaderText = "Frequencies";
            this.FrequenciesColumn.MinimumWidth = 6;
            this.FrequenciesColumn.Name = "FrequenciesColumn";
            this.FrequenciesColumn.ReadOnly = true;
            // 
            // ImpedancesColumn
            // 
            this.ImpedancesColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ImpedancesColumn.HeaderText = "Impedances";
            this.ImpedancesColumn.MinimumWidth = 6;
            this.ImpedancesColumn.Name = "ImpedancesColumn";
            this.ImpedancesColumn.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1012, 422);
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
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1012, 422);
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
            this.panel6.Location = new System.Drawing.Point(2, 2);
            this.panel6.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(286, 418);
            this.panel6.TabIndex = 0;
            // 
            // addSegmentButton
            // 
            this.addSegmentButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.addSegmentButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addSegmentButton.FlatAppearance.BorderSize = 0;
            this.addSegmentButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.addSegmentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addSegmentButton.ImageIndex = 3;
            this.addSegmentButton.ImageList = this.buttonsImageList;
            this.addSegmentButton.Location = new System.Drawing.Point(110, 381);
            this.addSegmentButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addSegmentButton.Name = "addSegmentButton";
            this.addSegmentButton.Size = new System.Drawing.Size(26, 28);
            this.addSegmentButton.TabIndex = 5;
            this.addElementToolTip.SetToolTip(this.addSegmentButton, "Add new segment");
            this.addSegmentButton.UseVisualStyleBackColor = true;
            this.addSegmentButton.Click += new System.EventHandler(this.addSegmentButton_Click);
            // 
            // editCircuitButton
            // 
            this.editCircuitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.editCircuitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editCircuitButton.FlatAppearance.BorderSize = 0;
            this.editCircuitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.editCircuitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editCircuitButton.ImageIndex = 1;
            this.editCircuitButton.ImageList = this.buttonsImageList;
            this.editCircuitButton.Location = new System.Drawing.Point(75, 381);
            this.editCircuitButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.editCircuitButton.Name = "editCircuitButton";
            this.editCircuitButton.Size = new System.Drawing.Size(26, 28);
            this.editCircuitButton.TabIndex = 4;
            this.addElementToolTip.SetToolTip(this.editCircuitButton, "Edit current circuit");
            this.editCircuitButton.UseVisualStyleBackColor = true;
            this.editCircuitButton.Click += new System.EventHandler(this.editCircuitButton_Click);
            // 
            // removeCircuitButton
            // 
            this.removeCircuitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.removeCircuitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.removeCircuitButton.FlatAppearance.BorderSize = 0;
            this.removeCircuitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.removeCircuitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeCircuitButton.ImageIndex = 2;
            this.removeCircuitButton.ImageList = this.buttonsImageList;
            this.removeCircuitButton.Location = new System.Drawing.Point(40, 381);
            this.removeCircuitButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.removeCircuitButton.Name = "removeCircuitButton";
            this.removeCircuitButton.Size = new System.Drawing.Size(26, 28);
            this.removeCircuitButton.TabIndex = 3;
            this.addElementToolTip.SetToolTip(this.removeCircuitButton, "Delete current circuit");
            this.removeCircuitButton.UseVisualStyleBackColor = true;
            this.removeCircuitButton.Click += new System.EventHandler(this.deleteCircuitButton_Click);
            // 
            // addCircuitButton
            // 
            this.addCircuitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.addCircuitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addCircuitButton.FlatAppearance.BorderSize = 0;
            this.addCircuitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.addCircuitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addCircuitButton.ImageIndex = 0;
            this.addCircuitButton.ImageList = this.buttonsImageList;
            this.addCircuitButton.Location = new System.Drawing.Point(4, 381);
            this.addCircuitButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addCircuitButton.Name = "addCircuitButton";
            this.addCircuitButton.Size = new System.Drawing.Size(26, 28);
            this.addCircuitButton.TabIndex = 2;
            this.addElementToolTip.SetToolTip(this.addCircuitButton, "Add new circuit");
            this.addCircuitButton.UseVisualStyleBackColor = true;
            this.addCircuitButton.Click += new System.EventHandler(this.addCircuitButton_Click);
            // 
            // circuitElementsTreeView
            // 
            this.circuitElementsTreeView.AllowDrop = true;
            this.circuitElementsTreeView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.circuitElementsTreeView.Location = new System.Drawing.Point(2, 29);
            this.circuitElementsTreeView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.circuitElementsTreeView.Name = "circuitElementsTreeView";
            this.circuitElementsTreeView.Size = new System.Drawing.Size(281, 347);
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
            this.circuitsComboBox.Location = new System.Drawing.Point(2, 5);
            this.circuitsComboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.circuitsComboBox.Name = "circuitsComboBox";
            this.circuitsComboBox.Size = new System.Drawing.Size(281, 21);
            this.circuitsComboBox.TabIndex = 0;
            this.addElementToolTip.SetToolTip(this.circuitsComboBox, "Circuits list");
            this.circuitsComboBox.SelectedIndexChanged += new System.EventHandler(this.circuitsComboBox_SelectedIndexChanged);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.circuitPictureBox);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(292, 2);
            this.panel7.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(718, 418);
            this.panel7.TabIndex = 1;
            // 
            // circuitPictureBox
            // 
            this.circuitPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.circuitPictureBox.Location = new System.Drawing.Point(0, 0);
            this.circuitPictureBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.circuitPictureBox.Name = "circuitPictureBox";
            this.circuitPictureBox.Size = new System.Drawing.Size(718, 418);
            this.circuitPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.circuitPictureBox.TabIndex = 0;
            this.circuitPictureBox.TabStop = false;
            this.circuitPictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.circuitPictureBox_Paint);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 568);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.calculationsGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.calculationsTabel)).EndInit();
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.circuitPictureBox)).EndInit();
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
        private System.Windows.Forms.ImageList buttonsImageList;
        private System.Windows.Forms.ToolTip addElementToolTip;
        private System.Windows.Forms.GroupBox calculationsGroupBox;
        private System.Windows.Forms.DataGridView calculationsTabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn FrequenciesColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImpedancesColumn;
    }
}

