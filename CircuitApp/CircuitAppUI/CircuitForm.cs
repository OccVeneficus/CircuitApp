using System;
using System.Windows.Forms;
using CircutApp;

namespace CircuitAppUI
{
    //TODO: именование (done)
    //TODO: xml
    //TODO: верстка
    //TODO: то есть форма не создает цепь, а просто меняет имя?
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
