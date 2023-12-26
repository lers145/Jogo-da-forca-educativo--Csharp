namespace Jogo_da_Forca
{
    partial class FrmInicio
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInicio));
            this.BtnJogar = new System.Windows.Forms.Button();
            this.BtnInstrucoes = new System.Windows.Forms.Button();
            this.BtnFechar = new System.Windows.Forms.Button();
            this.lblforcatitulo = new System.Windows.Forms.Label();
            this.btnautoria = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnJogar
            // 
            this.BtnJogar.BackColor = System.Drawing.Color.Transparent;
            this.BtnJogar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnJogar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnJogar.FlatAppearance.BorderSize = 0;
            this.BtnJogar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnJogar.Font = new System.Drawing.Font("Rudiment", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnJogar.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnJogar.Location = new System.Drawing.Point(318, 128);
            this.BtnJogar.Name = "BtnJogar";
            this.BtnJogar.Size = new System.Drawing.Size(172, 50);
            this.BtnJogar.TabIndex = 2;
            this.BtnJogar.Text = "Jogar";
            this.BtnJogar.UseVisualStyleBackColor = false;
            this.BtnJogar.Click += new System.EventHandler(this.BtnJogar_Click);
            // 
            // BtnInstrucoes
            // 
            this.BtnInstrucoes.BackColor = System.Drawing.Color.Transparent;
            this.BtnInstrucoes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnInstrucoes.FlatAppearance.BorderSize = 0;
            this.BtnInstrucoes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnInstrucoes.Font = new System.Drawing.Font("Rudiment", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnInstrucoes.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnInstrucoes.Location = new System.Drawing.Point(318, 200);
            this.BtnInstrucoes.Name = "BtnInstrucoes";
            this.BtnInstrucoes.Size = new System.Drawing.Size(172, 50);
            this.BtnInstrucoes.TabIndex = 3;
            this.BtnInstrucoes.Text = "Como Jogar";
            this.BtnInstrucoes.UseVisualStyleBackColor = false;
            this.BtnInstrucoes.Click += new System.EventHandler(this.BtnInstrucoes_Click);
            // 
            // BtnFechar
            // 
            this.BtnFechar.BackColor = System.Drawing.Color.Transparent;
            this.BtnFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnFechar.FlatAppearance.BorderSize = 0;
            this.BtnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFechar.Font = new System.Drawing.Font("Rudiment", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFechar.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnFechar.Location = new System.Drawing.Point(318, 270);
            this.BtnFechar.Name = "BtnFechar";
            this.BtnFechar.Size = new System.Drawing.Size(172, 50);
            this.BtnFechar.TabIndex = 4;
            this.BtnFechar.Text = "Fechar";
            this.BtnFechar.UseVisualStyleBackColor = false;
            this.BtnFechar.Click += new System.EventHandler(this.BtnFechar_Click);
            // 
            // lblforcatitulo
            // 
            this.lblforcatitulo.AutoSize = true;
            this.lblforcatitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblforcatitulo.Font = new System.Drawing.Font("Rudiment", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblforcatitulo.Location = new System.Drawing.Point(257, 38);
            this.lblforcatitulo.Name = "lblforcatitulo";
            this.lblforcatitulo.Size = new System.Drawing.Size(295, 47);
            this.lblforcatitulo.TabIndex = 5;
            this.lblforcatitulo.Text = "Jogo da Forca";
            // 
            // btnautoria
            // 
            this.btnautoria.BackColor = System.Drawing.Color.Transparent;
            this.btnautoria.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnautoria.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnautoria.FlatAppearance.BorderSize = 0;
            this.btnautoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnautoria.Font = new System.Drawing.Font("Rudiment", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnautoria.ForeColor = System.Drawing.SystemColors.Control;
            this.btnautoria.Location = new System.Drawing.Point(12, 417);
            this.btnautoria.Name = "btnautoria";
            this.btnautoria.Size = new System.Drawing.Size(100, 32);
            this.btnautoria.TabIndex = 6;
            this.btnautoria.Text = "Autoria";
            this.btnautoria.UseVisualStyleBackColor = false;
            this.btnautoria.Click += new System.EventHandler(this.btnautoria_Click);
            // 
            // FrmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Jogo_da_Forca.Properties.Resources.forcatema;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.btnautoria);
            this.Controls.Add(this.lblforcatitulo);
            this.Controls.Add(this.BtnFechar);
            this.Controls.Add(this.BtnInstrucoes);
            this.Controls.Add(this.BtnJogar);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jogo da Forca";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnJogar;
        private System.Windows.Forms.Button BtnInstrucoes;
        private System.Windows.Forms.Button BtnFechar;
        private System.Windows.Forms.Label lblforcatitulo;
        private System.Windows.Forms.Button btnautoria;
    }
}

