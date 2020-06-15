namespace BancoVirtualSql.View.AcessoRestrito
{
    partial class FrmLoginAcesso
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.btAcessar = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.lblConfiguracao = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(162, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Acesso Restrito";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Usuário:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(74, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Senha:";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(135, 53);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(199, 20);
            this.txtUsuario.TabIndex = 3;
            this.txtUsuario.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUsuario_KeyDown);
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(133, 81);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(199, 20);
            this.txtSenha.TabIndex = 4;
            // 
            // btAcessar
            // 
            this.btAcessar.Location = new System.Drawing.Point(133, 128);
            this.btAcessar.Name = "btAcessar";
            this.btAcessar.Size = new System.Drawing.Size(90, 31);
            this.btAcessar.TabIndex = 5;
            this.btAcessar.Text = "Acessar";
            this.btAcessar.UseVisualStyleBackColor = true;
            this.btAcessar.Click += new System.EventHandler(this.btAcessar_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(242, 128);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(90, 31);
            this.btCancelar.TabIndex = 6;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // lblConfiguracao
            // 
            this.lblConfiguracao.AutoSize = true;
            this.lblConfiguracao.Location = new System.Drawing.Point(73, 197);
            this.lblConfiguracao.Name = "lblConfiguracao";
            this.lblConfiguracao.Size = new System.Drawing.Size(75, 13);
            this.lblConfiguracao.TabIndex = 7;
            this.lblConfiguracao.Text = "Configurações";
            this.lblConfiguracao.DoubleClick += new System.EventHandler(this.lblConfiguracao_DoubleClick);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.Color.SlateGray;
            this.panel1.Location = new System.Drawing.Point(-1, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(72, 216);
            this.panel1.TabIndex = 16;
            // 
            // FrmLoginAcesso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(375, 212);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblConfiguracao);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btAcessar);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Location = new System.Drawing.Point(1546, 60);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(391, 251);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(391, 251);
            this.Name = "FrmLoginAcesso";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Acesso Restrito";
            this.Load += new System.EventHandler(this.FrmLoginAcesso_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Button btAcessar;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Label lblConfiguracao;
        private System.Windows.Forms.Panel panel1;
    }
}