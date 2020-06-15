namespace BancoVirtualSql.View.AcessoRestrito
{
    partial class FrmAreaRestrita {
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rdDesbloqueado = new System.Windows.Forms.RadioButton();
            this.rdBloqueado = new System.Windows.Forms.RadioButton();
            this.btEditar = new System.Windows.Forms.Button();
            this.btBloDesblo = new System.Windows.Forms.Button();
            this.btEcluir = new System.Windows.Forms.Button();
            this.btSair = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.Color.SlateGray;
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(72, 549);
            this.panel1.TabIndex = 1;
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Location = new System.Drawing.Point(269, 86);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(360, 20);
            this.txtPesquisar.TabIndex = 2;
            this.txtPesquisar.TextChanged += new System.EventHandler(this.txtPesquisar_TextChanged);
            this.txtPesquisar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtPesquisar_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(111, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Pesquisar Nome do Titular:";
            // 
            // rdDesbloqueado
            // 
            this.rdDesbloqueado.AutoSize = true;
            this.rdDesbloqueado.Checked = true;
            this.rdDesbloqueado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdDesbloqueado.Location = new System.Drawing.Point(634, 87);
            this.rdDesbloqueado.Name = "rdDesbloqueado";
            this.rdDesbloqueado.Size = new System.Drawing.Size(106, 19);
            this.rdDesbloqueado.TabIndex = 6;
            this.rdDesbloqueado.TabStop = true;
            this.rdDesbloqueado.Text = "Desbloqueada";
            this.rdDesbloqueado.UseVisualStyleBackColor = true;
            this.rdDesbloqueado.CheckedChanged += new System.EventHandler(this.rdDesbloqueado_CheckedChanged);
            // 
            // rdBloqueado
            // 
            this.rdBloqueado.AutoSize = true;
            this.rdBloqueado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdBloqueado.Location = new System.Drawing.Point(743, 87);
            this.rdBloqueado.Name = "rdBloqueado";
            this.rdBloqueado.Size = new System.Drawing.Size(85, 19);
            this.rdBloqueado.TabIndex = 7;
            this.rdBloqueado.Text = "Bloqueada";
            this.rdBloqueado.UseVisualStyleBackColor = true;
            this.rdBloqueado.CheckedChanged += new System.EventHandler(this.rdBloqueado_CheckedChanged);
            // 
            // btEditar
            // 
            this.btEditar.BackColor = System.Drawing.Color.SlateGray;
            this.btEditar.FlatAppearance.BorderSize = 0;
            this.btEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEditar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btEditar.Location = new System.Drawing.Point(111, 488);
            this.btEditar.Name = "btEditar";
            this.btEditar.Size = new System.Drawing.Size(92, 41);
            this.btEditar.TabIndex = 18;
            this.btEditar.Text = "Editar";
            this.btEditar.UseVisualStyleBackColor = false;
            this.btEditar.Click += new System.EventHandler(this.btEditar_Click);
            // 
            // btBloDesblo
            // 
            this.btBloDesblo.BackColor = System.Drawing.Color.SlateGray;
            this.btBloDesblo.FlatAppearance.BorderSize = 0;
            this.btBloDesblo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btBloDesblo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btBloDesblo.Location = new System.Drawing.Point(529, 488);
            this.btBloDesblo.Name = "btBloDesblo";
            this.btBloDesblo.Size = new System.Drawing.Size(92, 41);
            this.btBloDesblo.TabIndex = 20;
            this.btBloDesblo.Text = "Bloquear / Desbloquear";
            this.btBloDesblo.UseVisualStyleBackColor = false;
            this.btBloDesblo.Click += new System.EventHandler(this.btBloDesblo_Click);
            // 
            // btEcluir
            // 
            this.btEcluir.BackColor = System.Drawing.Color.SlateGray;
            this.btEcluir.FlatAppearance.BorderSize = 0;
            this.btEcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btEcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEcluir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btEcluir.Location = new System.Drawing.Point(320, 488);
            this.btEcluir.Name = "btEcluir";
            this.btEcluir.Size = new System.Drawing.Size(92, 41);
            this.btEcluir.TabIndex = 19;
            this.btEcluir.Text = "Excluir";
            this.btEcluir.UseVisualStyleBackColor = false;
            this.btEcluir.Click += new System.EventHandler(this.btEcluir_Click);
            // 
            // btSair
            // 
            this.btSair.BackColor = System.Drawing.Color.SlateGray;
            this.btSair.FlatAppearance.BorderSize = 0;
            this.btSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSair.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btSair.Location = new System.Drawing.Point(738, 488);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(92, 41);
            this.btSair.TabIndex = 21;
            this.btSair.Text = "Sair";
            this.btSair.UseVisualStyleBackColor = false;
            this.btSair.Click += new System.EventHandler(this.btSair_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(395, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 20);
            this.label2.TabIndex = 22;
            this.label2.Text = "Área Restrita";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(109, 110);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(722, 358);
            this.dataGridView1.TabIndex = 23;
            // 
            // FrmAreaRestrita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(876, 545);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btSair);
            this.Controls.Add(this.btBloDesblo);
            this.Controls.Add(this.btEcluir);
            this.Controls.Add(this.btEditar);
            this.Controls.Add(this.rdBloqueado);
            this.Controls.Add(this.rdDesbloqueado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPesquisar);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAreaRestrita";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Area Restrita";
            this.Load += new System.EventHandler(this.FrmAcessoRestrito_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdDesbloqueado;
        private System.Windows.Forms.RadioButton rdBloqueado;
        private System.Windows.Forms.Button btEditar;
        private System.Windows.Forms.Button btBloDesblo;
        private System.Windows.Forms.Button btEcluir;
        private System.Windows.Forms.Button btSair;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}