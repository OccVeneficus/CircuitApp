using System;
using System.Windows.Forms;
using CircutApp.Segments;

namespace CircuitAppUI.Forms
{
    /// <summary>
    /// Form for choosing connection type
    /// </summary>
    public partial class ConnectionTypeForm : Form
    {
        public ISegment Type { get; set; }
        public ConnectionTypeForm()
        {
            InitializeComponent();
            serialRadioButton.Checked = true;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void parallelRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (parallelRadioButton.Checked)
            {
                Type = new ParallelSegment();
            }
        }

        private void serialRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (serialRadioButton.Checked)
            {
                Type = new SerialSegment();
            }
        }

        private void ConnectionTypeForm_Load(object sender, EventArgs e)
        {
            if (Type is ParallelSegment)
            {
                parallelRadioButton.Checked = true;
            }
            else if (Type is SerialSegment)
            {
                serialRadioButton.Checked = true;
            }
            else
            {
                throw new ArgumentException("Failed to choose segment connection type");
            }
        }
    }
}
