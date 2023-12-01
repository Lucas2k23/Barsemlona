namespace Barsemlona
{
    partial class TelaDeInicio
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
            this.btnJogadores = new System.Windows.Forms.Button();
            this.btnTimes = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnContrato = new System.Windows.Forms.Button();
            this.btnGerenciamentoContrato = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnJogadores
            // 
            this.btnJogadores.Location = new System.Drawing.Point(279, 180);
            this.btnJogadores.Name = "btnJogadores";
            this.btnJogadores.Size = new System.Drawing.Size(75, 23);
            this.btnJogadores.TabIndex = 5;
            this.btnJogadores.Text = "Jogadores";
            this.btnJogadores.UseVisualStyleBackColor = true;
            this.btnJogadores.Click += new System.EventHandler(this.btnJogadores_Click);
            // 
            // btnTimes
            // 
            this.btnTimes.Location = new System.Drawing.Point(87, 180);
            this.btnTimes.Name = "btnTimes";
            this.btnTimes.Size = new System.Drawing.Size(75, 23);
            this.btnTimes.TabIndex = 4;
            this.btnTimes.Text = "Times";
            this.btnTimes.UseVisualStyleBackColor = true;
            this.btnTimes.Click += new System.EventHandler(this.btnTimes_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Barsemlona.Properties.Resources.sair;
            this.pictureBox1.Location = new System.Drawing.Point(402, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(57, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnContrato
            // 
            this.btnContrato.Location = new System.Drawing.Point(179, 212);
            this.btnContrato.Name = "btnContrato";
            this.btnContrato.Size = new System.Drawing.Size(87, 23);
            this.btnContrato.TabIndex = 7;
            this.btnContrato.Text = "Contratos";
            this.btnContrato.UseVisualStyleBackColor = true;
            this.btnContrato.Click += new System.EventHandler(this.btnContrato_Click);
            // 
            // btnGerenciamentoContrato
            // 
            this.btnGerenciamentoContrato.Location = new System.Drawing.Point(137, 241);
            this.btnGerenciamentoContrato.Name = "btnGerenciamentoContrato";
            this.btnGerenciamentoContrato.Size = new System.Drawing.Size(168, 23);
            this.btnGerenciamentoContrato.TabIndex = 8;
            this.btnGerenciamentoContrato.Text = "Gerenciamento de Contrato";
            this.btnGerenciamentoContrato.UseVisualStyleBackColor = true;
            this.btnGerenciamentoContrato.Click += new System.EventHandler(this.button1_Click);
            // 
            // TelaDeInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Barsemlona.Properties.Resources.inicio;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(460, 301);
            this.Controls.Add(this.btnGerenciamentoContrato);
            this.Controls.Add(this.btnContrato);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnJogadores);
            this.Controls.Add(this.btnTimes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TelaDeInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bar sem lona";
            this.Activated += new System.EventHandler(this.TelaDeFundo_Activated);
            this.Load += new System.EventHandler(this.TelaDeFundo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnJogadores;
        private System.Windows.Forms.Button btnTimes;
        private System.Windows.Forms.Button btnContrato;
        private System.Windows.Forms.Button btnGerenciamentoContrato;
    }
}