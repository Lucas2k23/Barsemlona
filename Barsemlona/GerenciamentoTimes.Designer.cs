namespace Barsemlona
{
    partial class GerenciamentoTimes
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
            this.dgvTimes = new System.Windows.Forms.DataGridView();
            this.gpbCadastrar = new System.Windows.Forms.GroupBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.lblDivisao = new System.Windows.Forms.Label();
            this.cmbDivisao = new System.Windows.Forms.ComboBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.gpbEditar = new System.Windows.Forms.GroupBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.cmbEditarDivisao = new System.Windows.Forms.ComboBox();
            this.lblDivisaoEdit = new System.Windows.Forms.Label();
            this.txbEditarNome = new System.Windows.Forms.TextBox();
            this.lblNomeEdit = new System.Windows.Forms.Label();
            this.gpbApagar = new System.Windows.Forms.GroupBox();
            this.btnApagar = new System.Windows.Forms.Button();
            this.cmbApagar = new System.Windows.Forms.ComboBox();
            this.lblDivisaoApagar = new System.Windows.Forms.Label();
            this.txbApagar = new System.Windows.Forms.TextBox();
            this.lblNomeApagar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimes)).BeginInit();
            this.gpbCadastrar.SuspendLayout();
            this.gpbEditar.SuspendLayout();
            this.gpbApagar.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvTimes
            // 
            this.dgvTimes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTimes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTimes.Location = new System.Drawing.Point(186, 33);
            this.dgvTimes.Name = "dgvTimes";
            this.dgvTimes.Size = new System.Drawing.Size(427, 185);
            this.dgvTimes.TabIndex = 0;
            this.dgvTimes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTimes_CellClick);
            this.dgvTimes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTimes_CellContentClick);
            // 
            // gpbCadastrar
            // 
            this.gpbCadastrar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.gpbCadastrar.Controls.Add(this.btnCadastrar);
            this.gpbCadastrar.Controls.Add(this.cmbDivisao);
            this.gpbCadastrar.Controls.Add(this.lblDivisao);
            this.gpbCadastrar.Controls.Add(this.txbNome);
            this.gpbCadastrar.Controls.Add(this.lblNome);
            this.gpbCadastrar.Location = new System.Drawing.Point(12, 224);
            this.gpbCadastrar.Name = "gpbCadastrar";
            this.gpbCadastrar.Size = new System.Drawing.Size(245, 190);
            this.gpbCadastrar.TabIndex = 1;
            this.gpbCadastrar.TabStop = false;
            this.gpbCadastrar.Text = "Cadastrar Time";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(10, 31);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(76, 13);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome do Time";
            // 
            // txbNome
            // 
            this.txbNome.Location = new System.Drawing.Point(93, 31);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(100, 20);
            this.txbNome.TabIndex = 1;
            // 
            // lblDivisao
            // 
            this.lblDivisao.AutoSize = true;
            this.lblDivisao.Location = new System.Drawing.Point(13, 72);
            this.lblDivisao.Name = "lblDivisao";
            this.lblDivisao.Size = new System.Drawing.Size(42, 13);
            this.lblDivisao.TabIndex = 2;
            this.lblDivisao.Text = "Divisão";
            // 
            // cmbDivisao
            // 
            this.cmbDivisao.FormattingEnabled = true;
            this.cmbDivisao.Items.AddRange(new object[] {
            "1- Serie A",
            "2- Serie B",
            "3- Serie C"});
            this.cmbDivisao.Location = new System.Drawing.Point(72, 69);
            this.cmbDivisao.Name = "cmbDivisao";
            this.cmbDivisao.Size = new System.Drawing.Size(121, 21);
            this.cmbDivisao.TabIndex = 3;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.Chartreuse;
            this.btnCadastrar.Location = new System.Drawing.Point(27, 115);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(183, 43);
            this.btnCadastrar.TabIndex = 4;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // gpbEditar
            // 
            this.gpbEditar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.gpbEditar.Controls.Add(this.btnEditar);
            this.gpbEditar.Controls.Add(this.cmbEditarDivisao);
            this.gpbEditar.Controls.Add(this.lblDivisaoEdit);
            this.gpbEditar.Controls.Add(this.txbEditarNome);
            this.gpbEditar.Controls.Add(this.lblNomeEdit);
            this.gpbEditar.Location = new System.Drawing.Point(277, 224);
            this.gpbEditar.Name = "gpbEditar";
            this.gpbEditar.Size = new System.Drawing.Size(245, 190);
            this.gpbEditar.TabIndex = 5;
            this.gpbEditar.TabStop = false;
            this.gpbEditar.Text = "Cadastrar Time";
            this.gpbEditar.Enter += new System.EventHandler(this.gpbEditar_Enter);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.Orange;
            this.btnEditar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEditar.Location = new System.Drawing.Point(27, 115);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(183, 43);
            this.btnEditar.TabIndex = 4;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // cmbEditarDivisao
            // 
            this.cmbEditarDivisao.FormattingEnabled = true;
            this.cmbEditarDivisao.Items.AddRange(new object[] {
            "1- Serie A",
            "2- Serie B",
            "3- Serie C"});
            this.cmbEditarDivisao.Location = new System.Drawing.Point(72, 69);
            this.cmbEditarDivisao.Name = "cmbEditarDivisao";
            this.cmbEditarDivisao.Size = new System.Drawing.Size(121, 21);
            this.cmbEditarDivisao.TabIndex = 3;
            // 
            // lblDivisaoEdit
            // 
            this.lblDivisaoEdit.AutoSize = true;
            this.lblDivisaoEdit.Location = new System.Drawing.Point(13, 72);
            this.lblDivisaoEdit.Name = "lblDivisaoEdit";
            this.lblDivisaoEdit.Size = new System.Drawing.Size(42, 13);
            this.lblDivisaoEdit.TabIndex = 2;
            this.lblDivisaoEdit.Text = "Divisão";
            // 
            // txbEditarNome
            // 
            this.txbEditarNome.Location = new System.Drawing.Point(93, 31);
            this.txbEditarNome.Name = "txbEditarNome";
            this.txbEditarNome.Size = new System.Drawing.Size(100, 20);
            this.txbEditarNome.TabIndex = 1;
            // 
            // lblNomeEdit
            // 
            this.lblNomeEdit.AutoSize = true;
            this.lblNomeEdit.Location = new System.Drawing.Point(10, 31);
            this.lblNomeEdit.Name = "lblNomeEdit";
            this.lblNomeEdit.Size = new System.Drawing.Size(76, 13);
            this.lblNomeEdit.TabIndex = 0;
            this.lblNomeEdit.Text = "Nome do Time";
            // 
            // gpbApagar
            // 
            this.gpbApagar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.gpbApagar.Controls.Add(this.btnApagar);
            this.gpbApagar.Controls.Add(this.cmbApagar);
            this.gpbApagar.Controls.Add(this.lblDivisaoApagar);
            this.gpbApagar.Controls.Add(this.txbApagar);
            this.gpbApagar.Controls.Add(this.lblNomeApagar);
            this.gpbApagar.Location = new System.Drawing.Point(528, 224);
            this.gpbApagar.Name = "gpbApagar";
            this.gpbApagar.Size = new System.Drawing.Size(245, 190);
            this.gpbApagar.TabIndex = 6;
            this.gpbApagar.TabStop = false;
            this.gpbApagar.Text = "Apagar";
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
            // cmbApagar
            // 
            this.cmbApagar.FormattingEnabled = true;
            this.cmbApagar.Items.AddRange(new object[] {
            "1- Serie A",
            "2- Serie B",
            "3- Serie C"});
            this.cmbApagar.Location = new System.Drawing.Point(72, 69);
            this.cmbApagar.Name = "cmbApagar";
            this.cmbApagar.Size = new System.Drawing.Size(121, 21);
            this.cmbApagar.TabIndex = 3;
            // 
            // lblDivisaoApagar
            // 
            this.lblDivisaoApagar.AutoSize = true;
            this.lblDivisaoApagar.Location = new System.Drawing.Point(13, 72);
            this.lblDivisaoApagar.Name = "lblDivisaoApagar";
            this.lblDivisaoApagar.Size = new System.Drawing.Size(42, 13);
            this.lblDivisaoApagar.TabIndex = 2;
            this.lblDivisaoApagar.Text = "Divisão";
            // 
            // txbApagar
            // 
            this.txbApagar.Location = new System.Drawing.Point(93, 31);
            this.txbApagar.Name = "txbApagar";
            this.txbApagar.Size = new System.Drawing.Size(100, 20);
            this.txbApagar.TabIndex = 1;
            // 
            // lblNomeApagar
            // 
            this.lblNomeApagar.AutoSize = true;
            this.lblNomeApagar.Location = new System.Drawing.Point(10, 31);
            this.lblNomeApagar.Name = "lblNomeApagar";
            this.lblNomeApagar.Size = new System.Drawing.Size(76, 13);
            this.lblNomeApagar.TabIndex = 0;
            this.lblNomeApagar.Text = "Nome do Time";
            // 
            // GerenciamentoTimes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Barsemlona.Properties.Resources.inicio;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(817, 459);
            this.Controls.Add(this.gpbApagar);
            this.Controls.Add(this.gpbEditar);
            this.Controls.Add(this.gpbCadastrar);
            this.Controls.Add(this.dgvTimes);
            this.Name = "GerenciamentoTimes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GerenciamentoTimes";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimes)).EndInit();
            this.gpbCadastrar.ResumeLayout(false);
            this.gpbCadastrar.PerformLayout();
            this.gpbEditar.ResumeLayout(false);
            this.gpbEditar.PerformLayout();
            this.gpbApagar.ResumeLayout(false);
            this.gpbApagar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTimes;
        private System.Windows.Forms.GroupBox gpbCadastrar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.ComboBox cmbDivisao;
        private System.Windows.Forms.Label lblDivisao;
        private System.Windows.Forms.TextBox txbNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.GroupBox gpbEditar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.ComboBox cmbEditarDivisao;
        private System.Windows.Forms.Label lblDivisaoEdit;
        private System.Windows.Forms.TextBox txbEditarNome;
        private System.Windows.Forms.Label lblNomeEdit;
        private System.Windows.Forms.GroupBox gpbApagar;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.ComboBox cmbApagar;
        private System.Windows.Forms.Label lblDivisaoApagar;
        private System.Windows.Forms.TextBox txbApagar;
        private System.Windows.Forms.Label lblNomeApagar;
    }
}