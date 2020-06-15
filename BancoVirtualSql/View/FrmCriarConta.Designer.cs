namespace BancoVirtualSql.View {
    partial class FrmCriarConta {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCriarConta));
            this.label1 = new System.Windows.Forms.Label();
            this.txtAgencia = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSaldo = new System.Windows.Forms.TextBox();
            this.txtSituacao = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtSobrenome = new System.Windows.Forms.TextBox();
            this.txtCpf = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtConta = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtComplemento = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCep = new System.Windows.Forms.MaskedTextBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.txtUf = new System.Windows.Forms.TextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtLogradouro = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btSalvar = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtConfSenha = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(338, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Conta Corrente";
            // 
            // txtAgencia
            // 
            this.txtAgencia.Enabled = false;
            this.txtAgencia.Location = new System.Drawing.Point(13, 35);
            this.txtAgencia.Name = "txtAgencia";
            this.txtAgencia.Size = new System.Drawing.Size(100, 20);
            this.txtAgencia.TabIndex = 1;
            this.txtAgencia.Text = "5536";
            this.txtAgencia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Agência: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(147, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Conta Corrente:";
            // 
            // txtSaldo
            // 
            this.txtSaldo.Enabled = false;
            this.txtSaldo.Location = new System.Drawing.Point(328, 35);
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.Size = new System.Drawing.Size(93, 20);
            this.txtSaldo.TabIndex = 5;
            this.txtSaldo.Text = " R$ 0,00";
            this.txtSaldo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSituacao
            // 
            this.txtSituacao.Enabled = false;
            this.txtSituacao.Location = new System.Drawing.Point(459, 35);
            this.txtSituacao.Name = "txtSituacao";
            this.txtSituacao.Size = new System.Drawing.Size(100, 20);
            this.txtSituacao.TabIndex = 6;
            this.txtSituacao.Text = "Ativo";
            this.txtSituacao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.SystemColors.Menu;
            this.txtNome.Location = new System.Drawing.Point(6, 37);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(173, 20);
            this.txtNome.TabIndex = 1;
            // 
            // txtSobrenome
            // 
            this.txtSobrenome.Location = new System.Drawing.Point(200, 37);
            this.txtSobrenome.Name = "txtSobrenome";
            this.txtSobrenome.Size = new System.Drawing.Size(220, 20);
            this.txtSobrenome.TabIndex = 2;
            // 
            // txtCpf
            // 
            this.txtCpf.BackColor = System.Drawing.SystemColors.Menu;
            this.txtCpf.Location = new System.Drawing.Point(441, 37);
            this.txtCpf.Mask = "00000000000";
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.PromptChar = ' ';
            this.txtCpf.Size = new System.Drawing.Size(186, 20);
            this.txtCpf.TabIndex = 3;
            this.txtCpf.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCpf.Enter += new System.EventHandler(this.txtCpf_Enter);
            this.txtCpf.Leave += new System.EventHandler(this.txtCpf_Leave);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtConta);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtAgencia);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtSituacao);
            this.groupBox1.Controls.Add(this.txtSaldo);
            this.groupBox1.Location = new System.Drawing.Point(81, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(647, 65);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados Da Conta";
            // 
            // txtConta
            // 
            this.txtConta.BackColor = System.Drawing.SystemColors.Menu;
            this.txtConta.Location = new System.Drawing.Point(143, 35);
            this.txtConta.MaxLength = 6;
            this.txtConta.Name = "txtConta";
            this.txtConta.Size = new System.Drawing.Size(129, 20);
            this.txtConta.TabIndex = 15;
            this.txtConta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(456, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Situação:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(325, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Saldo:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.txtComplemento);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtCep);
            this.groupBox2.Controls.Add(this.txtCidade);
            this.groupBox2.Controls.Add(this.txtUf);
            this.groupBox2.Controls.Add(this.txtBairro);
            this.groupBox2.Controls.Add(this.txtNumero);
            this.groupBox2.Controls.Add(this.txtLogradouro);
            this.groupBox2.Controls.Add(this.txtCpf);
            this.groupBox2.Controls.Add(this.txtNome);
            this.groupBox2.Controls.Add(this.txtSobrenome);
            this.groupBox2.Location = new System.Drawing.Point(81, 147);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(647, 167);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dados Pessoais";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(10, 121);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(74, 13);
            this.label15.TabIndex = 26;
            this.label15.Text = "Complemento:";
            // 
            // txtComplemento
            // 
            this.txtComplemento.Location = new System.Drawing.Point(6, 137);
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(210, 20);
            this.txtComplemento.TabIndex = 8;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(289, 121);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(43, 13);
            this.label14.TabIndex = 24;
            this.label14.Text = "Cidade:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(235, 121);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(21, 13);
            this.label13.TabIndex = 23;
            this.label13.Text = "Uf:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(450, 72);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(34, 13);
            this.label12.TabIndex = 22;
            this.label12.Text = "Bairro";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(402, 72);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(22, 13);
            this.label11.TabIndex = 21;
            this.label11.Text = "Nº:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(160, 71);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Logradouro:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 71);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Cep:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(444, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Cpf:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(203, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Sobrenome:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Nome:";
            // 
            // txtCep
            // 
            this.txtCep.Location = new System.Drawing.Point(6, 87);
            this.txtCep.Mask = "00000000";
            this.txtCep.Name = "txtCep";
            this.txtCep.PromptChar = ' ';
            this.txtCep.Size = new System.Drawing.Size(143, 20);
            this.txtCep.TabIndex = 4;
            this.txtCep.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCep.Leave += new System.EventHandler(this.txtCep_Leave);
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(286, 137);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(341, 20);
            this.txtCidade.TabIndex = 10;
            // 
            // txtUf
            // 
            this.txtUf.Location = new System.Drawing.Point(233, 137);
            this.txtUf.Name = "txtUf";
            this.txtUf.Size = new System.Drawing.Size(36, 20);
            this.txtUf.TabIndex = 9;
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(447, 87);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(180, 20);
            this.txtBairro.TabIndex = 7;
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(398, 87);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(42, 20);
            this.txtNumero.TabIndex = 6;
            // 
            // txtLogradouro
            // 
            this.txtLogradouro.Location = new System.Drawing.Point(156, 87);
            this.txtLogradouro.Name = "txtLogradouro";
            this.txtLogradouro.Size = new System.Drawing.Size(235, 20);
            this.txtLogradouro.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.Color.SlateGray;
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(72, 455);
            this.panel1.TabIndex = 12;
            // 
            // btSalvar
            // 
            this.btSalvar.BackColor = System.Drawing.Color.SlateGray;
            this.btSalvar.FlatAppearance.BorderSize = 0;
            this.btSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSalvar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btSalvar.Location = new System.Drawing.Point(507, 407);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(92, 31);
            this.btSalvar.TabIndex = 13;
            this.btSalvar.Text = "Salvar";
            this.btSalvar.UseVisualStyleBackColor = false;
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.BackColor = System.Drawing.Color.SlateGray;
            this.btCancelar.FlatAppearance.BorderSize = 0;
            this.btCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCancelar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btCancelar.Location = new System.Drawing.Point(627, 407);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(92, 31);
            this.btCancelar.TabIndex = 14;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = false;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtConfSenha);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.txtSenha);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Location = new System.Drawing.Point(81, 328);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(647, 52);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Segurança";
            // 
            // txtConfSenha
            // 
            this.txtConfSenha.BackColor = System.Drawing.SystemColors.Menu;
            this.txtConfSenha.Location = new System.Drawing.Point(358, 19);
            this.txtConfSenha.MaxLength = 6;
            this.txtConfSenha.Name = "txtConfSenha";
            this.txtConfSenha.PasswordChar = '*';
            this.txtConfSenha.Size = new System.Drawing.Size(126, 20);
            this.txtConfSenha.TabIndex = 12;
            this.txtConfSenha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(249, 23);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(94, 13);
            this.label17.TabIndex = 29;
            this.label17.Text = "Confirme a Senha:";
            // 
            // txtSenha
            // 
            this.txtSenha.BackColor = System.Drawing.SystemColors.Menu;
            this.txtSenha.Location = new System.Drawing.Point(106, 19);
            this.txtSenha.MaxLength = 6;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(126, 20);
            this.txtSenha.TabIndex = 11;
            this.txtSenha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 23);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(94, 13);
            this.label16.TabIndex = 27;
            this.label16.Text = "Digite uma Senha:";
            // 
            // FrmCriarConta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(755, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btSalvar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCriarConta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conta Corrente";
            this.Load += new System.EventHandler(this.FrmCriarConta_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txtAgencia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSaldo;
        private System.Windows.Forms.TextBox txtSituacao;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtSobrenome;
        private System.Windows.Forms.MaskedTextBox txtCpf;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox txtCep;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.TextBox txtUf;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.TextBox txtLogradouro;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtComplemento;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btSalvar;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtConfSenha;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtConta;
    }
}