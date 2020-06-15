using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BancoVirtualSql.View;

namespace BancoVirtualSql.Controller
{
   public class Transacao
   {

        CaixaDeMensagem Caixamsg = new CaixaDeMensagem();
        public int realizado;

        public void Transferir(string Agencia, string Conta, decimal Valor)
        {
            try
            {
                realizado = 1;
                BancoVirtualEntities1 bancoVirtualEntities1 = new BancoVirtualEntities1();
                bancoVirtualEntities1.TRANSFERIR(FrmAcessarConta.NumAgencia, FrmAcessarConta.NumConta, Agencia, Conta, Valor);
                Caixamsg.Mensagem("Tranferência efetuada Com Sucesso!", "_checked");

            }
            catch
            {
                realizado = 0;
                Caixamsg.Mensagem("Erro ao Transferir!", "cancel");
            }
        }

        public void Sacar(string Agencia, string Conta, decimal Valor)
        { 
            try
            {
                realizado = 1;
                BancoVirtualEntities1 bancoVirtualEntities1 = new BancoVirtualEntities1();
                bancoVirtualEntities1.SACAR(Agencia, Conta, Valor);
                Caixamsg.Mensagem("Saque efetuado Com Sucesso!", "_checked");
               
            }
            catch
            {
                realizado = 0;
                Caixamsg.Mensagem("Erro ao Sacar!", "cancel");
            }
        }

        public void Deposistar(string Agencia, string Conta, decimal Valor)
        {
            try
            {
                realizado = 1;
                BancoVirtualEntities1 bancoVirtualEntities1 = new BancoVirtualEntities1();
                bancoVirtualEntities1.DEPOSITAR(Agencia, Conta, Valor);
                Caixamsg.Mensagem("Deposito efetuado Com Sucesso!", "_checked");
            }
            catch
            {
                realizado = 0;
                Caixamsg.Mensagem("Erro ao Depositar!", "cancel");
            }
        }

        public void Pagar(string Agencia, string Conta, decimal Valor, string Tipo)
        {
            try
            {
                realizado = 1;
                BancoVirtualEntities1 bancoVirtualEntities1 = new BancoVirtualEntities1();
                bancoVirtualEntities1.PAGAR(Agencia, Conta, Valor, Tipo);
                Caixamsg.Mensagem("Pagamento efetuado Com Sucesso!", "_checked");
            }
            catch
            {
                realizado = 0;
                Caixamsg.Mensagem("Erro ao a Pagar!", "cancel");
            }
        }

    }
}
