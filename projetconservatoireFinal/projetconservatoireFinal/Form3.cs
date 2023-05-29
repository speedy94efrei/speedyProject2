using MySql.Data.MySqlClient;
using projetconservatoireFinal.DAL;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace projetconservatoireFinal
{
    public partial class Form3 : Form
    {
        private string provider = "localhost";

        private string dataBase = "conserefrei";

        private string uid = "root";
        private string mdp = "";


        private ConnexionSql maConnexionSql;


        private MySqlCommand oCom, oCom1;

        private DataTable dt;

        private string connectionString = "server=localhost;database=conserefrei;uid=root;pwd=";
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            maConnexionSql = ConnexionSql.getInstance(provider, dataBase, uid, mdp);


            maConnexionSql.OpenConnection();


            affiche();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(tb1.Text);
            string nom = tb2.Text;
            string prenom = tb3.Text;
            string prix = tb4.Text;
            string datepaiment = tb5.Text;

            if (InsertData(id, nom, prenom, prix, datepaiment))
            {
                MessageBox.Show("Données insérées avec succès !");
            }
            else
            {
                MessageBox.Show("Échec de l'insertion des données.");
            }

            affiche();
        }


        private bool InsertData(int id, string nom, string prenom, string prix, string datepaiment)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "INSERT INTO paiment (id, nom, prenom, prix, datepaiment) VALUES (@id, @nom, @prenom, @prix, @datepaiment)";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@id", id);
                    command.Parameters.AddWithValue("@nom", nom);
                    command.Parameters.AddWithValue("@prenom", prenom);
                    command.Parameters.AddWithValue("@prix", prix);
                    command.Parameters.AddWithValue("@datepaiment", datepaiment);

                    int rowsAffected = command.ExecuteNonQuery();

                    return rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de l'insertion des données : " + ex.Message);
                return false;
            }
        }

        public void affiche()

        {


            try
            {

                dt = new DataTable();

                oCom = maConnexionSql.reqExec("Select * from paiment");

                MySqlDataReader reader = oCom.ExecuteReader();

                //     MySqlDataAdapter myDataAdapter = new MySqlDataAdapter(oCom);

                //    myDataAdapter.Fill(dt);

                //   dgv1.DataSource = dt;




                for (int i = 0; i <= reader.FieldCount - 1; i++)
                {

                    dt.Columns.Add(reader.GetName(i));
                }


                while (reader.Read())
                {




                    DataRow dr = dt.NewRow();


                    for (int i = 0; i <= reader.FieldCount - 1; i++)
                    {

                        dr[i] = reader.GetValue(i);
                    }

                    dt.Rows.Add(dr);

                }




                // DATAGRIDVIEW
                dgv1.DataSource = dt;

                //     dgv1.Columns[0].ReadOnly = true;

                reader.Close();


            }


            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }



    }
}
