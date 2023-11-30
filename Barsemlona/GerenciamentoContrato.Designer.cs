namespace Barsemlona
{
    partial class GerenciamentoContrato
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
            this.dgvJogadorContrato = new System.Windows.Forms.DataGridView();
            this.dgvTimeContrato = new System.Windows.Forms.DataGridView();
            this.lblJogadores = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.gpbContratarJogador = new System.Windows.Forms.GroupBox();
            this.cmbPosicaoContrato = new System.Windows.Forms.ComboBox();
            this.lblPosicao = new System.Windows.Forms.Label();
            this.txbNomeContrato = new System.Windows.Forms.TextBox();
            this.lblJogadorContrato = new System.Windows.Forms.Label();
            this.lblNomeTIme = new System.Windows.Forms.Label();
            this.txbTimeContrato = new System.Windows.Forms.TextBox();
            this.lblValorContrato = new System.Windows.Forms.Label();
            this.txbValorContrato = new System.Windows.Forms.TextBox();
            this.lblDataContrato = new System.Windows.Forms.Label();
            this.dtpDataContrato = new System.Windows.Forms.DateTimePicker();
            this.btnContratar = new System.Windows.Forms.Button();
            this.lblIdJogador = new System.Windows.Forms.Label();
            this.txbIdJogador = new System.Windows.Forms.TextBox();
            this.lblIdTime = new System.Windows.Forms.Label();
            this.txbIdTime = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJogadorContrato)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimeContrato)).BeginInit();
            this.gpbContratarJogador.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvJogadorContrato
            // 
            this.dgvJogadorContrato.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvJogadorContrato.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvJogadorContrato.Location = new System.Drawing.Point(12, 32);
            this.dgvJogadorContrato.Name = "dgvJogadorContrato";
            this.dgvJogadorContrato.Size = new System.Drawing.Size(334, 177);
            this.dgvJogadorContrato.TabIndex = 0;
            this.dgvJogadorContrato.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvJogadorContrato_CellClick);
            // 
            // dgvTimeContrato
            // 
            this.dgvTimeContrato.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTimeContrato.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTimeContrato.Location = new System.Drawing.Point(352, 32);
            this.dgvTimeContrato.Name = "dgvTimeContrato";
            this.dgvTimeContrato.Size = new System.Drawing.Size(343, 177);
            this.dgvTimeContrato.TabIndex = 1;
            this.dgvTimeContrato.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTimeContrato_CellClick);
            // 
            // lblJogadores
            // 
            this.lblJogadores.AutoSize = true;
            this.lblJogadores.BackColor = System.Drawing.Color.Transparent;
            this.lblJogadores.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJogadores.ForeColor = System.Drawing.Color.White;
            this.lblJogadores.Location = new System.Drawing.Point(134, 9);
            this.lblJogadores.Name = "lblJogadores";
            this.lblJogadores.Size = new System.Drawing.Size(93, 20);
            this.lblJogadores.TabIndex = 6;
            this.lblJogadores.Text = "Jogadores";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.BackColor = System.Drawing.Color.Transparent;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.White;
            this.lblTime.Location = new System.Drawing.Point(470, 9);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(56, 20);
            this.lblTime.TabIndex = 7;
            this.lblTime.Text = "Times";
            // 
            // gpbContratarJogador
            // 
            this.gpbContratarJogador.BackColor = System.Drawing.SystemColors.ControlLight;
            this.gpbContratarJogador.Controls.Add(this.txbIdTime);
            this.gpbContratarJogador.Controls.Add(this.lblIdTime);
            this.gpbContratarJogador.Controls.Add(this.txbIdJogador);
            this.gpbContratarJogador.Controls.Add(this.lblIdJogador);
            this.gpbContratarJogador.Controls.Add(this.btnContratar);
            this.gpbContratarJogador.Controls.Add(this.dtpDataContrato);
            this.gpbContratarJogador.Controls.Add(this.lblDataContrato);
            this.gpbContratarJogador.Controls.Add(this.txbValorContrato);
            this.gpbContratarJogador.Controls.Add(this.lblValorContrato);
            this.gpbContratarJogador.Controls.Add(this.txbTimeContrato);
            this.gpbContratarJogador.Controls.Add(this.lblNomeTIme);
            this.gpbContratarJogador.Controls.Add(this.cmbPosicaoContrato);
            this.gpbContratarJogador.Controls.Add(this.lblPosicao);
            this.gpbContratarJogador.Controls.Add(this.txbNomeContrato);
            this.gpbContratarJogador.Controls.Add(this.lblJogadorContrato);
            this.gpbContratarJogador.Enabled = false;
            this.gpbContratarJogador.Location = new System.Drawing.Point(220, 225);
            this.gpbContratarJogador.Name = "gpbContratarJogador";
            this.gpbContratarJogador.Size = new System.Drawing.Size(244, 334);
            this.gpbContratarJogador.TabIndex = 8;
            this.gpbContratarJogador.TabStop = false;
            this.gpbContratarJogador.Text = "Contrato Jogador";
            // 
            // cmbPosicaoContrato
            // 
            this.cmbPosicaoContrato.Enabled = false;
            this.cmbPosicaoContrato.FormattingEnabled = true;
            this.cmbPosicaoContrato.Items.AddRange(new object[] {
            "1- GOL",
            "2- ZAG",
            "3- LD",
            "4- LE",
            "5- VOL",
            "6- ME",
            "7- MD",
            "8- MC",
            "9- ATA",
            "10- PD",
            "11- PE"});
            this.cmbPosicaoContrato.Location = new System.Drawing.Point(73, 84);
            this.cmbPosicaoContrato.Name = "cmbPosicaoContrato";
            this.cmbPosicaoContrato.Size = new System.Drawing.Size(121, 21);
            this.cmbPosicaoContrato.TabIndex = 3;
            // 
            // lblPosicao
            // 
            this.lblPosicao.AutoSize = true;
            this.lblPosicao.Location = new System.Drawing.Point(13, 87);
            this.lblPosicao.Name = "lblPosicao";
            this.lblPosicao.Size = new System.Drawing.Size(45, 13);
            this.lblPosicao.TabIndex = 2;
            this.lblPosicao.Text = "Posição";
            // 
            // txbNomeContrato
            // 
            this.txbNomeContrato.Enabled = false;
            this.txbNomeContrato.Location = new System.Drawing.Point(107, 58);
            this.txbNomeContrato.Name = "txbNomeContrato";
            this.txbNomeContrato.ReadOnly = true;
            this.txbNomeContrato.Size = new System.Drawing.Size(100, 20);
            this.txbNomeContrato.TabIndex = 1;
            // 
            // lblJogadorContrato
            // 
            this.lblJogadorContrato.AutoSize = true;
            this.lblJogadorContrato.Location = new System.Drawing.Point(10, 58);
            this.lblJogadorContrato.Name = "lblJogadorContrato";
            this.lblJogadorContrato.Size = new System.Drawing.Size(91, 13);
            this.lblJogadorContrato.TabIndex = 0;
            this.lblJogadorContrato.Text = "Nome do Jogador";
            // 
            // lblNomeTIme
            // 
            this.lblNomeTIme.AutoSize = true;
            this.lblNomeTIme.Location = new System.Drawing.Point(10, 170);
            this.lblNomeTIme.Name = "lblNomeTIme";
            this.lblNomeTIme.Size = new System.Drawing.Size(76, 13);
            this.lblNomeTIme.TabIndex = 10;
            this.lblNomeTIme.Text = "Nome do Time";
            // 
            // txbTimeContrato
            // 
            this.txbTimeContrato.Enabled = false;
            this.txbTimeContrato.Location = new System.Drawing.Point(94, 167);
            this.txbTimeContrato.Name = "txbTimeContrato";
            this.txbTimeContrato.ReadOnly = true;
            this.txbTimeContrato.Size = new System.Drawing.Size(100, 20);
            this.txbTimeContrato.TabIndex = 11;
            // 
            // lblValorContrato
            // 
            this.lblValorContrato.AutoSize = true;
            this.lblValorContrato.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorContrato.Location = new System.Drawing.Point(73, 240);
            this.lblValorContrato.Name = "lblValorContrato";
            this.lblValorContrato.Size = new System.Drawing.Size(111, 16);
            this.lblValorContrato.TabIndex = 12;
            this.lblValorContrato.Text = "Valor do Contrato";
            // 
            // txbValorContrato
            // 
            this.txbValorContrato.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbValorContrato.Location = new System.Drawing.Point(52, 259);
            this.txbValorContrato.Name = "txbValorContrato";
            this.txbValorContrato.Size = new System.Drawing.Size(155, 22);
            this.txbValorContrato.TabIndex = 13;
            // 
            // lblDataContrato
            // 
            this.lblDataContrato.AutoSize = true;
            this.lblDataContrato.Location = new System.Drawing.Point(10, 206);
            this.lblDataContrato.Name = "lblDataContrato";
            this.lblDataContrato.Size = new System.Drawing.Size(88, 13);
            this.lblDataContrato.TabIndex = 14;
            this.lblDataContrato.Text = "Data do Contrato";
            // 
            // dtpDataContrato
            // 
            this.dtpDataContrato.Location = new System.Drawing.Point(107, 200);
            this.dtpDataContrato.Name = "dtpDataContrato";
            this.dtpDataContrato.Size = new System.Drawing.Size(131, 20);
            this.dtpDataContrato.TabIndex = 15;
            // 
            // btnContratar
            // 
            this.btnContratar.Location = new System.Drawing.Point(52, 287);
            this.btnContratar.Name = "btnContratar";
            this.btnContratar.Size = new System.Drawing.Size(155, 26);
            this.btnContratar.TabIndex = 16;
            this.btnContratar.Text = "Contratar";
            this.btnContratar.UseVisualStyleBackColor = true;
            this.btnContratar.Click += new System.EventHandler(this.btnContratar_Click);
            // 
            // lblIdJogador
            // 
            this.lblIdJogador.AutoSize = true;
            this.lblIdJogador.Location = new System.Drawing.Point(13, 30);
            this.lblIdJogador.Name = "lblIdJogador";
            this.lblIdJogador.Size = new System.Drawing.Size(57, 13);
            this.lblIdJogador.TabIndex = 17;
            this.lblIdJogador.Text = "Id Jogador";
            // 
            // txbIdJogador
            // 
            this.txbIdJogador.Enabled = false;
            this.txbIdJogador.Location = new System.Drawing.Point(76, 27);
            this.txbIdJogador.Name = "txbIdJogador";
            this.txbIdJogador.Size = new System.Drawing.Size(100, 20);
            this.txbIdJogador.TabIndex = 18;
            // 
            // lblIdTime
            // 
            this.lblIdTime.AutoSize = true;
            this.lblIdTime.Location = new System.Drawing.Point(13, 145);
            this.lblIdTime.Name = "lblIdTime";
            this.lblIdTime.Size = new System.Drawing.Size(57, 13);
            this.lblIdTime.TabIndex = 19;
            this.lblIdTime.Text = "Id do Time";
            // 
            // txbIdTime
            // 
            this.txbIdTime.Location = new System.Drawing.Point(76, 141);
            this.txbIdTime.Name = "txbIdTime";
            this.txbIdTime.Size = new System.Drawing.Size(100, 20);
            this.txbIdTime.TabIndex = 20;
            // 
            // GerenciamentoContrato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Barsemlona.Properties.Resources.dylan_gillis_KdeqA3aTnBY_unsplash;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(700, 562);
            this.Controls.Add(this.gpbContratarJogador);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblJogadores);
            this.Controls.Add(this.dgvTimeContrato);
            this.Controls.Add(this.dgvJogadorContrato);
            this.Name = "GerenciamentoContrato";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GerenciamentoContrato";
            this.Load += new System.EventHandler(this.GerenciamentoContrato_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvJogadorContrato)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimeContrato)).EndInit();
            this.gpbContratarJogador.ResumeLayout(false);
            this.gpbContratarJogador.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvJogadorContrato;
        private System.Windows.Forms.DataGridView dgvTimeContrato;
        private System.Windows.Forms.Label lblJogadores;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.GroupBox gpbContratarJogador;
        private System.Windows.Forms.ComboBox cmbPosicaoContrato;
        private System.Windows.Forms.Label lblPosicao;
        private System.Windows.Forms.TextBox txbNomeContrato;
        private System.Windows.Forms.Label lblJogadorContrato;
        private System.Windows.Forms.Label lblNomeTIme;
        private System.Windows.Forms.DateTimePicker dtpDataContrato;
        private System.Windows.Forms.Label lblDataContrato;
        private System.Windows.Forms.TextBox txbValorContrato;
        private System.Windows.Forms.Label lblValorContrato;
        private System.Windows.Forms.TextBox txbTimeContrato;
        private System.Windows.Forms.Button btnContratar;
        private System.Windows.Forms.TextBox txbIdJogador;
        private System.Windows.Forms.Label lblIdJogador;
        private System.Windows.Forms.TextBox txbIdTime;
        private System.Windows.Forms.Label lblIdTime;
    }
}