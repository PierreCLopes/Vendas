using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vendas.View
{
    public partial class FormAuditoria : Form
    {
        public FormAuditoria(DateTime prLogDataCadastro, DateTime prLogDataAlteracao, string prLogUsuarioCadastro, string prLogUsuarioAlteracao)
        {
            InitializeComponent();

            TextBoxDataCadastro.Text = Convert.ToString(prLogDataCadastro);
            TextBoxDataAlteracao.Text = Convert.ToString(prLogDataAlteracao);
            TextBoxUsuarioCadastro.Text = prLogUsuarioCadastro;
            TextBoxUsuarioAlteracao.Text = prLogUsuarioAlteracao;
        }
    }
}
