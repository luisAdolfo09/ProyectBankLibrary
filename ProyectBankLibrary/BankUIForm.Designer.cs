namespace ProyectBankLibrary
{
    partial class BankUIForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txt_account = new TextBox();
            btn_agregar = new Button();
            btn_xml = new Button();
            dt_datos = new DataGridView();
            groupBox1 = new GroupBox();
            btn_json = new Button();
            label5 = new Label();
            txt_firtsName = new TextBox();
            txt_lastName = new TextBox();
            txt_balance = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dt_datos).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(32, 59);
            label1.Name = "label1";
            label1.Size = new Size(48, 15);
            label1.TabIndex = 0;
            label1.Text = "Cuenta:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.Control;
            label2.Location = new Point(32, 90);
            label2.Name = "label2";
            label2.Size = new Size(92, 15);
            label2.TabIndex = 1;
            label2.Text = "Primer Nombre:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.Control;
            label3.Location = new Point(32, 124);
            label3.Name = "label3";
            label3.Size = new Size(98, 15);
            label3.TabIndex = 2;
            label3.Text = "Apellido Paterno:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.Control;
            label4.Location = new Point(32, 157);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 3;
            label4.Text = "Saldo:";
            // 
            // txt_account
            // 
            txt_account.Location = new Point(185, 52);
            txt_account.Margin = new Padding(3, 2, 3, 2);
            txt_account.Multiline = true;
            txt_account.Name = "txt_account";
            txt_account.Size = new Size(172, 22);
            txt_account.TabIndex = 4;
            txt_account.KeyPress += accountTxtBox_KeyPress;
            // 
            // btn_agregar
            // 
            btn_agregar.Location = new Point(283, 236);
            btn_agregar.Name = "btn_agregar";
            btn_agregar.Size = new Size(113, 33);
            btn_agregar.TabIndex = 8;
            btn_agregar.Text = "Agregar cuenta";
            btn_agregar.UseVisualStyleBackColor = true;
            btn_agregar.Click += btn_agregar_Click;
            // 
            // btn_xml
            // 
            btn_xml.Location = new Point(22, 41);
            btn_xml.Name = "btn_xml";
            btn_xml.Size = new Size(71, 31);
            btn_xml.TabIndex = 9;
            btn_xml.Text = "XML";
            btn_xml.UseVisualStyleBackColor = true;
            btn_xml.Click += btn_xml_Click;
            // 
            // dt_datos
            // 
            dt_datos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dt_datos.Dock = DockStyle.Bottom;
            dt_datos.Location = new Point(0, 345);
            dt_datos.Name = "dt_datos";
            dt_datos.Size = new Size(499, 232);
            dt_datos.TabIndex = 10;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btn_json);
            groupBox1.Controls.Add(btn_xml);
            groupBox1.Location = new Point(26, 195);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(204, 99);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tipo de deserialización:";
            // 
            // btn_json
            // 
            btn_json.Location = new Point(117, 41);
            btn_json.Name = "btn_json";
            btn_json.Size = new Size(59, 31);
            btn_json.TabIndex = 10;
            btn_json.Text = "JSON";
            btn_json.UseVisualStyleBackColor = true;
            btn_json.Click += btn_json_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(78, 9);
            label5.Name = "label5";
            label5.Size = new Size(333, 25);
            label5.TabIndex = 12;
            label5.Text = "REGISTRO DE CUENTAS BANCARIAS";
            // 
            // txt_firtsName
            // 
            txt_firtsName.Location = new Point(185, 87);
            txt_firtsName.Margin = new Padding(3, 2, 3, 2);
            txt_firtsName.Multiline = true;
            txt_firtsName.Name = "txt_firtsName";
            txt_firtsName.Size = new Size(172, 22);
            txt_firtsName.TabIndex = 13;
            txt_firtsName.KeyPress += textBox1_KeyPress;
            // 
            // txt_lastName
            // 
            txt_lastName.Location = new Point(185, 121);
            txt_lastName.Margin = new Padding(3, 2, 3, 2);
            txt_lastName.Multiline = true;
            txt_lastName.Name = "txt_lastName";
            txt_lastName.Size = new Size(172, 22);
            txt_lastName.TabIndex = 14;
            txt_lastName.KeyPress += textBox1_KeyPress;
            // 
            // txt_balance
            // 
            txt_balance.Location = new Point(185, 157);
            txt_balance.Margin = new Padding(3, 2, 3, 2);
            txt_balance.Multiline = true;
            txt_balance.Name = "txt_balance";
            txt_balance.Size = new Size(172, 22);
            txt_balance.TabIndex = 15;
            txt_balance.KeyPress += accountTxtBox_KeyPress;
            // 
            // BankUIForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(499, 577);
            Controls.Add(txt_balance);
            Controls.Add(txt_lastName);
            Controls.Add(txt_firtsName);
            Controls.Add(label5);
            Controls.Add(groupBox1);
            Controls.Add(dt_datos);
            Controls.Add(btn_agregar);
            Controls.Add(txt_account);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "BankUIForm";
            Text = "BankUIForm";
            Load += BankUIForm_Load;
            ((System.ComponentModel.ISupportInitialize)dt_datos).EndInit();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txt_account;
        private Button btn_agregar;
        private Button btn_xml;
        private DataGridView dt_datos;
        private GroupBox groupBox1;
        private Button btn_json;
        private Label label5;
        private TextBox txt_firtsName;
        private TextBox txt_lastName;
        private TextBox txt_balance;
    }
}