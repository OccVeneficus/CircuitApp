using System;
using System.Windows.Forms;
using CircutApp;

namespace CircuitAppUI
{
    //TODO: верстка
    //TODO: xml
    public partial class ChooseConnectionTypeForm : Form
    {
        //TODO: именование
        public ISegment Type { get; set; }
        public ChooseConnectionTypeForm()
        {
            InitializeComponent();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            //TODO: лучше создавать объект Type в обработчиках радиобаттонов, а здесь просто Close()
            if (parallelRadioButton.Checked)
            {
                Type = new ParallelCircuit();
                serialRadioButton.Checked = false; //TODO: зачем сбрасывать перед закрытием?
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
            { //TODO: почему не сделать какой-нибудь радиобаттон включенным по умолчанию?
                MessageBox.Show(@"You must choose connection type first.",
                    @"Type not chosen", MessageBoxButtons.OK);
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void ChooseConnectionTypeForm_Shown(object sender, EventArgs e)
        {
            if (Type is ParallelCircuit)
            {
                parallelRadioButton.Checked = true;
            }
            else if (Type is SerialCircuit)
            {
                serialRadioButton.Checked = true;
            }
            else
            { 
                //TODO: здесь должно кидаться исключение на случай добавления новых радиобаттонов на форму
                serialRadioButton.Checked = true;
            }
        }
    }
}
