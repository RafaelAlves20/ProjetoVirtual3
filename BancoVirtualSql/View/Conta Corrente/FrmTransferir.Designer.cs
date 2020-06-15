namespace BancoVirtualSql.View.Conta_Corrente
{
    partial class FrmTransferir
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAgencia = new System.Windows.Forms.TextBox();
            this.txtConta = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btCancelar = new System.Windows.Forms.Button();
            this.btTransferir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.Color.SlateGray;
            this.panel1.Location = new System.Drawing.Point(-1, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(72, 245);
            this.panel1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(206, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Transferência";
            // 
            // txtAgencia
            // 
            this.txtAgencia.Enabled = false;
            this.txtAgencia.Location = new System.Drawing.Point(151, 84);
            this.txtAgencia.Name = "txtAgencia";
            this.txtAgencia.Size = new System.Drawing.Size(82, 20);
            this.txtAgencia.TabIndex = 9;
            this.txtAgencia.Text = "5536";
            this.txtAgencia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtConta
            // 
            this.txtConta.Location = new System.Drawing.Point(253, 84);
            this.txtConta.MaxLength = 6;
            this.txtConta.Name = "txtConta";
            this.txtConta.Size = new System.Drawing.Size(103, 20);
            this.txtConta.TabIndex = 10;
            this.txtConta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtConta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtConta_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(154, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Agência";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(256, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Conta Corrente";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(253, 127);
            this.txtValor.MaxLength = 10;
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(103, 20);
            this.txtValor.TabIndex = 13;
            this.txtValor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValor_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(154, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Informe o Valor:";
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(270, 183);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(86, 33);
            this.btCancelar.TabIndex = 16;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // btTransferir
            // 
            this.btTransferir.Location = new System.Drawing.Point(172, 183);
            this.btTransferir.Name = "btTransferir";
            this.btTransferir.Size = new System.Drawing.Size(86, 33);
            this.btTransferir.TabIndex = 15;
            this.btTransferir.Text = "Transferir";
            this.btTransferir.UseVisualStyleBackColor = true;
            this.btTransferir.Click += new System.EventHandler(this.btTransferir_Click);
            // 
            // FrmTransferir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(451, 240);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btTransferir);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtConta);
            this.Controls.Add(this.txtAgencia);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmTransferir";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transferir";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAgencia;
        private System.Windows.Forms.TextBox txtConta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Button btTransferir;
    }
}