using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace JogodoGalo
{
    public partial class Guardar : Form
    {
        public Guardar()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
            

        }

        private void bsave_Click(object sender, EventArgs e)
        {
            string conectionstring = "Server = 127.0.0.1; Database = highscore; Uid = root; Pwd = ''; ";

            MySqlConnection dados = new MySqlConnection(conectionstring);

            dados.Open();

            MySqlCommand data = new MySqlCommand();

            data.Connection = dados;

            

            data.Connection = dados;

            data.CommandText = "INSERT INTO jogadores(nomejoga,filtros) VALUES (@jogador, @filtro)";

            data.Parameters.Add("@jogador", MySqlDbType.VarChar).Value = textBox1.Text;

            data.Parameters.Add("@filtro", MySqlDbType.Int32).Value = 0;

            data.ExecuteNonQuery();



            dados.Close();

            this.Close();

        }

        private void bcancel_Click(object sender, EventArgs e)
        {

        }
    }
}
