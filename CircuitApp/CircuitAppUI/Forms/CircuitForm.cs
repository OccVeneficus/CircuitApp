using System;
using System.Windows.Forms;
using CircutApp;

namespace CircuitAppUI.Forms
{
    /// <summary>
    /// Form for editing/adding new circuit
    /// </summary>
    public partial class CircuitForm : Form
    {
        public Circuit Circuit { get; set; }

        public CircuitForm()
        {
            InitializeComponent();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            Circuit.Name = nameTextBox.Text;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void AddEditCircuitForm_Shown(object sender, EventArgs e)
        {
            nameTextBox.Text = Circuit.Name;
        }
    }
}
