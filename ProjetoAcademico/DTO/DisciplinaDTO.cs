using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAcademico.DTO
{
    internal class DisciplinaDTO
    {
        private int id;
        private string sigla;
        private string nome;
        private int cargahoraria;
        private int modulo;
        private string tipo;
        private bool eixotecnico;

        public DisciplinaDTO()
        {
        }

        public DisciplinaDTO(int id, string sigla, string nome, int cargahoraria, int modulo, string tipo, bool eixotecnico)
        {
            this.Id = id;
            this.Sigla = sigla;
            this.Nome = nome;
            this.Cargahoraria = cargahoraria;
            this.Modulo = modulo;
            this.Tipo = tipo;
            this.Eixotecnico = eixotecnico;
        }

        public int Id { get => id; set => id = value; }
        public string Sigla { get => sigla; set => sigla = value; }
        public string Nome { get => nome; set => nome = value; }
        public int Cargahoraria { get => cargahoraria; set => cargahoraria = value; }
        public int Modulo { get => modulo; set => modulo = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        public bool Eixotecnico { get => eixotecnico; set => eixotecnico = value; }
    }
}
