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
using projetconservatoireFinal.DAL;

namespace projetconservatoireFinal
{
    public partial class Form2 : Form
    {
        private string provider = "localhost";

        private string dataBase = "conserefrei";

        private string uid = "root";
        private string mdp = "";


        private ConnexionSql maConnexionSql;


        private MySqlCommand oCom, oCom1;

        private DataTable dt;







        private string connectionString = "server=localhost;database=conserefrei;uid=root;pwd=";
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            maConnexionSql = ConnexionSql.getInstance(provider, dataBase, uid, mdp);


            maConnexionSql.OpenConnection();


            affiche();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtId.Text);
            string name = txtName.Text;
            string email = txtEmail.Text;
            string phone = txtPhone.Text;
            string address = txtAddress.Text;

            if (InsertData(id, name, email, phone, address))
            {
                MessageBox.Show("Données insérées avec succès !");
            }
            else
            {
                MessageBox.Show("Échec de l'insertion des données.");
            }

            affiche();
        }


        private bool InsertData(int id, string name, string email, string phone, string address)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "INSERT INTO etudiant (id, name, email, phone, adresse) VALUES (@id, @name, @email, @phone, @adresse)";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@id", id);
                    command.Parameters.AddWithValue("@name", name);
                    command.Parameters.AddWithValue("@email", email);
                    command.Parameters.AddWithValue("@phone", phone);
                    command.Parameters.AddWithValue("@adresse", address);

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

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 mainForm = new Form3();
            mainForm.Show();
            this.Hide();
        }

        public void affiche()

        {


            try
            {

                dt = new DataTable();

                oCom = maConnexionSql.reqExec("Select * from etudiant");

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
