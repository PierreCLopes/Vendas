namespace Vendas
{
    partial class FormPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pessoasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DataGridViewUsuario = new System.Windows.Forms.DataGridView();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Handle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Login = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LogDataAlteracao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BotaoAbrir = new System.Windows.Forms.Button();
            this.DataGridViewPessoa = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CnpjCpf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DataGridViewProduto = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estoque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BotaoInserir = new System.Windows.Forms.Button();
            this.DataGridViewVenda = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumeroPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewPessoa)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewProduto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewVenda)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(944, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pessoasToolStripMenuItem,
            this.produtosToolStripMenuItem,
            this.usuáriosToolStripMenuItem,
            this.vendasToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // pessoasToolStripMenuItem
            // 
            this.pessoasToolStripMenuItem.Name = "pessoasToolStripMenuItem";
            this.pessoasToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.pessoasToolStripMenuItem.Text = "Pessoas";
            this.pessoasToolStripMenuItem.Click += new System.EventHandler(this.pessoasToolStripMenuItem_Click);
            // 
            // produtosToolStripMenuItem
            // 
            this.produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            this.produtosToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.produtosToolStripMenuItem.Text = "Produtos";
            this.produtosToolStripMenuItem.Click += new System.EventHandler(this.produtosToolStripMenuItem_Click);
            // 
            // usuáriosToolStripMenuItem
            // 
            this.usuáriosToolStripMenuItem.Name = "usuáriosToolStripMenuItem";
            this.usuáriosToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.usuáriosToolStripMenuItem.Text = "Usuários";
            this.usuáriosToolStripMenuItem.Click += new System.EventHandler(this.usuáriosToolStripMenuItem_Click);
            // 
            // vendasToolStripMenuItem
            // 
            this.vendasToolStripMenuItem.Name = "vendasToolStripMenuItem";
            this.vendasToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.vendasToolStripMenuItem.Text = "Vendas";
            // 
            // DataGridViewUsuario
            // 
            this.DataGridViewUsuario.BackgroundColor = System.Drawing.SystemColors.Window;
            this.DataGridViewUsuario.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DataGridViewUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewUsuario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Status,
            this.Handle,
            this.Login,
            this.LogDataAlteracao});
            this.DataGridViewUsuario.Location = new System.Drawing.Point(0, 0);
            this.DataGridViewUsuario.Name = "DataGridViewUsuario";
            this.DataGridViewUsuario.ReadOnly = true;
            this.DataGridViewUsuario.RowTemplate.Height = 25;
            this.DataGridViewUsuario.Size = new System.Drawing.Size(920, 427);
            this.DataGridViewUsuario.TabIndex = 0;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "StatusTraducao";
            this.Status.HeaderText = "Situação";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // Handle
            // 
            this.Handle.DataPropertyName = "Handle";
            this.Handle.HeaderText = "Código";
            this.Handle.Name = "Handle";
            this.Handle.ReadOnly = true;
            // 
            // Login
            // 
            this.Login.DataPropertyName = "Login";
            this.Login.HeaderText = "Login";
            this.Login.Name = "Login";
            this.Login.ReadOnly = true;
            this.Login.Width = 150;
            // 
            // LogDataAlteracao
            // 
            this.LogDataAlteracao.DataPropertyName = "LogDataAlteracao";
            this.LogDataAlteracao.HeaderText = "Data de alteração";
            this.LogDataAlteracao.Name = "LogDataAlteracao";
            this.LogDataAlteracao.ReadOnly = true;
            // 
            // BotaoAbrir
            // 
            this.BotaoAbrir.Location = new System.Drawing.Point(857, 466);
            this.BotaoAbrir.Name = "BotaoAbrir";
            this.BotaoAbrir.Size = new System.Drawing.Size(75, 23);
            this.BotaoAbrir.TabIndex = 2;
            this.BotaoAbrir.Text = "Abrir";
            this.BotaoAbrir.UseVisualStyleBackColor = true;
            this.BotaoAbrir.Click += new System.EventHandler(this.BotaoAbrir_Click);
            // 
            // DataGridViewPessoa
            // 
            this.DataGridViewPessoa.BackgroundColor = System.Drawing.SystemColors.Window;
            this.DataGridViewPessoa.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DataGridViewPessoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewPessoa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.Nome,
            this.CnpjCpf,
            this.dataGridViewTextBoxColumn3});
            this.DataGridViewPessoa.Location = new System.Drawing.Point(0, 0);
            this.DataGridViewPessoa.MultiSelect = false;
            this.DataGridViewPessoa.Name = "DataGridViewPessoa";
            this.DataGridViewPessoa.ReadOnly = true;
            this.DataGridViewPessoa.RowTemplate.Height = 25;
            this.DataGridViewPessoa.Size = new System.Drawing.Size(920, 427);
            this.DataGridViewPessoa.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "StatusTraducao";
            this.dataGridViewTextBoxColumn1.HeaderText = "Situação";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Handle";
            this.dataGridViewTextBoxColumn2.HeaderText = "Código";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // Nome
            // 
            this.Nome.DataPropertyName = "Nome";
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            // 
            // CnpjCpf
            // 
            this.CnpjCpf.DataPropertyName = "CnpjCpf";
            this.CnpjCpf.HeaderText = "CNPJ/CPF";
            this.CnpjCpf.Name = "CnpjCpf";
            this.CnpjCpf.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "LogDataAlteracao";
            this.dataGridViewTextBoxColumn3.HeaderText = "Data de alteração";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 130;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.DataGridViewVenda);
            this.panel1.Controls.Add(this.DataGridViewPessoa);
            this.panel1.Controls.Add(this.DataGridViewUsuario);
            this.panel1.Controls.Add(this.DataGridViewProduto);
            this.panel1.Location = new System.Drawing.Point(12, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(920, 427);
            this.panel1.TabIndex = 1;
            // 
            // DataGridViewProduto
            // 
            this.DataGridViewProduto.BackgroundColor = System.Drawing.SystemColors.Window;
            this.DataGridViewProduto.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DataGridViewProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewProduto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.Valor,
            this.Estoque,
            this.dataGridViewTextBoxColumn8});
            this.DataGridViewProduto.Location = new System.Drawing.Point(0, 0);
            this.DataGridViewProduto.MultiSelect = false;
            this.DataGridViewProduto.Name = "DataGridViewProduto";
            this.DataGridViewProduto.ReadOnly = true;
            this.DataGridViewProduto.RowTemplate.Height = 25;
            this.DataGridViewProduto.Size = new System.Drawing.Size(920, 427);
            this.DataGridViewProduto.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Handle";
            this.dataGridViewTextBoxColumn5.HeaderText = "Código";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Nome";
            this.dataGridViewTextBoxColumn6.HeaderText = "Nome";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // Valor
            // 
            this.Valor.DataPropertyName = "Valor";
            this.Valor.HeaderText = "Valor";
            this.Valor.Name = "Valor";
            this.Valor.ReadOnly = true;
            // 
            // Estoque
            // 
            this.Estoque.DataPropertyName = "Estoque";
            this.Estoque.HeaderText = "Estoque";
            this.Estoque.Name = "Estoque";
            this.Estoque.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "LogDataAlteracao";
            this.dataGridViewTextBoxColumn8.HeaderText = "Data de alteração";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 130;
            // 
            // BotaoInserir
            // 
            this.BotaoInserir.Location = new System.Drawing.Point(776, 466);
            this.BotaoInserir.Name = "BotaoInserir";
            this.BotaoInserir.Size = new System.Drawing.Size(75, 23);
            this.BotaoInserir.TabIndex = 3;
            this.BotaoInserir.Text = "Inserir";
            this.BotaoInserir.UseVisualStyleBackColor = true;
            this.BotaoInserir.Click += new System.EventHandler(this.BotaoInserir_Click);
            // 
            // DataGridViewVenda
            // 
            this.DataGridViewVenda.BackgroundColor = System.Drawing.SystemColors.Window;
            this.DataGridViewVenda.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DataGridViewVenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewVenda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn7,
            this.NumeroPedido,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.Data,
            this.dataGridViewTextBoxColumn11});
            this.DataGridViewVenda.Location = new System.Drawing.Point(0, 0);
            this.DataGridViewVenda.MultiSelect = false;
            this.DataGridViewVenda.Name = "DataGridViewVenda";
            this.DataGridViewVenda.ReadOnly = true;
            this.DataGridViewVenda.RowTemplate.Height = 25;
            this.DataGridViewVenda.Size = new System.Drawing.Size(920, 427);
            this.DataGridViewVenda.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "StatusTraducao";
            this.dataGridViewTextBoxColumn4.HeaderText = "Situação";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Handle";
            this.dataGridViewTextBoxColumn7.HeaderText = "Código";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // NumeroPedido
            // 
            this.NumeroPedido.HeaderText = "Número de pedido";
            this.NumeroPedido.Name = "NumeroPedido";
            this.NumeroPedido.ReadOnly = true;
            this.NumeroPedido.Width = 150;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "NomeCliente";
            this.dataGridViewTextBoxColumn9.HeaderText = "Cliente";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Width = 150;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.HeaderText = "Valor";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // Data
            // 
            this.Data.HeaderText = "Data";
            this.Data.Name = "Data";
            this.Data.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "LogDataAlteracao";
            this.dataGridViewTextBoxColumn11.HeaderText = "Data de alteração";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            this.dataGridViewTextBoxColumn11.Width = 130;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 501);
            this.Controls.Add(this.BotaoInserir);
            this.Controls.Add(this.BotaoAbrir);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vendas";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewPessoa)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewProduto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewVenda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuToolStripMenuItem;
        private ToolStripMenuItem pessoasToolStripMenuItem;
        private ToolStripMenuItem produtosToolStripMenuItem;
        private ToolStripMenuItem usuáriosToolStripMenuItem;
        private ToolStripMenuItem vendasToolStripMenuItem;
        private DataGridView DataGridViewUsuario;
        private Button BotaoAbrir;
        private DataGridView DataGridViewPessoa;
        private Panel panel1;
        private Button BotaoInserir;
        private DataGridViewTextBoxColumn Status;
        private DataGridViewTextBoxColumn Handle;
        private DataGridViewTextBoxColumn Login;
        private DataGridViewTextBoxColumn LogDataAlteracao;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewTextBoxColumn CnpjCpf;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridView DataGridViewProduto;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn Valor;
        private DataGridViewTextBoxColumn Estoque;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private DataGridView DataGridViewVenda;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn NumeroPedido;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private DataGridViewTextBoxColumn Data;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
    }
}