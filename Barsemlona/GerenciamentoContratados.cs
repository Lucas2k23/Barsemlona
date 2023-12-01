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
    public partial class GerenciamentoContratados : Form
    {
        
        Contrato c = new Contrato();
        public GerenciamentoContratados()
        {
            InitializeComponent();
            dgvContratados.DataSource = c.ListarContrato();
        }

        private void GerenciamentoContratados_Load(object sender, EventArgs e)
        {

        }

        private void dgvContratados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvContratados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //ativar os group box:
            gpbDispensarJogador.Enabled = true;

            btnDispensar.Enabled = true;
            btnEditarContrato.Enabled = true;
            
            //Obter a linha clicada:
            int linhaselecionada = dgvContratados.CurrentCell.RowIndex;

            //Amazenar os dados selecionados em "linha" tipo um vetor:

            var linha = dgvContratados.Rows[linhaselecionada];

            //prrencher os campos:
            txbIdContrato.Text = linha.Cells[0].Value.ToString();
            txbContratante.Text = linha.Cells[1].Value.ToString();
            txbNomeContratado.Text = linha.Cells[2].Value.ToString();
            txbValorNegociado.Text = linha.Cells[3].Value.ToString();
            dtpDataContratado.Text = linha.Cells[4].Value.ToString();

            
        }

        private void lblValorContrato_Click(object sender, EventArgs e)
        {

        }

        private void btnEditarContrato_Click(object sender, EventArgs e)
        {
            c.IdContrato = int.Parse(txbIdContrato.Text);
            c.ValorContrato = double.Parse(txbValorNegociado.Text);
           
            
            dgvContratados.DataSource = c.ListarContrato();
            
            if (c.EditarContrato() == true)
            {
                MessageBox.Show("contrato Editado com sucesso!");
                txbIdContrato.Clear();
                txbContratante.Clear();
                txbNomeContratado.Clear();
                txbValorNegociado.Clear();
                dtpDataContratado.ResetText();
                //Atualizar o dgv:
                dgvContratados.DataSource = c.ListarContrato();
            }
            else
            {

                MessageBox.Show("Falha ao Editar Contrato!");
                txbIdContrato.Clear();
                txbContratante.Clear();
                txbNomeContratado.Clear();
                txbValorNegociado.Clear();
                dtpDataContratado.ResetText();
            }
        }

        private void txbValorContrato_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDispensar_Click(object sender, EventArgs e)
        {
            //Apagar:
            var r = MessageBox.Show("Tem certeza que deseja apagar?", "Atenção!",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                c.IdContrato = int.Parse(txbIdContrato.Text);
                if (c.DispensarContrato() == true)
                {
                    MessageBox.Show("Contrato apagado!", " sucesso!",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //Atualizar o dgv:
                    dgvContratados.DataSource = c.ListarContrato();
                    //Limpar os campos de edição:
                    txbIdContrato.Clear();
                    txbContratante.Clear();
                    txbNomeContratado.Clear();
                    txbValorNegociado.Clear();
                    dtpDataContratado.ResetText();

                    
                    //Desabilitar os grbs:
                    btnDispensar.Enabled = false;
                    btnEditarContrato.Enabled = false;
                    

                }
                else
                {
                    MessageBox.Show("Falha ao apagar Contrato!", "Falha!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Falha ao apagar Contrato!", "Falha!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
        }
    }
}
