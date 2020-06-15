using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BancoVirtualSql.Conexao;
using BancoVirtualSql.Controller;
using BancoVirtualSql.Repositorio;
using BancoVirtualSql.View.Conta_Corrente;
using Microsoft.EntityFrameworkCore;

namespace BancoVirtualSql.View {
    public partial class FrmCriarConta : Form {
        public FrmCriarConta() 
        {
            InitializeComponent();
        }

        Cliente cliente = new Cliente();
        ContaCorrente conta = new ContaCorrente();
        CaixaDeMensagem Caixamsg = new CaixaDeMensagem();
        public static int formulario;

        private void FrmCriarConta_Load(object sender, EventArgs e)
        {
            if(formulario == 1)
            {
                if (Transferencia.Situacao) 
                {
                    txtSituacao.Text = "Ativado";
                }
                else 
                {
                    txtSituacao.Text = "Bloqueado";
                }

                txtConta.Text = Transferencia.Conta;
                txtSaldo.Text = Convert.ToString(Transferencia.Saldo);
                txtNome.Text = Transferencia.Nome;
                txtSobrenome.Text = Transferencia.Sobrenome;
                txtCpf.Text = Transferencia.Cpf;
                txtCep.Text = Transferencia.Cep;
                txtLogradouro.Text = Transferencia.Logradouro;
                txtNumero.Text = Transferencia.Numero;
                txtBairro.Text = Transferencia.Bairro;
                txtComplemento.Text = Transferencia.Complemento;
                txtUf.Text = Transferencia.Uf;
                txtCidade.Text = Transferencia.Cidade;
                txtSenha.Text = Transferencia.Senha;
                txtConfSenha.Text = Transferencia.Senha;

                txtConta.Enabled = false;
            }
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtCep_Leave(object sender, EventArgs e)
        {
            try
            {   var vJson = Controller.Cep.GeraJSONCEP(txtCep.Text);
                Repositorio.GetCep getCep = new Repositorio.GetCep();
                getCep = GetCep.DesSerializedClassGetCep(vJson);

                txtLogradouro.Text = getCep.Logradouro;
                txtNumero.Text = getCep.Unidade;
                txtBairro.Text = getCep.Bairro;
                txtCidade.Text = getCep.Localidade;
                txtUf.Text = getCep.Uf;
            }
            catch
            {
                if(txtCep.Text.Trim() != "")
                 Caixamsg.Mensagem("CEP inválido!","cancel");
            }
        }

        private void txtCpf_Leave(object sender, EventArgs e)
        {
            if (Controller.ValidaCpf.IsCpf(txtCpf.Text))
            {
                txtCpf.Mask = "000,000,000-00";
            }
            else 
            {
                if (txtCpf.Text.Trim() != "")
                    Caixamsg.Mensagem("Cpf inválido!","cancel");
            }
        }

        [Obsolete]
        private void btSalvar_Click(object sender, EventArgs e)
        {
            if (txtConta.Text.Trim() != "" && txtNome.Text.Trim() != "" && txtCpf.Text.Trim() != "" &&
               txtSenha.Text.Trim() != "" && txtConfSenha.Text.Trim() != "")
            {
                if (txtConta.Text.Trim() != "" || txtNome.Text.Trim() != "" || txtCpf.Text.Trim() != "" ||
                   txtSenha.Text.Trim() != "" || txtConfSenha.Text.Trim() != "")
                {
                    if(txtSenha.Text == txtConfSenha.Text)
                    {
                        BancoVirtualContext bvContext = new BancoVirtualContext();
                        if (FrmCriarConta.formulario == 0)
                        {
                            InserirCliente
                            (txtNome.Text, txtSobrenome.Text, txtCpf.Text, txtCep.Text, txtLogradouro.Text, txtNumero.Text, txtBairro.Text, txtComplemento.Text, txtUf.Text, txtCidade.Text);

                            bvContext.Clientes.Add(cliente);
                            bvContext.Clientes.ToList();
                            bvContext.SaveChanges();

                            InserirConta
                              (cliente.Id, txtAgencia.Text, txtConta.Text, 0, txtSenha.Text, true);

                            bvContext.ContasCorrentes.Add(conta);
                            bvContext.SaveChanges();

                            Caixamsg.Mensagem("Conta Corrente salvo com  Sucesso!", "_checked");
                            this.Close();
                        }
                        else if(FrmCriarConta.formulario == 1)
                        {
                            var consulta = (from contas in bvContext.ContasCorrentes
                                            join cliente in bvContext.Clientes on contas.Cliente.Id equals cliente.Id
                                            select new
                                            { 
                                            contas.Cliente.Id,
                                            contas.Conta
                                            })
                                            .Where(x => x.Conta == Transferencia.Conta)
                                            .ToList();

                            var ContaCorrente = bvContext.Database
                            .ExecuteSqlCommand($"Update ContasCorrentes set Senha = {txtSenha.Text} where clienteid ={consulta[0].Id}");

                            var Clientes = bvContext.Database
                            .ExecuteSqlCommand
                            ($"Update Clientes set Nome ={txtNome.Text}, sobrenome = {txtSobrenome.Text}, cpf ={txtCpf.Text},cep ={txtCep.Text}, Logradouro ={txtLogradouro.Text}, Numero ={txtNumero.Text}, Bairro={txtBairro.Text}, Complemento ={txtComplemento.Text}, uf = {txtUf.Text}, cidade = {txtCidade.Text} where id ={consulta[0].Id}");

                            Caixamsg.Mensagem("Conta Corrente Atualizada com  Sucesso!", "_checked");
                            this.Close();
                        }
                    }
                    else
                    {
                        Caixamsg.Mensagem("Senhas Não Confere. Verifique!","cancel");
                    }
                }
                else
                {
                    Caixamsg.Mensagem("Preencher Dados Obrigatórios!", "cancel");
                }
            }
            else
            {
                Caixamsg.Mensagem("Preencher Dados Obrigatórios!", "cancel");
            }
        }

        private void txtCpf_Enter(object sender, EventArgs e)
        {
            txtCpf.Mask = "";
        }

        public void InserirCliente
        (string Nome, string Sobrenome, string Cpf, string Cep, string Logradouro, string Numero, string Bairro, string Complemento, string Uf, string Cidade)
        {
            cliente.Nome = Nome;
            cliente.Sobrenome = Sobrenome;
            cliente.Cpf = Cpf;
            cliente.Cep = Cep;
            cliente.Logradouro = Logradouro;
            cliente.Numero = Numero;
            cliente.Bairro = Bairro;
            cliente.Complemento = Complemento;
            cliente.Uf = Uf;
            cliente.Cidade = Cidade;
        }

        public void InserirConta
        (int Cliente, string Agencia, string Conta, float Saldo, string Senha, bool Situacao )
        {
            conta.Cliente = cliente;
            conta.Agencia = Agencia;
            conta.Conta = Conta;
            conta.Saldo = Saldo;
            conta.Senha = Senha;
            conta.Situacao = Situacao;
        }

    }
}
