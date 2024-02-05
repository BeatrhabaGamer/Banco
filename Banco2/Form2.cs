using Banco2;
using MySql.Data.MySqlClient;
namespace Banco
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var srtConection = GlobalVariables.strConection;
                using (var conexao = new MySqlConnection(srtConection))
                {
                    conexao.Open();

                    // Obter o último ID da tabela
                    MySqlCommand getmaxid = new MySqlCommand("SELECT MAX(Id) AS NovoId FROM banco_database.usertable", conexao);
                    int maxId = Convert.ToInt32(getmaxid.ExecuteScalar());
                    int novoId = maxId + 1;

                    // Executar o comando de inserção
                    MySqlCommand command = new MySqlCommand($"INSERT INTO banco_database.usertable (Id, Username, Money, Limits) " +
                                                            $"VALUES ({novoId}, @username, 1000.0, 500.0)", conexao);
                    command.Parameters.AddWithValue("@username", textBox1.Text);
                    command.ExecuteNonQuery();

                    MessageBox.Show($"ID = {novoId} <GUARDE ESTE ID!>");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao conectar: " + ex.Message);
            }
            Hide();
            new Form1().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            new Form1().Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
