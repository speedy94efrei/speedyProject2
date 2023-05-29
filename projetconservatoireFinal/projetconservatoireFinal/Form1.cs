using MySql.Data.MySqlClient;

namespace projetconservatoireFinal
{
    public partial class Form1 : Form
    {
        private string connectionString = "server=localhost;database=conserefrei;uid=root;pwd=";
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;

            // Vérification des informations de connexion dans la base de données
            if (CheckLogin(username, password))
            {
                MessageBox.Show("Connexion réussie !");
                // Ouverture du formulaire principal de votre application après une connexion réussie

                Form2 mainForm = new Form2();
                mainForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Échec de la connexion. Veuillez vérifier vos informations d'identification.");
            }


            


        }

        private bool CheckLogin(string username, string password)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT COUNT(*) FROM administrateur WHERE login = @username AND mdp = @password";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@password", password);

                    int count = Convert.ToInt32(command.ExecuteScalar());

                    return count > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la connexion à la base de données : " + ex.Message);
                return false;
            }
        }
    }
}