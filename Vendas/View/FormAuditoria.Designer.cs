namespace Vendas.View
{
    partial class FormAuditoria
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
            this.TextBoxDataAlteracao = new System.Windows.Forms.TextBox();
            this.LabelDataAlteracao = new System.Windows.Forms.Label();
            this.LabelDataCadastro = new System.Windows.Forms.Label();
            this.TextBoxDataCadastro = new System.Windows.Forms.TextBox();
            this.LabelUsuarioAlteracao = new System.Windows.Forms.Label();
            this.TextBoxUsuarioAlteracao = new System.Windows.Forms.TextBox();
            this.LabelUsuarioCadastro = new System.Windows.Forms.Label();
            this.TextBoxUsuarioCadastro = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TextBoxDataAlteracao
            // 
            this.TextBoxDataAlteracao.Location = new System.Drawing.Point(12, 27);
            this.TextBoxDataAlteracao.Name = "TextBoxDataAlteracao";
            this.TextBoxDataAlteracao.ReadOnly = true;
            this.TextBoxDataAlteracao.Size = new System.Drawing.Size(130, 23);
            this.TextBoxDataAlteracao.TabIndex = 0;
            // 
            // LabelDataAlteracao
            // 
            this.LabelDataAlteracao.AutoSize = true;
            this.LabelDataAlteracao.Location = new System.Drawing.Point(12, 9);
            this.LabelDataAlteracao.Name = "LabelDataAlteracao";
            this.LabelDataAlteracao.Size = new System.Drawing.Size(98, 15);
            this.LabelDataAlteracao.TabIndex = 1;
            this.LabelDataAlteracao.Text = "Data de alteração";
            // 
            // LabelDataCadastro
            // 
            this.LabelDataCadastro.AutoSize = true;
            this.LabelDataCadastro.Location = new System.Drawing.Point(12, 53);
            this.LabelDataCadastro.Name = "LabelDataCadastro";
            this.LabelDataCadastro.Size = new System.Drawing.Size(95, 15);
            this.LabelDataCadastro.TabIndex = 3;
            this.LabelDataCadastro.Text = "Data de cadastro";
            // 
            // TextBoxDataCadastro
            // 
            this.TextBoxDataCadastro.Location = new System.Drawing.Point(12, 71);
            this.TextBoxDataCadastro.Name = "TextBoxDataCadastro";
            this.TextBoxDataCadastro.ReadOnly = true;
            this.TextBoxDataCadastro.Size = new System.Drawing.Size(130, 23);
            this.TextBoxDataCadastro.TabIndex = 2;
            // 
            // LabelUsuarioAlteracao
            // 
            this.LabelUsuarioAlteracao.AutoSize = true;
            this.LabelUsuarioAlteracao.Location = new System.Drawing.Point(146, 9);
            this.LabelUsuarioAlteracao.Name = "LabelUsuarioAlteracao";
            this.LabelUsuarioAlteracao.Size = new System.Drawing.Size(114, 15);
            this.LabelUsuarioAlteracao.TabIndex = 5;
            this.LabelUsuarioAlteracao.Text = "Usuário da alteração";
            // 
            // TextBoxUsuarioAlteracao
            // 
            this.TextBoxUsuarioAlteracao.Location = new System.Drawing.Point(148, 27);
            this.TextBoxUsuarioAlteracao.Name = "TextBoxUsuarioAlteracao";
            this.TextBoxUsuarioAlteracao.ReadOnly = true;
            this.TextBoxUsuarioAlteracao.Size = new System.Drawing.Size(114, 23);
            this.TextBoxUsuarioAlteracao.TabIndex = 4;
            // 
            // LabelUsuarioCadastro
            // 
            this.LabelUsuarioCadastro.AutoSize = true;
            this.LabelUsuarioCadastro.Location = new System.Drawing.Point(148, 53);
            this.LabelUsuarioCadastro.Name = "LabelUsuarioCadastro";
            this.LabelUsuarioCadastro.Size = new System.Drawing.Size(112, 15);
            this.LabelUsuarioCadastro.TabIndex = 7;
            this.LabelUsuarioCadastro.Text = "Usuário do cadastro";
            // 
            // TextBoxUsuarioCadastro
            // 
            this.TextBoxUsuarioCadastro.Location = new System.Drawing.Point(148, 71);
            this.TextBoxUsuarioCadastro.Name = "TextBoxUsuarioCadastro";
            this.TextBoxUsuarioCadastro.ReadOnly = true;
            this.TextBoxUsuarioCadastro.Size = new System.Drawing.Size(114, 23);
            this.TextBoxUsuarioCadastro.TabIndex = 6;
            // 
            // FormAuditoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 106);
            this.Controls.Add(this.LabelUsuarioCadastro);
            this.Controls.Add(this.TextBoxUsuarioCadastro);
            this.Controls.Add(this.LabelUsuarioAlteracao);
            this.Controls.Add(this.TextBoxUsuarioAlteracao);
            this.Controls.Add(this.LabelDataCadastro);
            this.Controls.Add(this.TextBoxDataCadastro);
            this.Controls.Add(this.LabelDataAlteracao);
            this.Controls.Add(this.TextBoxDataAlteracao);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormAuditoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Auditoria";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox TextBoxDataAlteracao;
        private Label LabelDataAlteracao;
        private Label LabelDataCadastro;
        private TextBox TextBoxDataCadastro;
        private Label LabelUsuarioAlteracao;
        private TextBox TextBoxUsuarioAlteracao;
        private Label LabelUsuarioCadastro;
        private TextBox TextBoxUsuarioCadastro;
    }
}