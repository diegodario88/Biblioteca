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
    public partial class Devolucao : Form
    {
        SqlConnection con;
        bancodedados banco = new bancodedados();
        int intIDEmprestimo, intIDLeitor, intIDLivro;

        private void txtLeitor_TextChanged(object sender, EventArgs e)
        {
            strLeitor = txtLeitor.Text;

            string selecionar = @"SELECT Leitor, Livro, Retirada, Devolucao, Id_Emprestimo, Id_Leitor, Id_Livro FROM Emprestimo where Leitor like '%" + strLeitor + "%'";
            SqlDataAdapter adaptador = new SqlDataAdapter(selecionar, con);
            DataTable tabela = new DataTable();
            adaptador.Fill(tabela);
            data.DataSource = tabela;


        }

        private void btnSalvar_Click(object sender, EventArgs e)

        {
            con = banco.abrir_conexao();
            intIDLeitor = Convert.ToInt32(txtIdLeitor.Text);
            intIDLivro = Convert.ToInt32(txtIdLivro.Text);
            strLeitor = lblLeitor.Text;
            strLivro = lblLivro.Text;
            strRetirada = txtEmprestimo.Text;
            strDevolucao = txtDevolucao.Text;

            string inserir = @"insert into Devolucao (Id_Emprestimo, Id_Leitor, Id_Livro, Leitor, Livro, Retirada, Devolucao) values ('" + intIDEmprestimo + "','" + intIDLeitor + "','" + intIDLivro + "','" + strLeitor + "','" + strLivro + "', '" + strRetirada + "', '" + strDevolucao + "')";
            string excluir = @"DELETE FROM Emprestimo WHERE Id_Emprestimo='" + intIDEmprestimo + "';";

            SqlCommand _cmd = new SqlCommand(inserir, con);
            SqlCommand _cmd2 = new SqlCommand(excluir, con);

            // executa o comando

            // _cmd.ExecuteNonQuery();
            _cmd2.ExecuteNonQuery();

            //Fecha a conexão

            con.Close();
            //Exibe Mensagem!!

            MessageBox.Show("Devolução cadastrada com Sucesso!");
        }

        private void data_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void VerificaLivros(object sender, DataGridViewCellEventArgs e)
        {
            strLeitor = Convert.ToString(data.Rows[e.RowIndex].Cells[0].Value);
            lblLeitor.Text = strLeitor;


            strLivro = Convert.ToString(data.Rows[e.RowIndex].Cells[1].Value);
            lblLivro.Text = strLivro;

            strRetirada = Convert.ToString(data.Rows[e.RowIndex].Cells[2].Value);
            txtEmprestimo.Text = strRetirada;

            strDevolucao = Convert.ToString(data.Rows[e.RowIndex].Cells[3].Value);
            txtDevolucao.Text = strDevolucao;

            intIDEmprestimo = Convert.ToInt32(data.Rows[e.RowIndex].Cells[4].Value);

            intIDLeitor = Convert.ToInt32(data.Rows[e.RowIndex].Cells[5].Value);
            txtIdLeitor.Text = Convert.ToString(intIDLeitor);

            intIDLivro = Convert.ToInt32(data.Rows[e.RowIndex].Cells[6].Value);
            txtIdLivro.Text = Convert.ToString(intIDLivro);

            DateTime atual = DateTime.Now;
            DateTime devolucao = Convert.ToDateTime(strDevolucao);
            int result = DateTime.Compare(devolucao, atual);

            if (result < 0)
            {
                TimeSpan resultado = atual - devolucao;
                Double multa = resultado.Days * 2.0;
                txtDias.Text = Convert.ToString(resultado.Days);
                txtMulta.Text = Convert.ToString(multa);
            }
            else
            {
                txtDias.Text = Convert.ToString("0");
                txtMulta.Text = Convert.ToString("");
            }
        }

        string strLeitor, strLivro, strRetirada, strDevolucao;

        public Devolucao()
        {
            InitializeComponent();
            con = banco.abrir_conexao();
        }
    }
}
