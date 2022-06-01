namespace Vendas.View
{
    partial class FormLogin
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
            this.labelLogin = new System.Windows.Forms.Label();
            this.TextLogin = new System.Windows.Forms.TextBox();
            this.TextSenha = new System.Windows.Forms.TextBox();
            this.LabelSenha = new System.Windows.Forms.Label();
            this.ButtonEntrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelLogin.Location = new System.Drawing.Point(12, 39);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(49, 21);
            this.labelLogin.TabIndex = 0;
            this.labelLogin.Text = "Login";
            // 
            // TextLogin
            // 
            this.TextLogin.Location = new System.Drawing.Point(12, 63);
            this.TextLogin.Name = "TextLogin";
            this.TextLogin.Size = new System.Drawing.Size(260, 23);
            this.TextLogin.TabIndex = 1;
            // 
            // TextSenha
            // 
            this.TextSenha.Location = new System.Drawing.Point(12, 129);
            this.TextSenha.Name = "TextSenha";
            this.TextSenha.PasswordChar = '*';
            this.TextSenha.Size = new System.Drawing.Size(260, 23);
            this.TextSenha.TabIndex = 3;
            // 
            // LabelSenha
            // 
            this.LabelSenha.AutoSize = true;
            this.LabelSenha.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabelSenha.Location = new System.Drawing.Point(12, 105);
            this.LabelSenha.Name = "LabelSenha";
            this.LabelSenha.Size = new System.Drawing.Size(53, 21);
            this.LabelSenha.TabIndex = 2;
            this.LabelSenha.Text = "Senha";
            // 
            // ButtonEntrar
            // 
            this.ButtonEntrar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonEntrar.Location = new System.Drawing.Point(85, 173);
            this.ButtonEntrar.Name = "ButtonEntrar";
            this.ButtonEntrar.Size = new System.Drawing.Size(120, 35);
            this.ButtonEntrar.TabIndex = 4;
            this.ButtonEntrar.Text = "Entrar";
            this.ButtonEntrar.UseVisualStyleBackColor = true;
            this.ButtonEntrar.Click += new System.EventHandler(this.ButtonEntrar_Click);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.ButtonEntrar);
            this.Controls.Add(this.TextSenha);
            this.Controls.Add(this.LabelSenha);
            this.Controls.Add(this.TextLogin);
            this.Controls.Add(this.labelLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelLogin;
        private TextBox TextLogin;
        private TextBox TextSenha;
        private Label LabelSenha;
        private Button ButtonEntrar;
    }
}