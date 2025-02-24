using ProjetoAcademico.Controller;
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
            int cargahoraria = 0, modulo=0;
            bool eixotecnologico = true;

            //Validar os campos da tela (preenchimento obrigatório)
            string retornomensagem = ValidaCampos();
            if(retornomensagem != "")
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
                //Trabalhar com Banco de Dados
                string strconexao = "";

                //String de Conexão
                strconexao = "server=localhost;userid=professor;password=professor@;database=bdacademicolp3";
                //Criação do Canal de Conexão
                MySqlConnection con = new MySqlConnection(strconexao);
                //Abertura do Canal de Conexão
                con.Open();
                //String contendo o comando SQL a ser enviado ao SGBD
                string sql = "insert into disciplina " +
                                "(sigla,nome,cargahoraria,modulo,tipo,eixotecnico) " +
                                "values " +
                                "(@sigla,@nome,@ch,@modulo,@tipo,@eixo)";
                //Criação do objeto de comando que irá carregar o comando SQL até o SGBD
                MySqlCommand envelope = new MySqlCommand();
                //Indica qual o comando SQL irá ser enviado pelo canal
                envelope.CommandText = sql;
                //Indica qual canal será usado para enviar o comando
                envelope.Connection = con;
                //Permuta os parâmetros com valores
                envelope.Parameters.AddWithValue("@sigla", sigla);
                envelope.Parameters.AddWithValue("@nome", nome);
                envelope.Parameters.AddWithValue("@ch", cargahoraria);
                envelope.Parameters.AddWithValue("@modulo", modulo);
                envelope.Parameters.AddWithValue("@tipo", tipo);
                envelope.Parameters.AddWithValue("@eixo", eixotecnologico);
                //Prepara o comando
                envelope.Prepare();
                //Dispara o comando pelo canal de conexão e aguarda o retorno do processamento
                int resultado = envelope.ExecuteNonQuery();

                if (resultado > 0)
                {
                    MessageBox.Show("Dados salvos com sucesso");
                }
                else
                {
                    MessageBox.Show("Algo deu errado!!!");
                }

                //Usou o canal de comunicação
                con.Close();


                //Cria um objeto Controller para ajudar a Salvar os Dados
                ControllerDisciplina controllerdisciplina = new ControllerDisciplina();
                controllerdisciplina.SalvarDisciplina(sigla,nome,cargahoraria,modulo,tipo,eixotecnologico);

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

            if(TxtNome.Text.Trim() == "")
            {
                mensagem = "O nome da disciplina é obrigatória!!";
                return mensagem;
            }  

            if(CmbModulo.Text.Trim() == "")
            {
                mensagem = "O módulo é obrigatório!!!";
                return mensagem;
            }
            return mensagem;
        }
    }
}
