using System;
using System.Windows.Forms;
using CircutApp;

namespace CircuitAppUI
{
    public partial class ChooseConnectionTypeForm : Form
    {
        public ISegment Type { get; private set; }
        public ChooseConnectionTypeForm()
        {
            InitializeComponent();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if (parallelRadioButton.Checked)
            {
                Type = new ParallelCircuit();
                serialRadioButton.Checked = false;
                DialogResult = DialogResult.OK;
                this.Close();
            }
            else if (serialRadioButton.Checked)
            {
                Type = new SerialCircuit();
                parallelRadioButton.Checked = false;
                DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show(@"You must choose connection type first.",
                    @"Type not chosen", MessageBoxButtons.OK);
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
