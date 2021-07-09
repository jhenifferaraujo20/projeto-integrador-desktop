using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Painel
{
    public partial class FormProdutos : Form
    {
        public FormProdutos()
        {
            InitializeComponent();
        }

        private void FormProdutos_Load(object sender, EventArgs e)
        {
            string BancoDeDados = "server=localhost;user id=root;password=;database=loja_jadore";
            MySqlConnection conexao = new MySqlConnection(BancoDeDados);
            try
            {
                conexao.Open();
                string sqlSelect = $"SELECT produtos.id, produtos.nome, produtos.preco, produtos.preco_antigo, produtos.descricao, produtos.cor, produtos.tamanho, categorias.categoria AS 'categoria', subcategorias.subcategoria AS 'subcategoria', produtos.quantidade_estoque, produtos.fotos FROM produtos INNER JOIN categorias ON produtos.id_categoria = categorias.id INNER JOIN subcategorias ON produtos.id_subcategoria = subcategorias.id";
                MySqlDataAdapter da = new MySqlDataAdapter(sqlSelect, conexao);
                DataTable dt = new DataTable();
                da.Fill(dt);
                GridProdutos.DataSource = dt;
            }
            catch (MySqlException erro)
            {
                MessageBox.Show("Ocorreu um erro. \nErro: " + erro.Message, "Erro", MessageBoxButtons.OK);
            }
        }

        private void textBoxBusca_TextChanged(object sender, EventArgs e)
        {
            string BancoDeDados = "server=localhost;user id=root;password=;database=loja_jadore";
            MySqlConnection conexao = new MySqlConnection(BancoDeDados);
            try
            {
                string Busca = textBoxBusca.Text;
                conexao.Open();
                string sqlSelect = $"SELECT produtos.id, produtos.nome, produtos.preco, produtos.preco_antigo, produtos.descricao, produtos.cor, produtos.tamanho, categorias.categoria AS 'categoria', subcategorias.subcategoria AS 'subcategoria', produtos.quantidade_estoque, produtos.fotos FROM produtos INNER JOIN categorias ON produtos.id_categoria = categorias.id INNER JOIN subcategorias ON produtos.id_subcategoria = subcategorias.id WHERE produtos.nome LIKE '%{Busca}%'";
                MySqlDataAdapter da = new MySqlDataAdapter(sqlSelect, conexao);
                DataTable dt = new DataTable();
                da.Fill(dt);
                GridProdutos.DataSource = dt;
                conexao.Close();
            }
            catch (MySqlException erro)
            {
                MessageBox.Show("Ocorreu um erro. \nErro: " + erro.Message, "Erro", MessageBoxButtons.OK);
            }
        }
    }
}
