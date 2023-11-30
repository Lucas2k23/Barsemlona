using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace Barsemlona.Classes
{
    internal class Jogadores
    {
        public int IdJogador { get; set; }
        public string Nome { get; set; }
        public DateTime Data { get; set; }
        public string Posicao { get; set; }

        public DataTable ListarTudo()
        {
            string comando = "SELECT id_jogadores AS 'Id',nome AS 'Nome do Time', posicao AS 'Posicao', data_nascimento AS 'Data de Nascimento' " +
                "FROM jogadores ";
            Banco.ConexaoBanco conexaoBD = new Banco.ConexaoBanco();
            MySqlConnection con = conexaoBD.ObterConexao();
            MySqlCommand cmd = new MySqlCommand(comando, con);
            cmd.Prepare();
            // Declarar tabela que irá receber o resultado:
            DataTable tabela = new DataTable();
            // Preencher a tabela com o resultado da consulta
            tabela.Load(cmd.ExecuteReader());
            conexaoBD.Desconectar(con);
            return tabela;
        }
        public bool CadastrarJogador()
        {
            string comando = "INSERT INTO jogadores (nome, data_nascimento, posicao) " +
                "VALUES (@nome, @data_nascimento, @posicao)";
            Banco.ConexaoBanco conexaoBD = new Banco.ConexaoBanco();
            MySqlConnection con = conexaoBD.ObterConexao();
            MySqlCommand cmd = new MySqlCommand(comando, con);
            cmd.Parameters.AddWithValue("@nome", Nome);
            cmd.Parameters.AddWithValue("@data_nascimento", Data);
            cmd.Parameters.AddWithValue("@posicao", Posicao);

            cmd.Prepare();
            try
            {
                if (cmd.ExecuteNonQuery() == 0)
                {
                    conexaoBD.Desconectar(con);
                    return false;
                }
                else
                {
                    conexaoBD.Desconectar(con);
                    return true;
                }
            }
            catch
            {
                conexaoBD.Desconectar(con);
                return false;
            }


        }
        public bool EditarJogador()
        {
            string comando = "UPDATE jogadores SET nome = @nome, data_nascimento = @data_nascimento, posicao = @posicao " +
                 " WHERE id_jogadores = @id_jogadores ";

            Banco.ConexaoBanco conexaoBD = new Banco.ConexaoBanco();
            MySqlConnection con = conexaoBD.ObterConexao();
            MySqlCommand cmd = new MySqlCommand(comando, con);
            cmd.Parameters.AddWithValue("@nome", Nome);
            cmd.Parameters.AddWithValue("@data_nascimento", Data);
            cmd.Parameters.AddWithValue("@posicao", Posicao);
            cmd.Parameters.AddWithValue("@id_jogadores", IdJogador);
            cmd.Prepare();
            try
            {
                if (cmd.ExecuteNonQuery() == 0)
                {
                    conexaoBD.Desconectar(con);
                    return false;
                }
                else
                {
                    conexaoBD.Desconectar(con);
                    return true;
                }
            }
            catch
            {
                conexaoBD.Desconectar(con);
                return false;
            }

        }
        public bool ApagarJogador()
        {
            string comando = "DELETE FROM jogadores WHERE id_jogadores = @id_jogadores";
            Banco.ConexaoBanco conexaoBD = new Banco.ConexaoBanco();
            MySqlConnection con = conexaoBD.ObterConexao();
            MySqlCommand cmd = new MySqlCommand(comando, con);

            cmd.Parameters.AddWithValue("@id_jogadores", IdJogador);
            cmd.Prepare();
            try
            {
                if (cmd.ExecuteNonQuery() == 0)
                {
                    conexaoBD.Desconectar(con);
                    return false;
                }
                else
                {
                    conexaoBD.Desconectar(con);
                    return true;
                }
            }
            catch
            {
                conexaoBD.Desconectar(con);
                return false;
            }
        }
    }
}
