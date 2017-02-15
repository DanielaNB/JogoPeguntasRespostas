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
    public partial class frmInicial : Form
    {
        public frmInicial()
        {
            InitializeComponent();
        }

        private void txtNome_Enter(object sender, EventArgs e)
        {
            txtNome.Text = "";
        }

        private void txtNome_Leave(object sender, EventArgs e)
        {

            if(txtNome.Text == "")
            {
                txtNome.Text = "Digite seu nome";
            }

        }

        private void frmInicial_Load(object sender, EventArgs e)
        {
           
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "Digite seu nome")
            {
                MessageBox.Show("Você deve informar seu nome", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNome.Focus();
            }
            else if (txtSobrenome.Text == "Digite seu sobrenome")
            {
                MessageBox.Show("Você deve informar seu sobrenome", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSobrenome.Focus();
            }

            else if (txtEmail.Text == "Digite seu email")
            {
                MessageBox.Show("Você deve informar seu email", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtEmail.Focus();
            }

            else {

                //início do código para inserir o jogador na tabela
                //using System.Data.SqlClient;
                using (SqlConnection conexao = new SqlConnection("Server=AME0556317W10-1\\SQLEXPRESS;Database=db_PerguntasERespostas;Trusted_Connection=Yes"))
                {
                    using(SqlCommand comando = new SqlCommand("insert into tb_jogadores(nome, sobrenome, email) OUTPUT INSERTED.ID_jogador values(@NOME, @SOBRENOME, @EMAIL)",conexao))
                    {
                        comando.Parameters.AddWithValue("NOME", txtNome.Text);
                        comando.Parameters.AddWithValue("SOBRENOME", txtSobrenome.Text);
                        comando.Parameters.AddWithValue("EMAIL", txtEmail.Text);
                        conexao.Open();

                        int id_jogador = (int)comando.ExecuteScalar();

                        if (id_jogador > 0)
                        {



                            MessageBox.Show("O id inserido foi: " + id_jogador);

                            MessageBox.Show("Olá " + txtNome.Text.ToUpper() + ". Você está pronto para continuar!!!", "PLAYYYY", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                            //System.Media.SoundPlayer player = new System.Media.SoundPlayer();
                            // player.SoundLocation = "c:\\vm\\teste\\som.wav";
                            // player.Play();

                            Pergunta1 p1 = new Pergunta1(id_jogador);
                            p1.ShowDialog();
                            Pergunta2 p2 = new Pergunta2(id_jogador);
                            p2.ShowDialog();
                            Pergunta3 p3 = new Pergunta3(id_jogador);
                            p3.ShowDialog();
                            Pergunta4 p4 = new Pergunta4(id_jogador);
                            p4.ShowDialog();


                            //pega a quantidades de acertos
                            comando.CommandText = "select COUNT(pergunta) from tb_perguntas where id_jogador = " + id_jogador;
                            SqlDataReader dr_acertos = comando.ExecuteReader();
                            dr_acertos.Read();
                            MessageBox.Show("Sua pontuação é de: " + dr_acertos.GetInt32(0) + "pontos");
                            dr_acertos.Close();

                

                        }
                        else
                        {
                            MessageBox.Show("DEU RUIMMMM!!!! Algo aconteceu durante o insert");
                        }
                    }
                }
                //fim do código para inserir o jogador na tabela

            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSobrenome_Enter(object sender, EventArgs e)
        {
            txtSobrenome.Text = "";
        }

        private void txtSobrenome_Leave(object sender, EventArgs e)
        {
            if (txtSobrenome.Text == "")
            {
                txtSobrenome.Text = "Digite seu sobrenome";
            }
        }

        private void txtSobrenome_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (txtEmail.Text == "")
            {
                txtEmail.Text = "Digite seu email";
            }
        }

        private void txtEmail_Enter(object sender, EventArgs e)
        {
            txtEmail.Text = "";
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
