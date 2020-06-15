using BancoVirtualSql.Conexao;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BancoVirtualSql.Controller;
using BancoVirtualSql.Repositorio;

namespace BancoVirtualSql.View.Conta_Corrente
{
    public partial class FrmLancamento : Form
    {
        public FrmLancamento()
        {
            InitializeComponent();
        }

        BancoVirtualContext bvContext = new BancoVirtualContext();
        Transacao transacao = new Transacao();
        CaixaDeMensagem Caixamsg = new CaixaDeMensagem();

        private void btLancar_Click(object sender, EventArgs e)
        {
            if (txtValor.Text.Trim() != "")
            {
                if (ContaCorrente.Tipo == 0)
                {
                    transacao.Sacar(FrmAcessarConta.NumAgencia, FrmAcessarConta.NumConta, Convert.ToDecimal(txtValor.Text));
                    if (transacao.realizado == 1)
                        this.Close();
                }
                else if (ContaCorrente.Tipo == 1)
                {
                    transacao.Deposistar(FrmAcessarConta.NumAgencia, FrmAcessarConta.NumConta, Convert.ToDecimal(txtValor.Text));
                    if (transacao.realizado == 1)
                        this.Close();
                }
            }
            else
            {
                Caixamsg.Mensagem("Informe o valor!", "cancel");
            }
        }


        private void FrmLancamento_Load(object sender, EventArgs e)
        {
            if (ContaCorrente.Tipo == 0)
            {
                lblLanc.Text = "Sacar";
            }
            else if (ContaCorrente.Tipo == 1)
            {
                lblLanc.Text = "Depositar";
            }
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
        }
    }
}
