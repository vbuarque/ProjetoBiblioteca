using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoBiblioteca
{
    public static class Conexao
    {
        public static SqlConnection conn;
        public static string conexao = @"Data Source = SJC0562927W10-1;
                Initial Catalog = BIBLIOTECA;
                User Id = sa; Password = senac@sjc";

        public static void Conectar()
        {
            conn = new SqlConnection(conexao);
            conn.Open();
        }

        public static void Desconectar()
        {
            conn.Close();
        }
    }
}
