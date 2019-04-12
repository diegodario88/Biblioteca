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
    public partial class ConsultarEmprestimo : Form
    {
        SqlConnection con;
        bancodedados banco = new bancodedados();
        public ConsultarEmprestimo()
        {
            InitializeComponent();
            con = banco.abrir_conexao();
        }

        private void data_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            String strNome = txtNome.Text;

            string selecionar = @"SELECT Leitor, Livro, Retirada, Devolucao, Id_Emprestimo FROM Emprestimo where Leitor like '%" + strNome + "%'";

            SqlDataAdapter adatador = new SqlDataAdapter(selecionar, con);
            DataTable tabela = new DataTable();
            adatador.Fill(tabela);
            data.DataSource = tabela;
        }
    }
}
