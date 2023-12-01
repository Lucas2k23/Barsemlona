namespace Barsemlona
{
    partial class GerenciamentoContratados
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
            this.dgvContratados = new System.Windows.Forms.DataGridView();
            this.gpbDispensarJogador = new System.Windows.Forms.GroupBox();
            this.txbIdContrato = new System.Windows.Forms.TextBox();
            this.lblIdContrato = new System.Windows.Forms.Label();
            this.btnEditarContrato = new System.Windows.Forms.Button();
            this.dtpDataContratado = new System.Windows.Forms.DateTimePicker();
            this.lblDataContrato = new System.Windows.Forms.Label();
            this.txbValorNegociado = new System.Windows.Forms.TextBox();
            this.lblValorContrato = new System.Windows.Forms.Label();
            this.txbContratante = new System.Windows.Forms.TextBox();
            this.lblNomeTIme = new System.Windows.Forms.Label();
            this.txbNomeContratado = new System.Windows.Forms.TextBox();
            this.lblJogadorContrato = new System.Windows.Forms.Label();
            this.btnDispensar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContratados)).BeginInit();
            this.gpbDispensarJogador.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvContratados
            // 
            this.dgvContratados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvContratados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContratados.Location = new System.Drawing.Point(102, 0);
            this.dgvContratados.Name = "dgvContratados";
            this.dgvContratados.ReadOnly = true;
            this.dgvContratados.Size = new System.Drawing.Size(551, 181);
            this.dgvContratados.TabIndex = 0;
            this.dgvContratados.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvContratados_CellClick);
            this.dgvContratados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvContratados_CellContentClick);
            // 
            // gpbDispensarJogador
            // 
            this.gpbDispensarJogador.BackColor = System.Drawing.SystemColors.ControlLight;
            this.gpbDispensarJogador.Controls.Add(this.btnDispensar);
            this.gpbDispensarJogador.Controls.Add(this.txbIdContrato);
            this.gpbDispensarJogador.Controls.Add(this.lblIdContrato);
            this.gpbDispensarJogador.Controls.Add(this.btnEditarContrato);
            this.gpbDispensarJogador.Controls.Add(this.dtpDataContratado);
            this.gpbDispensarJogador.Controls.Add(this.lblDataContrato);
            this.gpbDispensarJogador.Controls.Add(this.txbValorNegociado);
            this.gpbDispensarJogador.Controls.Add(this.lblValorContrato);
            this.gpbDispensarJogador.Controls.Add(this.txbContratante);
            this.gpbDispensarJogador.Controls.Add(this.lblNomeTIme);
            this.gpbDispensarJogador.Controls.Add(this.txbNomeContratado);
            this.gpbDispensarJogador.Controls.Add(this.lblJogadorContrato);
            this.gpbDispensarJogador.Enabled = false;
            this.gpbDispensarJogador.Location = new System.Drawing.Point(126, 187);
            this.gpbDispensarJogador.Name = "gpbDispensarJogador";
            this.gpbDispensarJogador.Size = new System.Drawing.Size(511, 255);
            this.gpbDispensarJogador.TabIndex = 9;
            this.gpbDispensarJogador.TabStop = false;
            this.gpbDispensarJogador.Text = "Gerenciar Contrato";
            // 
            // txbIdContrato
            // 
            this.txbIdContrato.Enabled = false;
            this.txbIdContrato.Location = new System.Drawing.Point(76, 32);
            this.txbIdContrato.Name = "txbIdContrato";
            this.txbIdContrato.Size = new System.Drawing.Size(100, 20);
            this.txbIdContrato.TabIndex = 18;
            // 
            // lblIdContrato
            // 
            this.lblIdContrato.AutoSize = true;
            this.lblIdContrato.Location = new System.Drawing.Point(13, 35);
            this.lblIdContrato.Name = "lblIdContrato";
            this.lblIdContrato.Size = new System.Drawing.Size(59, 13);
            this.lblIdContrato.TabIndex = 17;
            this.lblIdContrato.Text = "Id Contrato";
            // 
            // btnEditarContrato
            // 
            this.btnEditarContrato.Enabled = false;
            this.btnEditarContrato.Location = new System.Drawing.Point(167, 180);
            this.btnEditarContrato.Name = "btnEditarContrato";
            this.btnEditarContrato.Size = new System.Drawing.Size(155, 26);
            this.btnEditarContrato.TabIndex = 16;
            this.btnEditarContrato.Text = "Editar";
            this.btnEditarContrato.UseVisualStyleBackColor = true;
            this.btnEditarContrato.Click += new System.EventHandler(this.btnEditarContrato_Click);
            // 
            // dtpDataContratado
            // 
            this.dtpDataContratado.Enabled = false;
            this.dtpDataContratado.Location = new System.Drawing.Point(364, 65);
            this.dtpDataContratado.Name = "dtpDataContratado";
            this.dtpDataContratado.Size = new System.Drawing.Size(131, 20);
            this.dtpDataContratado.TabIndex = 15;
            // 
            // lblDataContrato
            // 
            this.lblDataContrato.AutoSize = true;
            this.lblDataContrato.Location = new System.Drawing.Point(267, 71);
            this.lblDataContrato.Name = "lblDataContrato";
            this.lblDataContrato.Size = new System.Drawing.Size(88, 13);
            this.lblDataContrato.TabIndex = 14;
            this.lblDataContrato.Text = "Data do Contrato";
            // 
            // txbValorNegociado
            // 
            this.txbValorNegociado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbValorNegociado.Location = new System.Drawing.Point(167, 150);
            this.txbValorNegociado.Name = "txbValorNegociado";
            this.txbValorNegociado.Size = new System.Drawing.Size(155, 22);
            this.txbValorNegociado.TabIndex = 13;
            this.txbValorNegociado.TextChanged += new System.EventHandler(this.txbValorContrato_TextChanged);
            // 
            // lblValorContrato
            // 
            this.lblValorContrato.AutoSize = true;
            this.lblValorContrato.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorContrato.Location = new System.Drawing.Point(192, 121);
            this.lblValorContrato.Name = "lblValorContrato";
            this.lblValorContrato.Size = new System.Drawing.Size(111, 16);
            this.lblValorContrato.TabIndex = 12;
            this.lblValorContrato.Text = "Valor do Contrato";
            this.lblValorContrato.Click += new System.EventHandler(this.lblValorContrato_Click);
            // 
            // txbContratante
            // 
            this.txbContratante.Enabled = false;
            this.txbContratante.Location = new System.Drawing.Point(351, 32);
            this.txbContratante.Name = "txbContratante";
            this.txbContratante.ReadOnly = true;
            this.txbContratante.Size = new System.Drawing.Size(100, 20);
            this.txbContratante.TabIndex = 11;
            // 
            // lblNomeTIme
            // 
            this.lblNomeTIme.AutoSize = true;
            this.lblNomeTIme.Location = new System.Drawing.Point(267, 35);
            this.lblNomeTIme.Name = "lblNomeTIme";
            this.lblNomeTIme.Size = new System.Drawing.Size(76, 13);
            this.lblNomeTIme.TabIndex = 10;
            this.lblNomeTIme.Text = "Nome do Time";
            // 
            // txbNomeContratado
            // 
            this.txbNomeContratado.Enabled = false;
            this.txbNomeContratado.Location = new System.Drawing.Point(107, 58);
            this.txbNomeContratado.Name = "txbNomeContratado";
            this.txbNomeContratado.ReadOnly = true;
            this.txbNomeContratado.Size = new System.Drawing.Size(100, 20);
            this.txbNomeContratado.TabIndex = 1;
            // 
            // lblJogadorContrato
            // 
            this.lblJogadorContrato.AutoSize = true;
            this.lblJogadorContrato.Location = new System.Drawing.Point(10, 63);
            this.lblJogadorContrato.Name = "lblJogadorContrato";
            this.lblJogadorContrato.Size = new System.Drawing.Size(91, 13);
            this.lblJogadorContrato.TabIndex = 0;
            this.lblJogadorContrato.Text = "Nome do Jogador";
            // 
            // btnDispensar
            // 
            this.btnDispensar.Enabled = false;
            this.btnDispensar.Location = new System.Drawing.Point(167, 221);
            this.btnDispensar.Name = "btnDispensar";
            this.btnDispensar.Size = new System.Drawing.Size(155, 26);
            this.btnDispensar.TabIndex = 21;
            this.btnDispensar.Text = "Dispensar";
            this.btnDispensar.UseVisualStyleBackColor = true;
            this.btnDispensar.Click += new System.EventHandler(this.btnDispensar_Click);
            // 
            // GerenciamentoContratados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(723, 447);
            this.Controls.Add(this.gpbDispensarJogador);
            this.Controls.Add(this.dgvContratados);
            this.Name = "GerenciamentoContratados";
            this.Text = "GerenciamentoContratados";
            this.Load += new System.EventHandler(this.GerenciamentoContratados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvContratados)).EndInit();
            this.gpbDispensarJogador.ResumeLayout(false);
            this.gpbDispensarJogador.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvContratados;
        private System.Windows.Forms.GroupBox gpbDispensarJogador;
        private System.Windows.Forms.Button btnDispensar;
        private System.Windows.Forms.TextBox txbIdContrato;
        private System.Windows.Forms.Label lblIdContrato;
        private System.Windows.Forms.Button btnEditarContrato;
        private System.Windows.Forms.DateTimePicker dtpDataContratado;
        private System.Windows.Forms.Label lblDataContrato;
        private System.Windows.Forms.TextBox txbValorNegociado;
        private System.Windows.Forms.Label lblValorContrato;
        private System.Windows.Forms.TextBox txbContratante;
        private System.Windows.Forms.Label lblNomeTIme;
        private System.Windows.Forms.TextBox txbNomeContratado;
        private System.Windows.Forms.Label lblJogadorContrato;
    }
}