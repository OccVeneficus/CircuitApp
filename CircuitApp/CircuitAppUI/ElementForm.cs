using System;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using CircutApp;

namespace CircuitAppUI
{
    //TODO: именование (done)
    //TODO: xml
    //TODO: верстка
    /// <summary>
    /// Form for adding/editing circuit elements
    /// </summary>
    public partial class ElementForm : Form
    {
        public string ElementName { get; set; }

        public double ElementValue { get; set; }

        public Type ElementType { get; set; }

        public ElementForm()
        {
            InitializeComponent();
            elementTypeComboBox.Items.Add(typeof(Resistor));
            elementTypeComboBox.Items.Add(typeof(Capacitor));
            elementTypeComboBox.Items.Add(typeof(Inductor));
            elementTypeComboBox.DisplayMember = "Name";
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
            }
        }

        private void valueTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //TODO: аналогичная проверка в MainForm - избавиться от дублирования
            //TODO: вообще, не очевидно, что проверяется условием, пояснить комментарием

            //If pressed key button isn't control, number or "." then consider event handled. 
            //This will prevent char from getting into TextBox.Text
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            //If pressed key button was '.' and there is already '.' in TextBox.Text then consider event handled.
            //This will prevent char from getting into TextBox.Text
            if ((e.KeyChar == '.') && (valueTextBox.Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if (ElementValue <= 0.0)
            {
                MessageBox.Show(@"Value can't be 0 or less", @"Invalid data",
                    MessageBoxButtons.OK);
                return;
            }
            ElementName = nameTextBox.Text;
            ElementValue = Convert.ToDouble(valueTextBox.Text, CultureInfo.InvariantCulture);
            ElementType = (Type)elementTypeComboBox.SelectedItem;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void ElementForm_Load(object sender, EventArgs e)
        {
            nameTextBox.Text = ElementName;
            valueTextBox.Text = ElementValue.ToString(CultureInfo.InvariantCulture);
            elementTypeComboBox.SelectedItem = ElementType ?? typeof(Resistor);
        }

        private void valueTextBox_Validating(object sender, CancelEventArgs e)
        {
            ElementValue = Convert.ToDouble(valueTextBox.Text, CultureInfo.InvariantCulture);
        }
    }
}
