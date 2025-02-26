using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAcademico.util
{
    internal class ConexaoBD
    {
        private MySqlConnection con;
        public ConexaoBD()
        {
            //Conexao com o Banco de Dados
            string strconexao = "";
            //String de Conexao com o Banco de Dados
            strconexao = "server=localhost;userid=professor;password=professor@;database=bdacademicolp3";
            //Criação do Canal de Comunicação
            con = new MySqlConnection(strconexao);
        }

        public MySqlConnection RetornaConexao()
        {
            return this.con;
        }
    }
}
