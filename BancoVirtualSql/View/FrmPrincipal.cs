using BancoVirtualSql.Controller;
using BancoVirtualSql.View.AcessoRestrito;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BancoVirtualSql.CaixaMensagem;

namespace BancoVirtualSql.View
{
    public partial class FrmPrincipal : Form 
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        CaixaDeMensagem Caixamsg = new CaixaDeMensagem();

        private void btSair_Click(object sender, EventArgs e)
        {
            var frmMensagemSair = new FrmMensagemSair("Deseja sair do Banco Virtual?");
            frmMensagemSair.ShowDialog();

            if (frmMensagemSair.DialogResult == DialogResult.Yes)
            {
                Application.ExitThread();
            }
        }

        private void btAcessoRestrito_Click(object sender, EventArgs e)
        {
            FrmLoginAcesso frmAcesso = new FrmLoginAcesso();
            frmAcesso.ShowDialog();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e) {

        }

        private void btCriarConta_Click(object sender, EventArgs e)
        {
            FrmCriarConta frmCriarConta = new FrmCriarConta();
            frmCriarConta.ShowDialog();
        }

        private void btDepositar_Click(object sender, EventArgs e)
        {
            FrmDepositar frmDepositar = new FrmDepositar();
            frmDepositar.ShowDialog();
        }

        private void btAcessar_Click(object sender, EventArgs e)
        {
            FrmAcessarConta frmAcessarConta = new FrmAcessarConta();
            frmAcessarConta.ShowDialog();
        }

        private void FrmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            var frmMensagemSair = new FrmMensagemSair("Deseja sair do Banco Virtual?");
            frmMensagemSair.ShowDialog();

            if(frmMensagemSair.DialogResult == DialogResult.Yes)
            {
                Application.ExitThread();
            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}
