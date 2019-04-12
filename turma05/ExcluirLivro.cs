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
    public partial class ExcluirLivro : Form
    {
        SqlConnection con;
        bancodedados banco = new bancodedados();
        int codigo_livro;
        
        public ExcluirLivro()
        {
            InitializeComponent();
            con = banco.abrir_conexao();
            btnExcluir.Enabled = false;
            
        }

        private void ExcluirLivro_Load(object sender, EventArgs e)
        {

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            String strNome = txtNome.Text;

            string selecionar = @"SELECT Nome, Id_Livro, Autor, Genero, Paginas, Quantidade FROM Livro where Nome like '%" + strNome + "%'";

            SqlDataAdapter adaptador = new SqlDataAdapter(selecionar, con);
            DataTable tabela = new DataTable();
            adaptador.Fill(tabela);
            data.DataSource = tabela;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Você tem certeza que deseja Excluir?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes)
            {
                //Deleta o Registro
                string deletar = @"DELETE FROM Livro WHERE Id_Livro='" + codigo_livro + "';";

                SqlCommand _cmd = new SqlCommand(deletar, con);
                _cmd.ExecuteNonQuery();
                txtNome.Text = "";

                //Atualiza Data
                string strNome = txtNome.Text;
                string selecionar = @"SELECT Nome, Id_Livro, Autor, Genero, Paginas, Quantidade FROM Livro where Nome like '%" + strNome + "%'";

                //Exibe no DataGrid
                SqlDataAdapter a = new SqlDataAdapter(selecionar, con);
                DataTable t = new DataTable();
                a.Fill(t);
                data.DataSource = t;
                btnExcluir.Enabled = false;



            }
        }

        private void SelecionaRegistro(object sender, DataGridViewCellEventArgs e)
        {
            //Conteudo Selecionado na Célula 1 que é Id Livro
            codigo_livro = Convert.ToInt32(data.Rows[e.RowIndex].Cells[1].Value);
            //Código Selecionado então habilitando botão excluir
            btnExcluir.Enabled = true;
        }
    }
}
