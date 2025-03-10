﻿using ProjetoAcademico.Controller;
using ProjetoAcademico.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlConnector;
using ProjetoAcademico.DAO;

namespace ProjetoAcademico
{
    public partial class FrmDisciplinas : Form
    {
        public FrmDisciplinas()
        {
            InitializeComponent();
        }

        private void BarraBtnSalvar_Click(object sender, EventArgs e)
        {
            string sigla = "", nome = "", tipo = "";
            int cargahoraria = 0, modulo = 0;
            bool eixotecnologico = true;

            //Validar os campos da tela (preenchimento obrigatório)
            string retornomensagem = ValidaCampos();
            if (retornomensagem != "")
            {
                MessageBox.Show(retornomensagem);
            }
            else
            {
                //Recuperar os dados
                //SIGLA DA DISCIPLINA
                sigla = TxtSigla.Text;
                //NOME DA DISCIPLINA
                nome = TxtNome.Text;
                //CARGA HORÁRIA
                if (Rd40.Checked)
                {
                    cargahoraria = 40;
                }

                if (Rd80.Checked)
                {
                    cargahoraria = 80;
                }

                if (Rd90.Checked)
                {
                    cargahoraria = 90;
                }
                //MÓDULO
                modulo = Convert.ToInt32(CmbModulo.Text);
                //TIPO
                if (RdTeorica.Checked)
                {
                    tipo = "Teórica";
                }
                if (RdPratica.Checked)
                {
                    tipo = "Prática";
                }
                if (RdTeoricaPratica.Checked)
                {
                    tipo = "Teórica e Prática";
                }
                //EIXO TECNOLÓGICO
                if (RdSim.Checked)
                {
                    eixotecnologico = true;
                }
                else
                {
                    eixotecnologico = false;
                }
                //Cria um objeto Controller para ajudar a Salvar os Dados
                ControllerDisciplina controllerdisciplina = new ControllerDisciplina();
                int resultado = controllerdisciplina.SalvarDisciplina(sigla, nome, cargahoraria, modulo, tipo, eixotecnologico);
                if (resultado > 0)
                {
                    MessageBox.Show("Dados salvos com sucesso");
                }
                else
                {
                    MessageBox.Show("Algo deu errado!!!");
                }
            }

        }

        public string ValidaCampos()
        {
            string mensagem = "";
            if (TxtSigla.Text.Trim() == "")
            {
                mensagem = "A sigla é obrigatória!!";
                return mensagem;
            }

            if (TxtNome.Text.Trim() == "")
            {
                mensagem = "O nome da disciplina é obrigatória!!";
                return mensagem;
            }

            if (CmbModulo.Text.Trim() == "")
            {
                mensagem = "O módulo é obrigatório!!!";
                return mensagem;
            }
            return mensagem;
        }

        private void BarraBtnListar_Click(object sender, EventArgs e)
        {
            ControllerDisciplina controller = new ControllerDisciplina();
            List<DisciplinaDTO> listaretorno = controller.ListarDisciplinas();
            //Caso a lista retornada pelo Controller esteja vazia, significa que 
            //não tem nenhuma disciplina no banco de dados, cadastrada
            if (listaretorno.Count == 0)
            {
                MessageBox.Show("Não há disciplinas cadastradas");
            }
            else
            {
                string mensagem = "";
                foreach (DisciplinaDTO disciplinadto in listaretorno)
                {
                    mensagem = "ID:" + disciplinadto.Id.ToString() + "\n";
                    mensagem = mensagem + "Sigla:" + disciplinadto.Sigla + "\n";
                    mensagem = mensagem + "Nome:" + disciplinadto.Nome + "\n";
                    mensagem = mensagem + "Carga Horária:" + disciplinadto.Cargahoraria.ToString() + "\n";
                    mensagem = mensagem + "Módulo:" + disciplinadto.Modulo.ToString() + "\n";
                    mensagem = mensagem + "Tipo:" + disciplinadto.Tipo + "\n";
                    string pertence = disciplinadto.Eixotecnico ? "Sim" : "Não";
                    mensagem = mensagem + "Pertence ao Eixo Tecnológico:" + pertence;
                    MessageBox.Show(mensagem);
                }
            }

        }

        private void BarraBtnDeletar_Click(object sender, EventArgs e)
        {
            
        }
    }
}
