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
            this.projectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.serialCircuitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.circuitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.deleteFrequencyButton = new System.Windows.Forms.Button();
            this.frequencyInputTextBox = new System.Windows.Forms.TextBox();
            this.addFrequencyButton = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.deleteElementButton = new System.Windows.Forms.Button();
            this.editElementButton = new System.Windows.Forms.Button();
            this.addElementButton = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.deleteCircuitButton = new System.Windows.Forms.Button();
            this.addCircuitButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.elementsLabel = new System.Windows.Forms.Label();
            this.circuitElementsTreeView = new System.Windows.Forms.TreeView();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.circuitElementsPictureBox = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.impedancesLabel = new System.Windows.Forms.Label();
            this.impedancesListBox = new System.Windows.Forms.ListBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.frequenciesLabel = new System.Windows.Forms.Label();
            this.frequenciesListBox = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.circuitsLabel = new System.Windows.Forms.Label();
            this.circuitsListBox = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.circuitsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serialCircuitBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.circuitBindingSource)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.circuitElementsPictureBox)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // circuitsBindingSource
            // 
            this.circuitsBindingSource.DataMember = "Circuits";
            this.circuitsBindingSource.DataSource = this.projectBindingSource;
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
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 844F));
            this.tableLayoutPanel1.Controls.Add(this.panel7, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel5, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1355, 699);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.deleteFrequencyButton);
            this.panel7.Controls.Add(this.frequencyInputTextBox);
            this.panel7.Controls.Add(this.addFrequencyButton);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(514, 665);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(838, 31);
            this.panel7.TabIndex = 5;
            // 
            // deleteFrequencyButton
            // 
            this.deleteFrequencyButton.Location = new System.Drawing.Point(222, 4);
            this.deleteFrequencyButton.Name = "deleteFrequencyButton";
            this.deleteFrequencyButton.Size = new System.Drawing.Size(75, 23);
            this.deleteFrequencyButton.TabIndex = 6;
            this.deleteFrequencyButton.Text = "Delete";
            this.deleteFrequencyButton.UseVisualStyleBackColor = true;
            // 
            // frequencyInputTextBox
            // 
            this.frequencyInputTextBox.Location = new System.Drawing.Point(9, 5);
            this.frequencyInputTextBox.MaxLength = 15;
            this.frequencyInputTextBox.Name = "frequencyInputTextBox";
            this.frequencyInputTextBox.Size = new System.Drawing.Size(126, 22);
            this.frequencyInputTextBox.TabIndex = 5;
            this.frequencyInputTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frequencyInputTextBox_KeyPress);
            // 
            // addFrequencyButton
            // 
            this.addFrequencyButton.Location = new System.Drawing.Point(141, 4);
            this.addFrequencyButton.Name = "addFrequencyButton";
            this.addFrequencyButton.Size = new System.Drawing.Size(75, 23);
            this.addFrequencyButton.TabIndex = 4;
            this.addFrequencyButton.Text = "Add";
            this.addFrequencyButton.UseVisualStyleBackColor = true;
            this.addFrequencyButton.Click += new System.EventHandler(this.addFrequencyButton_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.deleteElementButton);
            this.panel5.Controls.Add(this.editElementButton);
            this.panel5.Controls.Add(this.addElementButton);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(256, 665);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(252, 31);
            this.panel5.TabIndex = 4;
            // 
            // deleteElementButton
            // 
            this.deleteElementButton.Location = new System.Drawing.Point(173, 4);
            this.deleteElementButton.Name = "deleteElementButton";
            this.deleteElementButton.Size = new System.Drawing.Size(75, 23);
            this.deleteElementButton.TabIndex = 3;
            this.deleteElementButton.Text = "Delete";
            this.deleteElementButton.UseVisualStyleBackColor = true;
            // 
            // editElementButton
            // 
            this.editElementButton.Location = new System.Drawing.Point(92, 4);
            this.editElementButton.Name = "editElementButton";
            this.editElementButton.Size = new System.Drawing.Size(75, 23);
            this.editElementButton.TabIndex = 2;
            this.editElementButton.Text = "Edit";
            this.editElementButton.UseVisualStyleBackColor = true;
            // 
            // addElementButton
            // 
            this.addElementButton.Location = new System.Drawing.Point(11, 4);
            this.addElementButton.Name = "addElementButton";
            this.addElementButton.Size = new System.Drawing.Size(75, 23);
            this.addElementButton.TabIndex = 1;
            this.addElementButton.Text = "Add";
            this.addElementButton.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.deleteCircuitButton);
            this.panel4.Controls.Add(this.addCircuitButton);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 665);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(247, 31);
            this.panel4.TabIndex = 3;
            // 
            // deleteCircuitButton
            // 
            this.deleteCircuitButton.Location = new System.Drawing.Point(84, 4);
            this.deleteCircuitButton.Name = "deleteCircuitButton";
            this.deleteCircuitButton.Size = new System.Drawing.Size(75, 23);
            this.deleteCircuitButton.TabIndex = 1;
            this.deleteCircuitButton.Text = "Delete";
            this.deleteCircuitButton.UseVisualStyleBackColor = true;
            // 
            // addCircuitButton
            // 
            this.addCircuitButton.Location = new System.Drawing.Point(3, 4);
            this.addCircuitButton.Name = "addCircuitButton";
            this.addCircuitButton.Size = new System.Drawing.Size(75, 23);
            this.addCircuitButton.TabIndex = 0;
            this.addCircuitButton.Text = "Add";
            this.addCircuitButton.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.elementsLabel);
            this.panel2.Controls.Add(this.circuitElementsTreeView);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(256, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(252, 656);
            this.panel2.TabIndex = 2;
            // 
            // elementsLabel
            // 
            this.elementsLabel.AutoSize = true;
            this.elementsLabel.Location = new System.Drawing.Point(89, 8);
            this.elementsLabel.Name = "elementsLabel";
            this.elementsLabel.Size = new System.Drawing.Size(66, 17);
            this.elementsLabel.TabIndex = 2;
            this.elementsLabel.Text = "Elements";
            // 
            // circuitElementsTreeView
            // 
            this.circuitElementsTreeView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.circuitElementsTreeView.Location = new System.Drawing.Point(3, 28);
            this.circuitElementsTreeView.Name = "circuitElementsTreeView";
            this.circuitElementsTreeView.Size = new System.Drawing.Size(245, 612);
            this.circuitElementsTreeView.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.panel3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(514, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 66.66666F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(838, 656);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.circuitElementsPictureBox);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(832, 431);
            this.panel3.TabIndex = 2;
            // 
            // circuitElementsPictureBox
            // 
            this.circuitElementsPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.circuitElementsPictureBox.Location = new System.Drawing.Point(0, 0);
            this.circuitElementsPictureBox.Name = "circuitElementsPictureBox";
            this.circuitElementsPictureBox.Size = new System.Drawing.Size(832, 431);
            this.circuitElementsPictureBox.TabIndex = 0;
            this.circuitElementsPictureBox.TabStop = false;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.panel8, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.panel6, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 440);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(832, 213);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.impedancesLabel);
            this.panel8.Controls.Add(this.impedancesListBox);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(419, 3);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(410, 207);
            this.panel8.TabIndex = 3;
            // 
            // impedancesLabel
            // 
            this.impedancesLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.impedancesLabel.AutoSize = true;
            this.impedancesLabel.Location = new System.Drawing.Point(167, 5);
            this.impedancesLabel.Name = "impedancesLabel";
            this.impedancesLabel.Size = new System.Drawing.Size(84, 17);
            this.impedancesLabel.TabIndex = 2;
            this.impedancesLabel.Text = "Imbedances";
            // 
            // impedancesListBox
            // 
            this.impedancesListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.impedancesListBox.FormattingEnabled = true;
            this.impedancesListBox.ItemHeight = 16;
            this.impedancesListBox.Location = new System.Drawing.Point(3, 25);
            this.impedancesListBox.Name = "impedancesListBox";
            this.impedancesListBox.Size = new System.Drawing.Size(404, 164);
            this.impedancesListBox.TabIndex = 1;
            this.impedancesListBox.SelectedIndexChanged += new System.EventHandler(this.impedancesListBox_SelectedIndexChanged);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.frequenciesLabel);
            this.panel6.Controls.Add(this.frequenciesListBox);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(3, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(410, 207);
            this.panel6.TabIndex = 2;
            // 
            // frequenciesLabel
            // 
            this.frequenciesLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.frequenciesLabel.AutoSize = true;
            this.frequenciesLabel.Location = new System.Drawing.Point(157, 5);
            this.frequenciesLabel.Name = "frequenciesLabel";
            this.frequenciesLabel.Size = new System.Drawing.Size(86, 17);
            this.frequenciesLabel.TabIndex = 1;
            this.frequenciesLabel.Text = "Frequencies";
            // 
            // frequenciesListBox
            // 
            this.frequenciesListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.frequenciesListBox.FormattingEnabled = true;
            this.frequenciesListBox.ItemHeight = 16;
            this.frequenciesListBox.Location = new System.Drawing.Point(4, 25);
            this.frequenciesListBox.Name = "frequenciesListBox";
            this.frequenciesListBox.Size = new System.Drawing.Size(404, 164);
            this.frequenciesListBox.TabIndex = 0;
            this.frequenciesListBox.SelectedIndexChanged += new System.EventHandler(this.frequenciesListBox_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.circuitsLabel);
            this.panel1.Controls.Add(this.circuitsListBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(247, 656);
            this.panel1.TabIndex = 1;
            // 
            // circuitsLabel
            // 
            this.circuitsLabel.AutoSize = true;
            this.circuitsLabel.Location = new System.Drawing.Point(93, 8);
            this.circuitsLabel.Name = "circuitsLabel";
            this.circuitsLabel.Size = new System.Drawing.Size(54, 17);
            this.circuitsLabel.TabIndex = 1;
            this.circuitsLabel.Text = "Circuits";
            // 
            // circuitsListBox
            // 
            this.circuitsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.circuitsListBox.FormattingEnabled = true;
            this.circuitsListBox.ItemHeight = 16;
            this.circuitsListBox.Location = new System.Drawing.Point(8, 28);
            this.circuitsListBox.Name = "circuitsListBox";
            this.circuitsListBox.Size = new System.Drawing.Size(235, 612);
            this.circuitsListBox.TabIndex = 0;
            this.circuitsListBox.SelectedIndexChanged += new System.EventHandler(this.circuitsListBox_SelectedIndexChanged);
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
            ((System.ComponentModel.ISupportInitialize)(this.projectBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serialCircuitBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.circuitBindingSource)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.circuitElementsPictureBox)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource projectBindingSource;
        private System.Windows.Forms.BindingSource circuitBindingSource;
        private System.Windows.Forms.BindingSource serialCircuitBindingSource;
        private System.Windows.Forms.BindingSource circuitsBindingSource;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button deleteFrequencyButton;
        private System.Windows.Forms.TextBox frequencyInputTextBox;
        private System.Windows.Forms.Button addFrequencyButton;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button deleteElementButton;
        private System.Windows.Forms.Button editElementButton;
        private System.Windows.Forms.Button addElementButton;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button deleteCircuitButton;
        private System.Windows.Forms.Button addCircuitButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TreeView circuitElementsTreeView;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox circuitElementsPictureBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.ListBox impedancesListBox;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.ListBox frequenciesListBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox circuitsListBox;
        private System.Windows.Forms.Label elementsLabel;
        private System.Windows.Forms.Label impedancesLabel;
        private System.Windows.Forms.Label frequenciesLabel;
        private System.Windows.Forms.Label circuitsLabel;
    }
}

