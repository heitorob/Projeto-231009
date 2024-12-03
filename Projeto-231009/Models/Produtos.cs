using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;
using static Org.BouncyCastle.Asn1.Cmp.Challenge;

namespace Projeto_231009.Models
{
    public class Produtos
    {
        public int id { get; set; }
        public string descricao { get; set; }
        public int idCategoria { get; set; }
        public int idMarca { get; set; }
        public double estoque {  get; set; }
        public double valorVenda { get; set; }
        public string foto { get; set; }

        public void Incluir()
        {
            try
            {
                Banco.Conectar.Open();
                Banco.Comando = new MySqlCommand("INSERT INTO produtos (descricao, idCategoria, idMarca, estoque, valorVenda, foto) VALUES (@descricao, @idCategoria, @idMarca, @estoque, @valorVenda, @foto)", Banco.Conectar);
                Banco.Comando.Parameters.AddWithValue("@descricao", descricao);
                Banco.Comando.Parameters.AddWithValue("@idCategoria", idCategoria);
                Banco.Comando.Parameters.AddWithValue("@idMarca", idMarca);
                Banco.Comando.Parameters.AddWithValue("@estoque", estoque);
                Banco.Comando.Parameters.AddWithValue("@valorVenda", valorVenda);
                Banco.Comando.Parameters.AddWithValue("@foto", foto);
                Banco.Comando.ExecuteNonQuery();
                Banco.Conectar.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Alterar()
        {
            try
            {
                Banco.Conectar.Open();
                Banco.Comando = new MySqlCommand("UPDATE produtos SET descricao = @descricao, idCategoria = @idCategoria, idMarca = @idMarca, estoque = @estoque, valorVenda = @valorVenda, foto = @foto where id = @id", Banco.Conectar);
                Banco.Comando.Parameters.AddWithValue("@id", id);
                Banco.Comando.Parameters.AddWithValue("@descricao", descricao);
                Banco.Comando.Parameters.AddWithValue("@idCategoria", idCategoria);
                Banco.Comando.Parameters.AddWithValue("@idMarca", idMarca);
                Banco.Comando.Parameters.AddWithValue("@estoque", estoque);
                Banco.Comando.Parameters.AddWithValue("@valorVenda", valorVenda);
                Banco.Comando.Parameters.AddWithValue("@foto", foto);
                Banco.Comando.ExecuteNonQuery();
                Banco.Conectar.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Excluir()
        {
            try
            {
                Banco.Conectar.Open();
                Banco.Comando = new MySqlCommand("DELETE FROM produtos WHERE id = @id", Banco.Conectar);
                Banco.Comando.Parameters.AddWithValue("@id", id);
                Banco.Comando.ExecuteNonQuery();
                Banco.Conectar.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public DataTable Consultar()
        {
            try
            {
                Banco.Comando = new MySqlCommand("SELECT p.*, c.categoria categoria, m.marca FROM produtos p INNER JOIN categorias c on (c.id = p.idCategoria) INNER JOIN marcas m on (m.id = p.idMarca) where p.descricao like ?descricao order by p.descricao", Banco.Conectar);
                Banco.Comando.Parameters.AddWithValue("@descricao", descricao + "%");
                Banco.Adaptar = new MySqlDataAdapter(Banco.Comando);
                Banco.DataTabela = new DataTable();
                Banco.Adaptar.Fill(Banco.DataTabela);
                return Banco.DataTabela;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
    }
}
