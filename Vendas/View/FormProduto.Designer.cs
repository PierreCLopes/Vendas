namespace Vendas.View
{
    partial class FormProduto
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
            this.components = new System.ComponentModel.Container();
            this.LabelDescricao = new System.Windows.Forms.Label();
            this.TextBoxDescricao = new System.Windows.Forms.RichTextBox();
            this.LabelEstoque = new System.Windows.Forms.Label();
            this.BotaoExcluir = new System.Windows.Forms.Button();
            this.LabelCnpjCpf = new System.Windows.Forms.Label();
            this.LabelNome = new System.Windows.Forms.Label();
            this.TextBoxNome = new System.Windows.Forms.TextBox();
            this.LabelHandle = new System.Windows.Forms.Label();
            this.TextBoxHandle = new System.Windows.Forms.TextBox();
            this.BotaoSalvar = new System.Windows.Forms.Button();
            this.LabelCodigoAuxiliar = new System.Windows.Forms.Label();
            this.TextBoxCodigoAuxiliar = new System.Windows.Forms.TextBox();
            this.TextBoxValor = new Syncfusion.Windows.Forms.Tools.CurrencyTextBox();
            this.TextBoxEstoque = new Syncfusion.Windows.Forms.Tools.DoubleTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxValor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxEstoque)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelDescricao
            // 
            this.LabelDescricao.AutoSize = true;
            this.LabelDescricao.Location = new System.Drawing.Point(4, 92);
            this.LabelDescricao.Name = "LabelDescricao";
            this.LabelDescricao.Size = new System.Drawing.Size(58, 15);
            this.LabelDescricao.TabIndex = 40;
            this.LabelDescricao.Text = "Descricao";
            // 
            // TextBoxDescricao
            // 
            this.TextBoxDescricao.Location = new System.Drawing.Point(4, 111);
            this.TextBoxDescricao.Name = "TextBoxDescricao";
            this.TextBoxDescricao.Size = new System.Drawing.Size(440, 73);
            this.TextBoxDescricao.TabIndex = 39;
            this.TextBoxDescricao.Text = "";
            // 
            // LabelEstoque
            // 
            this.LabelEstoque.AutoSize = true;
            this.LabelEstoque.Location = new System.Drawing.Point(95, 48);
            this.LabelEstoque.Name = "LabelEstoque";
            this.LabelEstoque.Size = new System.Drawing.Size(49, 15);
            this.LabelEstoque.TabIndex = 38;
            this.LabelEstoque.Text = "Estoque";
            // 
            // BotaoExcluir
            // 
            this.BotaoExcluir.Location = new System.Drawing.Point(288, 190);
            this.BotaoExcluir.Name = "BotaoExcluir";
            this.BotaoExcluir.Size = new System.Drawing.Size(75, 23);
            this.BotaoExcluir.TabIndex = 35;
            this.BotaoExcluir.Text = "Excluir";
            this.BotaoExcluir.UseVisualStyleBackColor = true;
            this.BotaoExcluir.Click += new System.EventHandler(this.BotaoExcluir_Click);
            // 
            // LabelCnpjCpf
            // 
            this.LabelCnpjCpf.AutoSize = true;
            this.LabelCnpjCpf.Location = new System.Drawing.Point(4, 48);
            this.LabelCnpjCpf.Name = "LabelCnpjCpf";
            this.LabelCnpjCpf.Size = new System.Drawing.Size(33, 15);
            this.LabelCnpjCpf.TabIndex = 31;
            this.LabelCnpjCpf.Text = "Valor";
            // 
            // LabelNome
            // 
            this.LabelNome.AutoSize = true;
            this.LabelNome.Location = new System.Drawing.Point(4, 3);
            this.LabelNome.Name = "LabelNome";
            this.LabelNome.Size = new System.Drawing.Size(40, 15);
            this.LabelNome.TabIndex = 29;
            this.LabelNome.Text = "Nome";
            // 
            // TextBoxNome
            // 
            this.TextBoxNome.Location = new System.Drawing.Point(4, 22);
            this.TextBoxNome.Name = "TextBoxNome";
            this.TextBoxNome.Size = new System.Drawing.Size(440, 23);
            this.TextBoxNome.TabIndex = 28;
            // 
            // LabelHandle
            // 
            this.LabelHandle.AutoSize = true;
            this.LabelHandle.Location = new System.Drawing.Point(344, 48);
            this.LabelHandle.Name = "LabelHandle";
            this.LabelHandle.Size = new System.Drawing.Size(46, 15);
            this.LabelHandle.TabIndex = 27;
            this.LabelHandle.Text = "Código";
            // 
            // TextBoxHandle
            // 
            this.TextBoxHandle.Location = new System.Drawing.Point(344, 66);
            this.TextBoxHandle.Name = "TextBoxHandle";
            this.TextBoxHandle.ReadOnly = true;
            this.TextBoxHandle.Size = new System.Drawing.Size(100, 23);
            this.TextBoxHandle.TabIndex = 26;
            this.TextBoxHandle.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // BotaoSalvar
            // 
            this.BotaoSalvar.Location = new System.Drawing.Point(369, 190);
            this.BotaoSalvar.Name = "BotaoSalvar";
            this.BotaoSalvar.Size = new System.Drawing.Size(75, 23);
            this.BotaoSalvar.TabIndex = 36;
            this.BotaoSalvar.Text = "Salvar";
            this.BotaoSalvar.UseVisualStyleBackColor = true;
            this.BotaoSalvar.Click += new System.EventHandler(this.BotaoSalvar_Click);
            // 
            // LabelCodigoAuxiliar
            // 
            this.LabelCodigoAuxiliar.AutoSize = true;
            this.LabelCodigoAuxiliar.Location = new System.Drawing.Point(186, 48);
            this.LabelCodigoAuxiliar.Name = "LabelCodigoAuxiliar";
            this.LabelCodigoAuxiliar.Size = new System.Drawing.Size(87, 15);
            this.LabelCodigoAuxiliar.TabIndex = 42;
            this.LabelCodigoAuxiliar.Text = "Código auxiliar";
            // 
            // TextBoxCodigoAuxiliar
            // 
            this.TextBoxCodigoAuxiliar.Location = new System.Drawing.Point(186, 66);
            this.TextBoxCodigoAuxiliar.Name = "TextBoxCodigoAuxiliar";
            this.TextBoxCodigoAuxiliar.Size = new System.Drawing.Size(152, 23);
            this.TextBoxCodigoAuxiliar.TabIndex = 41;
            this.TextBoxCodigoAuxiliar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TextBoxValor
            // 
            this.TextBoxValor.BeforeTouchSize = new System.Drawing.Size(85, 23);
            this.TextBoxValor.DecimalValue = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            this.TextBoxValor.Location = new System.Drawing.Point(4, 66);
            this.TextBoxValor.Name = "TextBoxValor";
            this.TextBoxValor.Size = new System.Drawing.Size(85, 23);
            this.TextBoxValor.TabIndex = 43;
            this.TextBoxValor.Text = "R$ 0,00";
            this.TextBoxValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TextBoxEstoque
            // 
            this.TextBoxEstoque.BeforeTouchSize = new System.Drawing.Size(85, 23);
            this.TextBoxEstoque.DoubleValue = 0D;
            this.TextBoxEstoque.Location = new System.Drawing.Point(95, 66);
            this.TextBoxEstoque.Name = "TextBoxEstoque";
            this.TextBoxEstoque.Size = new System.Drawing.Size(85, 23);
            this.TextBoxEstoque.TabIndex = 44;
            this.TextBoxEstoque.Text = "0,00";
            this.TextBoxEstoque.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // FormProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 224);
            this.Controls.Add(this.TextBoxEstoque);
            this.Controls.Add(this.TextBoxValor);
            this.Controls.Add(this.LabelCodigoAuxiliar);
            this.Controls.Add(this.TextBoxCodigoAuxiliar);
            this.Controls.Add(this.LabelDescricao);
            this.Controls.Add(this.TextBoxDescricao);
            this.Controls.Add(this.LabelEstoque);
            this.Controls.Add(this.BotaoSalvar);
            this.Controls.Add(this.BotaoExcluir);
            this.Controls.Add(this.LabelCnpjCpf);
            this.Controls.Add(this.LabelNome);
            this.Controls.Add(this.TextBoxNome);
            this.Controls.Add(this.LabelHandle);
            this.Controls.Add(this.TextBoxHandle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Name = "FormProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormProduto";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormProduto_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxValor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxEstoque)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label LabelDescricao;
        private RichTextBox TextBoxDescricao;
        private Label LabelEstoque;
        private Button BotaoExcluir;
        private Label LabelCnpjCpf;
        private Label LabelNome;
        private TextBox TextBoxNome;
        private Label LabelHandle;
        private TextBox TextBoxHandle;
        private Button BotaoSalvar;
        private Label LabelCodigoAuxiliar;
        private TextBox TextBoxCodigoAuxiliar;
        private Syncfusion.Windows.Forms.Tools.CurrencyTextBox TextBoxValor;
        private Syncfusion.Windows.Forms.Tools.DoubleTextBox TextBoxEstoque;
    }
}