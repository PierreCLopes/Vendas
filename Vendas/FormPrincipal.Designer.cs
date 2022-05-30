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
            this.BotaoAbrir = new System.Windows.Forms.Button();
            this.DataGridViewPessoa = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BotaoInserir = new System.Windows.Forms.Button();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Handle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Login = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LogDataAlteracao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewPessoa)).BeginInit();
            this.panel1.SuspendLayout();
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
            // 
            // produtosToolStripMenuItem
            // 
            this.produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            this.produtosToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.produtosToolStripMenuItem.Text = "Produtos";
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
            this.DataGridViewUsuario.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewUsuario_CellContentClick);
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
            this.DataGridViewPessoa.Location = new System.Drawing.Point(0, 12);
            this.DataGridViewPessoa.MultiSelect = false;
            this.DataGridViewPessoa.Name = "DataGridViewPessoa";
            this.DataGridViewPessoa.ReadOnly = true;
            this.DataGridViewPessoa.RowTemplate.Height = 25;
            this.DataGridViewPessoa.Size = new System.Drawing.Size(920, 433);
            this.DataGridViewPessoa.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.DataGridViewPessoa);
            this.panel1.Controls.Add(this.DataGridViewUsuario);
            this.panel1.Location = new System.Drawing.Point(12, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(920, 427);
            this.panel1.TabIndex = 1;
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
    }
}