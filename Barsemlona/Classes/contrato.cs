using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barsemlona.Classes
{
    internal class Contrato
    {
         public int IdContrato {get; set;}
        public int IdTime { get; set;}
        public int IdJogador { get; set; }
        public double ValorContrato { get; set; }
        public DateTime DataContrato { get; set; }

        public bool Contratar()
        {
            string comando = "INSERT INTO contrato (id_time, id_jogadores, valor_contrato, data_contrato) " +
                " VALUES (@id_time, @id_jogadores, @valor_contrato, @data_contrato) ";
            Banco.ConexaoBanco conexaoBD = new Banco.ConexaoBanco();
            MySqlConnection con = conexaoBD.ObterConexao();
            MySqlCommand cmd = new MySqlCommand(comando, con);
            cmd.Parameters.AddWithValue("@id_time", IdTime);
            cmd.Parameters.AddWithValue("@id_jogadores", IdJogador);
            cmd.Parameters.AddWithValue("@valor_contrato", ValorContrato);
            cmd.Parameters.AddWithValue("@data_contrato", DataContrato);

            cmd.Prepare();
            //try
            //{
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
            //}
            //catch
            //{
            //    conexaoBD.Desconectar(con);
            //    return false;
            //}
        }
    }
}
