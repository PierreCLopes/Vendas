namespace Vendas.Model
{
    partial class FormVendaProduto
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
            this.LabelObservacao = new System.Windows.Forms.Label();
            this.TextBoxObservacao = new System.Windows.Forms.RichTextBox();
            this.LabelEndereco = new System.Windows.Forms.Label();
            this.TextBoxEndereco = new System.Windows.Forms.TextBox();
            this.BotaoSalvar = new System.Windows.Forms.Button();
            this.BotaoExcluir = new System.Windows.Forms.Button();
            this.LabelCnpjCpf = new System.Windows.Forms.Label();
            this.TextBoxCnpjCpf = new System.Windows.Forms.TextBox();
            this.LabelNome = new System.Windows.Forms.Label();
            this.TextBoxNome = new System.Windows.Forms.TextBox();
            this.LabelHandle = new System.Windows.Forms.Label();
            this.TextBoxHandle = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LabelObservacao
            // 
            this.LabelObservacao.AutoSize = true;
            this.LabelObservacao.Location = new System.Drawing.Point(12, 93);
            this.LabelObservacao.Name = "LabelObservacao";
            this.LabelObservacao.Size = new System.Drawing.Size(69, 15);
            this.LabelObservacao.TabIndex = 40;
            this.LabelObservacao.Text = "Observação";
            // 
            // TextBoxObservacao
            // 
            this.TextBoxObservacao.Location = new System.Drawing.Point(12, 112);
            this.TextBoxObservacao.Name = "TextBoxObservacao";
            this.TextBoxObservacao.Size = new System.Drawing.Size(440, 73);
            this.TextBoxObservacao.TabIndex = 39;
            this.TextBoxObservacao.Text = "";
            // 
            // LabelEndereco
            // 
            this.LabelEndereco.AutoSize = true;
            this.LabelEndereco.Location = new System.Drawing.Point(220, 49);
            this.LabelEndereco.Name = "LabelEndereco";
            this.LabelEndereco.Size = new System.Drawing.Size(56, 15);
            this.LabelEndereco.TabIndex = 38;
            this.LabelEndereco.Text = "Endereço";
            // 
            // TextBoxEndereco
            // 
            this.TextBoxEndereco.Location = new System.Drawing.Point(220, 67);
            this.TextBoxEndereco.Name = "TextBoxEndereco";
            this.TextBoxEndereco.Size = new System.Drawing.Size(232, 23);
            this.TextBoxEndereco.TabIndex = 37;
            // 
            // BotaoSalvar
            // 
            this.BotaoSalvar.Location = new System.Drawing.Point(377, 191);
            this.BotaoSalvar.Name = "BotaoSalvar";
            this.BotaoSalvar.Size = new System.Drawing.Size(75, 23);
            this.BotaoSalvar.TabIndex = 36;
            this.BotaoSalvar.Text = "Salvar";
            this.BotaoSalvar.UseVisualStyleBackColor = true;
            // 
            // BotaoExcluir
            // 
            this.BotaoExcluir.Location = new System.Drawing.Point(296, 191);
            this.BotaoExcluir.Name = "BotaoExcluir";
            this.BotaoExcluir.Size = new System.Drawing.Size(75, 23);
            this.BotaoExcluir.TabIndex = 35;
            this.BotaoExcluir.Text = "Excluir";
            this.BotaoExcluir.UseVisualStyleBackColor = true;
            // 
            // LabelCnpjCpf
            // 
            this.LabelCnpjCpf.AutoSize = true;
            this.LabelCnpjCpf.Location = new System.Drawing.Point(12, 49);
            this.LabelCnpjCpf.Name = "LabelCnpjCpf";
            this.LabelCnpjCpf.Size = new System.Drawing.Size(60, 15);
            this.LabelCnpjCpf.TabIndex = 31;
            this.LabelCnpjCpf.Text = "CNPJ/CPF";
            // 
            // TextBoxCnpjCpf
            // 
            this.TextBoxCnpjCpf.Location = new System.Drawing.Point(12, 67);
            this.TextBoxCnpjCpf.Name = "TextBoxCnpjCpf";
            this.TextBoxCnpjCpf.Size = new System.Drawing.Size(202, 23);
            this.TextBoxCnpjCpf.TabIndex = 30;
            // 
            // LabelNome
            // 
            this.LabelNome.AutoSize = true;
            this.LabelNome.Location = new System.Drawing.Point(12, 4);
            this.LabelNome.Name = "LabelNome";
            this.LabelNome.Size = new System.Drawing.Size(40, 15);
            this.LabelNome.TabIndex = 29;
            this.LabelNome.Text = "Nome";
            // 
            // TextBoxNome
            // 
            this.TextBoxNome.Location = new System.Drawing.Point(12, 23);
            this.TextBoxNome.Name = "TextBoxNome";
            this.TextBoxNome.Size = new System.Drawing.Size(334, 23);
            this.TextBoxNome.TabIndex = 28;
            // 
            // LabelHandle
            // 
            this.LabelHandle.AutoSize = true;
            this.LabelHandle.Location = new System.Drawing.Point(352, 5);
            this.LabelHandle.Name = "LabelHandle";
            this.LabelHandle.Size = new System.Drawing.Size(46, 15);
            this.LabelHandle.TabIndex = 27;
            this.LabelHandle.Text = "Código";
            // 
            // TextBoxHandle
            // 
            this.TextBoxHandle.Location = new System.Drawing.Point(352, 23);
            this.TextBoxHandle.Name = "TextBoxHandle";
            this.TextBoxHandle.ReadOnly = true;
            this.TextBoxHandle.Size = new System.Drawing.Size(100, 23);
            this.TextBoxHandle.TabIndex = 26;
            this.TextBoxHandle.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // FormVendaProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 223);
            this.Controls.Add(this.LabelObservacao);
            this.Controls.Add(this.TextBoxObservacao);
            this.Controls.Add(this.LabelEndereco);
            this.Controls.Add(this.TextBoxEndereco);
            this.Controls.Add(this.BotaoSalvar);
            this.Controls.Add(this.BotaoExcluir);
            this.Controls.Add(this.LabelCnpjCpf);
            this.Controls.Add(this.TextBoxCnpjCpf);
            this.Controls.Add(this.LabelNome);
            this.Controls.Add(this.TextBoxNome);
            this.Controls.Add(this.LabelHandle);
            this.Controls.Add(this.TextBoxHandle);
            this.Name = "FormVendaProduto";
            this.Text = "Produto da Venda";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label LabelObservacao;
        private RichTextBox TextBoxObservacao;
        private Label LabelEndereco;
        private TextBox TextBoxEndereco;
        private Button BotaoSalvar;
        private Button BotaoExcluir;
        private Label LabelCnpjCpf;
        private TextBox TextBoxCnpjCpf;
        private Label LabelNome;
        private TextBox TextBoxNome;
        private Label LabelHandle;
        private TextBox TextBoxHandle;
    }
}