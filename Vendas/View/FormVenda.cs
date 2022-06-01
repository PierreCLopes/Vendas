using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vendas.Control;
using Vendas.Model;

namespace Vendas.View
{
    public partial class FormVenda : Form
    {
        Venda venda;
        Usuario usuarioLogado;
        NpgsqlConnection conexao;
        bool inserindo;

        public FormVenda(NpgsqlConnection prConexao, Venda prVenda, Usuario prUsuarioLogado)
        {
            venda = prVenda;
            usuarioLogado = prUsuarioLogado;
            conexao = prConexao;
            inserindo = (venda.Handle == 0);
            InitializeComponent();

            PreencherCampos();
            AtualizarPermissoes();
        }

        private void FormVenda_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                Auditoria();
            }
        }

        private void Auditoria()
        {
            FormAuditoria Form = new FormAuditoria(venda.LogDataCadastro,
                                                   venda.LogDataAlteracao,
                                                   UsuarioDB.GetUsuarioByHandle(conexao, venda.LogUsuarioCadastro).Login,
                                                   UsuarioDB.GetUsuarioByHandle(conexao, venda.LogUsuarioAlteracao).Login);
            Form.ShowDialog();
        }

        private void AtualizarPermissoes()
        {
            BotaoExcluir.Enabled = venda.Status == Status.Cadastrado;
            BotaoCancelar.Enabled = venda.Status == Status.AgModificacao;
            BotaoEntregar.Enabled = venda.Status == Status.AgEntrega;
            BotaoLiberar.Enabled = (venda.Status == Status.Cadastrado) ^ (venda.Status == Status.AgModificacao);
            BotaoVoltar.Enabled = (venda.Status == Status.Ativo) ^ (venda.Status == Status.Cancelado);
            BotaoSalvar.Enabled = !(venda.Status == Status.Ativo) && !(venda.Status == Status.Cancelado);
            BotaoItemAdicionar.Enabled = BotaoSalvar.Enabled  &&  !inserindo;

            ComboBoxCliente.Enabled = BotaoSalvar.Enabled;
            TextBoxNumeroPedido.ReadOnly = !BotaoSalvar.Enabled;
            TextBoxObservacao.ReadOnly = !BotaoSalvar.Enabled;
        }

        private void PreencherCampos()
        {
            List<VendaProduto> lista = VendaProdutoDB.GetVendaProdutos(conexao, venda.Handle);
            DataGridViewVendaProduto.DataSource = lista;

            TextBoxHandle.Text = venda.Handle.ToString();
            TextBoxValor.DecimalValue = venda.ValorLiquido;
            TextBoxObservacao.Text = venda.Observacao;
            TextBoxNumeroPedido.Text = venda.NumeroPedido;
            TextBoxVendedor.Text = UsuarioDB.GetUsuarioByHandle(conexao, venda.Vendedor).Login;

            List<Pessoa> listaPessoa = PessoaDB.GetPessoas(conexao, Status.Ativo);
            ComboBoxCliente.DataSource = listaPessoa;

            if (!inserindo)
            {
                this.Text = venda.StatusTraducao + " desde " + venda.StatusData.ToString();

                int indice = 0;
                for (int i = 0; i < listaPessoa.Count(); i++)
                {
                    Pessoa pessoa = listaPessoa[i];
                    if (pessoa.Handle == venda.Cliente)
                    {
                        indice = i;
                        break;
                    }
                }
                ComboBoxCliente.SelectedIndex = indice;
            }
        }

        private void BotaoSalvar_Click(object sender, EventArgs e)
        {
            
            if (!inserindo)
            {
                venda.ValorLiquido = TextBoxValor.DecimalValue;
                venda.NumeroPedido = TextBoxNumeroPedido.Text;
                venda.Observacao = TextBoxObservacao.Text;
                venda.LogDataAlteracao = DateTime.Now;
                venda.LogUsuarioAlteracao = usuarioLogado.Handle;

                Pessoa pessoa = (Pessoa)ComboBoxCliente.SelectedItem;
                venda.Cliente = pessoa.Handle;

                VendaDB.SetAlteraVenda(venda, conexao);

                PreencherCampos();
            }
            else
            {
                venda.Handle = VendaDB.GetHandleInsert(conexao);
                venda.ValorLiquido = TextBoxValor.DecimalValue;
                venda.NumeroPedido = TextBoxNumeroPedido.Text;
                venda.Observacao = TextBoxObservacao.Text;

                Pessoa pessoa = (Pessoa)ComboBoxCliente.SelectedItem;
                venda.Cliente = pessoa.Handle;

                venda.Vendedor = usuarioLogado.Handle;
                venda.Status = Status.Cadastrado;
                venda.StatusTraducao = "Cadastrado";
                venda.StatusData = DateTime.Now;
                venda.LogDataAlteracao = DateTime.Now;
                venda.LogUsuarioAlteracao = usuarioLogado.Handle;
                venda.LogDataCadastro = DateTime.Now;
                venda.LogUsuarioCadastro = usuarioLogado.Handle;

                inserindo = !VendaDB.SetInsereVenda(venda, conexao);

                PreencherCampos();
            }

            AtualizarPermissoes();
        }

        private void BotaoExcluir_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                        null
                        , $"Deseja excluir a venda " + venda.Handle + "?"
                        , "Pessoa"
                        , MessageBoxButtons.OKCancel
                        , MessageBoxIcon.Question
                        );
            if (result == DialogResult.OK)
            {
                bool retorno = VendaDB.SetExcluirVenda(venda.Handle, conexao);
                if (retorno)
                {
                    MessageBox.Show("Sucesso, venda excluída!");
                    Close();
                }
                else
                {
                    MessageBox.Show("Erro, venda não excluída!");
                }
            }
        }

        private void BotaoLiberar_Click(object sender, EventArgs e)
        {
            if (VerificarCampos())
            {
                DialogResult result = MessageBox.Show(
                                null
                                , $"Deseja liberar a venda " + venda.Handle + "?"
                                , "Pessoa"
                                , MessageBoxButtons.OKCancel
                                , MessageBoxIcon.Question
                                );
                if (result == DialogResult.OK)
                {
                    venda.Liberar();
                    VendaDB.SetAlteraVenda(venda, conexao);
                    PreencherCampos();
                    AtualizarPermissoes();
                }
            }
            else
            {
                MessageBox.Show("Campo obrigatório não preenchido!");
            }
        }

        private void BotaoEntregar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                        null
                        , $"Deseja entregar a venda " + venda.Handle + "?"
                        , "Pessoa"
                        , MessageBoxButtons.OKCancel
                        , MessageBoxIcon.Question
                        );
            if (result == DialogResult.OK)
            {
                venda.Entregar();
                VendaDB.SetAlteraVenda(venda, conexao);
                PreencherCampos();
                AtualizarPermissoes();
            }
        }

        private void BotaoVoltar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                        null
                        , $"Deseja Voltar a venda " + venda.Handle + "?"
                        , "Pessoa"
                        , MessageBoxButtons.OKCancel
                        , MessageBoxIcon.Question
                        );
            if (result == DialogResult.OK)
            {
                venda.Voltar();
                VendaDB.SetAlteraVenda(venda, conexao);
                PreencherCampos();
                AtualizarPermissoes();
            }
        }

        private void BotaoCancelar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                        null
                        , $"Deseja realmente cancelar a vendaa " + venda.Handle + "?"
                        , "Pessoa"
                        , MessageBoxButtons.OKCancel
                        , MessageBoxIcon.Question
                        );
            if (result == DialogResult.OK)
            {
                venda.Cancelar();
                VendaDB.SetAlteraVenda(venda, conexao);
                PreencherCampos();
                AtualizarPermissoes();
            }
        }

        private bool VerificarCampos()
        {
            bool Retorno = true;

            if (TextBoxValor.DecimalValue == 0)
            {
                TextBoxValor.Focus();
                Retorno = false;
            }

            return Retorno;
        }

        private void ButtonItemAdicionar_Click(object sender, EventArgs e)
        {
            VendaProduto vVendaProduto = new VendaProduto(venda.Handle);
            FormVendaProduto Form = new FormVendaProduto(conexao, vVendaProduto, usuarioLogado);
            Form.ShowDialog();


            
        }

        private void ButtonItemAbrir_Click(object sender, EventArgs e)
        {
            VendaProduto vVendaProduto = (VendaProduto)DataGridViewVendaProduto.CurrentRow.DataBoundItem;
            FormVendaProduto Form = new FormVendaProduto(conexao, vVendaProduto, usuarioLogado);
            Form.ShowDialog();
            Recalcular();
        }

        private void Recalcular()
        {
            venda.Recalcular();
            VendaDB.SetAlteraVenda(venda, conexao);
            PreencherCampos();
            AtualizarPermissoes();
        }
    }
}
