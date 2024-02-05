using Banco.Entities;
using MySql.Data.MySqlClient;

namespace Banco.Services
{
    internal class TransferService
    {
        private static double _valor;
        private static int _idDest;

        public static bool Transfer(double valor, string Dest)
        {
            _valor = valor;
            int _idUser = User.Id;

            if(valor > User.Limit)
            {
                MessageBox.Show("Valor excede o limite!");
                return false;
            }
            
            if(valor > User.Money)
            {
                MessageBox.Show("Valor excede o saldo!");
                return false;
            }

            var srtConection = "server=localhost;uid=root;pwd=123456;database=Banco_database";
            using (var conexao = new MySqlConnection(srtConection))
            {
                conexao.Open();

                string command3 = $"SELECT Id FROM banco_database.usertable WHERE Username = '{Dest}'";
                MySqlCommand commander3 = new MySqlCommand(command3, conexao);
                _idDest = Convert.ToInt32(commander3.ExecuteScalar());

                string command1 = $"UPDATE banco_database.usertable SET Money = Money + {_valor} WHERE Id = {_idDest}";
                MySqlCommand commander1 = new MySqlCommand(command1, conexao);
                commander1.ExecuteNonQuery();

                string command2 = $"UPDATE banco_database.usertable SET Money = Money - {_valor} WHERE Id = {_idUser}";
                MySqlCommand commander2 = new MySqlCommand(command2, conexao);
                commander2.ExecuteNonQuery();

                MessageBox.Show($"Foram transferidos ${valor.ToString("F2")} para {Dest}");

                conexao.Close();
                return true;
            }
        }
    }
}
