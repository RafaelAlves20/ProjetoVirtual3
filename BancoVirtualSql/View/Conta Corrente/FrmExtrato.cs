using BancoVirtualSql.Conexao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BancoVirtualSql.Repositorio;

namespace BancoVirtualSql.View.Conta_Corrente
{
    public partial class FrmExtrato : Form
    {
        public FrmExtrato()
        {
            InitializeComponent();
            this.dataGridView1.RowsDefaultCellStyle.BackColor = Color.Gainsboro;
            this.dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
        }

        private void FrmExtrato_Load(object sender, EventArgs e)
        {
            BancoVirtualEntities1 bancoVirtualEntities1 = new BancoVirtualEntities1();
            var dados = bancoVirtualEntities1.EXTRATO(FrmAcessarConta.NumAgencia, FrmAcessarConta.NumConta);
            dataGridView1.DataSource = dados.ToList();

            dataGridView1.ClearSelection();
            dataGridView1.Columns[0].HeaderText = "LANC.";
            dataGridView1.Columns[3].HeaderText = "DATA E HORA";
            dataGridView1.Columns[0].Width = 40;
            dataGridView1.Columns[2].Width = 50;
            dataGridView1.Columns[3].Width = 110;
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
