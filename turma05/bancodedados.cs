using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace turma05
{
    class bancodedados
    {
        SqlConnection con;

        public SqlConnection abrir_conexao()
        {
            
            con = new SqlConnection();
            con.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\diego\source\repos\senaccsharp\turma05\bancodedados.mdf";
            con.Open();
            return con;

        }
        public void fechar_conexao (SqlConnection con)
        {
            con.Close();
        }
    }
}
