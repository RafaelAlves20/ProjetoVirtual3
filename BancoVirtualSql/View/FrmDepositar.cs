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

namespace BancoVirtualSql.View {
    public partial class FrmDepositar : Form {
        public FrmDepositar() {
            InitializeComponent();
        }
        Transacao transacao = new Transacao();
        CaixaDeMensagem Caixamsg = new CaixaDeMensagem();

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btDepositar_Click(object sender, EventArgs e)
        {
            if(txtConta.Text.Trim() != "" && txtValor.Text.Trim() != "" || txtConta.Text.Trim() != "" || txtValor.Text.Trim() != "")
            {
                transacao.Deposistar(txtAgencia.Text, txtConta.Text, decimal.Parse(txtValor.Text));
                if (transacao.realizado == 1)
                   Close();
            }
            else
            {
                Caixamsg.Mensagem("Preencher os dados!", "cancel");
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
