namespace BancoVirtualSql.View {
    partial class FrmPrincipal {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btSair = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btAcessoRestrito = new System.Windows.Forms.Button();
            this.btAcessar = new System.Windows.Forms.Button();
            this.btDepositar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btCriarConta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.Color.SlateGray;
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(72, 700);
            this.panel1.TabIndex = 0;
            // 
            // btSair
            // 
            this.btSair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btSair.BackColor = System.Drawing.Color.SlateGray;
            this.btSair.FlatAppearance.BorderSize = 0;
            this.btSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSair.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btSair.Location = new System.Drawing.Point(903, 636);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(160, 46);
            this.btSair.TabIndex = 1;
            this.btSair.Text = "Sair";
            this.btSair.UseVisualStyleBackColor = false;
            this.btSair.Click += new System.EventHandler(this.btSair_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SlateGray;
            this.label2.Location = new System.Drawing.Point(548, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 58);
            this.label2.TabIndex = 3;
            this.label2.Text = "Virtual";
            // 
            // btAcessoRestrito
            // 
            this.btAcessoRestrito.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btAcessoRestrito.BackColor = System.Drawing.Color.SlateGray;
            this.btAcessoRestrito.FlatAppearance.BorderSize = 0;
            this.btAcessoRestrito.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAcessoRestrito.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAcessoRestrito.ForeColor = System.Drawing.Color.White;
            this.btAcessoRestrito.Location = new System.Drawing.Point(79, 505);
            this.btAcessoRestrito.Name = "btAcessoRestrito";
            this.btAcessoRestrito.Size = new System.Drawing.Size(160, 46);
            this.btAcessoRestrito.TabIndex = 4;
            this.btAcessoRestrito.Text = "Acesso Restrito";
            this.btAcessoRestrito.UseVisualStyleBackColor = false;
            this.btAcessoRestrito.Click += new System.EventHandler(this.btAcessoRestrito_Click);
            // 
            // btAcessar
            // 
            this.btAcessar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btAcessar.BackColor = System.Drawing.Color.SlateGray;
            this.btAcessar.FlatAppearance.BorderSize = 0;
            this.btAcessar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAcessar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAcessar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btAcessar.Location = new System.Drawing.Point(79, 375);
            this.btAcessar.Name = "btAcessar";
            this.btAcessar.Size = new System.Drawing.Size(160, 46);
            this.btAcessar.TabIndex = 5;
            this.btAcessar.Text = "Acessar Conta";
            this.btAcessar.UseVisualStyleBackColor = false;
            this.btAcessar.Click += new System.EventHandler(this.btAcessar_Click);
            // 
            // btDepositar
            // 
            this.btDepositar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btDepositar.BackColor = System.Drawing.Color.SlateGray;
            this.btDepositar.FlatAppearance.BorderSize = 0;
            this.btDepositar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDepositar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDepositar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btDepositar.Location = new System.Drawing.Point(79, 440);
            this.btDepositar.Name = "btDepositar";
            this.btDepositar.Size = new System.Drawing.Size(160, 46);
            this.btDepositar.TabIndex = 6;
            this.btDepositar.Text = "Depositar";
            this.btDepositar.UseVisualStyleBackColor = false;
            this.btDepositar.Click += new System.EventHandler(this.btDepositar_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SlateGray;
            this.label1.Location = new System.Drawing.Point(365, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 58);
            this.label1.TabIndex = 2;
            this.label1.Text = "Banco";
            // 
            // btCriarConta
            // 
            this.btCriarConta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btCriarConta.BackColor = System.Drawing.Color.SlateGray;
            this.btCriarConta.FlatAppearance.BorderSize = 0;
            this.btCriarConta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCriarConta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCriarConta.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btCriarConta.Location = new System.Drawing.Point(79, 310);
            this.btCriarConta.Name = "btCriarConta";
            this.btCriarConta.Size = new System.Drawing.Size(160, 46);
            this.btCriarConta.TabIndex = 7;
            this.btCriarConta.Text = "Criar Conta Corrente";
            this.btCriarConta.UseVisualStyleBackColor = false;
            this.btCriarConta.Click += new System.EventHandler(this.btCriarConta_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::BancoVirtualSql.Properties.Resources.Principal;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1075, 694);
            this.Controls.Add(this.btCriarConta);
            this.Controls.Add(this.btDepositar);
            this.Controls.Add(this.btAcessar);
            this.Controls.Add(this.btAcessoRestrito);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btSair);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1091, 733);
            this.MinimumSize = new System.Drawing.Size(1091, 733);
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Banco Virtual";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btSair;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btAcessoRestrito;
        private System.Windows.Forms.Button btAcessar;
        private System.Windows.Forms.Button btDepositar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btCriarConta;
    }
}

