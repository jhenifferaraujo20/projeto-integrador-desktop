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
    public partial class FormClientes : Form
    {
        private Form currentChildForm;

        public FormClientes()
        {
            InitializeComponent();
        }

        private void FormClientes_Load(object sender, EventArgs e)
        {
            string BancoDeDados = "server=localhost;user id=root;password=;database=loja_jadore";
            MySqlConnection conexao = new MySqlConnection(BancoDeDados);
            try
            {
                conexao.Open();
                string sqlSelect = $"SELECT * FROM clientes";
                MySqlDataAdapter da = new MySqlDataAdapter(sqlSelect, conexao);
                DataTable dt = new DataTable();
                da.Fill(dt);
                GridClientes.DataSource = dt;
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
                string sqlSelect = $"SELECT * FROM clientes WHERE nome_completo LIKE '%{Busca}%'";
                MySqlDataAdapter da = new MySqlDataAdapter(sqlSelect, conexao);
                DataTable dt = new DataTable();
                da.Fill(dt);
                GridClientes.DataSource = dt;
                conexao.Close();
            }
            catch (MySqlException erro)
            {
                MessageBox.Show("Ocorreu um erro. \nErro: " + erro.Message, "Erro", MessageBoxButtons.OK);
            }
        }

        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                // Abrir apenas um formulário
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelFormClientes.Controls.Add(childForm);
            panelFormClientes.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void ButtonNovoCliente_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormClientesCadastro());
        }
    }
}
