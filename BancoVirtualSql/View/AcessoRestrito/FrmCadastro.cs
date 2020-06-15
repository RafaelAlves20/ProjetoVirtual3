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

namespace BancoVirtualSql.View.AcessoRestrito
{
    public partial class FrmCadastro : Form
    {
        public FrmCadastro()
        {
            InitializeComponent();
        }

        Usuario usuarios = new Usuario();
        BancoVirtualContext bvContext = new BancoVirtualContext();
        CaixaDeMensagem Caixamsg = new CaixaDeMensagem();
      
        private void btCadastrar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text.Trim() != "" && txtSenha.Text.Trim() != ""
               || txtUsuario.Text.Trim() != "" || txtSenha.Text.Trim() != "")
            {
                if (txtSenha.Text == txtConfSenha.Text)
                {
                    usuarios.Nome = txtUsuario.Text;
                    usuarios.Senha = txtSenha.Text;

                    bvContext.Usuarios.Add(usuarios);
                    bvContext.Usuarios.ToList();
                    bvContext.SaveChanges();

                    Caixamsg.Mensagem("Usuário Salvo!", "_checked");
                    Close();
                }
                else 
                {
                    Caixamsg.Mensagem("As senhas são diferentes!", "cancel");
                }
            }
            else
            {
                Caixamsg.Mensagem("Preenche os Dados!", "cancel");
            }
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
