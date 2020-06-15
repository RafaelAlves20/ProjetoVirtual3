using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BancoVirtualSql.CaixaMensagem
{
    public partial class FrmMensagemOK : Form
    {
        public FrmMensagemOK(string texto, string imagem)
        {
            InitializeComponent();
            lblMensagem.Text = texto;
            Image MyImage = (Image)global::BancoVirtualSql.Properties.Resources.ResourceManager.GetObject(imagem);
            pctImagem.Image = MyImage;
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
