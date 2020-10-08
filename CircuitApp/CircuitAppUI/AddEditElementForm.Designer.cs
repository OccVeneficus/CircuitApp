namespace CircuitAppUI
{
    partial class AddEditElementForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.capacitorTypeRadioButton = new System.Windows.Forms.RadioButton();
            this.inductorTypeRadioButton = new System.Windows.Forms.RadioButton();
            this.resistorTypeRadioButton = new System.Windows.Forms.RadioButton();
            this.cancelButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.typeLabel = new System.Windows.Forms.Label();
            this.valueLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.valueTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.capacitorTypeRadioButton);
            this.panel1.Controls.Add(this.inductorTypeRadioButton);
            this.panel1.Controls.Add(this.resistorTypeRadioButton);
            this.panel1.Controls.Add(this.cancelButton);
            this.panel1.Controls.Add(this.okButton);
            this.panel1.Controls.Add(this.typeLabel);
            this.panel1.Controls.Add(this.valueLabel);
            this.panel1.Controls.Add(this.nameLabel);
            this.panel1.Controls.Add(this.valueTextBox);
            this.panel1.Controls.Add(this.nameTextBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(371, 246);
            this.panel1.TabIndex = 1;
            // 
            // capacitorTypeRadioButton
            // 
            this.capacitorTypeRadioButton.AutoSize = true;
            this.capacitorTypeRadioButton.Location = new System.Drawing.Point(110, 146);
            this.capacitorTypeRadioButton.Name = "capacitorTypeRadioButton";
            this.capacitorTypeRadioButton.Size = new System.Drawing.Size(89, 21);
            this.capacitorTypeRadioButton.TabIndex = 12;
            this.capacitorTypeRadioButton.TabStop = true;
            this.capacitorTypeRadioButton.Text = "Capacitor";
            this.capacitorTypeRadioButton.UseVisualStyleBackColor = true;
            // 
            // inductorTypeRadioButton
            // 
            this.inductorTypeRadioButton.AutoSize = true;
            this.inductorTypeRadioButton.Location = new System.Drawing.Point(110, 119);
            this.inductorTypeRadioButton.Name = "inductorTypeRadioButton";
            this.inductorTypeRadioButton.Size = new System.Drawing.Size(80, 21);
            this.inductorTypeRadioButton.TabIndex = 11;
            this.inductorTypeRadioButton.TabStop = true;
            this.inductorTypeRadioButton.Text = "Inductor";
            this.inductorTypeRadioButton.UseVisualStyleBackColor = true;
            // 
            // resistorTypeRadioButton
            // 
            this.resistorTypeRadioButton.AutoSize = true;
            this.resistorTypeRadioButton.Location = new System.Drawing.Point(110, 92);
            this.resistorTypeRadioButton.Name = "resistorTypeRadioButton";
            this.resistorTypeRadioButton.Size = new System.Drawing.Size(81, 21);
            this.resistorTypeRadioButton.TabIndex = 10;
            this.resistorTypeRadioButton.TabStop = true;
            this.resistorTypeRadioButton.Text = "Resistor";
            this.resistorTypeRadioButton.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(191, 187);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 9;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(110, 187);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 8;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.Location = new System.Drawing.Point(62, 92);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(44, 17);
            this.typeLabel.TabIndex = 5;
            this.typeLabel.Text = "Type:";
            // 
            // valueLabel
            // 
            this.valueLabel.AutoSize = true;
            this.valueLabel.Location = new System.Drawing.Point(58, 66);
            this.valueLabel.Name = "valueLabel";
            this.valueLabel.Size = new System.Drawing.Size(48, 17);
            this.valueLabel.TabIndex = 4;
            this.valueLabel.Text = "Value:";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(58, 38);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(49, 17);
            this.nameLabel.TabIndex = 3;
            this.nameLabel.Text = "Name:";
            // 
            // valueTextBox
            // 
            this.valueTextBox.Location = new System.Drawing.Point(110, 66);
            this.valueTextBox.Name = "valueTextBox";
            this.valueTextBox.Size = new System.Drawing.Size(171, 22);
            this.valueTextBox.TabIndex = 1;
            this.valueTextBox.TextChanged += new System.EventHandler(this.valueTextBox_TextChanged);
            this.valueTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.valueTextBox_KeyPress);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(110, 38);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(171, 22);
            this.nameTextBox.TabIndex = 0;
            this.nameTextBox.TextChanged += new System.EventHandler(this.nameTextBox_TextChanged);
            // 
            // AddEditElementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 246);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(389, 293);
            this.MinimumSize = new System.Drawing.Size(389, 293);
            this.Name = "AddEditElementForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add/Edit Element";
            this.Shown += new System.EventHandler(this.AddEditElementForm_Shown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton capacitorTypeRadioButton;
        private System.Windows.Forms.RadioButton inductorTypeRadioButton;
        private System.Windows.Forms.RadioButton resistorTypeRadioButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.Label valueLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox valueTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
    }
}