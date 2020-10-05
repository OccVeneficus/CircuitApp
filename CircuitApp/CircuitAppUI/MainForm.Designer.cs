namespace CircuitAppUI
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
            this.circuitsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.frequencyLabel = new System.Windows.Forms.Label();
            this.frequencyImputTextBox = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.frequenciesListBox = new System.Windows.Forms.ListBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.impedancesListBox = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.editCircuitButton = new System.Windows.Forms.Button();
            this.deleteCircuitButton = new System.Windows.Forms.Button();
            this.addCircuitButton = new System.Windows.Forms.Button();
            this.circuitElementsTreeView = new System.Windows.Forms.TreeView();
            this.circuitsComboBox = new System.Windows.Forms.ComboBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.deleteFrequencyButton = new System.Windows.Forms.Button();
            this.addFrequencyButton = new System.Windows.Forms.Button();
            this.projectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.serialCircuitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.circuitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.elementNameTextBox = new System.Windows.Forms.TextBox();
            this.elementValueTextBox = new System.Windows.Forms.TextBox();
            this.elementTypeTextBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.valueLabel = new System.Windows.Forms.Label();
            this.typeLabel = new System.Windows.Forms.Label();
            this.selectedElementLabel = new System.Windows.Forms.Label();
            this.addElementButton = new System.Windows.Forms.Button();
            this.editElementButton = new System.Windows.Forms.Button();
            this.removeElementButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.circuitsBindingSource)).BeginInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serialCircuitBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.circuitBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // circuitsBindingSource
            // 
            this.circuitsBindingSource.DataMember = "Circuits";
            this.circuitsBindingSource.DataSource = this.projectBindingSource;
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
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
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
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 492);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1349, 204);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(452, 198);
            this.panel2.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.removeElementButton);
            this.groupBox4.Controls.Add(this.editElementButton);
            this.groupBox4.Controls.Add(this.addElementButton);
            this.groupBox4.Controls.Add(this.selectedElementLabel);
            this.groupBox4.Controls.Add(this.typeLabel);
            this.groupBox4.Controls.Add(this.valueLabel);
            this.groupBox4.Controls.Add(this.nameLabel);
            this.groupBox4.Controls.Add(this.elementTypeTextBox);
            this.groupBox4.Controls.Add(this.elementValueTextBox);
            this.groupBox4.Controls.Add(this.elementNameTextBox);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(0, 0);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(452, 198);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.groupBox3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(461, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(290, 198);
            this.panel3.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.addFrequencyButton);
            this.groupBox3.Controls.Add(this.deleteFrequencyButton);
            this.groupBox3.Controls.Add(this.frequencyLabel);
            this.groupBox3.Controls.Add(this.frequencyImputTextBox);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(290, 198);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            // 
            // frequencyLabel
            // 
            this.frequencyLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.frequencyLabel.AutoSize = true;
            this.frequencyLabel.Location = new System.Drawing.Point(45, 41);
            this.frequencyLabel.Name = "frequencyLabel";
            this.frequencyLabel.Size = new System.Drawing.Size(79, 17);
            this.frequencyLabel.TabIndex = 1;
            this.frequencyLabel.Text = "Frequency:";
            // 
            // frequencyImputTextBox
            // 
            this.frequencyImputTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.frequencyImputTextBox.Location = new System.Drawing.Point(130, 38);
            this.frequencyImputTextBox.Name = "frequencyImputTextBox";
            this.frequencyImputTextBox.Size = new System.Drawing.Size(122, 22);
            this.frequencyImputTextBox.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.groupBox2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(757, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(290, 198);
            this.panel4.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.frequenciesListBox);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(290, 198);
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
            this.frequenciesListBox.Size = new System.Drawing.Size(287, 164);
            this.frequenciesListBox.TabIndex = 1;
            this.frequenciesListBox.SelectedIndexChanged += new System.EventHandler(this.frequenciesListBox_SelectedIndexChanged);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.groupBox1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(1053, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(293, 198);
            this.panel5.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.impedancesListBox);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(293, 198);
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
            this.impedancesListBox.Size = new System.Drawing.Size(287, 164);
            this.impedancesListBox.TabIndex = 0;
            this.impedancesListBox.SelectedIndexChanged += new System.EventHandler(this.impedancesListBox_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1349, 483);
            this.panel1.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.Controls.Add(this.panel6, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.panel7, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1349, 483);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.editCircuitButton);
            this.panel6.Controls.Add(this.deleteCircuitButton);
            this.panel6.Controls.Add(this.addCircuitButton);
            this.panel6.Controls.Add(this.circuitElementsTreeView);
            this.panel6.Controls.Add(this.circuitsComboBox);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(3, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(331, 477);
            this.panel6.TabIndex = 0;
            // 
            // editCircuitButton
            // 
            this.editCircuitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.editCircuitButton.Location = new System.Drawing.Point(203, 442);
            this.editCircuitButton.Name = "editCircuitButton";
            this.editCircuitButton.Size = new System.Drawing.Size(67, 32);
            this.editCircuitButton.TabIndex = 4;
            this.editCircuitButton.Text = "Edit";
            this.editCircuitButton.UseVisualStyleBackColor = true;
            // 
            // deleteCircuitButton
            // 
            this.deleteCircuitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.deleteCircuitButton.Location = new System.Drawing.Point(126, 442);
            this.deleteCircuitButton.Name = "deleteCircuitButton";
            this.deleteCircuitButton.Size = new System.Drawing.Size(71, 32);
            this.deleteCircuitButton.TabIndex = 3;
            this.deleteCircuitButton.Text = "Delete";
            this.deleteCircuitButton.UseVisualStyleBackColor = true;
            // 
            // addCircuitButton
            // 
            this.addCircuitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.addCircuitButton.Location = new System.Drawing.Point(49, 442);
            this.addCircuitButton.Name = "addCircuitButton";
            this.addCircuitButton.Size = new System.Drawing.Size(71, 32);
            this.addCircuitButton.TabIndex = 2;
            this.addCircuitButton.Text = "Add";
            this.addCircuitButton.UseVisualStyleBackColor = true;
            // 
            // circuitElementsTreeView
            // 
            this.circuitElementsTreeView.AllowDrop = true;
            this.circuitElementsTreeView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.circuitElementsTreeView.Location = new System.Drawing.Point(3, 36);
            this.circuitElementsTreeView.Name = "circuitElementsTreeView";
            this.circuitElementsTreeView.Size = new System.Drawing.Size(325, 400);
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
            this.circuitsComboBox.Size = new System.Drawing.Size(325, 24);
            this.circuitsComboBox.TabIndex = 0;
            this.circuitsComboBox.SelectedIndexChanged += new System.EventHandler(this.circuitsComboBox_SelectedIndexChanged);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.pictureBox1);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(340, 3);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1006, 477);
            this.panel7.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1006, 477);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // deleteFrequencyButton
            // 
            this.deleteFrequencyButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteFrequencyButton.Location = new System.Drawing.Point(48, 134);
            this.deleteFrequencyButton.Name = "deleteFrequencyButton";
            this.deleteFrequencyButton.Size = new System.Drawing.Size(204, 38);
            this.deleteFrequencyButton.TabIndex = 3;
            this.deleteFrequencyButton.Text = "Delete";
            this.deleteFrequencyButton.UseVisualStyleBackColor = true;
            this.deleteFrequencyButton.Click += new System.EventHandler(this.deleteFrequencyButton_Click);
            // 
            // addFrequencyButton
            // 
            this.addFrequencyButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.addFrequencyButton.Location = new System.Drawing.Point(48, 78);
            this.addFrequencyButton.Name = "addFrequencyButton";
            this.addFrequencyButton.Size = new System.Drawing.Size(204, 38);
            this.addFrequencyButton.TabIndex = 4;
            this.addFrequencyButton.Text = "Add";
            this.addFrequencyButton.UseVisualStyleBackColor = true;
            this.addFrequencyButton.Click += new System.EventHandler(this.addFrequencyButton_Click);
            // 
            // projectBindingSource
            // 
            this.projectBindingSource.DataSource = typeof(CircutApp.Project);
            // 
            // serialCircuitBindingSource
            // 
            this.serialCircuitBindingSource.DataSource = typeof(CircutApp.SerialCircuit);
            // 
            // circuitBindingSource
            // 
            this.circuitBindingSource.DataSource = typeof(CircutApp.Circuit);
            // 
            // elementNameTextBox
            // 
            this.elementNameTextBox.Enabled = false;
            this.elementNameTextBox.Location = new System.Drawing.Point(99, 54);
            this.elementNameTextBox.MaxLength = 40;
            this.elementNameTextBox.Name = "elementNameTextBox";
            this.elementNameTextBox.Size = new System.Drawing.Size(128, 22);
            this.elementNameTextBox.TabIndex = 0;
            // 
            // elementValueTextBox
            // 
            this.elementValueTextBox.Enabled = false;
            this.elementValueTextBox.Location = new System.Drawing.Point(99, 94);
            this.elementValueTextBox.Name = "elementValueTextBox";
            this.elementValueTextBox.Size = new System.Drawing.Size(128, 22);
            this.elementValueTextBox.TabIndex = 1;
            // 
            // elementTypeTextBox
            // 
            this.elementTypeTextBox.Enabled = false;
            this.elementTypeTextBox.Location = new System.Drawing.Point(99, 134);
            this.elementTypeTextBox.Name = "elementTypeTextBox";
            this.elementTypeTextBox.Size = new System.Drawing.Size(128, 22);
            this.elementTypeTextBox.TabIndex = 2;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(46, 57);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(49, 17);
            this.nameLabel.TabIndex = 3;
            this.nameLabel.Text = "Name:";
            // 
            // valueLabel
            // 
            this.valueLabel.AutoSize = true;
            this.valueLabel.Location = new System.Drawing.Point(46, 97);
            this.valueLabel.Name = "valueLabel";
            this.valueLabel.Size = new System.Drawing.Size(48, 17);
            this.valueLabel.TabIndex = 4;
            this.valueLabel.Text = "Value:";
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.Location = new System.Drawing.Point(46, 137);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(44, 17);
            this.typeLabel.TabIndex = 5;
            this.typeLabel.Text = "Type:";
            // 
            // selectedElementLabel
            // 
            this.selectedElementLabel.AutoSize = true;
            this.selectedElementLabel.Location = new System.Drawing.Point(64, 21);
            this.selectedElementLabel.Name = "selectedElementLabel";
            this.selectedElementLabel.Size = new System.Drawing.Size(121, 17);
            this.selectedElementLabel.TabIndex = 6;
            this.selectedElementLabel.Text = "Selected element:";
            // 
            // addElementButton
            // 
            this.addElementButton.Location = new System.Drawing.Point(275, 49);
            this.addElementButton.Name = "addElementButton";
            this.addElementButton.Size = new System.Drawing.Size(152, 32);
            this.addElementButton.TabIndex = 7;
            this.addElementButton.Text = "Add";
            this.addElementButton.UseVisualStyleBackColor = true;
            // 
            // editElementButton
            // 
            this.editElementButton.Location = new System.Drawing.Point(275, 87);
            this.editElementButton.Name = "editElementButton";
            this.editElementButton.Size = new System.Drawing.Size(152, 31);
            this.editElementButton.TabIndex = 8;
            this.editElementButton.Text = "Edit";
            this.editElementButton.UseVisualStyleBackColor = true;
            // 
            // removeElementButton
            // 
            this.removeElementButton.Location = new System.Drawing.Point(275, 124);
            this.removeElementButton.Name = "removeElementButton";
            this.removeElementButton.Size = new System.Drawing.Size(152, 32);
            this.removeElementButton.TabIndex = 9;
            this.removeElementButton.Text = "Remove";
            this.removeElementButton.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1355, 699);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MainForm";
            this.Text = "CircuitApp";
            ((System.ComponentModel.ISupportInitialize)(this.circuitsBindingSource)).EndInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serialCircuitBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.circuitBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource projectBindingSource;
        private System.Windows.Forms.BindingSource circuitBindingSource;
        private System.Windows.Forms.BindingSource serialCircuitBindingSource;
        private System.Windows.Forms.BindingSource circuitsBindingSource;
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label frequencyLabel;
        private System.Windows.Forms.TextBox frequencyImputTextBox;
        private System.Windows.Forms.Button editCircuitButton;
        private System.Windows.Forms.Button deleteCircuitButton;
        private System.Windows.Forms.Button addCircuitButton;
        private System.Windows.Forms.Button addFrequencyButton;
        private System.Windows.Forms.Button deleteFrequencyButton;
        private System.Windows.Forms.TextBox elementNameTextBox;
        private System.Windows.Forms.Button removeElementButton;
        private System.Windows.Forms.Button editElementButton;
        private System.Windows.Forms.Button addElementButton;
        private System.Windows.Forms.Label selectedElementLabel;
        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.Label valueLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox elementTypeTextBox;
        private System.Windows.Forms.TextBox elementValueTextBox;
    }
}

