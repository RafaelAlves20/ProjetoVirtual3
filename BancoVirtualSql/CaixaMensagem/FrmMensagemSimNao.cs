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
    public partial class FrmMensagemSimNao : Form
    {
        public FrmMensagemSimNao(string texto)
        {
            InitializeComponent();
            lblMensagem.Text = texto;
        }

        private void btSim_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Yes;
            this.Close();
        }

        private void btNao_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.No;
            this.Close();
        }
    }
}
