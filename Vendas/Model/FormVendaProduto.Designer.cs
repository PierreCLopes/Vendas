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
            this.components = new System.ComponentModel.Container();
            this.LabelObservacao = new System.Windows.Forms.Label();
            this.TextBoxObservacao = new System.Windows.Forms.RichTextBox();
            this.BotaoSalvar = new System.Windows.Forms.Button();
            this.BotaoExcluir = new System.Windows.Forms.Button();
            this.LabelValorUnitario = new System.Windows.Forms.Label();
            this.LabelProduto = new System.Windows.Forms.Label();
            this.LabelHandle = new System.Windows.Forms.Label();
            this.TextBoxHandle = new System.Windows.Forms.TextBox();
            this.ComboBoxProduto = new System.Windows.Forms.ComboBox();
            this.TextBoxValorUnitario = new Syncfusion.Windows.Forms.Tools.CurrencyTextBox();
            this.TextBoxValorTotal = new Syncfusion.Windows.Forms.Tools.CurrencyTextBox();
            this.LabelValorTotal = new System.Windows.Forms.Label();
            this.LabelQuantidade = new System.Windows.Forms.Label();
            this.TextBoxQuantidade = new Syncfusion.Windows.Forms.Tools.DoubleTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxValorUnitario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxValorTotal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxQuantidade)).BeginInit();
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
            // LabelValorUnitario
            // 
            this.LabelValorUnitario.AutoSize = true;
            this.LabelValorUnitario.Location = new System.Drawing.Point(12, 49);
            this.LabelValorUnitario.Name = "LabelValorUnitario";
            this.LabelValorUnitario.Size = new System.Drawing.Size(77, 15);
            this.LabelValorUnitario.TabIndex = 31;
            this.LabelValorUnitario.Text = "Valor unitário";
            // 
            // LabelProduto
            // 
            this.LabelProduto.AutoSize = true;
            this.LabelProduto.Location = new System.Drawing.Point(12, 4);
            this.LabelProduto.Name = "LabelProduto";
            this.LabelProduto.Size = new System.Drawing.Size(50, 15);
            this.LabelProduto.TabIndex = 29;
            this.LabelProduto.Text = "Produto";
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
            // ComboBoxProduto
            // 
            this.ComboBoxProduto.FormattingEnabled = true;
            this.ComboBoxProduto.Location = new System.Drawing.Point(12, 23);
            this.ComboBoxProduto.Name = "ComboBoxProduto";
            this.ComboBoxProduto.Size = new System.Drawing.Size(334, 23);
            this.ComboBoxProduto.TabIndex = 41;
            // 
            // TextBoxValorUnitario
            // 
            this.TextBoxValorUnitario.BeforeTouchSize = new System.Drawing.Size(85, 23);
            this.TextBoxValorUnitario.DecimalValue = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            this.TextBoxValorUnitario.Location = new System.Drawing.Point(12, 67);
            this.TextBoxValorUnitario.Name = "TextBoxValorUnitario";
            this.TextBoxValorUnitario.Size = new System.Drawing.Size(143, 23);
            this.TextBoxValorUnitario.TabIndex = 42;
            this.TextBoxValorUnitario.Text = "R$ 0,00";
            this.TextBoxValorUnitario.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TextBoxValorTotal
            // 
            this.TextBoxValorTotal.BeforeTouchSize = new System.Drawing.Size(85, 23);
            this.TextBoxValorTotal.DecimalValue = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            this.TextBoxValorTotal.Location = new System.Drawing.Point(309, 67);
            this.TextBoxValorTotal.Name = "TextBoxValorTotal";
            this.TextBoxValorTotal.Size = new System.Drawing.Size(143, 23);
            this.TextBoxValorTotal.TabIndex = 44;
            this.TextBoxValorTotal.Text = "R$ 0,00";
            this.TextBoxValorTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // LabelValorTotal
            // 
            this.LabelValorTotal.AutoSize = true;
            this.LabelValorTotal.Location = new System.Drawing.Point(311, 49);
            this.LabelValorTotal.Name = "LabelValorTotal";
            this.LabelValorTotal.Size = new System.Drawing.Size(60, 15);
            this.LabelValorTotal.TabIndex = 43;
            this.LabelValorTotal.Text = "Valor total";
            // 
            // LabelQuantidade
            // 
            this.LabelQuantidade.AutoSize = true;
            this.LabelQuantidade.Location = new System.Drawing.Point(161, 49);
            this.LabelQuantidade.Name = "LabelQuantidade";
            this.LabelQuantidade.Size = new System.Drawing.Size(69, 15);
            this.LabelQuantidade.TabIndex = 45;
            this.LabelQuantidade.Text = "Quantidade";
            // 
            // TextBoxQuantidade
            // 
            this.TextBoxQuantidade.BeforeTouchSize = new System.Drawing.Size(85, 23);
            this.TextBoxQuantidade.DoubleValue = 0D;
            this.TextBoxQuantidade.Location = new System.Drawing.Point(161, 67);
            this.TextBoxQuantidade.Name = "TextBoxQuantidade";
            this.TextBoxQuantidade.Size = new System.Drawing.Size(143, 23);
            this.TextBoxQuantidade.TabIndex = 46;
            this.TextBoxQuantidade.Text = "0,00";
            this.TextBoxQuantidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // FormVendaProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 223);
            this.Controls.Add(this.TextBoxQuantidade);
            this.Controls.Add(this.LabelQuantidade);
            this.Controls.Add(this.TextBoxValorTotal);
            this.Controls.Add(this.LabelValorTotal);
            this.Controls.Add(this.TextBoxValorUnitario);
            this.Controls.Add(this.ComboBoxProduto);
            this.Controls.Add(this.LabelObservacao);
            this.Controls.Add(this.TextBoxObservacao);
            this.Controls.Add(this.BotaoSalvar);
            this.Controls.Add(this.BotaoExcluir);
            this.Controls.Add(this.LabelValorUnitario);
            this.Controls.Add(this.LabelProduto);
            this.Controls.Add(this.LabelHandle);
            this.Controls.Add(this.TextBoxHandle);
            this.Name = "FormVendaProduto";
            this.Text = "Produto da Venda";
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxValorUnitario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxValorTotal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxQuantidade)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label LabelObservacao;
        private RichTextBox TextBoxObservacao;
        private Button BotaoSalvar;
        private Button BotaoExcluir;
        private Label LabelValorUnitario;
        private Label LabelProduto;
        private Label LabelHandle;
        private TextBox TextBoxHandle;
        private ComboBox ComboBoxProduto;
        private Syncfusion.Windows.Forms.Tools.CurrencyTextBox TextBoxValorUnitario;
        private Syncfusion.Windows.Forms.Tools.CurrencyTextBox TextBoxValorTotal;
        private Label LabelValorTotal;
        private Label LabelQuantidade;
        private Syncfusion.Windows.Forms.Tools.DoubleTextBox TextBoxQuantidade;
    }
}