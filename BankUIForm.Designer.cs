namespace BankLibraryy
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
            accountTextBox = new TextBox();
            firstNameTextBox = new TextBox();
            lastNameTextBox = new TextBox();
            balanceTextBox = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(51, 51);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 0;
            label1.Text = "Cuenta";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(51, 147);
            label2.Name = "label2";
            label2.Size = new Size(89, 15);
            label2.TabIndex = 1;
            label2.Text = "Primer Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(51, 242);
            label3.Name = "label3";
            label3.Size = new Size(95, 15);
            label3.TabIndex = 2;
            label3.Text = "Apellido Paterno";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(51, 322);
            label4.Name = "label4";
            label4.Size = new Size(45, 15);
            label4.TabIndex = 3;
            label4.Text = "Cuenta";
            // 
            // accountTextBox
            // 
            accountTextBox.Location = new Point(179, 43);
            accountTextBox.Name = "accountTextBox";
            accountTextBox.Size = new Size(173, 23);
            accountTextBox.TabIndex = 4;
            // 
            // firstNameTextBox
            // 
            firstNameTextBox.Location = new Point(179, 139);
            firstNameTextBox.Name = "firstNameTextBox";
            firstNameTextBox.Size = new Size(173, 23);
            firstNameTextBox.TabIndex = 5;
            // 
            // lastNameTextBox
            // 
            lastNameTextBox.Location = new Point(179, 234);
            lastNameTextBox.Name = "lastNameTextBox";
            lastNameTextBox.Size = new Size(173, 23);
            lastNameTextBox.TabIndex = 6;
            // 
            // balanceTextBox
            // 
            balanceTextBox.Location = new Point(179, 314);
            balanceTextBox.Name = "balanceTextBox";
            balanceTextBox.Size = new Size(173, 23);
            balanceTextBox.TabIndex = 7;
            // 
            // BankUIForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(576, 435);
            Controls.Add(balanceTextBox);
            Controls.Add(lastNameTextBox);
            Controls.Add(firstNameTextBox);
            Controls.Add(accountTextBox);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "BankUIForm";
            Text = "BankUIForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox accountTextBox;
        private TextBox firstNameTextBox;
        private TextBox lastNameTextBox;
        private TextBox balanceTextBox;
    }
}