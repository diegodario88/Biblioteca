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

namespace turma05
{
    public partial class CadastroLivro : Form
    {
        //Conectar ao banco de dados
        SqlConnection con;
        bancodedados banco = new bancodedados();

        public CadastroLivro()
        {
            InitializeComponent();
            con = banco.abrir_conexao();
        }

        private void CadastroLivro_Load(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if ((txtLivro.Text != "") && (txtAutor.Text != "") && (txtGenero.Text != "") && (txtPaginas.Text != "") && (txtQuantidade.Text != ""))
            {
                try
                {
                    con = banco.abrir_conexao();

                    String strLivro = txtLivro.Text;
                    String strAutor = txtAutor.Text;
                    String strGenero = txtGenero.Text;
                    int intPaginas = Convert.ToInt32(txtPaginas.Text);
                    int intQuantidade = Convert.ToInt32(txtQuantidade.Text);

                    string inserir = @"insert into Livro (Nome, Autor, Genero, Paginas, Quantidade) values ('" + strLivro + "','" + strAutor + "','" + strGenero + "','" + intPaginas + "','" + intQuantidade + "')";

                    SqlCommand _cmd = new SqlCommand(inserir, con);

                    //Executar o comando
                    _cmd.ExecuteNonQuery();

                    //Fecha Banco
                    con.Close();

                    MessageBox.Show("Livro Cadastrado com Sucesso!");

                    txtLivro.Clear();
                    txtAutor.Clear();
                    txtQuantidade.Clear();
                    txtPaginas.Clear();

                }
                catch (System.FormatException)
                {
                    MessageBox.Show("Certifique-se que você digitou um número no(s) campo (s) Páginas/Quantidade");
                }


            }
            else
            {
                MessageBox.Show("Certifique-se que todos os campos foram preenchidos");
                txtLivro.Focus();
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            

        }

      
    }
}
