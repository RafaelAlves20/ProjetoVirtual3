namespace BancoVirtualSql.View.Conta_Corrente
{
    partial class FrmContaCorrente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblusuario = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.btSacar = new System.Windows.Forms.Button();
            this.btDepositar = new System.Windows.Forms.Button();
            this.btTransferir = new System.Windows.Forms.Button();
            this.btPagar = new System.Windows.Forms.Button();
            this.btSair = new System.Windows.Forms.Button();
            this.btExtrato = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsHoradata = new System.Windows.Forms.ToolStripStatusLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblSituacao = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblAgencia = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblConta = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.Color.SlateGray;
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(72, 481);
            this.panel1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(295, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Banco Virtual - Conta Corrente";
            // 
            // lblusuario
            // 
            this.lblusuario.AutoSize = true;
            this.lblusuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusuario.Location = new System.Drawing.Point(152, 85);
            this.lblusuario.Name = "lblusuario";
            this.lblusuario.Size = new System.Drawing.Size(76, 16);
            this.lblusuario.TabIndex = 7;
            this.lblusuario.Text = "USUARIO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(70, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(691, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "_________________________________________________________________________________" +
    "_________________________________";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblSaldo);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(79, 105);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(110, 52);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Saldo Atual:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "R$";
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldo.Location = new System.Drawing.Point(25, 31);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(44, 15);
            this.lblSaldo.TabIndex = 10;
            this.lblSaldo.Text = "Saldo";
            // 
            // btSacar
            // 
            this.btSacar.BackColor = System.Drawing.Color.SlateGray;
            this.btSacar.FlatAppearance.BorderSize = 0;
            this.btSacar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSacar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSacar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btSacar.Location = new System.Drawing.Point(132, 214);
            this.btSacar.Name = "btSacar";
            this.btSacar.Size = new System.Drawing.Size(113, 63);
            this.btSacar.TabIndex = 10;
            this.btSacar.Text = "Sacar";
            this.btSacar.UseVisualStyleBackColor = false;
            this.btSacar.Click += new System.EventHandler(this.btSacar_Click);
            // 
            // btDepositar
            // 
            this.btDepositar.BackColor = System.Drawing.Color.SlateGray;
            this.btDepositar.FlatAppearance.BorderSize = 0;
            this.btDepositar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDepositar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDepositar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btDepositar.Location = new System.Drawing.Point(337, 214);
            this.btDepositar.Name = "btDepositar";
            this.btDepositar.Size = new System.Drawing.Size(113, 63);
            this.btDepositar.TabIndex = 11;
            this.btDepositar.Text = "Depositar";
            this.btDepositar.UseVisualStyleBackColor = false;
            this.btDepositar.Click += new System.EventHandler(this.btDepositar_Click);
            // 
            // btTransferir
            // 
            this.btTransferir.BackColor = System.Drawing.Color.SlateGray;
            this.btTransferir.FlatAppearance.BorderSize = 0;
            this.btTransferir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btTransferir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTransferir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btTransferir.Location = new System.Drawing.Point(558, 214);
            this.btTransferir.Name = "btTransferir";
            this.btTransferir.Size = new System.Drawing.Size(113, 63);
            this.btTransferir.TabIndex = 12;
            this.btTransferir.Text = "Transferir";
            this.btTransferir.UseVisualStyleBackColor = false;
            this.btTransferir.Click += new System.EventHandler(this.btTransferir_Click);
            // 
            // btPagar
            // 
            this.btPagar.BackColor = System.Drawing.Color.SlateGray;
            this.btPagar.FlatAppearance.BorderSize = 0;
            this.btPagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPagar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btPagar.Location = new System.Drawing.Point(132, 341);
            this.btPagar.Name = "btPagar";
            this.btPagar.Size = new System.Drawing.Size(113, 63);
            this.btPagar.TabIndex = 13;
            this.btPagar.Text = "Pagar";
            this.btPagar.UseVisualStyleBackColor = false;
            this.btPagar.Click += new System.EventHandler(this.btPagar_Click);
            // 
            // btSair
            // 
            this.btSair.BackColor = System.Drawing.Color.SlateGray;
            this.btSair.FlatAppearance.BorderSize = 0;
            this.btSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSair.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btSair.Location = new System.Drawing.Point(558, 341);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(113, 63);
            this.btSair.TabIndex = 14;
            this.btSair.Text = "Sair";
            this.btSair.UseVisualStyleBackColor = false;
            this.btSair.Click += new System.EventHandler(this.btSair_Click);
            // 
            // btExtrato
            // 
            this.btExtrato.BackColor = System.Drawing.Color.SlateGray;
            this.btExtrato.FlatAppearance.BorderSize = 0;
            this.btExtrato.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btExtrato.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExtrato.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btExtrato.Location = new System.Drawing.Point(337, 341);
            this.btExtrato.Name = "btExtrato";
            this.btExtrato.Size = new System.Drawing.Size(113, 63);
            this.btExtrato.TabIndex = 15;
            this.btExtrato.Text = "Extrato";
            this.btExtrato.UseVisualStyleBackColor = false;
            this.btExtrato.Click += new System.EventHandler(this.btExtrato_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.SlateGray;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.tsHoradata});
            this.statusStrip1.Location = new System.Drawing.Point(0, 454);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(755, 22);
            this.statusStrip1.TabIndex = 16;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(337, 17);
            this.toolStripStatusLabel1.Text = "                                                                                 " +
    "                             ";
            this.toolStripStatusLabel1.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // tsHoradata
            // 
            this.tsHoradata.BackColor = System.Drawing.Color.Transparent;
            this.tsHoradata.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsHoradata.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tsHoradata.Name = "tsHoradata";
            this.tsHoradata.Size = new System.Drawing.Size(60, 17);
            this.tsHoradata.Text = "DataHora";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(75, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 16);
            this.label3.TabIndex = 17;
            this.label3.Text = "Bem-Vindo :";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.lblSituacao);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(205, 105);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(110, 52);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Situação:";
            // 
            // lblSituacao
            // 
            this.lblSituacao.AutoSize = true;
            this.lblSituacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSituacao.Location = new System.Drawing.Point(6, 30);
            this.lblSituacao.Name = "lblSituacao";
            this.lblSituacao.Size = new System.Drawing.Size(63, 15);
            this.lblSituacao.TabIndex = 10;
            this.lblSituacao.Text = "Situacao";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(248, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 16);
            this.label5.TabIndex = 18;
            this.label5.Text = "Agencia: ";
            // 
            // lblAgencia
            // 
            this.lblAgencia.AutoSize = true;
            this.lblAgencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgencia.Location = new System.Drawing.Point(303, 85);
            this.lblAgencia.Name = "lblAgencia";
            this.lblAgencia.Size = new System.Drawing.Size(45, 16);
            this.lblAgencia.TabIndex = 19;
            this.lblAgencia.Text = "label6";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(356, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 16);
            this.label7.TabIndex = 20;
            this.label7.Text = "Conta:";
            // 
            // lblConta
            // 
            this.lblConta.AutoSize = true;
            this.lblConta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConta.Location = new System.Drawing.Point(396, 85);
            this.lblConta.Name = "lblConta";
            this.lblConta.Size = new System.Drawing.Size(45, 16);
            this.lblConta.TabIndex = 21;
            this.lblConta.Text = "label8";
            // 
            // FrmContaCorrente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(755, 476);
            this.Controls.Add(this.lblConta);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblAgencia);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btExtrato);
            this.Controls.Add(this.btSair);
            this.Controls.Add(this.btPagar);
            this.Controls.Add(this.btTransferir);
            this.Controls.Add(this.btDepositar);
            this.Controls.Add(this.btSacar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblusuario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(771, 515);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(771, 515);
            this.Name = "FrmContaCorrente";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conta Corrente";
            this.Load += new System.EventHandler(this.FrmContaCorrente_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblusuario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.Button btSacar;
        private System.Windows.Forms.Button btDepositar;
        private System.Windows.Forms.Button btTransferir;
        private System.Windows.Forms.Button btPagar;
        private System.Windows.Forms.Button btSair;
        private System.Windows.Forms.Button btExtrato;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel tsHoradata;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblSituacao;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblAgencia;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblConta;
    }
}