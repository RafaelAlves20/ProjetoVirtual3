namespace BancoVirtualSql.View {
    partial class FrmDepositar {
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtConta = new System.Windows.Forms.MaskedTextBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btCancelar = new System.Windows.Forms.Button();
            this.btDepositar = new System.Windows.Forms.Button();
            this.txtAgencia = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(195, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Depositar";
            // 
            // txtConta
            // 
            this.txtConta.Location = new System.Drawing.Point(235, 95);
            this.txtConta.Mask = "000000";
            this.txtConta.Name = "txtConta";
            this.txtConta.PromptChar = ' ';
            this.txtConta.Size = new System.Drawing.Size(111, 20);
            this.txtConta.TabIndex = 2;
            this.txtConta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(235, 141);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(111, 20);
            this.txtValor.TabIndex = 3;
            this.txtValor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValor_KeyPress);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.Color.SlateGray;
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(72, 271);
            this.panel1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(143, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Agencia:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(238, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Conta Corrente:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(138, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Informar Valor:  R$";
            // 
            // btCancelar
            // 
            this.btCancelar.BackColor = System.Drawing.Color.SlateGray;
            this.btCancelar.FlatAppearance.BorderSize = 0;
            this.btCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCancelar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btCancelar.Location = new System.Drawing.Point(254, 216);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(92, 31);
            this.btCancelar.TabIndex = 16;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = false;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // btDepositar
            // 
            this.btDepositar.BackColor = System.Drawing.Color.SlateGray;
            this.btDepositar.FlatAppearance.BorderSize = 0;
            this.btDepositar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDepositar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btDepositar.Location = new System.Drawing.Point(132, 216);
            this.btDepositar.Name = "btDepositar";
            this.btDepositar.Size = new System.Drawing.Size(92, 31);
            this.btDepositar.TabIndex = 15;
            this.btDepositar.Text = "Depositar";
            this.btDepositar.UseVisualStyleBackColor = false;
            this.btDepositar.Click += new System.EventHandler(this.btDepositar_Click);
            // 
            // txtAgencia
            // 
            this.txtAgencia.Enabled = false;
            this.txtAgencia.Location = new System.Drawing.Point(141, 95);
            this.txtAgencia.Name = "txtAgencia";
            this.txtAgencia.Size = new System.Drawing.Size(88, 20);
            this.txtAgencia.TabIndex = 17;
            this.txtAgencia.Text = "5536";
            this.txtAgencia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FrmDepositar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 265);
            this.Controls.Add(this.txtAgencia);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btDepositar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.txtConta);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(430, 304);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(430, 304);
            this.Name = "FrmDepositar";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Depositar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txtConta;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Button btDepositar;
        private System.Windows.Forms.MaskedTextBox txtAgencia;
    }
}