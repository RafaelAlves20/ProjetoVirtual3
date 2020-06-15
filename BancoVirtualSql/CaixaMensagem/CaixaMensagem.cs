using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoVirtualSql.Controller
{
   public class CaixaDeMensagem
    {
        public void Mensagem(string msg, string imagem)
        {
            CaixaMensagem.FrmMensagemOK frmMensagemOK = new CaixaMensagem.FrmMensagemOK(msg, imagem);
            frmMensagemOK.ShowDialog();
        }
        public void MensagemSair(string msg, string imagem)
        {
            CaixaMensagem.FrmMensagemSair frmMensagemSair = new CaixaMensagem.FrmMensagemSair(msg);
            frmMensagemSair.ShowDialog();
        }
    }
}
