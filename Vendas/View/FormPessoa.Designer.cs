namespace Vendas.View
{
    partial class FormPessoa
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
            this.BotaoSalvar = new System.Windows.Forms.Button();
            this.BotaoExcluir = new System.Windows.Forms.Button();
            this.BotaoCancelar = new System.Windows.Forms.Button();
            this.BotaoLiberar = new System.Windows.Forms.Button();
            this.BotaoVoltar = new System.Windows.Forms.Button();
            this.LabelCnpjCpf = new System.Windows.Forms.Label();
            this.TextBoxCnpjCpf = new System.Windows.Forms.TextBox();
            this.LabelNome = new System.Windows.Forms.Label();
            this.TextBoxNome = new System.Windows.Forms.TextBox();
            this.LabelHandle = new System.Windows.Forms.Label();
            this.TextBoxHandle = new System.Windows.Forms.TextBox();
            this.LabelEndereco = new System.Windows.Forms.Label();
            this.TextBoxEndereco = new System.Windows.Forms.TextBox();
            this.TextBoxObservacao = new System.Windows.Forms.RichTextBox();
            this.LabelObservacao = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BotaoSalvar
            // 
            this.BotaoSalvar.Location = new System.Drawing.Point(133, 192);
            this.BotaoSalvar.Name = "BotaoSalvar";
            this.BotaoSalvar.Size = new System.Drawing.Size(75, 23);
            this.BotaoSalvar.TabIndex = 21;
            this.BotaoSalvar.Text = "Salvar";
            this.BotaoSalvar.UseVisualStyleBackColor = true;
            this.BotaoSalvar.Click += new System.EventHandler(this.BotaoSalvar_Click);
            // 
            // BotaoExcluir
            // 
            this.BotaoExcluir.Location = new System.Drawing.Point(52, 192);
            this.BotaoExcluir.Name = "BotaoExcluir";
            this.BotaoExcluir.Size = new System.Drawing.Size(75, 23);
            this.BotaoExcluir.TabIndex = 20;
            this.BotaoExcluir.Text = "Excluir";
            this.BotaoExcluir.UseVisualStyleBackColor = true;
            this.BotaoExcluir.Click += new System.EventHandler(this.BotaoExcluir_Click);
            // 
            // BotaoCancelar
            // 
            this.BotaoCancelar.Location = new System.Drawing.Point(214, 192);
            this.BotaoCancelar.Name = "BotaoCancelar";
            this.BotaoCancelar.Size = new System.Drawing.Size(75, 23);
            this.BotaoCancelar.TabIndex = 19;
            this.BotaoCancelar.Text = "Cancelar";
            this.BotaoCancelar.UseVisualStyleBackColor = true;
            this.BotaoCancelar.Click += new System.EventHandler(this.BotaoCancelar_Click);
            // 
            // BotaoLiberar
            // 
            this.BotaoLiberar.Location = new System.Drawing.Point(295, 192);
            this.BotaoLiberar.Name = "BotaoLiberar";
            this.BotaoLiberar.Size = new System.Drawing.Size(75, 23);
            this.BotaoLiberar.TabIndex = 18;
            this.BotaoLiberar.Text = "Liberar";
            this.BotaoLiberar.UseVisualStyleBackColor = true;
            this.BotaoLiberar.Click += new System.EventHandler(this.BotaoLiberar_Click);
            // 
            // BotaoVoltar
            // 
            this.BotaoVoltar.Location = new System.Drawing.Point(376, 192);
            this.BotaoVoltar.Name = "BotaoVoltar";
            this.BotaoVoltar.Size = new System.Drawing.Size(75, 23);
            this.BotaoVoltar.TabIndex = 17;
            this.BotaoVoltar.Text = "Voltar";
            this.BotaoVoltar.UseVisualStyleBackColor = true;
            this.BotaoVoltar.Click += new System.EventHandler(this.BotaoVoltar_Click);
            // 
            // LabelCnpjCpf
            // 
            this.LabelCnpjCpf.AutoSize = true;
            this.LabelCnpjCpf.Location = new System.Drawing.Point(12, 50);
            this.LabelCnpjCpf.Name = "LabelCnpjCpf";
            this.LabelCnpjCpf.Size = new System.Drawing.Size(60, 15);
            this.LabelCnpjCpf.TabIndex = 16;
            this.LabelCnpjCpf.Text = "CNPJ/CPF";
            // 
            // TextBoxCnpjCpf
            // 
            this.TextBoxCnpjCpf.Location = new System.Drawing.Point(12, 68);
            this.TextBoxCnpjCpf.Name = "TextBoxCnpjCpf";
            this.TextBoxCnpjCpf.Size = new System.Drawing.Size(202, 23);
            this.TextBoxCnpjCpf.TabIndex = 15;
            this.TextBoxCnpjCpf.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxCnpjCpf_KeyPress);
            // 
            // LabelNome
            // 
            this.LabelNome.AutoSize = true;
            this.LabelNome.Location = new System.Drawing.Point(12, 5);
            this.LabelNome.Name = "LabelNome";
            this.LabelNome.Size = new System.Drawing.Size(40, 15);
            this.LabelNome.TabIndex = 14;
            this.LabelNome.Text = "Nome";
            // 
            // TextBoxNome
            // 
            this.TextBoxNome.Location = new System.Drawing.Point(12, 24);
            this.TextBoxNome.Name = "TextBoxNome";
            this.TextBoxNome.Size = new System.Drawing.Size(334, 23);
            this.TextBoxNome.TabIndex = 13;
            // 
            // LabelHandle
            // 
            this.LabelHandle.AutoSize = true;
            this.LabelHandle.Location = new System.Drawing.Point(352, 6);
            this.LabelHandle.Name = "LabelHandle";
            this.LabelHandle.Size = new System.Drawing.Size(46, 15);
            this.LabelHandle.TabIndex = 12;
            this.LabelHandle.Text = "Código";
            // 
            // TextBoxHandle
            // 
            this.TextBoxHandle.Location = new System.Drawing.Point(352, 24);
            this.TextBoxHandle.Name = "TextBoxHandle";
            this.TextBoxHandle.ReadOnly = true;
            this.TextBoxHandle.Size = new System.Drawing.Size(100, 23);
            this.TextBoxHandle.TabIndex = 11;
            this.TextBoxHandle.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // LabelEndereco
            // 
            this.LabelEndereco.AutoSize = true;
            this.LabelEndereco.Location = new System.Drawing.Point(220, 50);
            this.LabelEndereco.Name = "LabelEndereco";
            this.LabelEndereco.Size = new System.Drawing.Size(56, 15);
            this.LabelEndereco.TabIndex = 23;
            this.LabelEndereco.Text = "Endereço";
            // 
            // TextBoxEndereco
            // 
            this.TextBoxEndereco.Location = new System.Drawing.Point(220, 68);
            this.TextBoxEndereco.Name = "TextBoxEndereco";
            this.TextBoxEndereco.Size = new System.Drawing.Size(232, 23);
            this.TextBoxEndereco.TabIndex = 22;
            // 
            // TextBoxObservacao
            // 
            this.TextBoxObservacao.Location = new System.Drawing.Point(12, 113);
            this.TextBoxObservacao.Name = "TextBoxObservacao";
            this.TextBoxObservacao.Size = new System.Drawing.Size(440, 73);
            this.TextBoxObservacao.TabIndex = 24;
            this.TextBoxObservacao.Text = "";
            // 
            // LabelObservacao
            // 
            this.LabelObservacao.AutoSize = true;
            this.LabelObservacao.Location = new System.Drawing.Point(12, 94);
            this.LabelObservacao.Name = "LabelObservacao";
            this.LabelObservacao.Size = new System.Drawing.Size(69, 15);
            this.LabelObservacao.TabIndex = 25;
            this.LabelObservacao.Text = "Observação";
            // 
            // FormPessoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 227);
            this.Controls.Add(this.LabelObservacao);
            this.Controls.Add(this.TextBoxObservacao);
            this.Controls.Add(this.LabelEndereco);
            this.Controls.Add(this.TextBoxEndereco);
            this.Controls.Add(this.BotaoSalvar);
            this.Controls.Add(this.BotaoExcluir);
            this.Controls.Add(this.BotaoCancelar);
            this.Controls.Add(this.BotaoLiberar);
            this.Controls.Add(this.BotaoVoltar);
            this.Controls.Add(this.LabelCnpjCpf);
            this.Controls.Add(this.TextBoxCnpjCpf);
            this.Controls.Add(this.LabelNome);
            this.Controls.Add(this.TextBoxNome);
            this.Controls.Add(this.LabelHandle);
            this.Controls.Add(this.TextBoxHandle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Name = "FormPessoa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pessoa";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormPessoa_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button BotaoSalvar;
        private Button BotaoExcluir;
        private Button BotaoCancelar;
        private Button BotaoLiberar;
        private Button BotaoVoltar;
        private Label LabelCnpjCpf;
        private TextBox TextBoxCnpjCpf;
        private Label LabelNome;
        private TextBox TextBoxNome;
        private Label LabelHandle;
        private TextBox TextBoxHandle;
        private Label LabelEndereco;
        private TextBox TextBoxEndereco;
        private RichTextBox TextBoxObservacao;
        private Label LabelObservacao;
    }
}