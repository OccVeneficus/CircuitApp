namespace CircuitAppUI.Forms
{
    partial class ConnectionTypeForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.serialRadioButton = new System.Windows.Forms.RadioButton();
            this.parallelRadioButton = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cancelButton);
            this.groupBox1.Controls.Add(this.okButton);
            this.groupBox1.Controls.Add(this.serialRadioButton);
            this.groupBox1.Controls.Add(this.parallelRadioButton);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(243, 107);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add segment as:";
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.Location = new System.Drawing.Point(164, 80);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 3;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // okButton
            // 
            this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.okButton.Location = new System.Drawing.Point(85, 80);
            this.okButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 2;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // serialRadioButton
            // 
            this.serialRadioButton.AutoSize = true;
            this.serialRadioButton.Location = new System.Drawing.Point(11, 48);
            this.serialRadioButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.serialRadioButton.Name = "serialRadioButton";
            this.serialRadioButton.Size = new System.Drawing.Size(107, 17);
            this.serialRadioButton.TabIndex = 1;
            this.serialRadioButton.Text = "Serial to choosen";
            this.serialRadioButton.UseVisualStyleBackColor = true;
            this.serialRadioButton.CheckedChanged += new System.EventHandler(this.serialRadioButton_CheckedChanged);
            // 
            // parallelRadioButton
            // 
            this.parallelRadioButton.AutoSize = true;
            this.parallelRadioButton.Location = new System.Drawing.Point(11, 27);
            this.parallelRadioButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.parallelRadioButton.Name = "parallelRadioButton";
            this.parallelRadioButton.Size = new System.Drawing.Size(115, 17);
            this.parallelRadioButton.TabIndex = 0;
            this.parallelRadioButton.TabStop = true;
            this.parallelRadioButton.Text = "Parallel to choosen";
            this.parallelRadioButton.UseVisualStyleBackColor = true;
            this.parallelRadioButton.CheckedChanged += new System.EventHandler(this.parallelRadioButton_CheckedChanged);
            // 
            // ConnectionTypeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(243, 107);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximumSize = new System.Drawing.Size(259, 146);
            this.MinimumSize = new System.Drawing.Size(259, 146);
            this.Name = "ConnectionTypeForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add as...";
            this.Load += new System.EventHandler(this.ConnectionTypeForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.RadioButton serialRadioButton;
        private System.Windows.Forms.RadioButton parallelRadioButton;
        private System.Windows.Forms.Button cancelButton;
    }
}