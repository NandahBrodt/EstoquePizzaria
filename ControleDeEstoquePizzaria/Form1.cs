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

        private void dgPizzaria_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgPizzaria.CurrentRow.Selected = true;
            //preenche os textbox com as células da linha selecionada
            tbSabor.Text = dgPizzaria.Rows[e.RowIndex].Cells["colSabor"].FormattedValue.ToString();
            tbTipo.Text = dgPizzaria.Rows[e.RowIndex].Cells["colTipo"].FormattedValue.ToString();
            tbCategoria.Text = dgPizzaria.Rows[e.RowIndex].Cells["colCategoria"].FormattedValue.ToString();
            tbIgredientes.Text = dgPizzaria.Rows[e.RowIndex].Cells["colIgredientes"].FormattedValue.ToString();
            tbID.Text = dgPizzaria.Rows[e.RowIndex].Cells["colID"].FormattedValue.ToString();
        }

        private void btAlterar_Click(object sender, EventArgs e)
        {

            MySqlConnectionStringBuilder conexaoBD = conexaoBanco();
            MySqlConnection realizaConexacoBD = new MySqlConnection(conexaoBD.ToString());
            try
            {
                realizaConexacoBD.Open(); //Abre a conexão com o banco

                MySqlCommand comandoMySql = realizaConexacoBD.CreateCommand(); //Crio um comando SQL
                comandoMySql.CommandText = "UPDATE pizzas SET saborPizza = '" + tbSabor.Text + "', " +
                    "tipoPizza = '" + tbTipo.Text + "', " +
                    "categoriaPizza = '" + tbCategoria.Text + "', " +
                    "igredientesPizza = '" + tbIgredientes.Text + "' " +
                    " WHERE idPizza = " + tbID.Text + "";
                comandoMySql.ExecuteNonQuery();

                realizaConexacoBD.Close(); // Fecho a conexão com o banco
              
                atualizaGrid();
                limparCampos();
                MessageBox.Show("Atualizado com sucesso"); //Exibo mensagem de aviso
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Não foi possivel abrir a conexão! ");
                Console.WriteLine(ex.Message);
            }
        }

      

     

        private void btLimpar_Click_1(object sender, EventArgs e)
        {
            limparCampos();
        }

        private void limparCampos()
        {
            tbID.Clear();
            tbSabor.Clear();
            tbTipo.Clear();
            tbCategoria.Clear();
            tbIgredientes.Clear();
        }

        private void btDeletar_Click_1(object sender, EventArgs e)
        {
            MySqlConnectionStringBuilder conexaoBD = conexaoBanco();
            MySqlConnection realizaConexacoBD = new MySqlConnection(conexaoBD.ToString());
            try
            {
                realizaConexacoBD.Open(); //Abre a conexão com o banco

                MySqlCommand comandoMySql = realizaConexacoBD.CreateCommand(); //Crio um comando SQL
                // "DELETE FROM pizzas WHERE idPizza= "+ textBoxId.Text +""
                //comandoMySql.CommandText = "DELETE FROM pizzas WHERE idPizza = " + tbID.Text + "";
                comandoMySql.CommandText = "UPDATE pizzas SET ativoPizza = 0 WHERE idPizza = " + tbID.Text + "";

                comandoMySql.ExecuteNonQuery();

                realizaConexacoBD.Close(); // Fecho a conexão com o banco
                
                atualizaGrid();
                limparCampos();
                MessageBox.Show("Deletado com sucesso"); //Exibo mensagem de aviso
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Não foi possivel abrir a conexão! ");
                Console.WriteLine(ex.Message);
            }
        }
    }
}
