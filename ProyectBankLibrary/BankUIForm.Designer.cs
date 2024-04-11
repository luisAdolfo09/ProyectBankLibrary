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
            accountTxtBox = new TextBox();
            firstNameTxtBox = new TextBox();
            lastNameTxtBox = new TextBox();
            balanceTxtBox = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaption;
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(63, 52);
            label1.Name = "label1";
            label1.Size = new Size(58, 20);
            label1.TabIndex = 0;
            label1.Text = "Cuenta:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ActiveCaption;
            label2.Location = new Point(63, 94);
            label2.Name = "label2";
            label2.Size = new Size(114, 20);
            label2.TabIndex = 1;
            label2.Text = "Primer Nombre:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ActiveCaption;
            label3.Location = new Point(63, 139);
            label3.Name = "label3";
            label3.Size = new Size(123, 20);
            label3.TabIndex = 2;
            label3.Text = "Apellido Paterno:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ActiveCaption;
            label4.Location = new Point(63, 183);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 3;
            label4.Text = "Saldo:";
            // 
            // accountTxtBox
            // 
            accountTxtBox.Location = new Point(238, 49);
            accountTxtBox.Multiline = true;
            accountTxtBox.Name = "accountTxtBox";
            accountTxtBox.Size = new Size(196, 23);
            accountTxtBox.TabIndex = 4;
            // 
            // firstNameTxtBox
            // 
            firstNameTxtBox.Location = new Point(238, 91);
            firstNameTxtBox.Multiline = true;
            firstNameTxtBox.Name = "firstNameTxtBox";
            firstNameTxtBox.Size = new Size(196, 23);
            firstNameTxtBox.TabIndex = 5;
            // 
            // lastNameTxtBox
            // 
            lastNameTxtBox.Location = new Point(238, 136);
            lastNameTxtBox.Multiline = true;
            lastNameTxtBox.Name = "lastNameTxtBox";
            lastNameTxtBox.Size = new Size(196, 23);
            lastNameTxtBox.TabIndex = 6;
            // 
            // balanceTxtBox
            // 
            balanceTxtBox.Location = new Point(238, 183);
            balanceTxtBox.Multiline = true;
            balanceTxtBox.Name = "balanceTxtBox";
            balanceTxtBox.Size = new Size(196, 27);
            balanceTxtBox.TabIndex = 7;
            // 
            // BankUIForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(465, 268);
            Controls.Add(balanceTxtBox);
            Controls.Add(lastNameTxtBox);
            Controls.Add(firstNameTxtBox);
            Controls.Add(accountTxtBox);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "BankUIForm";
            Text = "BankUIForm";
            Load += BankUIForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox accountTxtBox;
        private TextBox firstNameTxtBox;
        private TextBox lastNameTxtBox;
        private TextBox balanceTxtBox;
    }
}