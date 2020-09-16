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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mainPanel = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.circuit1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.circuit2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.circuit3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.circuit4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.circuit5ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.circuitPictureBox = new System.Windows.Forms.PictureBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.mainPanel.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.circuitPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.circuitPictureBox);
            this.mainPanel.Controls.Add(this.menuStrip1);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(800, 450);
            this.mainPanel.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.circuit1ToolStripMenuItem,
            this.circuit2ToolStripMenuItem,
            this.circuit3ToolStripMenuItem,
            this.circuit4ToolStripMenuItem,
            this.circuit5ToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(60, 26);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // circuit1ToolStripMenuItem
            // 
            this.circuit1ToolStripMenuItem.Name = "circuit1ToolStripMenuItem";
            this.circuit1ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.circuit1ToolStripMenuItem.Text = "Circuit 1";
            this.circuit1ToolStripMenuItem.Click += new System.EventHandler(this.circuit1ToolStripMenuItem_Click);
            // 
            // circuit2ToolStripMenuItem
            // 
            this.circuit2ToolStripMenuItem.Name = "circuit2ToolStripMenuItem";
            this.circuit2ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.circuit2ToolStripMenuItem.Text = "Circuit 2";
            // 
            // circuit3ToolStripMenuItem
            // 
            this.circuit3ToolStripMenuItem.Name = "circuit3ToolStripMenuItem";
            this.circuit3ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.circuit3ToolStripMenuItem.Text = "Circuit 3";
            // 
            // circuit4ToolStripMenuItem
            // 
            this.circuit4ToolStripMenuItem.Name = "circuit4ToolStripMenuItem";
            this.circuit4ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.circuit4ToolStripMenuItem.Text = "Circuit 4";
            // 
            // circuit5ToolStripMenuItem
            // 
            this.circuit5ToolStripMenuItem.Name = "circuit5ToolStripMenuItem";
            this.circuit5ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.circuit5ToolStripMenuItem.Text = "Circuit 5";
            // 
            // circuitPictureBox
            // 
            this.circuitPictureBox.Location = new System.Drawing.Point(197, 41);
            this.circuitPictureBox.Name = "circuitPictureBox";
            this.circuitPictureBox.Size = new System.Drawing.Size(591, 306);
            this.circuitPictureBox.TabIndex = 1;
            this.circuitPictureBox.TabStop = false;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "wallhaven-482ggk.jpg");
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mainPanel);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "CircuitApp";
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.circuitPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem circuit1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem circuit2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem circuit3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem circuit4ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem circuit5ToolStripMenuItem;
        private System.Windows.Forms.PictureBox circuitPictureBox;
        private System.Windows.Forms.ImageList imageList1;
    }
}

