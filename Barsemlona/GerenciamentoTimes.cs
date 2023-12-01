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
    public partial class GerenciamentoTimes : Form
    {
        int idSelecionado = 0;
        Time time = new Time();
        public GerenciamentoTimes()
        {

            InitializeComponent();
            Time time = new Time();
            dgvTimes.DataSource = time.ListarTudo();
        }

        private void btnSerieC_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void dgvTimes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {

            time.NomeTime = txbNome.Text;
            time.IdDivisao = int.Parse(cmbDivisao.Text.Split('-')[0]);
            dgvTimes.DataSource = time.ListarTudo();
            if (time.CadastrarTime() == true)
            {
                MessageBox.Show("time cadastrado com sucesso!");
                txbNome.Clear();
                cmbDivisao.SelectedIndex = -1;
                //Atualizar o dgv:
                dgvTimes.DataSource = time.ListarTudo();
            }
            else
            {

                MessageBox.Show("Falha ao cadastrar Time!");
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

            time.NomeTime = txbEditarNome.Text;
            time.IdDivisao = int.Parse(cmbEditarDivisao.Text.Split('-')[0]);
            dgvTimes.DataSource = time.ListarTudo();
            time.IdTime = idSelecionado;
            if (time.EditarTime() == true)
            {
                MessageBox.Show("time Editado com sucesso!");
                txbEditarNome.Clear();
                cmbEditarDivisao.SelectedIndex = -1;
                //Atualizar o dgv:
                dgvTimes.DataSource = time.ListarTudo();
            }
            else
            {

                MessageBox.Show("Falha ao Editar Time!");
            }
        }

        private void dgvTimes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //ativar os group box:
            gpbEditar.Enabled = true;
            gpbApagar.Enabled = true;

            
            //gpbApagar.Enabled = true;

            //Obter a linha clicada:
            int linhaselecionada = dgvTimes.CurrentCell.RowIndex;

            //Amazenar os dados selecionados em "linha" tipo um vetor:

            var linha = dgvTimes.Rows[linhaselecionada];

            //prrencher os campos:
            txbEditarNome.Text = linha.Cells[1].Value.ToString();
            txbApagar.Text = linha.Cells[1].Value.ToString();

            //Juntar o id e o nome para exibir no apagar:
            lblInformacao.Text = linha.Cells[0].Value.ToString();
            linha.Cells[1].Value.ToString();

            //Salvar o id do selecionado na variavel global:
            idSelecionado = (int)linha.Cells[0].Value;
        }

        private void gpbEditar_Enter(object sender, EventArgs e)
        {

        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            time.IdTime = idSelecionado;
            //Apagar:
            var r = MessageBox.Show("Tem certeza que deseja apagar?", "Atenção!",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                if (time.ApagarTime() == true)
                {
                    MessageBox.Show("Time apagado!", " sucesso!",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //Atualizar o dgv:
                    dgvTimes.DataSource = time.ListarTudo();
                    //Limpar os campos de edição:
                    txbEditarNome.Clear();
                    cmbEditarDivisao.SelectedIndex = -1;
                    
                    //lblInformacao.Text = "Selecione um usuario para apagar.";
                    //Desabilitar os grbs:
                    gpbApagar.Enabled = false;
                    gpbEditar.Enabled = false;

                }

            }
            else
            {
                MessageBox.Show("Falha ao apagar Time!", "Falha!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
        }

        private void gpbApagar_Enter(object sender, EventArgs e)
        {

        }
    }
}
