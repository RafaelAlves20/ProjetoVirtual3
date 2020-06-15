namespace BancoVirtualSql.CaixaMensagem
{
    partial class FrmMensagemOK
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
            this.btOk = new System.Windows.Forms.Button();
            this.pctImagem = new System.Windows.Forms.PictureBox();
            this.lblMensagem = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pctImagem)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.Color.SlateGray;
            this.panel1.Location = new System.Drawing.Point(-2, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(72, 175);
            this.panel1.TabIndex = 5;
            // 
            // btOk
            // 
            this.btOk.Location = new System.Drawing.Point(417, 122);
            this.btOk.Name = "btOk";
            this.btOk.Size = new System.Drawing.Size(85, 34);
            this.btOk.TabIndex = 6;
            this.btOk.Text = "Ok";
            this.btOk.UseVisualStyleBackColor = true;
            this.btOk.Click += new System.EventHandler(this.btOk_Click);
            // 
            // pctImagem
            // 
            this.pctImagem.Location = new System.Drawing.Point(100, 38);
            this.pctImagem.Name = "pctImagem";
            this.pctImagem.Size = new System.Drawing.Size(81, 81);
            this.pctImagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctImagem.TabIndex = 7;
            this.pctImagem.TabStop = false;
            // 
            // lblMensagem
            // 
            this.lblMensagem.AutoSize = true;
            this.lblMensagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensagem.Location = new System.Drawing.Point(187, 72);
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Size = new System.Drawing.Size(105, 15);
            this.lblMensagem.TabIndex = 8;
            this.lblMensagem.Text = "SUA MENSAGEM";
            // 
            // FrmMensagemOK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(532, 168);
            this.Controls.Add(this.lblMensagem);
            this.Controls.Add(this.pctImagem);
            this.Controls.Add(this.btOk);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMensagemOK";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aviso!";
            ((System.ComponentModel.ISupportInitialize)(this.pctImagem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btOk;
        private System.Windows.Forms.PictureBox pctImagem;
        private System.Windows.Forms.Label lblMensagem;
    }
}