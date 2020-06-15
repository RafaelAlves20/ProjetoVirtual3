using BancoVirtualSql.Controller;
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
    public partial class FrmTransferir : Form
    {
        public FrmTransferir()
        {
            InitializeComponent();
        }

        Transacao transacao = new Transacao();
        CaixaDeMensagem Caixamsg = new CaixaDeMensagem();

        private void btTransferir_Click(object sender, EventArgs e)
        {
            if(txtConta.Text.Trim() != "" && txtValor.Text.Trim() != "" || txtConta.Text.Trim() != "" || txtValor.Text.Trim() != "")
            {
               transacao.Transferir(txtAgencia.Text, txtConta.Text, decimal.Parse(txtValor.Text));
                if (transacao.realizado == 1)
                    this.Close();
            }
            else 
            {
                Caixamsg.Mensagem("Preenche os Dados!","cancel");
            }
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

        private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
        }
    }
}
