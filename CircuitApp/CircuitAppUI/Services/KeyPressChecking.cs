using System.Windows.Forms;

namespace CircuitAppUI.Services
{
    /// <summary>
    /// Class for checking input int textboxes
    /// </summary>
    public static class KeyPressChecking
    {
        /// <summary>
        /// Check if after adding char to TextBox.Text it still will be double number
        /// </summary>
        /// <param name="sender">TextBox</param>
        /// <param name="e">Info about pressed button</param>
        public static void CheckForDouble(object sender, KeyPressEventArgs e)
        {
            var textBox = (TextBox) sender;
            //If pressed key button isn't control, number or "." then consider event handled. 
            //This will prevent char from getting into TextBox.Text
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            //If pressed key button was '.' and there is already '.' in TextBox.Text then consider event handled.
            //This will prevent char from getting into TextBox.Text
            if ((e.KeyChar == '.') && (textBox.Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
