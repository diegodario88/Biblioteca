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
    public partial class CadastrarEmprestimo : Form
    {
        SqlConnection con;
        bancodedados banco = new bancodedados();
        int selecao, intIDLeitor, intIDLivro;
        string strLeitor, strLivro, strRetirada, strDevolucao;

        public CadastrarEmprestimo()
        {
            InitializeComponent();

            con = banco.abrir_conexao();
            txtRetirada.Text = DateTime.Now.ToShortDateString();
            //AQUI É O LOCAL ONDE SERÁ DEFINIDO A REGRA DE NEGÓCIO DA EMPRESA
            txtDevolucao.Text = DateTime.Now.AddDays(7).ToShortDateString();
        }

        private void txtLeitor_TextChanged(object sender, EventArgs e)
        {
            strLeitor = txtLeitor.Text;

            string selecionar = @"SELECT nome, Id_cliente, endereco, numero, bairro, cidade FROM clientes where nome like '%" + strLeitor + "%'";

            SqlDataAdapter adaptador = new SqlDataAdapter(selecionar, con);
            DataTable tabela = new DataTable();
            adaptador.Fill(tabela);
            data.DataSource = tabela;

            selecao = 1;

        }

        private void txtLivro_TextChanged(object sender, EventArgs e)
        {
            strLivro = txtLivro.Text;

            string selecionar = @"SELECT Nome, Id_Livro, Autor, Genero, Paginas, Quantidade FROM Livro where Nome like '%" + strLivro + "%'";

            SqlDataAdapter adaptador = new SqlDataAdapter(selecionar, con);
            DataTable tabela = new DataTable();
            adaptador.Fill(tabela);
            data.DataSource = tabela;

            selecao = 2;

        }

        private void CadastraCampos(object sender, DataGridViewCellEventArgs e)
        {
            if (selecao == 1)
            {
                intIDLeitor = Convert.ToInt32(data.Rows[e.RowIndex].Cells[1].Value);
                txtIdLeitor.Text = Convert.ToString(intIDLeitor);
                strLeitor = Convert.ToString(data.Rows[e.RowIndex].Cells[0].Value);
                lblLeitor.Text = strLeitor;

            }

            if (selecao == 2)
            {

                intIDLivro = Convert.ToInt32(data.Rows[e.RowIndex].Cells[1].Value);
                txtIdLivro.Text = Convert.ToString(intIDLivro);
                strLivro = Convert.ToString(data.Rows[e.RowIndex].Cells[0].Value);
                lblLivro.Text = strLivro;

            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if ((txtIdLivro.Text != "") && (txtIdLeitor.Text != ""))
            {


                strLeitor = lblLeitor.Text;
                strLivro = lblLivro.Text;
                intIDLeitor = Convert.ToInt32(txtIdLeitor.Text);
                intIDLivro = Convert.ToInt32(txtIdLivro.Text);
                strRetirada = txtRetirada.Text;
                strDevolucao = txtDevolucao.Text;



                string inserir = @"insert into Emprestimo (Id_Leitor, Id_Livro, Leitor, Livro, Retirada, Devolucao) values ('" + intIDLeitor + "','" + intIDLivro + "','" + strLeitor + "','" + strLivro + "','" + strRetirada + "', '" + strDevolucao + "')";

                SqlCommand _cmd = new SqlCommand(inserir, con);

                // executa o comando

                _cmd.ExecuteNonQuery();

                //Fecha a conexão

                con.Close();
                //Exibe Mensagem!!

                MessageBox.Show("Emprestimo cadastrado com Sucesso!");

            }

            else
            {
                MessageBox.Show("Certifique-se que todos os campos foram preenchidos!");
                txtLeitor.Focus();
            }
        }
    }
}

        

       
