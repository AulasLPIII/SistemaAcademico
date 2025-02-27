using ProjetoAcademico.DAO;
using ProjetoAcademico.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAcademico.Controller
{
    internal class ControllerDisciplina
    {
        public int SalvarDisciplina(string sigla, string nome, int cargahoraria, int modulo, string tipo, bool eixotecnico)
        {
            //Criar um objeto Disciplina
            DisciplinaDTO disciplinaDTO = new DisciplinaDTO();
            disciplinaDTO.Sigla = sigla;
            disciplinaDTO.Nome = nome;
            disciplinaDTO.Cargahoraria = cargahoraria;
            disciplinaDTO.Modulo = modulo;
            disciplinaDTO.Tipo = tipo;
            disciplinaDTO.Eixotecnico = eixotecnico;
            
            //Criar um objeto DAO
            DisciplinaDAO disciplinadao = new DisciplinaDAO();
            //Salvar a disciplina no banco de dados
            int resultadodao = disciplinadao.salvar(disciplinaDTO);
            //Retornar o resultado da operação
            return resultadodao;           
        }

        public List<DisciplinaDTO> ListarDisciplinas()
        {
            //Criar um objeto DAO
            DisciplinaDAO disciplinadao = new DisciplinaDAO();
            //Retornar uma lista contendo as disciplinas salvas no banco de dados
            List<DisciplinaDTO> lista = disciplinadao.listar();
            return lista;
        }
    }
}
