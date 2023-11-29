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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace Barsemlona
{
    
    public partial class GerenciamentoJogador : Form
    {
        int idSelecionado = 0;
        Jogadores j = new Jogadores();
        public GerenciamentoJogador()
        {
            InitializeComponent();
            dgvJogador.DataSource = j.ListarTudo();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            j.Nome = txbNome.Text;
            j.Posicao = cmbPosicao.Text.Split('-')[1];
            j.Data = dtpData.Value;
            dgvJogador.DataSource = j.ListarTudo();
            if (j.CadastrarJogador() == true)
            {
                MessageBox.Show("Jogador cadastrado com sucesso!");
                txbNome.Clear();
                cmbPosicao.SelectedIndex = -1;
                dtpData.ResetText();
                //Atualizar o dgv:
                dgvJogador.DataSource = j.ListarTudo();
            }
            else
            {

                MessageBox.Show("Falha ao cadastrar Jogador!");
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            j.Nome = txbNomeEdit.Text;
            j.Posicao = cmbPosicaoEdit.Text.Split('-')[1];
            j.Data = dtpData.Value;
            j.IdJogador = idSelecionado;

            if (j.EditarJogador() == true)
            {
                MessageBox.Show("Jogador Editado com sucesso!");
                txbNomeEdit.Clear();
                cmbPosicaoEdit.SelectedIndex = -1;
                dtpDataEdit.ResetText();
                //Atualizar o dgv:
                dgvJogador.DataSource = j.ListarTudo();
            }
            else
            {

                MessageBox.Show("Falha ao Editar Jogador!");
            }
        }

        private void dgvJogador_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //ativar os group box:
            gpbJogadorEditar.Enabled = true;
            gpbApagarJogador.Enabled = true;


            //gpbApagar.Enabled = true;

            //Obter a linha clicada:
            int linhaselecionada = dgvJogador.CurrentCell.RowIndex;

            //Amazenar os dados selecionados em "linha" tipo um vetor:

            var linha = dgvJogador.Rows[linhaselecionada];

            //prrencher os campos:
            txbNomeEdit.Text = linha.Cells[1].Value.ToString();
            txbApagarNome.Text = linha.Cells[1].Value.ToString();

            //Juntar o id e o nome para exibir no apagar:
            lblInformacaoApagar.Text = linha.Cells[0].Value.ToString();
            linha.Cells[1].Value.ToString();

            //Salvar o id do selecionado na variavel global:
            idSelecionado = (int)linha.Cells[0].Value;
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {

        }
    }
}
