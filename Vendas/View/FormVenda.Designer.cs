namespace Vendas.View
{
    partial class FormVenda
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
            this.LabelValor = new System.Windows.Forms.Label();
            this.BotaoSalvar = new System.Windows.Forms.Button();
            this.BotaoExcluir = new System.Windows.Forms.Button();
            this.BotaoCancelar = new System.Windows.Forms.Button();
            this.BotaoLiberar = new System.Windows.Forms.Button();
            this.BotaoVoltar = new System.Windows.Forms.Button();
            this.LabelCliente = new System.Windows.Forms.Label();
            this.LabelHandle = new System.Windows.Forms.Label();
            this.TextBoxHandle = new System.Windows.Forms.TextBox();
            this.TextBoxValor = new Syncfusion.Windows.Forms.Tools.CurrencyTextBox();
            this.ComboBoxCliente = new System.Windows.Forms.ComboBox();
            this.TextBoxVendedor = new System.Windows.Forms.TextBox();
            this.LabelVendedor = new System.Windows.Forms.Label();
            this.TextBoxNumeroPedido = new System.Windows.Forms.TextBox();
            this.LabelNumeroPedido = new System.Windows.Forms.Label();
            this.TabPage = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.BotaoEntregar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ButtonItemAdicionar = new System.Windows.Forms.Button();
            this.ButtonItemAbrir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxValor)).BeginInit();
            this.TabPage.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelObservacao
            // 
            this.LabelObservacao.AutoSize = true;
            this.LabelObservacao.Location = new System.Drawing.Point(3, 3);
            this.LabelObservacao.Name = "LabelObservacao";
            this.LabelObservacao.Size = new System.Drawing.Size(69, 15);
            this.LabelObservacao.TabIndex = 40;
            this.LabelObservacao.Text = "Observação";
            // 
            // TextBoxObservacao
            // 
            this.TextBoxObservacao.Location = new System.Drawing.Point(6, 21);
            this.TextBoxObservacao.Name = "TextBoxObservacao";
            this.TextBoxObservacao.Size = new System.Drawing.Size(459, 122);
            this.TextBoxObservacao.TabIndex = 39;
            this.TextBoxObservacao.Text = "";
            // 
            // LabelValor
            // 
            this.LabelValor.AutoSize = true;
            this.LabelValor.Location = new System.Drawing.Point(12, 49);
            this.LabelValor.Name = "LabelValor";
            this.LabelValor.Size = new System.Drawing.Size(60, 15);
            this.LabelValor.TabIndex = 38;
            this.LabelValor.Text = "Valor total";
            // 
            // BotaoSalvar
            // 
            this.BotaoSalvar.Location = new System.Drawing.Point(92, 279);
            this.BotaoSalvar.Name = "BotaoSalvar";
            this.BotaoSalvar.Size = new System.Drawing.Size(75, 23);
            this.BotaoSalvar.TabIndex = 36;
            this.BotaoSalvar.Text = "Salvar";
            this.BotaoSalvar.UseVisualStyleBackColor = true;
            this.BotaoSalvar.Click += new System.EventHandler(this.BotaoSalvar_Click);
            // 
            // BotaoExcluir
            // 
            this.BotaoExcluir.Location = new System.Drawing.Point(11, 279);
            this.BotaoExcluir.Name = "BotaoExcluir";
            this.BotaoExcluir.Size = new System.Drawing.Size(75, 23);
            this.BotaoExcluir.TabIndex = 35;
            this.BotaoExcluir.Text = "Excluir";
            this.BotaoExcluir.UseVisualStyleBackColor = true;
            this.BotaoExcluir.Click += new System.EventHandler(this.BotaoExcluir_Click);
            // 
            // BotaoCancelar
            // 
            this.BotaoCancelar.Location = new System.Drawing.Point(254, 279);
            this.BotaoCancelar.Name = "BotaoCancelar";
            this.BotaoCancelar.Size = new System.Drawing.Size(75, 23);
            this.BotaoCancelar.TabIndex = 34;
            this.BotaoCancelar.Text = "Cancelar";
            this.BotaoCancelar.UseVisualStyleBackColor = true;
            this.BotaoCancelar.Click += new System.EventHandler(this.BotaoCancelar_Click);
            // 
            // BotaoLiberar
            // 
            this.BotaoLiberar.Location = new System.Drawing.Point(335, 279);
            this.BotaoLiberar.Name = "BotaoLiberar";
            this.BotaoLiberar.Size = new System.Drawing.Size(75, 23);
            this.BotaoLiberar.TabIndex = 33;
            this.BotaoLiberar.Text = "Liberar";
            this.BotaoLiberar.UseVisualStyleBackColor = true;
            this.BotaoLiberar.Click += new System.EventHandler(this.BotaoLiberar_Click);
            // 
            // BotaoVoltar
            // 
            this.BotaoVoltar.Location = new System.Drawing.Point(416, 279);
            this.BotaoVoltar.Name = "BotaoVoltar";
            this.BotaoVoltar.Size = new System.Drawing.Size(75, 23);
            this.BotaoVoltar.TabIndex = 32;
            this.BotaoVoltar.Text = "Voltar";
            this.BotaoVoltar.UseVisualStyleBackColor = true;
            this.BotaoVoltar.Click += new System.EventHandler(this.BotaoVoltar_Click);
            // 
            // LabelCliente
            // 
            this.LabelCliente.AutoSize = true;
            this.LabelCliente.Location = new System.Drawing.Point(12, 4);
            this.LabelCliente.Name = "LabelCliente";
            this.LabelCliente.Size = new System.Drawing.Size(40, 15);
            this.LabelCliente.TabIndex = 29;
            this.LabelCliente.Text = "Nome";
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
            this.TextBoxHandle.Size = new System.Drawing.Size(135, 23);
            this.TextBoxHandle.TabIndex = 26;
            this.TextBoxHandle.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TextBoxValor
            // 
            this.TextBoxValor.BeforeTouchSize = new System.Drawing.Size(120, 23);
            this.TextBoxValor.DecimalValue = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            this.TextBoxValor.Location = new System.Drawing.Point(12, 67);
            this.TextBoxValor.Name = "TextBoxValor";
            this.TextBoxValor.ReadOnly = true;
            this.TextBoxValor.Size = new System.Drawing.Size(120, 23);
            this.TextBoxValor.TabIndex = 41;
            this.TextBoxValor.Text = "R$ 0,00";
            this.TextBoxValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ComboBoxCliente
            // 
            this.ComboBoxCliente.FormattingEnabled = true;
            this.ComboBoxCliente.Location = new System.Drawing.Point(12, 23);
            this.ComboBoxCliente.Name = "ComboBoxCliente";
            this.ComboBoxCliente.Size = new System.Drawing.Size(334, 23);
            this.ComboBoxCliente.TabIndex = 42;
            // 
            // TextBoxVendedor
            // 
            this.TextBoxVendedor.Location = new System.Drawing.Point(314, 67);
            this.TextBoxVendedor.Name = "TextBoxVendedor";
            this.TextBoxVendedor.ReadOnly = true;
            this.TextBoxVendedor.Size = new System.Drawing.Size(173, 23);
            this.TextBoxVendedor.TabIndex = 43;
            // 
            // LabelVendedor
            // 
            this.LabelVendedor.AutoSize = true;
            this.LabelVendedor.Location = new System.Drawing.Point(314, 49);
            this.LabelVendedor.Name = "LabelVendedor";
            this.LabelVendedor.Size = new System.Drawing.Size(57, 15);
            this.LabelVendedor.TabIndex = 44;
            this.LabelVendedor.Text = "Vendedor";
            // 
            // TextBoxNumeroPedido
            // 
            this.TextBoxNumeroPedido.Location = new System.Drawing.Point(138, 67);
            this.TextBoxNumeroPedido.Name = "TextBoxNumeroPedido";
            this.TextBoxNumeroPedido.Size = new System.Drawing.Size(170, 23);
            this.TextBoxNumeroPedido.TabIndex = 45;
            this.TextBoxNumeroPedido.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // LabelNumeroPedido
            // 
            this.LabelNumeroPedido.AutoSize = true;
            this.LabelNumeroPedido.Location = new System.Drawing.Point(138, 49);
            this.LabelNumeroPedido.Name = "LabelNumeroPedido";
            this.LabelNumeroPedido.Size = new System.Drawing.Size(107, 15);
            this.LabelNumeroPedido.TabIndex = 46;
            this.LabelNumeroPedido.Text = "Número de pedido";
            // 
            // TabPage
            // 
            this.TabPage.Controls.Add(this.tabPage1);
            this.TabPage.Controls.Add(this.tabPage2);
            this.TabPage.Location = new System.Drawing.Point(12, 96);
            this.TabPage.Name = "TabPage";
            this.TabPage.SelectedIndex = 0;
            this.TabPage.Size = new System.Drawing.Size(479, 177);
            this.TabPage.TabIndex = 47;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.LabelObservacao);
            this.tabPage1.Controls.Add(this.TextBoxObservacao);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(471, 149);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Complemento";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.ButtonItemAbrir);
            this.tabPage2.Controls.Add(this.ButtonItemAdicionar);
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(471, 149);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Item";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // BotaoEntregar
            // 
            this.BotaoEntregar.Location = new System.Drawing.Point(173, 279);
            this.BotaoEntregar.Name = "BotaoEntregar";
            this.BotaoEntregar.Size = new System.Drawing.Size(75, 23);
            this.BotaoEntregar.TabIndex = 48;
            this.BotaoEntregar.Text = "Entregar";
            this.BotaoEntregar.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 29);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(459, 114);
            this.dataGridView1.TabIndex = 0;
            // 
            // ButtonItemAdicionar
            // 
            this.ButtonItemAdicionar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonItemAdicionar.Location = new System.Drawing.Point(390, 3);
            this.ButtonItemAdicionar.Name = "ButtonItemAdicionar";
            this.ButtonItemAdicionar.Size = new System.Drawing.Size(75, 23);
            this.ButtonItemAdicionar.TabIndex = 1;
            this.ButtonItemAdicionar.Text = "Adicionar";
            this.ButtonItemAdicionar.UseVisualStyleBackColor = true;
            this.ButtonItemAdicionar.Click += new System.EventHandler(this.ButtonItemAdicionar_Click);
            // 
            // ButtonItemAbrir
            // 
            this.ButtonItemAbrir.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonItemAbrir.Location = new System.Drawing.Point(309, 3);
            this.ButtonItemAbrir.Name = "ButtonItemAbrir";
            this.ButtonItemAbrir.Size = new System.Drawing.Size(75, 23);
            this.ButtonItemAbrir.TabIndex = 2;
            this.ButtonItemAbrir.Text = "Abrir";
            this.ButtonItemAbrir.UseVisualStyleBackColor = true;
            // 
            // FormVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 314);
            this.Controls.Add(this.BotaoEntregar);
            this.Controls.Add(this.TabPage);
            this.Controls.Add(this.LabelNumeroPedido);
            this.Controls.Add(this.TextBoxNumeroPedido);
            this.Controls.Add(this.LabelVendedor);
            this.Controls.Add(this.TextBoxVendedor);
            this.Controls.Add(this.ComboBoxCliente);
            this.Controls.Add(this.TextBoxValor);
            this.Controls.Add(this.LabelValor);
            this.Controls.Add(this.BotaoSalvar);
            this.Controls.Add(this.BotaoExcluir);
            this.Controls.Add(this.BotaoCancelar);
            this.Controls.Add(this.BotaoLiberar);
            this.Controls.Add(this.BotaoVoltar);
            this.Controls.Add(this.LabelCliente);
            this.Controls.Add(this.LabelHandle);
            this.Controls.Add(this.TextBoxHandle);
            this.KeyPreview = true;
            this.Name = "FormVenda";
            this.Text = "Venda";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormVenda_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxValor)).EndInit();
            this.TabPage.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label LabelObservacao;
        private RichTextBox TextBoxObservacao;
        private Label LabelValor;
        private Button BotaoSalvar;
        private Button BotaoExcluir;
        private Button BotaoCancelar;
        private Button BotaoLiberar;
        private Button BotaoVoltar;
        private Label LabelCliente;
        private Label LabelHandle;
        private TextBox TextBoxHandle;
        private Syncfusion.Windows.Forms.Tools.CurrencyTextBox TextBoxValor;
        private ComboBox ComboBoxCliente;
        private TextBox TextBoxVendedor;
        private Label LabelVendedor;
        private TextBox TextBoxNumeroPedido;
        private Label LabelNumeroPedido;
        private TabControl TabPage;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Button BotaoEntregar;
        private DataGridView dataGridView1;
        private Button ButtonItemAbrir;
        private Button ButtonItemAdicionar;
    }
}