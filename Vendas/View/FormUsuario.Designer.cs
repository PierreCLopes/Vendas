namespace Vendas.View
{
    partial class FormUsuario
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
            this.TextBoxHandle = new System.Windows.Forms.TextBox();
            this.LabelHandle = new System.Windows.Forms.Label();
            this.TextBoxLogin = new System.Windows.Forms.TextBox();
            this.LabelLogin = new System.Windows.Forms.Label();
            this.TextBoxSenha = new System.Windows.Forms.TextBox();
            this.LabelSenha = new System.Windows.Forms.Label();
            this.BotaoVoltar = new System.Windows.Forms.Button();
            this.BotaoLiberar = new System.Windows.Forms.Button();
            this.BotaoCancelar = new System.Windows.Forms.Button();
            this.BotaoExcluir = new System.Windows.Forms.Button();
            this.BotaoSalvar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TextBoxHandle
            // 
            this.TextBoxHandle.Location = new System.Drawing.Point(352, 28);
            this.TextBoxHandle.Name = "TextBoxHandle";
            this.TextBoxHandle.ReadOnly = true;
            this.TextBoxHandle.Size = new System.Drawing.Size(100, 23);
            this.TextBoxHandle.TabIndex = 0;
            this.TextBoxHandle.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // LabelHandle
            // 
            this.LabelHandle.AutoSize = true;
            this.LabelHandle.Location = new System.Drawing.Point(352, 10);
            this.LabelHandle.Name = "LabelHandle";
            this.LabelHandle.Size = new System.Drawing.Size(46, 15);
            this.LabelHandle.TabIndex = 1;
            this.LabelHandle.Text = "Código";
            // 
            // TextBoxLogin
            // 
            this.TextBoxLogin.Location = new System.Drawing.Point(12, 28);
            this.TextBoxLogin.Name = "TextBoxLogin";
            this.TextBoxLogin.Size = new System.Drawing.Size(334, 23);
            this.TextBoxLogin.TabIndex = 2;
            // 
            // LabelLogin
            // 
            this.LabelLogin.AutoSize = true;
            this.LabelLogin.Location = new System.Drawing.Point(12, 9);
            this.LabelLogin.Name = "LabelLogin";
            this.LabelLogin.Size = new System.Drawing.Size(37, 15);
            this.LabelLogin.TabIndex = 3;
            this.LabelLogin.Text = "Login";
            // 
            // TextBoxSenha
            // 
            this.TextBoxSenha.Location = new System.Drawing.Point(12, 72);
            this.TextBoxSenha.Name = "TextBoxSenha";
            this.TextBoxSenha.PasswordChar = '*';
            this.TextBoxSenha.Size = new System.Drawing.Size(440, 23);
            this.TextBoxSenha.TabIndex = 4;
            // 
            // LabelSenha
            // 
            this.LabelSenha.AutoSize = true;
            this.LabelSenha.Location = new System.Drawing.Point(12, 54);
            this.LabelSenha.Name = "LabelSenha";
            this.LabelSenha.Size = new System.Drawing.Size(39, 15);
            this.LabelSenha.TabIndex = 5;
            this.LabelSenha.Text = "Senha";
            // 
            // BotaoVoltar
            // 
            this.BotaoVoltar.Location = new System.Drawing.Point(377, 101);
            this.BotaoVoltar.Name = "BotaoVoltar";
            this.BotaoVoltar.Size = new System.Drawing.Size(75, 23);
            this.BotaoVoltar.TabIndex = 6;
            this.BotaoVoltar.Text = "Voltar";
            this.BotaoVoltar.UseVisualStyleBackColor = true;
            this.BotaoVoltar.Click += new System.EventHandler(this.BotaoVoltar_Click);
            // 
            // BotaoLiberar
            // 
            this.BotaoLiberar.Location = new System.Drawing.Point(296, 101);
            this.BotaoLiberar.Name = "BotaoLiberar";
            this.BotaoLiberar.Size = new System.Drawing.Size(75, 23);
            this.BotaoLiberar.TabIndex = 7;
            this.BotaoLiberar.Text = "Liberar";
            this.BotaoLiberar.UseVisualStyleBackColor = true;
            this.BotaoLiberar.Click += new System.EventHandler(this.BotaoLiberar_Click);
            // 
            // BotaoCancelar
            // 
            this.BotaoCancelar.Location = new System.Drawing.Point(215, 101);
            this.BotaoCancelar.Name = "BotaoCancelar";
            this.BotaoCancelar.Size = new System.Drawing.Size(75, 23);
            this.BotaoCancelar.TabIndex = 8;
            this.BotaoCancelar.Text = "Cancelar";
            this.BotaoCancelar.UseVisualStyleBackColor = true;
            this.BotaoCancelar.Click += new System.EventHandler(this.BotaoCancelar_Click);
            // 
            // BotaoExcluir
            // 
            this.BotaoExcluir.Location = new System.Drawing.Point(53, 101);
            this.BotaoExcluir.Name = "BotaoExcluir";
            this.BotaoExcluir.Size = new System.Drawing.Size(75, 23);
            this.BotaoExcluir.TabIndex = 9;
            this.BotaoExcluir.Text = "Excluir";
            this.BotaoExcluir.UseVisualStyleBackColor = true;
            this.BotaoExcluir.Click += new System.EventHandler(this.BotaoExcluir_Click);
            // 
            // BotaoSalvar
            // 
            this.BotaoSalvar.Location = new System.Drawing.Point(134, 101);
            this.BotaoSalvar.Name = "BotaoSalvar";
            this.BotaoSalvar.Size = new System.Drawing.Size(75, 23);
            this.BotaoSalvar.TabIndex = 10;
            this.BotaoSalvar.Text = "Salvar";
            this.BotaoSalvar.UseVisualStyleBackColor = true;
            this.BotaoSalvar.Click += new System.EventHandler(this.BotaoSalvar_Click);
            // 
            // FormUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 134);
            this.Controls.Add(this.BotaoSalvar);
            this.Controls.Add(this.BotaoExcluir);
            this.Controls.Add(this.BotaoCancelar);
            this.Controls.Add(this.BotaoLiberar);
            this.Controls.Add(this.BotaoVoltar);
            this.Controls.Add(this.LabelSenha);
            this.Controls.Add(this.TextBoxSenha);
            this.Controls.Add(this.LabelLogin);
            this.Controls.Add(this.TextBoxLogin);
            this.Controls.Add(this.LabelHandle);
            this.Controls.Add(this.TextBoxHandle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Name = "FormUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuário";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormUsuario_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox TextBoxHandle;
        private Label LabelHandle;
        private TextBox TextBoxLogin;
        private Label LabelLogin;
        private TextBox TextBoxSenha;
        private Label LabelSenha;
        private Button BotaoVoltar;
        private Button BotaoLiberar;
        private Button BotaoCancelar;
        private Button BotaoExcluir;
        private Button BotaoSalvar;
    }
}