using MySqlConnector;
using ProjetoAcademico.DTO;
using ProjetoAcademico.util;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAcademico.DAO
{
    internal class DisciplinaDAO
    {
        //Atributos da Classe DAO
        MySqlConnection? con;
        MySqlCommand? envelope;
        MySqlDataReader? cursor;
        List<DisciplinaDTO> listadisciplinas;
        string? sql;

        public DisciplinaDAO()
        {
            ConexaoBD conexaobd = new ConexaoBD();
            con = conexaobd.RetornaConexao();
        }

        public int salvar(DisciplinaDTO disciplinadto)
        {
            //Abertura do Canal de Conexão
            con.Open();
            //String contendo o comando SQL a ser enviado ao SGBD
            string sql = "insert into disciplina " +
                            "(sigla,nome,cargahoraria,modulo,tipo,eixotecnico) " +
                            "values " +
                            "(@sigla,@nome,@ch,@modulo,@tipo,@eixo)";
            //Criação do objeto de comando que irá carregar o comando SQL até o SGBD
            envelope = new MySqlCommand();
            //Indica qual o comando SQL irá ser enviado pelo canal
            envelope.CommandText = sql;
            //Indica qual canal será usado para enviar o comando
            envelope.Connection = con;
            //Permuta os parâmetros com valores
            envelope.Parameters.AddWithValue("@sigla", disciplinadto.Sigla);
            envelope.Parameters.AddWithValue("@nome", disciplinadto.Nome);
            envelope.Parameters.AddWithValue("@ch", disciplinadto.Cargahoraria);
            envelope.Parameters.AddWithValue("@modulo", disciplinadto.Modulo);
            envelope.Parameters.AddWithValue("@tipo", disciplinadto.Tipo);
            envelope.Parameters.AddWithValue("@eixo", disciplinadto.Eixotecnico);
            //Prepara o comando
            envelope.Prepare();
            //Dispara o comando pelo canal de conexão e aguarda o retorno do processamento
            int resultado = envelope.ExecuteNonQuery();
            //Fechando a Conexão
            con.Close();
            return resultado;
        }

        public List<DisciplinaDTO> listar()
        {
            //Criacao do objeto de lista de disciplinas
            listadisciplinas = new List<DisciplinaDTO>();
            //Abrir o canal de comunicação
            con.Open();
            //Comando SQL a ser executado
            sql = "Select * from disciplina";
            //Criação de um objeto envelope (Comando MySql)
            envelope = new MySqlCommand(sql, con);
            envelope.Prepare();
            //O método ExecuteReader deve ser usado em comandos que retornam
            //um conjunto de dados tabulares, como o SELECT.
            //O objeto cursor permite navegar no conjunto de dados retornados
            cursor = envelope.ExecuteReader();
            while (cursor.Read()) 
            {
                //Transformando cada linha da tabela retornada em um objeto
                DisciplinaDTO disciplinadto = new DisciplinaDTO();
                disciplinadto.Id = cursor.GetInt32("iddisciplina");
                disciplinadto.Sigla = cursor.GetString("sigla");
                disciplinadto.Nome = cursor.GetString("nome");
                disciplinadto.Cargahoraria = cursor.GetInt32("cargahoraria");
                disciplinadto.Modulo = Convert.ToInt32(cursor.GetString("modulo"));
                disciplinadto.Tipo = cursor.GetString("tipo");
                disciplinadto.Eixotecnico = cursor.GetBoolean("eixotecnico");
                //Adicionar o objeto a Lista de Disciplinas
                listadisciplinas.Add(disciplinadto);
            }
            //Fechar o canal de comunicação
            con.Close();
            //Retorna a lista de disciplinas
            return listadisciplinas;
        }
    }
}
