namespace BancoVirtualSql.View.Conta_Corrente
{
    partial class FrmLancamento
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
            this.btCancelar = new System.Windows.Forms.Button();
            this.btLancar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.lblLanc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.Color.SlateGray;
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(72, 225);
            this.panel1.TabIndex = 6;
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(246, 150);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(86, 33);
            this.btCancelar.TabIndex = 24;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // btLancar
            // 
            this.btLancar.Location = new System.Drawing.Point(133, 150);
            this.btLancar.Name = "btLancar";
            this.btLancar.Size = new System.Drawing.Size(86, 33);
            this.btLancar.TabIndex = 23;
            this.btLancar.Text = "Salvar";
            this.btLancar.UseVisualStyleBackColor = true;
            this.btLancar.Click += new System.EventHandler(this.btLancar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(123, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Informe o Valor:";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(217, 81);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(115, 20);
            this.txtValor.TabIndex = 21;
            this.txtValor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValor_KeyPress);
            // 
            // lblLanc
            // 
            this.lblLanc.AutoSize = true;
            this.lblLanc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLanc.Location = new System.Drawing.Point(191, 23);
            this.lblLanc.Name = "lblLanc";
            this.lblLanc.Size = new System.Drawing.Size(82, 16);
            this.lblLanc.TabIndex = 25;
            this.lblLanc.Text = "Lançamento";
            // 
            // FrmLancamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(401, 220);
            this.Controls.Add(this.lblLanc);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btLancar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmLancamento";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lançamento";
            this.Load += new System.EventHandler(this.FrmLancamento_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Button btLancar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label lblLanc;
    }
}