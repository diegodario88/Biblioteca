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
    public partial class ConsultaLeitor : Form
    {
        public ConsultaLeitor()
        {
            InitializeComponent();
        }

        private void TxtNome_TextChanged(object sender, EventArgs e)
        {
            bancodedados banco = new bancodedados();

            SqlConnection con;
            con = banco.abrir_conexao();

            String strNome = txtNome.Text;

            string selecionar = @"SELECT nome,Id_cliente, endereco, numero, bairro, cidade FROM clientes where nome like '%" + strNome + "%'";

            SqlDataAdapter adaptador = new SqlDataAdapter(selecionar, con);
            DataTable tabela = new DataTable();
            adaptador.Fill(tabela);
            data.DataSource = tabela;
            con.Close();


        }

      
    }
}
