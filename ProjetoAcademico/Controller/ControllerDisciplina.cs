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
        public void SalvarDisciplina(string sigla, string nome, int cargahoraria, int modulo, string tipo, bool eixotecnico)
        {
            //Criar um objeto Disciplina
            DisciplinaDTO disciplinaDTO = new DisciplinaDTO();
            disciplinaDTO.Sigla = sigla;
            disciplinaDTO.Nome = nome;
            disciplinaDTO.Cargahoraria = cargahoraria;
            disciplinaDTO.Modulo = modulo;
            disciplinaDTO.Tipo = tipo;
            disciplinaDTO.Eixotecnico = eixotecnico;
            /*
            DisciplinaDAO disciplinadao = new DisciplinaDAO();
            disciplinadao.salvar(disciplinaDTO);
            */
        }
    }
}
