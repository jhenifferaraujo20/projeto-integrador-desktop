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
    public partial class FormClientesCadastro : Form
    {
        public FormClientesCadastro()
        {
            InitializeComponent();
        }

        private void LimparFormulario()
        {
            textBoxNome.Clear();
            textBoxCpf.Clear();
            textBoxTelefone.Clear();
            textBoxEmail.Clear();
            textBoxCep.Clear();
            textBoxRua.Clear();
            textBoxNumero.Clear();
            textBoxBairro.Clear();
            textBoxCidade.Clear();
            textBoxEstado.Clear();
        }

        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            LimparFormulario();
        }

        private void SalvarCliente(string nome, string cpf, string telefone, string email, string cep, string rua, string numero, string bairro, string cidade, string estado)
        {
            string BandoDeDados = "server=localhost;user id=root;password=;database=loja_jadore";
            MySqlConnection conexao = new MySqlConnection(BandoDeDados);
            try
            {
                conexao.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexao;
                cmd.CommandText = $"INSERT INTO clientes (nome_completo, cpf, telefone, email, cep, rua, numero_casa, bairro, cidade, estado) VALUES ('{nome}', '{cpf}', '{telefone}', '{email}', '{cep}', '{rua}', '{numero}', '{bairro}', '{cidade}', '{estado}')";
                cmd.ExecuteNonQuery();
                conexao.Close();
                MessageBox.Show("Cadastro efetuado com sucesso.");
            }
            catch (MySqlException erro)
            {
                MessageBox.Show("Ocorreu um erro. \nErro: " + erro.Message, "Erro", MessageBoxButtons.OK);
            }
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            SalvarCliente(textBoxNome.Text, textBoxCpf.Text, textBoxTelefone.Text, textBoxEmail.Text, textBoxCep.Text, textBoxRua.Text, textBoxNumero.Text, textBoxBairro.Text, textBoxCidade.Text, textBoxEstado.Text);
            LimparFormulario();
        }

    }
}
