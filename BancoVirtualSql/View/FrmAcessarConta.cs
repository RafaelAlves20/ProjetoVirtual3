using BancoVirtualSql.Conexao;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace BancoVirtualSql.View
{
    public partial class FrmAcessarConta : Form
    {
        public FrmAcessarConta()
        {
            InitializeComponent();
        }

        public static string NumAgencia;
        public static string NumConta;
        public static int NumId;

        BancoVirtualContext bvContext = new BancoVirtualContext();

        private void btAcessar_Click(object sender, EventArgs e)
        {
            Login(txtAgencia.Text, txtConta.Text, txtSenha.Text);

        }

        private void Login (string Agencia, string Conta, string Senha)
        {
            try
            {
                var Acesso = bvContext.ContasCorrentes
                    .FromSqlInterpolated($"Select * from ContasCorrentes  where Agencia = {Agencia} and Conta = {Conta} and Senha = {Senha}")
                    .ToList();

                var consulta = from p in bvContext.ContasCorrentes select new { p.Cliente.Id, p.Conta };
                var Dados = consulta.Where(x => x.Conta == Acesso[0].Conta).ToList();

                if (Acesso.Count > 0)
                {
                    NumAgencia = Acesso[0].Agencia;
                    NumConta = Acesso[0].Conta;
                    NumId = Dados[0].Id;

                    var frmContaCorrente = new Conta_Corrente.FrmContaCorrente();
                    frmContaCorrente.ShowDialog();
                    this.Close();
                }
                else
                {
                    Mensagem("Conta Corrente Não Encontrada!", "cancel");
                }
            }
            catch
            {
                Mensagem("Erro ao Acessar Conta Corrente!", "cancel");
            }
           
        }

        public void Mensagem(string msg, string imagem)
        {
            CaixaMensagem.FrmMensagemOK frmMensagemOK = new CaixaMensagem.FrmMensagemOK(msg, imagem);
            frmMensagemOK.ShowDialog();
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtConta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void txtSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
        }
    }
}
