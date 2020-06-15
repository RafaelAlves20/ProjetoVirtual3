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

namespace BancoVirtualSql.View.AcessoRestrito
{
    public partial class FrmSeguranca : Form
    {
        public FrmSeguranca()
        {
            InitializeComponent();
        }

        CaixaDeMensagem Caixamsg = new CaixaDeMensagem();

        private void FrmSeguranca_Load(object sender, EventArgs e)
        {

        }

        private void btAcessar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text.Trim() != "" && txtSenha.Text.Trim() != "" || txtUsuario.Text.Trim() != "" || txtSenha.Text.Trim() != "")
            {
                if (txtUsuario.Text == "Adm" || txtUsuario.Text == "adm" && txtSenha.Text == "adm")
                {
                    FrmCadastro frmCadastro = new FrmCadastro();
                    frmCadastro.ShowDialog();
                    this.Close();
                }
                else
                {
                    Caixamsg.Mensagem("Informações Incorrentas!", "cancel");
                }
            }
            else
            {
                Caixamsg.Mensagem("Preencher os Dados!", "cancel");
            }
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
