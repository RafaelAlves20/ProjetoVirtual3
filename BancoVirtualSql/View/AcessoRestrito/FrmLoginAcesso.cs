using BancoVirtualSql.Conexao;
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
using Microsoft.EntityFrameworkCore;

namespace BancoVirtualSql.View.AcessoRestrito
{
    public partial class FrmLoginAcesso : Form {
        public FrmLoginAcesso()
        {
            InitializeComponent();
        }

        public static string Nome;
        CaixaDeMensagem Caixamsg = new CaixaDeMensagem();
        BancoVirtualContext bvContext = new BancoVirtualContext();

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btAcessar_Click(object sender, EventArgs e) 
        {
            if (txtUsuario.Text.Trim() != "" && txtSenha.Text.Trim() != ""
                || txtUsuario.Text.Trim() != "" || txtSenha.Text.Trim() != "")
            {
                var Acesso = bvContext.Usuarios
               .FromSqlInterpolated($"Select * from Usuarios where Nome = {txtUsuario.Text} and  Senha = {txtSenha.Text}")
               .ToList();

                if (Acesso.Count > 0)
                {
                    Nome = Acesso[0].Nome;
                   FrmAreaRestrita frmAcessoRestrito = new FrmAreaRestrita();
                   frmAcessoRestrito.ShowDialog();
                    Close();
                }
                else
                {
                    Caixamsg.Mensagem("Dados Incorretos!", "cancel");
                }
                    
            }
            else
            {
                Caixamsg.Mensagem("Preenche os Dados!", "cancel");
            }
        }

        
        private void FrmLoginAcesso_Load(object sender, EventArgs e)
        {

        }

        private void lblConfiguracao_DoubleClick(object sender, EventArgs e)
        {
            txtSenha.Text = "";
            txtUsuario.Text = "";
            FrmSeguranca frmSeguranca = new FrmSeguranca();
            frmSeguranca.ShowDialog();
        }

        private void lblConfiguracao_Click(object sender, EventArgs e)
        {

        }

        private void txtUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (txtUsuario.Text.Length > 0)
            {
                txtUsuario.Text = txtUsuario.Text.Substring(0, 1).ToUpper() + txtUsuario.Text.Substring(1);
                txtUsuario.SelectionStart = txtUsuario.Text.Length + 1;
            }
        }
    }
}
