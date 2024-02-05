using MySql.Data.MySqlClient;
using Banco.Entities;
using Banco2;

namespace Banco
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Form2().Show();
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var srtConection = GlobalVariables.strConection;
                using (var conexao = new MySqlConnection(srtConection))
                {
                    conexao.Open();

                    // Valor a ser verificado na tabela
                    string Name = textBox1.Text;
                    int Id = int.Parse(textBox3.Text);

                    // Consulta SQL para verificar se o valor existe na tabela
                    string query = "SELECT COUNT(*) FROM banco_database.usertable WHERE Username = @valor1 AND Id= @valor2";
                    MySqlCommand command = new MySqlCommand(query, conexao);
                    command.Parameters.AddWithValue("@valor1", Name);
                    command.Parameters.AddWithValue("@valor2", Id);

                    // Executar a consulta e obter o resultado
                    int count = Convert.ToInt32(command.ExecuteScalar());

                    // Verificar se o valor existe na tabela
                    bool valorExiste = count > 0;

                    query = $"SELECT Limits FROM banco_database.usertable WHERE Id = {Id}";
                    command = new MySqlCommand(query, conexao);
                    string query2 = $"SELECT Money FROM banco_database.usertable WHERE Id = {Id}";
                    MySqlCommand command2 = new MySqlCommand(query2, conexao);
                    if (valorExiste)
                    {
                        MessageBox.Show("Conectado");
                        User.Name = Name;
                        User.Id = Id;
                        User.Limit = Convert.ToDouble(command.ExecuteScalar());
                        User.Money = Convert.ToDouble(command2.ExecuteScalar());
                        Hide();
                        new Form3().Show();
                    }
                    else
                    {
                        MessageBox.Show("Conexão não concluida, verifique os dados e tente novamente");
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao conectar: " + ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            User.Reset();
        }
    }
}
