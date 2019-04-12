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
    public partial class ConsultaLivro : Form
    {
        public ConsultaLivro()
        {
            InitializeComponent();
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            // Fazer o código que irá exibir no DATAGRID
            //Atribui o texto digitado no argumento StrNome
            bancodedados banco = new bancodedados();
            SqlConnection con;
            con = banco.abrir_conexao();
            string StrNome = txtNome.Text;

            //Realiza a consultano banco pelo que foi digitado e guardado no argumento StrNome
            string selecionar = @"SELECT Nome, Id_Livro, Autor, Genero, Paginas, Quantidade FROM Livro where Nome like '%" + strNome + "%'";

            //Alimenta o DATAGRID com as informações do SELECT especificado acima
            SqlDataAdapter adaptador = new SqlDataAdapter(selecionar, con);
            DataTable tabela = new DataTable();
            adaptador.Fill(tabela);
            data.DataSource = tabela;
            con.Close();
        }
        public string strNome { get; set; }

    }
}
