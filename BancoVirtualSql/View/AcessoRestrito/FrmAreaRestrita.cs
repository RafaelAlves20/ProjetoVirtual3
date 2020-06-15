using BancoVirtualSql.Conexao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BancoVirtualSql.Repositorio;
using BancoVirtualSql.Controller;
using Microsoft.EntityFrameworkCore;



namespace BancoVirtualSql.View.AcessoRestrito
{
    public partial class FrmAreaRestrita : Form 
    {
        public FrmAreaRestrita()
        {
            InitializeComponent();
        }

        CaixaDeMensagem Caixamsg = new CaixaDeMensagem();
        BancoVirtualContext db = new BancoVirtualContext();
        Cliente cliente = new Cliente();
        ContaCorrente contaCorrente = new ContaCorrente();

        private void FrmAcessoRestrito_Load(object sender, EventArgs e)
        {
            Caixamsg.Mensagem($"Bem-vindo {FrmLoginAcesso.Nome}","_checked");

            var consulta = from p in db.ContasCorrentes select new { p.Cliente.Nome, p.Agencia, p.Conta, p.Situacao };
            var dados = consulta.Where(x => x.Situacao == true);
            dataGridView1.DataSource = dados.ToList();
            dataGridView1.ClearSelection();
        }

        private void txtPesquisar_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtPesquisar.Text.Length > 0)
            {
                txtPesquisar.Text = txtPesquisar.Text.Substring(0, 1).ToUpper() + txtPesquisar.Text.Substring(1);
                txtPesquisar.SelectionStart = txtPesquisar.Text.Length + 1;
            }
        }

        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {
            if (rdDesbloqueado.Checked == true)
            {
                var consulta = from p in db.ContasCorrentes select new { p.Cliente.Nome, p.Agencia, p.Conta, p.Situacao };
                var dados = consulta.Where(x => x.Nome.Contains(txtPesquisar.Text))
                    .Where(x => x.Situacao == true);
                dataGridView1.DataSource = dados.ToList();
            }
            else
            {
                var consulta = from p in db.ContasCorrentes select new { p.Cliente.Nome, p.Agencia, p.Conta, p.Situacao };
                var dados = consulta.Where(x => x.Nome.Contains(txtPesquisar.Text))
                    .Where(x => x.Situacao == false);
                dataGridView1.DataSource = dados.ToList();
            }
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rdDesbloqueado_CheckedChanged(object sender, EventArgs e)
        {
            var consulta = from p in db.ContasCorrentes select new { p.Cliente.Nome, p.Agencia, p.Conta, p.Situacao };
            var dados = consulta.Where(x => x.Situacao == true);
            dataGridView1.DataSource = dados.ToList();
        }

        private void rdBloqueado_CheckedChanged(object sender, EventArgs e)
        {
            var consulta = from p in db.ContasCorrentes select new { p.Cliente.Nome, p.Agencia, p.Conta, p.Situacao };
            var dados = consulta.Where(x => x.Situacao == false);
            dataGridView1.DataSource = dados.ToList();
        }

        [Obsolete]
        private void btEcluir_Click(object sender, EventArgs e)
        {
            try
            {
                var FrmMensagemSimNao = new CaixaMensagem.FrmMensagemSimNao("Deseja Realmente Excluir?");
                FrmMensagemSimNao.ShowDialog();

                if (FrmMensagemSimNao.DialogResult == DialogResult.Yes)
                {
                    string conta = dataGridView1.CurrentRow.Cells[2].Value.ToString();

                    var consulta = from p in db.ContasCorrentes select new { p.Id, p.Cliente, p.Conta };
                    var filtro = consulta.Where(x => x.Conta == conta);
                    var dado = filtro.ToList();

                    var Extrato = db.Database
                       .ExecuteSqlCommand($"delete from Extratos where ContaId ={dado[0].Id}");

                    var ContaCorrente = db.Database
                       .ExecuteSqlCommand($"delete from contascorrentes where Conta ={conta}");

                    var Cliente = db.Database
                      .ExecuteSqlCommand($"delete from clientes where Id ={dado[0].Cliente.Id}");

                    Caixamsg.Mensagem("Conta Corrente Excluida com Sucesso!", "_checked");
                    AtualizarGrid();
                }
            }
            catch (Exception ex) 
            {
                Caixamsg.Mensagem(" Erro ao Excluir Conta Corrente!", "_checked" +ex);
            }
        }

        public void AtualizarGrid() 
        {
            if (rdDesbloqueado.Checked == true)
            {
                var consulta = from p in db.ContasCorrentes select new { p.Cliente.Nome, p.Agencia, p.Conta, p.Situacao };
                var dados = consulta.Where(x => x.Situacao == true);
                dataGridView1.DataSource = dados.ToList();
            }
            else
            {
                var consulta = from p in db.ContasCorrentes select new { p.Cliente.Nome, p.Agencia, p.Conta, p.Situacao };
                var dados = consulta.Where(x => x.Situacao == false);
                dataGridView1.DataSource = dados.ToList();
            }
        }

        [Obsolete]
        private void btBloDesblo_Click(object sender, EventArgs e)
        {
            string conta = dataGridView1.CurrentRow.Cells[2].Value.ToString();

            var consulta = from p in db.ContasCorrentes select new {p.Conta, p.Situacao };
            var filtro = consulta.Where(x => x.Conta == conta);
            var dado = filtro.ToList();

            if (dado[0].Situacao == true)
            {
                var FrmMensagemSimNao = new CaixaMensagem.FrmMensagemSimNao("Deseja Bloquear a Conta?");
                FrmMensagemSimNao.ShowDialog();

                if (FrmMensagemSimNao.DialogResult == DialogResult.Yes)
                {
                    var ContaCorrente = db.Database
                .ExecuteSqlCommand($"update ContasCorrentes set situacao ={0} where conta ={conta}");
                }
            }
            else
            {
                var FrmMensagemSimNao = new CaixaMensagem.FrmMensagemSimNao("Deseja Desloquear a Conta?");
                FrmMensagemSimNao.ShowDialog();

                if (FrmMensagemSimNao.DialogResult == DialogResult.Yes)
                {
                    var ContaCorrente = db.Database
                .ExecuteSqlCommand($"update ContasCorrentes set situacao ={1} where conta ={conta}");
                }
            }
            AtualizarGrid();
        }

        private void btEditar_Click(object sender, EventArgs e)
        {
            try
            {
                string conta = dataGridView1.CurrentRow.Cells[2].Value.ToString();

                var consulta = (from contas in db.ContasCorrentes
                                join cliente in db.Clientes on contas.Cliente.Id equals cliente.Id
                                select new
                                {
                                    contas.Conta,
                                    contas.Saldo,
                                    contas.Situacao,
                                    cliente.Nome,
                                    cliente.Sobrenome,
                                    cliente.Cpf,
                                    cliente.Cep,
                                    cliente.Logradouro,
                                    cliente.Numero,
                                    cliente.Bairro,
                                    cliente.Complemento,
                                    cliente.Uf,
                                    cliente.Cidade,
                                    contas.Senha
                                })
                               .Where(x => x.Conta == conta)
                               .ToList();

                Transferencia.Conta = consulta[0].Conta;
                Transferencia.Saldo = consulta[0].Saldo;
                Transferencia.Situacao = consulta[0].Situacao;
                Transferencia.Nome = consulta[0].Nome;
                Transferencia.Sobrenome = consulta[0].Sobrenome;
                Transferencia.Cpf = consulta[0].Cpf;
                Transferencia.Cep = consulta[0].Cep;
                Transferencia.Logradouro = consulta[0].Logradouro;
                Transferencia.Numero = consulta[0].Numero;
                Transferencia.Bairro = consulta[0].Bairro;
                Transferencia.Complemento = consulta[0].Complemento;
                Transferencia.Uf = consulta[0].Uf;
                Transferencia.Cidade = consulta[0].Cidade;
                Transferencia.Senha = consulta[0].Senha;

                FrmCriarConta.formulario = 1;
                FrmCriarConta frmCriarConta = new FrmCriarConta();
                frmCriarConta.ShowDialog();
            }
            catch(Exception ex)
            {
                Caixamsg.Mensagem(" Erro ao Editar Conta Corrente!", "_checked" + ex);
            }
        }
    }
}
