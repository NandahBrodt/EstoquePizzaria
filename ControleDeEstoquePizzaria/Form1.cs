using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ControleDeEstoquePapelaria
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private MySqlConnectionStringBuilder conexaoBanco()
        {
            MySqlConnectionStringBuilder conexaoBD = new MySqlConnectionStringBuilder();
            conexaoBD.Server = "localhost";
            conexaoBD.Database = "pizzaria";
            conexaoBD.UserID = "root";
            conexaoBD.Password = "";
            conexaoBD.SslMode = 0;
            return conexaoBD;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btLimpar_Click(object sender, EventArgs e)
        {
           limparCampos();
        }

        private void limparCampos()
        {
            tbSabor.Clear();
            tbTipo.Clear();
            tbCategoria.Clear();
            tbIgredientes.Clear();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            atualizaGrid();
        }

        private void atualizaGrid()
        {
            MySqlConnectionStringBuilder conexaoBD = conexaoBanco();
            MySqlConnection realizaConexacoBD = new MySqlConnection(conexaoBD.ToString());
            try
            {
                realizaConexacoBD.Open();

                MySqlCommand comandoMySql = realizaConexacoBD.CreateCommand();
                comandoMySql.CommandText = "SELECT * FROM pizzas WHERE ativoPizza = 1";
                MySqlDataReader reader = comandoMySql.ExecuteReader();

                dgPizzaria.Rows.Clear();

                while (reader.Read())
                {
                    DataGridViewRow row = (DataGridViewRow)dgPizzaria.Rows[0].Clone();//FAZ UM CAST E CLONA A LINHA DA TABELA
                    row.Cells[0].Value = reader.GetInt32(0);//ID
                    row.Cells[1].Value = reader.GetString(1);//SABOR
                    row.Cells[2].Value = reader.GetString(2);//TIPO
                    row.Cells[3].Value = reader.GetString(3);//CATEGORIA
                    row.Cells[4].Value = reader.GetString(4);//IGREDIENTES
                    dgPizzaria.Rows.Add(row);//ADICIONO A LINHA NA TABELA
                }

                realizaConexacoBD.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! ");
                Console.WriteLine(ex.Message);
            }
        }

        private void btInserir_Click(object sender, EventArgs e)
        {
            MySqlConnectionStringBuilder conexaoBD = conexaoBanco();
            MySqlConnection realizaConexacoBD = new MySqlConnection(conexaoBD.ToString());
            try
            {
                realizaConexacoBD.Open();

                MySqlCommand comandoMySql = realizaConexacoBD.CreateCommand();

                comandoMySql.CommandText = "INSERT INTO pizzas (saborPizza,tipoPizza,CategoriaPizza,igredientesPizza) " +
                    "VALUES('" + tbSabor.Text + "', '" + tbTipo.Text + "','" + tbCategoria.Text + "', '" + tbIgredientes.Text + "')";
                comandoMySql.ExecuteNonQuery();

                realizaConexacoBD.Close();
                atualizaGrid();
                MessageBox.Show("Inserido com sucesso");
                limparCampos();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
