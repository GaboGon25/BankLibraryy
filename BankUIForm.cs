using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankLibraryy
{
    public partial class BankUIForm : Form
    {
        protected int TextBoxCount { get; set; } = 4;
        public enum TextBoxIndices {Account, First, Last, Balance}
        public BankUIForm()
        {
            InitializeComponent();
        }

        public void ClearTextBoxes()
        {
            foreach(Control guicontrol in Controls)
            {
                (guicontrol as TextBox)?.Clear();
            }
        }

        public void SetTextBoxesValues(string[]values)
        {
            if(values.Length != TextBoxCount)
            {
                throw new ArgumentException(
                    $"There must be{TextBoxCount} strings in the array",
                    nameof(values));
            }
            else
            {
                accountTextBox.Text= values[(int)TextBoxIndices.Account];
                firstNameTextBox.Text = values[(int)TextBoxIndices.First];
                lastNameTextBox.Text = values[(int)TextBoxIndices.Last];
                balanceTextBox.Text = values[(int)TextBoxIndices.Balance];

            }

            
        }
        public string[] GetTextBoxesValues() 
        {

            return new string[]
            {
                accountTextBox.Text, firstNameTextBox.Text, lastNameTextBox.Text,balanceTextBox.Text
            };
        }

        
    }
}
