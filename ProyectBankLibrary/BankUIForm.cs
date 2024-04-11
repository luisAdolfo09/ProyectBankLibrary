using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectBankLibrary
{
    public partial class BankUIForm : Form
    {
        protected int TextBoxCount { get; set; } = 4;

        public enum TextBoxIndices { Account, First, Last, Balance}
        public BankUIForm()
        {
            InitializeComponent();
        }

        public void ClearTextBox()
        {
            foreach (Control guicontrol in Controls)
            {
                (guicontrol as TextBox)?.Clear();
            }
        }

        public void SetTextBoxValues(string[] values)
        {
            if(values.Length != TextBoxCount)
            {
                throw new ArgumentException($"There must be {TextBoxCount} string in the array", nameof(values));
            }
            else
            {
                accountTxtBox.Text = values[(int)TextBoxIndices.Account];
                firstNameTxtBox.Text = values[(int)TextBoxIndices.First];
                lastNameTxtBox.Text= values[(int)TextBoxIndices.Last];
                balanceTxtBox.Text = values[(int)(TextBoxIndices.Balance)];
            }
        }

        public string[] GetTextBoxValues()
        {
            return new string[] { 
                accountTxtBox.Text, firstNameTxtBox.Text, lastNameTxtBox.Text, 
                balanceTxtBox.Text 
            };
        }
        

        private void BankUIForm_Load(object sender, EventArgs e)
        {

        }
    }
}
