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

            // V�rification des informations de connexion dans la base de donn�es
            if (CheckLogin(username, password))
            {
                MessageBox.Show("Connexion r�ussie !");
                // Ouverture du formulaire principal de votre application apr�s une connexion r�ussie

                Form2 mainForm = new Form2();
                mainForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("�chec de la connexion. Veuillez v�rifier vos informations d'identification.");
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
                MessageBox.Show("Erreur lors de la connexion � la base de donn�es : " + ex.Message);
                return false;
            }
        }
    }
}