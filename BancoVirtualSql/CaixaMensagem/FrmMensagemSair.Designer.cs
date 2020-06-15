namespace BancoVirtualSql.CaixaMensagem
{
    partial class FrmMensagemSair
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
            this.lblMensagem = new System.Windows.Forms.Label();
            this.pctImagem = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btNao = new System.Windows.Forms.Button();
            this.btSim = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pctImagem)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMensagem
            // 
            this.lblMensagem.AutoSize = true;
            this.lblMensagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensagem.Location = new System.Drawing.Point(187, 72);
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Size = new System.Drawing.Size(172, 15);
            this.lblMensagem.TabIndex = 12;
            this.lblMensagem.Text = "Deseja Sair Do Banco Virtual?";
            // 
            // pctImagem
            // 
            this.pctImagem.Image = global::BancoVirtualSql.Properties.Resources.informacao;
            this.pctImagem.Location = new System.Drawing.Point(92, 38);
            this.pctImagem.Name = "pctImagem";
            this.pctImagem.Size = new System.Drawing.Size(81, 81);
            this.pctImagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctImagem.TabIndex = 11;
            this.pctImagem.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.Color.SlateGray;
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(72, 175);
            this.panel1.TabIndex = 9;
            // 
            // btNao
            // 
            this.btNao.Location = new System.Drawing.Point(355, 123);
            this.btNao.Name = "btNao";
            this.btNao.Size = new System.Drawing.Size(85, 34);
            this.btNao.TabIndex = 15;
            this.btNao.Text = "Não";
            this.btNao.UseVisualStyleBackColor = true;
            this.btNao.Click += new System.EventHandler(this.btNao_Click);
            // 
            // btSim
            // 
            this.btSim.Location = new System.Drawing.Point(264, 123);
            this.btSim.Name = "btSim";
            this.btSim.Size = new System.Drawing.Size(85, 34);
            this.btSim.TabIndex = 14;
            this.btSim.Text = "Sim";
            this.btSim.UseVisualStyleBackColor = true;
            this.btSim.Click += new System.EventHandler(this.btSim_Click);
            // 
            // FrmMensagemSair
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(456, 168);
            this.Controls.Add(this.btNao);
            this.Controls.Add(this.btSim);
            this.Controls.Add(this.lblMensagem);
            this.Controls.Add(this.pctImagem);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(472, 207);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(472, 207);
            this.Name = "FrmMensagemSair";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aviso!";
            ((System.ComponentModel.ISupportInitialize)(this.pctImagem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMensagem;
        private System.Windows.Forms.PictureBox pctImagem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btNao;
        private System.Windows.Forms.Button btSim;
    }
}