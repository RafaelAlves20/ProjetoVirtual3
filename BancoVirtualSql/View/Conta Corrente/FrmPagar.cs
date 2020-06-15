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
    public partial class FrmPagar : Form
    {
        public FrmPagar()
        {
            InitializeComponent();
        }
        Transacao transacao = new Transacao();
        private void btPagar_Click(object sender, EventArgs e)
        {
            string tipo = "PAG/" + cbTipo.Text;
            transacao.Pagar(FrmAcessarConta.NumAgencia, FrmAcessarConta.NumConta, Convert.ToDecimal(txtValor.Text),tipo);
            if (transacao.realizado == 1)
                this.Close();
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmPagar_Load(object sender, EventArgs e)
        {

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
