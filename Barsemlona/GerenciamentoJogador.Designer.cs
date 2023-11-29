namespace Barsemlona
{
    partial class GerenciamentoJogador
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
            this.dgvJogador = new System.Windows.Forms.DataGridView();
            this.gpbApagarJogador = new System.Windows.Forms.GroupBox();
            this.lblInformacaoApagar = new System.Windows.Forms.Label();
            this.btnApagar = new System.Windows.Forms.Button();
            this.txbApagarNome = new System.Windows.Forms.TextBox();
            this.lblNomeApagar = new System.Windows.Forms.Label();
            this.gpbCadastrarJogador = new System.Windows.Forms.GroupBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.cmbPosicao = new System.Windows.Forms.ComboBox();
            this.lblPosicao = new System.Windows.Forms.Label();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.lblNomeJogador = new System.Windows.Forms.Label();
            this.lblDataNascimento = new System.Windows.Forms.Label();
            this.gpbJogadorEditar = new System.Windows.Forms.GroupBox();
            this.lblDataEdit = new System.Windows.Forms.Label();
            this.btnEditar = new System.Windows.Forms.Button();
            this.lblPosicaoEdit = new System.Windows.Forms.Label();
            this.txbNomeEdit = new System.Windows.Forms.TextBox();
            this.lblNomeEdit = new System.Windows.Forms.Label();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.dtpDataEdit = new System.Windows.Forms.DateTimePicker();
            this.cmbPosicaoEdit = new System.Windows.Forms.ComboBox();
            this.lblId = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJogador)).BeginInit();
            this.gpbApagarJogador.SuspendLayout();
            this.gpbCadastrarJogador.SuspendLayout();
            this.gpbJogadorEditar.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvJogador
            // 
            this.dgvJogador.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvJogador.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvJogador.Location = new System.Drawing.Point(11, 12);
            this.dgvJogador.Name = "dgvJogador";
            this.dgvJogador.Size = new System.Drawing.Size(777, 230);
            this.dgvJogador.TabIndex = 0;
            this.dgvJogador.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvJogador_CellClick);
            // 
            // gpbApagarJogador
            // 
            this.gpbApagarJogador.BackColor = System.Drawing.SystemColors.ControlLight;
            this.gpbApagarJogador.Controls.Add(this.lblId);
            this.gpbApagarJogador.Controls.Add(this.lblInformacaoApagar);
            this.gpbApagarJogador.Controls.Add(this.btnApagar);
            this.gpbApagarJogador.Controls.Add(this.txbApagarNome);
            this.gpbApagarJogador.Controls.Add(this.lblNomeApagar);
            this.gpbApagarJogador.Enabled = false;
            this.gpbApagarJogador.Location = new System.Drawing.Point(543, 264);
            this.gpbApagarJogador.Name = "gpbApagarJogador";
            this.gpbApagarJogador.Size = new System.Drawing.Size(245, 190);
            this.gpbApagarJogador.TabIndex = 9;
            this.gpbApagarJogador.TabStop = false;
            this.gpbApagarJogador.Text = "Apagar Jogador";
            // 
            // lblInformacaoApagar
            // 
            this.lblInformacaoApagar.AutoSize = true;
            this.lblInformacaoApagar.Location = new System.Drawing.Point(31, 69);
            this.lblInformacaoApagar.Name = "lblInformacaoApagar";
            this.lblInformacaoApagar.Size = new System.Drawing.Size(0, 13);
            this.lblInformacaoApagar.TabIndex = 5;
            // 
            // btnApagar
            // 
            this.btnApagar.BackColor = System.Drawing.Color.Red;
            this.btnApagar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnApagar.Location = new System.Drawing.Point(27, 115);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(183, 43);
            this.btnApagar.TabIndex = 4;
            this.btnApagar.Text = "Apagar";
            this.btnApagar.UseVisualStyleBackColor = false;
            this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click);
            // 
            // txbApagarNome
            // 
            this.txbApagarNome.Location = new System.Drawing.Point(110, 28);
            this.txbApagarNome.Name = "txbApagarNome";
            this.txbApagarNome.Size = new System.Drawing.Size(100, 20);
            this.txbApagarNome.TabIndex = 1;
            // 
            // lblNomeApagar
            // 
            this.lblNomeApagar.AutoSize = true;
            this.lblNomeApagar.Location = new System.Drawing.Point(10, 31);
            this.lblNomeApagar.Name = "lblNomeApagar";
            this.lblNomeApagar.Size = new System.Drawing.Size(91, 13);
            this.lblNomeApagar.TabIndex = 0;
            this.lblNomeApagar.Text = "Nome do Jogador";
            // 
            // gpbCadastrarJogador
            // 
            this.gpbCadastrarJogador.BackColor = System.Drawing.SystemColors.ControlLight;
            this.gpbCadastrarJogador.Controls.Add(this.dtpData);
            this.gpbCadastrarJogador.Controls.Add(this.lblDataNascimento);
            this.gpbCadastrarJogador.Controls.Add(this.btnCadastrar);
            this.gpbCadastrarJogador.Controls.Add(this.cmbPosicao);
            this.gpbCadastrarJogador.Controls.Add(this.lblPosicao);
            this.gpbCadastrarJogador.Controls.Add(this.txbNome);
            this.gpbCadastrarJogador.Controls.Add(this.lblNomeJogador);
            this.gpbCadastrarJogador.Location = new System.Drawing.Point(11, 264);
            this.gpbCadastrarJogador.Name = "gpbCadastrarJogador";
            this.gpbCadastrarJogador.Size = new System.Drawing.Size(245, 212);
            this.gpbCadastrarJogador.TabIndex = 7;
            this.gpbCadastrarJogador.TabStop = false;
            this.gpbCadastrarJogador.Text = "Cadastrar Jogador";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.Chartreuse;
            this.btnCadastrar.Location = new System.Drawing.Point(24, 147);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(183, 43);
            this.btnCadastrar.TabIndex = 4;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // cmbPosicao
            // 
            this.cmbPosicao.FormattingEnabled = true;
            this.cmbPosicao.Items.AddRange(new object[] {
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
            this.cmbPosicao.Location = new System.Drawing.Point(72, 69);
            this.cmbPosicao.Name = "cmbPosicao";
            this.cmbPosicao.Size = new System.Drawing.Size(121, 21);
            this.cmbPosicao.TabIndex = 3;
            // 
            // lblPosicao
            // 
            this.lblPosicao.AutoSize = true;
            this.lblPosicao.Location = new System.Drawing.Point(13, 72);
            this.lblPosicao.Name = "lblPosicao";
            this.lblPosicao.Size = new System.Drawing.Size(45, 13);
            this.lblPosicao.TabIndex = 2;
            this.lblPosicao.Text = "Posição";
            // 
            // txbNome
            // 
            this.txbNome.Location = new System.Drawing.Point(107, 31);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(100, 20);
            this.txbNome.TabIndex = 1;
            // 
            // lblNomeJogador
            // 
            this.lblNomeJogador.AutoSize = true;
            this.lblNomeJogador.Location = new System.Drawing.Point(10, 31);
            this.lblNomeJogador.Name = "lblNomeJogador";
            this.lblNomeJogador.Size = new System.Drawing.Size(91, 13);
            this.lblNomeJogador.TabIndex = 0;
            this.lblNomeJogador.Text = "Nome do Jogador";
            // 
            // lblDataNascimento
            // 
            this.lblDataNascimento.AutoSize = true;
            this.lblDataNascimento.Location = new System.Drawing.Point(13, 115);
            this.lblDataNascimento.Name = "lblDataNascimento";
            this.lblDataNascimento.Size = new System.Drawing.Size(89, 13);
            this.lblDataNascimento.TabIndex = 5;
            this.lblDataNascimento.Text = "Data Nascimento";
            // 
            // gpbJogadorEditar
            // 
            this.gpbJogadorEditar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.gpbJogadorEditar.Controls.Add(this.cmbPosicaoEdit);
            this.gpbJogadorEditar.Controls.Add(this.dtpDataEdit);
            this.gpbJogadorEditar.Controls.Add(this.lblDataEdit);
            this.gpbJogadorEditar.Controls.Add(this.btnEditar);
            this.gpbJogadorEditar.Controls.Add(this.lblPosicaoEdit);
            this.gpbJogadorEditar.Controls.Add(this.txbNomeEdit);
            this.gpbJogadorEditar.Controls.Add(this.lblNomeEdit);
            this.gpbJogadorEditar.Enabled = false;
            this.gpbJogadorEditar.Location = new System.Drawing.Point(273, 264);
            this.gpbJogadorEditar.Name = "gpbJogadorEditar";
            this.gpbJogadorEditar.Size = new System.Drawing.Size(245, 212);
            this.gpbJogadorEditar.TabIndex = 10;
            this.gpbJogadorEditar.TabStop = false;
            this.gpbJogadorEditar.Text = "Editar Jogador";
            // 
            // lblDataEdit
            // 
            this.lblDataEdit.AutoSize = true;
            this.lblDataEdit.Location = new System.Drawing.Point(13, 115);
            this.lblDataEdit.Name = "lblDataEdit";
            this.lblDataEdit.Size = new System.Drawing.Size(89, 13);
            this.lblDataEdit.TabIndex = 5;
            this.lblDataEdit.Text = "Data Nascimento";
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnEditar.Location = new System.Drawing.Point(24, 147);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(183, 43);
            this.btnEditar.TabIndex = 4;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // lblPosicaoEdit
            // 
            this.lblPosicaoEdit.AutoSize = true;
            this.lblPosicaoEdit.Location = new System.Drawing.Point(13, 72);
            this.lblPosicaoEdit.Name = "lblPosicaoEdit";
            this.lblPosicaoEdit.Size = new System.Drawing.Size(45, 13);
            this.lblPosicaoEdit.TabIndex = 2;
            this.lblPosicaoEdit.Text = "Posição";
            // 
            // txbNomeEdit
            // 
            this.txbNomeEdit.Location = new System.Drawing.Point(107, 31);
            this.txbNomeEdit.Name = "txbNomeEdit";
            this.txbNomeEdit.Size = new System.Drawing.Size(100, 20);
            this.txbNomeEdit.TabIndex = 1;
            // 
            // lblNomeEdit
            // 
            this.lblNomeEdit.AutoSize = true;
            this.lblNomeEdit.Location = new System.Drawing.Point(10, 31);
            this.lblNomeEdit.Name = "lblNomeEdit";
            this.lblNomeEdit.Size = new System.Drawing.Size(91, 13);
            this.lblNomeEdit.TabIndex = 0;
            this.lblNomeEdit.Text = "Nome do Jogador";
            // 
            // dtpData
            // 
            this.dtpData.Location = new System.Drawing.Point(107, 115);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(132, 20);
            this.dtpData.TabIndex = 9;
            // 
            // dtpDataEdit
            // 
            this.dtpDataEdit.Location = new System.Drawing.Point(107, 115);
            this.dtpDataEdit.Name = "dtpDataEdit";
            this.dtpDataEdit.Size = new System.Drawing.Size(132, 20);
            this.dtpDataEdit.TabIndex = 10;
            // 
            // cmbPosicaoEdit
            // 
            this.cmbPosicaoEdit.FormattingEnabled = true;
            this.cmbPosicaoEdit.Items.AddRange(new object[] {
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
            this.cmbPosicaoEdit.Location = new System.Drawing.Point(86, 72);
            this.cmbPosicaoEdit.Name = "cmbPosicaoEdit";
            this.cmbPosicaoEdit.Size = new System.Drawing.Size(121, 21);
            this.cmbPosicaoEdit.TabIndex = 11;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(6, 69);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(19, 13);
            this.lblId.TabIndex = 6;
            this.lblId.Text = "Id:";
            // 
            // GerenciamentoJogador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Barsemlona.Properties.Resources.inicio;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 503);
            this.Controls.Add(this.gpbJogadorEditar);
            this.Controls.Add(this.gpbApagarJogador);
            this.Controls.Add(this.gpbCadastrarJogador);
            this.Controls.Add(this.dgvJogador);
            this.Name = "GerenciamentoJogador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            ((System.ComponentModel.ISupportInitialize)(this.dgvJogador)).EndInit();
            this.gpbApagarJogador.ResumeLayout(false);
            this.gpbApagarJogador.PerformLayout();
            this.gpbCadastrarJogador.ResumeLayout(false);
            this.gpbCadastrarJogador.PerformLayout();
            this.gpbJogadorEditar.ResumeLayout(false);
            this.gpbJogadorEditar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvJogador;
        private System.Windows.Forms.GroupBox gpbApagarJogador;
        private System.Windows.Forms.Label lblInformacaoApagar;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.TextBox txbApagarNome;
        private System.Windows.Forms.Label lblNomeApagar;
        private System.Windows.Forms.GroupBox gpbCadastrarJogador;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.ComboBox cmbPosicao;
        private System.Windows.Forms.Label lblPosicao;
        private System.Windows.Forms.TextBox txbNome;
        private System.Windows.Forms.Label lblNomeJogador;
        private System.Windows.Forms.Label lblDataNascimento;
        private System.Windows.Forms.GroupBox gpbJogadorEditar;
        private System.Windows.Forms.Label lblDataEdit;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Label lblPosicaoEdit;
        private System.Windows.Forms.TextBox txbNomeEdit;
        private System.Windows.Forms.Label lblNomeEdit;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.DateTimePicker dtpDataEdit;
        private System.Windows.Forms.ComboBox cmbPosicaoEdit;
        private System.Windows.Forms.Label lblId;
    }
}