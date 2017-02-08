using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JogoDesktop
{
    public partial class Pergunta4 : Form
    {
        public int id_jogador_banco;

        public Pergunta4(int id_jogador)
        {
            InitializeComponent();
            id_jogador_banco = id_jogador;
        }

        private void btnPP1_Click(object sender, EventArgs e)
        {
            //Copiar daqui
            if (rdbResposta4.Checked == true)
            {
                MessageBox.Show("Acertou!");
                using (SqlConnection conexao = new SqlConnection("Server=AME0556317W10-1\\SQLEXPRESS;Database=db_PerguntasERespostas;Trusted_Connection=Yes"))
                {
                    using (SqlCommand comando = new SqlCommand("insert into tb_Perguntas(pergunta, resposta_correta, id_jogador) values(@PERGUNTA1, @RESPOSTA2, @ID_JOGADOR)", conexao))
                    {
                        comando.Parameters.AddWithValue("PERGUNTA1", lblPergunta1.Text);
                        comando.Parameters.AddWithValue("RESPOSTA2", rdbResposta4.Text);
                        comando.Parameters.AddWithValue("ID_JOGADOR", id_jogador_banco);
                        conexao.Open();
                        comando.ExecuteNonQuery();

                        this.Close();

                    }
                }
            }
            else
            {
                MessageBox.Show("Errou!");
            }

            //Até aqui
        }
    }
}
