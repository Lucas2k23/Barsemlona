using Barsemlona.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Barsemlona
{
    public partial class GerenciamentoContrato : Form
    {
        int idSelecionado;
        Jogadores j = new Jogadores();
        Time t = new Time();
        Contrato c = new Contrato(); 
        public GerenciamentoContrato()
        {
            InitializeComponent();
            dgvJogadorContrato.DataSource = j.ListarTudo();
            dgvTimeContrato.DataSource = t.ListarTudo();
        }

        private void GerenciamentoContrato_Load(object sender, EventArgs e)
        {

        }

        private void dgvJogadorContrato_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //ativar os group box:
            gpbContratarJogador.Enabled = true;
            
            

            //Obter a linha clicada:
            int linhaselecionada = dgvJogadorContrato.CurrentCell.RowIndex;

            //Amazenar os dados selecionados em "linha" tipo um vetor:

            var linha = dgvJogadorContrato.Rows[linhaselecionada];

            //prrencher os campos:
            txbNomeContrato.Text = linha.Cells[1].Value.ToString();
            cmbPosicaoContrato.Text = linha.Cells[2].Value.ToString();

            //Juntar o id e o nome para exibir no Painel:
            txbIdJogador.Text = linha.Cells[0].Value.ToString();
            linha.Cells[1].Value.ToString();

            //Salvar o id do selecionado na variavel global:
            idSelecionado = (int)linha.Cells[0].Value;
        }

        private void dgvTimeContrato_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //ativar os group box:
            gpbContratarJogador.Enabled = true;
            
            //gpbApagar.Enabled = true;

            //Obter a linha clicada:
            int linhaselecionada = dgvTimeContrato.CurrentCell.RowIndex;

            //Amazenar os dados selecionados em "linha" tipo um vetor:

            var linha = dgvTimeContrato.Rows[linhaselecionada];

            //prrencher os campos:
            txbTimeContrato.Text = linha.Cells[1].Value.ToString();
             //dtpDataContrato.Text = linha.Cells[1].Value.ToString();

            //Juntar o id e o nome para exibir no apagar:
            txbIdTime.Text = linha.Cells[0].Value.ToString();
            linha.Cells[1].Value.ToString();

            //Salvar o id do selecionado na variavel global:
            idSelecionado = (int)linha.Cells[0].Value;
        }

        private void btnContratar_Click(object sender, EventArgs e)
        {
            var r = MessageBox.Show("Tem certeza que deseja Contratar?", "Atenção!",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            
            if (r == DialogResult.Yes)
            {
                c.IdJogador = int.Parse(txbIdJogador.Text); 
                c.IdTime = int.Parse(txbIdTime.Text);
                c.ValorContrato = double.Parse(txbValorContrato.Text);
                c.DataContrato = DateTime.Parse(dtpDataContrato.Text);
                MessageBox.Show(c.IdJogador.ToString());
                if (c.Contratar() == true)
                {
                    MessageBox.Show("Jogador Contratado!", " sucesso!",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //Atualizar o dgv:
                    dgvJogadorContrato.DataSource = j.ListarTudo();
                    dgvTimeContrato.DataSource = t.ListarTudo();
                    //Limpar os campos de edição:
                    txbNomeContrato.Clear();
                    cmbPosicaoContrato.SelectedIndex = -1;
                    txbTimeContrato.Clear();
                    dtpDataContrato.ResetText();

                    
                    //Desabilitar os grbs:
                    gpbContratarJogador.Enabled = false;
                    

                }
                else
                {
                    MessageBox.Show("erro!", "Falha!",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Falha ao contratar Jogador!", "Falha!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
        }
    }
}
