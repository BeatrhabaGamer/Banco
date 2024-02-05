using MySql.Data.MySqlClient;
using Banco.Entities;
using Banco;

namespace Banco2
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            try
            {
                var srtConnection = GlobalVariables.strConection;
                using (var connection = new MySqlConnection(srtConnection))
                {
                    connection.Open();

                    // Consulta para obter o limite do usuário
                    string queryLimit = $"SELECT Limits FROM usertable WHERE Id = {User.Id}";
                    MySqlCommand commandLimit = new MySqlCommand(queryLimit, connection);
                    object limitResult = commandLimit.ExecuteScalar();

                    if (limitResult != null && limitResult != DBNull.Value)
                    {
                        User.Limit = Convert.ToDouble(limitResult);
                    }
                    else
                    {
                        User.Limit = 0; // Define um valor padrão se não houver limite retornado
                    }

                    // Consulta para obter o saldo do usuário
                    string queryMoney = $"SELECT Money FROM usertable WHERE Id = {User.Id}";
                    MySqlCommand commandMoney = new MySqlCommand(queryMoney, connection);
                    object moneyResult = commandMoney.ExecuteScalar();

                    if (moneyResult != null && moneyResult != DBNull.Value)
                    {
                        User.Money = Convert.ToDouble(moneyResult);
                    }
                    else
                    {
                        User.Money = 0; // Define um valor padrão se não houver saldo retornado
                    }

                    connection.Close();
                }

                // Atualiza os controles do formulário com as informações do usuário
                label1.Text = "Nome: " + User.Name;
                label2.Text = "Id: " + User.Id;
                label4.Text = "Saldo: $" + User.Money.ToString("F2", System.Globalization.CultureInfo.InvariantCulture);
                label3.Text = "Limite: $" + User.Limit.ToString("F2", System.Globalization.CultureInfo.InvariantCulture);
            }
            catch (Exception ex)
            {
                // Manipular exceção aqui
                MessageBox.Show("Erro ao carregar informações do usuário: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            new Form4().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            new Form1().Show();
        }
    }
}
