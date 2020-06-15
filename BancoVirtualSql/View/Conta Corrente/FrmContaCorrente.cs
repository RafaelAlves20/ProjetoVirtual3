using BancoVirtualSql.Conexao;
using BancoVirtualSql.Controller;
using BancoVirtualSql.Repositorio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BancoVirtualSql.View.Conta_Corrente
{
    public partial class FrmContaCorrente : Form
    {
        public FrmContaCorrente()
        {
            InitializeComponent();
        }

        BancoVirtualContext db = new BancoVirtualContext();
        CaixaDeMensagem Caixamsg = new CaixaDeMensagem();
        FrmAcessarConta conta = new FrmAcessarConta();
        private static string Nome;

        private void FrmContaCorrente_Load(object sender, EventArgs e)
        {
            Usuario();
            Saldo();
            Caixamsg.Mensagem($"Bem-Vindo {Nome}!","_checked");

            if(lblSituacao.Text == "Bloqueado")
            {
                btSacar.Enabled = false;
                btDepositar.Enabled = false;
                btTransferir.Enabled = false;
                btPagar.Enabled = false;
                btExtrato.Enabled = false;
            }
        }

        private void Usuario()
        {
            var consulta = from p in db.ContasCorrentes select new { p.Cliente, p.Agencia, p.Conta, p.Saldo, p.Situacao };
            var Dados = consulta.ToList();
            var cliente = consulta.Where(x => x.Cliente.Id == FrmAcessarConta.NumId).ToList();

            lblusuario.Text = cliente[0].Cliente.Nome;
            lblAgencia.Text = cliente[0].Agencia.ToString();
            lblConta.Text = cliente[0].Conta.ToString();
            Nome = cliente[0].Cliente.Nome;

            if (cliente[0].Situacao)
            {
                lblSituacao.Text = "Ativo";
            }
            else 
            {
                lblSituacao.Text = "Bloqueado";
            }
        }

        private void Saldo()
        {
            var consulta = from p in db.ContasCorrentes select new { p.Cliente, p.Saldo };
            var Dados = consulta.ToList();
            var cliente = consulta.Where(x => x.Cliente.Id == FrmAcessarConta.NumId).ToList();
            lblSaldo.Text = cliente[0].Saldo.ToString();
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void btSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btSacar_Click(object sender, EventArgs e)
        {
            ContaCorrente.Tipo = 0;
            FrmLancamento frmLancamento = new FrmLancamento();
            frmLancamento.ShowDialog();
            Saldo();

        }

        private void btDepositar_Click(object sender, EventArgs e)
        {
            ContaCorrente.Tipo = 1;
            FrmLancamento frmLancamento = new FrmLancamento();
            frmLancamento.ShowDialog();
            Saldo();
        }

        private void btTransferir_Click(object sender, EventArgs e)
        {
            FrmTransferir frmTransferir = new FrmTransferir();
            frmTransferir.ShowDialog();
            Saldo();
        }

        private void btPagar_Click(object sender, EventArgs e)
        {
            FrmPagar frmPagar = new FrmPagar();
            frmPagar.ShowDialog();
            Saldo();
        }

        private void btExtrato_Click(object sender, EventArgs e)
        {
            FrmExtrato frmExtrato = new FrmExtrato();
            frmExtrato.ShowDialog();
            Saldo();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tsHoradata.Text = DateTime.Now.ToString();
        }
    }
}
