using Banco.Services;
namespace Banco2
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string destname = textBox1.Text;
            double valor = double.Parse(textBox2.Text, System.Globalization.CultureInfo.InvariantCulture);

            bool a = TransferService.Transfer(valor, destname);
            if (a)
            {
                Hide();
                new Form3().Show();
            }
            else
            {
                MessageBox.Show("Tente novamente");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            new Form3().Show();
        }
    }
}
