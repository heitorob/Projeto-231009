using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Projeto_231009
{
    public class Banco
    {
        public static MySqlConnection Conectar;
        public static MySqlCommand Comando;
        public static MySqlDataAdapter Adaptar;
        public static DataTable DataTabela;

        public static void AbrirConexao()
        {
            try
            {
                Conectar = new MySqlConnection("server=localhost;port=3307;uid=root;pwd=etecjau;");
                Conectar.Open();

                Comando = new MySqlCommand("CREATE DATABASE IF NOT EXISTS vendas;", Conectar);
                Comando.ExecuteNonQuery();

                Conectar.Close();

                Conectar = new MySqlConnection("server=localhost;port=3307;uid=root;pwd=etecjau;database=vendas");
                Conectar.Open();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void FecharConexao()
        {
            try
            {
                Conectar.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Conectar.Close();
            }
        }

        public static void CriarBanco()
        {
            try
            {
                AbrirConexao();

                Comando = new MySqlCommand("CREATE TABLE IF NOT EXISTS cidades (id integer auto_increment primary key, nome char(40), uf char(2));", Conectar);
                Comando.ExecuteNonQuery();

                Comando = new MySqlCommand("CREATE TABLE IF NOT EXISTS marcas (id integer auto_increment primary key, marca char(20));", Conectar);
                Comando.ExecuteNonQuery();

                Comando = new MySqlCommand("CREATE TABLE IF NOT EXISTS categorias (id integer auto_increment primary key, categoria char(20));", Conectar);
                Comando.ExecuteNonQuery();

                Comando = new MySqlCommand("CREATE TABLE IF NOT EXISTS clientes (id integer auto_increment primary key, nome char(40), idCidade integer, nascimento date, renda decimal(10,2), cpf char(14), foto varchar(100), venda boolean)", Conectar);
                Comando.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
