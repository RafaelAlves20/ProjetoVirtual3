namespace BancoVirtualSql.View
{
    partial class FrmAcessarConta
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
            this.btCancelar = new System.Windows.Forms.Button();
            this.btAcessar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAgencia = new System.Windows.Forms.MaskedTextBox();
            this.txtConta = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btCancelar
            // 
            this.btCancelar.BackColor = System.Drawing.Color.SlateGray;
            this.btCancelar.FlatAppearance.BorderSize = 0;
            this.btCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCancelar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btCancelar.Location = new System.Drawing.Point(251, 221);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(92, 31);
            this.btCancelar.TabIndex = 4;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = false;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // btAcessar
            // 
            this.btAcessar.BackColor = System.Drawing.Color.SlateGray;
            this.btAcessar.FlatAppearance.BorderSize = 0;
            this.btAcessar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAcessar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btAcessar.Location = new System.Drawing.Point(129, 221);
            this.btAcessar.Name = "btAcessar";
            this.btAcessar.Size = new System.Drawing.Size(92, 31);
            this.btAcessar.TabIndex = 3;
            this.btAcessar.Text = "Acessar";
            this.btAcessar.UseVisualStyleBackColor = false;
            this.btAcessar.Click += new System.EventHandler(this.btAcessar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(135, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Informar Senha:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(235, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Conta Corrente:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(140, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Agencia:";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.Color.SlateGray;
            this.panel1.Location = new System.Drawing.Point(0, -8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(72, 285);
            this.panel1.TabIndex = 21;
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(232, 140);
            this.txtSenha.MaxLength = 6;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(111, 20);
            this.txtSenha.TabIndex = 2;
            this.txtSenha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSenha_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(148, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Acessar Conta Corrente";
            // 
            // txtAgencia
            // 
            this.txtAgencia.Enabled = false;
            this.txtAgencia.Location = new System.Drawing.Point(138, 94);
            this.txtAgencia.Name = "txtAgencia";
            this.txtAgencia.Size = new System.Drawing.Size(88, 20);
            this.txtAgencia.TabIndex = 31;
            this.txtAgencia.Text = "5536";
            this.txtAgencia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtConta
            // 
            this.txtConta.Location = new System.Drawing.Point(238, 94);
            this.txtConta.MaxLength = 6;
            this.txtConta.Name = "txtConta";
            this.txtConta.Size = new System.Drawing.Size(100, 20);
            this.txtConta.TabIndex = 1;
            this.txtConta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtConta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtConta_KeyPress);
            // 
            // FrmAcessarConta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 273);
            this.Controls.Add(this.txtConta);
            this.Controls.Add(this.txtAgencia);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btAcessar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(426, 312);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(426, 312);
            this.Name = "FrmAcessarConta";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Acessar Conta Corrente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Button btAcessar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txtAgencia;
        private System.Windows.Forms.TextBox txtConta;
    }
}