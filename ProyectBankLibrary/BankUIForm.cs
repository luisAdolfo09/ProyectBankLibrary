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
        private string _filename;

        private List<Record> _cuentas = new List<Record>();
        protected int TextBoxCount { get; set; } = 4;

        public enum TextBoxIndices { Account, First, Last, Balance }
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


        private void btn_agregar_Click(object sender, EventArgs e)
        {
            foreach (Control cont in Controls)
            {
                if (cont is TextBox)
                {
                    if (cont.Text == "")
                    {
                        MessageBox.Show("RELLENAR TODOS LOS CAMPOS DE TEXTO POR FAVOR", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                }
            }

            try

            {

                Record cuenta = new(int.Parse(txt_account.Text), txt_firtsName.Text, txt_lastName.Text, decimal.Parse(txt_balance.Text));

                _cuentas.Add(cuenta);
                btn_json.Enabled = true;
                btn_xml.Enabled = true;


            }
            catch (Exception ex)

            {
                throw new Exception($"ES POSIBLE QUE ALGUN DATO FUE ESCRITO INCORRECTA MENTE {ex.Message}");

            }

            ClearTextBox();



        }

        private void accountTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char a = e.KeyChar;
            if (char.IsLetter(a))
            {
                e.Handled = true;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char a = e.KeyChar;
            if (char.IsDigit(a))
            {
                e.Handled = true;
            }
        }

        private void BankUIForm_Load(object sender, EventArgs e)
        {
            btn_json.Enabled = false;
            btn_xml.Enabled = false;

        }


        // los dos botones de xml y json serializan los datos y al mimso tiempo los deserializan mostradolos de un solo en el data griew
        private void btn_xml_Click(object sender, EventArgs e)
        {

            SerialezerXml a = new SerialezerXml();

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Archivos XML (*.xml)|*.xml";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                _filename = saveFileDialog.FileName;
                // Serializar la lista de cuentas en XML
                a.Serialize(_cuentas, _filename);
                MessageBox.Show("Datos guardados correctamente en formato XML.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            List<Record> cuentas = a.Deserialize<List<Record>>(_filename);

            dt_datos.DataSource = null;
            dt_datos.DataSource = cuentas;
            _cuentas.Clear();

        }

        private void btn_json_Click(object sender, EventArgs e)
        {
            SerializadorJson a = new SerializadorJson();

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Archivos JSON (*.json)|*.json";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                _filename = saveFileDialog.FileName;
                // Serializar la lista de cuentas en JSON
               a.Serialize(_cuentas, _filename);
                MessageBox.Show("Datos guardados correctamente en formato JSON.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }

            List<Record> ceuntas = a.Deserialize<List<Record>>(_filename);
            dt_datos.DataSource = null;
            dt_datos.DataSource= ceuntas;

            _cuentas.Clear();
        }
    }
}

