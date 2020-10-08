using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CircutApp;

namespace CircuitAppUI
{
    public partial class AddEditElementForm : Form
    {
        public string ElementName { get; set; }

        public double ElementValue { get; set; }

        public Type ElementType { get; set; }

        public AddEditElementForm()
        {
            InitializeComponent();
        }

        private void nameTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (nameTextBox.Text.Length > 30)
            {
                e.Cancel = true;
                nameTextBox.Select(0, nameTextBox.Text.Length);
            }
        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (nameTextBox.Text.Length > 30)
            {
                nameTextBox.BackColor = Color.LightCoral;
            }
            else
            {
                nameTextBox.BackColor = Color.White;
                ElementName = nameTextBox.Text;
            }
        }

        //TODO: Do something about "," with double input
        private void valueTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && (valueTextBox.Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if (ElementValue <= 0.0)
            {
                MessageBox.Show(@"Value can't be 0 or less", @"Invalid data",
                    MessageBoxButtons.OK);
                return;
            }

            if (resistorTypeRadioButton.Checked)
            {
                ElementType = typeof(Resistor);
            }
            else if (inductorTypeRadioButton.Checked)
            {
                ElementType = typeof(Inductor);
            }
            else if (capacitorTypeRadioButton.Checked)
            {
                ElementType = typeof(Capacitor);
            }
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void valueTextBox_TextChanged(object sender, EventArgs e)
        {
            ElementValue = Convert.ToDouble(valueTextBox.Text,CultureInfo.InvariantCulture);
        }

        private void AddEditElementForm_Shown(object sender, EventArgs e)
        {
            nameTextBox.Text = ElementName;
            valueTextBox.Text = ElementValue.ToString();
            if (ElementType == typeof(Resistor))
            {
                resistorTypeRadioButton.Checked = true;
            }
            else if (ElementType == typeof(Capacitor))
            {
                capacitorTypeRadioButton.Checked = true;
            }
            else if (ElementType == typeof(Inductor))
            {
                inductorTypeRadioButton.Checked = true;
            }
            else
            {
                resistorTypeRadioButton.Checked = true;
            }
        }
    }
}
