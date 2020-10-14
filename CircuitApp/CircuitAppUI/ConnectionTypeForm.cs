using System;
using System.Windows.Forms;
using CircutApp;

namespace CircuitAppUI
{
    //TODO: верстка
    //TODO: xml
    /// <summary>
    /// Form for choosing connection type
    /// </summary>
    public partial class ConnectionTypeForm : Form
    {
        //TODO: именование(done)
        public ISegment Type { get; set; }
        public ConnectionTypeForm()
        {
            InitializeComponent();
            serialRadioButton.Checked = true;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            //TODO: лучше создавать объект Type в обработчиках радиобаттонов, а здесь просто Close()
            //TODO: зачем сбрасывать перед закрытием?(done)
            DialogResult = DialogResult.OK;
            Close();
            //TODO: почему не сделать какой-нибудь радиобаттон включенным по умолчанию?
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
                //TODO: здесь должно кидаться исключение на случай добавления новых радиобаттонов на форму (done)
                throw new ArgumentException("Failed to choose segment connection type");
            }
        }
    }
}
