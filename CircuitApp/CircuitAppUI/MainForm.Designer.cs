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
            this.mainPanel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.circuitsListBox = new System.Windows.Forms.ListBox();
            this.elementTypeLabel = new System.Windows.Forms.Label();
            this.elementNameLabel = new System.Windows.Forms.Label();
            this.elementNameTextBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.frequenciesLabel = new System.Windows.Forms.Label();
            this.frequenciesListBox = new System.Windows.Forms.ListBox();
            this.impedancesListBox = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.elementValueLabel = new System.Windows.Forms.Label();
            this.elementTypeComboBox = new System.Windows.Forms.ComboBox();
            this.elementValueTextBox = new System.Windows.Forms.TextBox();
            this.addFrequencyLabel = new System.Windows.Forms.Label();
            this.addFrequencyTextBox = new System.Windows.Forms.TextBox();
            this.addFrequencyButton = new System.Windows.Forms.Button();
            this.addElementButton = new System.Windows.Forms.Button();
            this.mainPanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.tableLayoutPanel1);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(979, 501);
            this.mainPanel.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel4, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(979, 501);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(277, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(699, 301);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.circuitsListBox);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(268, 301);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.addElementButton);
            this.panel3.Controls.Add(this.addFrequencyButton);
            this.panel3.Controls.Add(this.addFrequencyTextBox);
            this.panel3.Controls.Add(this.addFrequencyLabel);
            this.panel3.Controls.Add(this.elementValueTextBox);
            this.panel3.Controls.Add(this.elementTypeComboBox);
            this.panel3.Controls.Add(this.elementValueLabel);
            this.panel3.Controls.Add(this.elementNameTextBox);
            this.panel3.Controls.Add(this.elementNameLabel);
            this.panel3.Controls.Add(this.elementTypeLabel);
            this.panel3.Location = new System.Drawing.Point(3, 310);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(268, 188);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.tableLayoutPanel2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(277, 310);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(699, 188);
            this.panel4.TabIndex = 3;
            // 
            // circuitsListBox
            // 
            this.circuitsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.circuitsListBox.FormattingEnabled = true;
            this.circuitsListBox.ItemHeight = 16;
            this.circuitsListBox.Location = new System.Drawing.Point(9, 5);
            this.circuitsListBox.Name = "circuitsListBox";
            this.circuitsListBox.Size = new System.Drawing.Size(250, 292);
            this.circuitsListBox.TabIndex = 0;
            // 
            // elementTypeLabel
            // 
            this.elementTypeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.elementTypeLabel.AutoSize = true;
            this.elementTypeLabel.Location = new System.Drawing.Point(19, 20);
            this.elementTypeLabel.Name = "elementTypeLabel";
            this.elementTypeLabel.Size = new System.Drawing.Size(91, 17);
            this.elementTypeLabel.TabIndex = 0;
            this.elementTypeLabel.Text = "Add element:";
            // 
            // elementNameLabel
            // 
            this.elementNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.elementNameLabel.AutoSize = true;
            this.elementNameLabel.Location = new System.Drawing.Point(61, 53);
            this.elementNameLabel.Name = "elementNameLabel";
            this.elementNameLabel.Size = new System.Drawing.Size(49, 17);
            this.elementNameLabel.TabIndex = 1;
            this.elementNameLabel.Text = "Name:";
            // 
            // elementNameTextBox
            // 
            this.elementNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.elementNameTextBox.Location = new System.Drawing.Point(116, 50);
            this.elementNameTextBox.Name = "elementNameTextBox";
            this.elementNameTextBox.Size = new System.Drawing.Size(121, 22);
            this.elementNameTextBox.TabIndex = 3;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.panel6, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel5, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(699, 188);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.frequenciesListBox);
            this.panel5.Controls.Add(this.frequenciesLabel);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(3, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(343, 182);
            this.panel5.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.impedancesListBox);
            this.panel6.Controls.Add(this.label4);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(352, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(344, 182);
            this.panel6.TabIndex = 1;
            // 
            // frequenciesLabel
            // 
            this.frequenciesLabel.AutoSize = true;
            this.frequenciesLabel.Location = new System.Drawing.Point(19, 17);
            this.frequenciesLabel.Name = "frequenciesLabel";
            this.frequenciesLabel.Size = new System.Drawing.Size(90, 17);
            this.frequenciesLabel.TabIndex = 1;
            this.frequenciesLabel.Text = "Frequencies:";
            // 
            // frequenciesListBox
            // 
            this.frequenciesListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.frequenciesListBox.FormattingEnabled = true;
            this.frequenciesListBox.ItemHeight = 16;
            this.frequenciesListBox.Location = new System.Drawing.Point(115, 14);
            this.frequenciesListBox.Name = "frequenciesListBox";
            this.frequenciesListBox.Size = new System.Drawing.Size(199, 148);
            this.frequenciesListBox.TabIndex = 2;
            // 
            // impedancesListBox
            // 
            this.impedancesListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.impedancesListBox.FormattingEnabled = true;
            this.impedancesListBox.ItemHeight = 16;
            this.impedancesListBox.Location = new System.Drawing.Point(117, 14);
            this.impedancesListBox.Name = "impedancesListBox";
            this.impedancesListBox.Size = new System.Drawing.Size(199, 148);
            this.impedancesListBox.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Impedance:";
            // 
            // elementValueLabel
            // 
            this.elementValueLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.elementValueLabel.AutoSize = true;
            this.elementValueLabel.Location = new System.Drawing.Point(62, 82);
            this.elementValueLabel.Name = "elementValueLabel";
            this.elementValueLabel.Size = new System.Drawing.Size(48, 17);
            this.elementValueLabel.TabIndex = 4;
            this.elementValueLabel.Text = "Value:";
            // 
            // elementTypeComboBox
            // 
            this.elementTypeComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.elementTypeComboBox.FormattingEnabled = true;
            this.elementTypeComboBox.Location = new System.Drawing.Point(116, 17);
            this.elementTypeComboBox.Name = "elementTypeComboBox";
            this.elementTypeComboBox.Size = new System.Drawing.Size(121, 24);
            this.elementTypeComboBox.TabIndex = 5;
            // 
            // elementValueTextBox
            // 
            this.elementValueTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.elementValueTextBox.Location = new System.Drawing.Point(116, 79);
            this.elementValueTextBox.Name = "elementValueTextBox";
            this.elementValueTextBox.Size = new System.Drawing.Size(121, 22);
            this.elementValueTextBox.TabIndex = 6;
            // 
            // addFrequencyLabel
            // 
            this.addFrequencyLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.addFrequencyLabel.AutoSize = true;
            this.addFrequencyLabel.Location = new System.Drawing.Point(6, 146);
            this.addFrequencyLabel.Name = "addFrequencyLabel";
            this.addFrequencyLabel.Size = new System.Drawing.Size(104, 17);
            this.addFrequencyLabel.TabIndex = 7;
            this.addFrequencyLabel.Text = "Add frequency:";
            // 
            // addFrequencyTextBox
            // 
            this.addFrequencyTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.addFrequencyTextBox.Location = new System.Drawing.Point(116, 143);
            this.addFrequencyTextBox.Name = "addFrequencyTextBox";
            this.addFrequencyTextBox.Size = new System.Drawing.Size(121, 22);
            this.addFrequencyTextBox.TabIndex = 8;
            // 
            // addFrequencyButton
            // 
            this.addFrequencyButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.addFrequencyButton.Location = new System.Drawing.Point(241, 142);
            this.addFrequencyButton.Name = "addFrequencyButton";
            this.addFrequencyButton.Size = new System.Drawing.Size(24, 23);
            this.addFrequencyButton.TabIndex = 9;
            this.addFrequencyButton.Text = "+";
            this.addFrequencyButton.UseVisualStyleBackColor = true;
            // 
            // addElementButton
            // 
            this.addElementButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.addElementButton.Location = new System.Drawing.Point(116, 108);
            this.addElementButton.Name = "addElementButton";
            this.addElementButton.Size = new System.Drawing.Size(75, 23);
            this.addElementButton.TabIndex = 10;
            this.addElementButton.Text = "Add";
            this.addElementButton.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 501);
            this.Controls.Add(this.mainPanel);
            this.Name = "MainForm";
            this.Text = "CircuitApp";
            this.mainPanel.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox elementNameTextBox;
        private System.Windows.Forms.Label elementNameLabel;
        private System.Windows.Forms.Label elementTypeLabel;
        private System.Windows.Forms.ListBox circuitsListBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.ListBox impedancesListBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.ListBox frequenciesListBox;
        private System.Windows.Forms.Label frequenciesLabel;
        private System.Windows.Forms.TextBox addFrequencyTextBox;
        private System.Windows.Forms.Label addFrequencyLabel;
        private System.Windows.Forms.TextBox elementValueTextBox;
        private System.Windows.Forms.ComboBox elementTypeComboBox;
        private System.Windows.Forms.Label elementValueLabel;
        private System.Windows.Forms.Button addElementButton;
        private System.Windows.Forms.Button addFrequencyButton;
    }
}

