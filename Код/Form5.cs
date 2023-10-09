using System;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Код
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        private void addToContest()
        {
            DB dB = new DB();
            string command1 = "insert into Змагання (Назва, Дата, Місце_проведення, ID_дисципліни, ID_фінансової_операції, ID_результату, ID_учасника) value (@Name, @Data, @Teritory, @IdSport, @IdMoney, @IdRezult, @IdMember)";
            MySqlCommand newContest = new MySqlCommand(command1, dB.getConnection());
            newContest.Parameters.AddWithValue("@Name", textBox1.Text);
            newContest.Parameters.AddWithValue("@Data", textBox2.Text);
            newContest.Parameters.AddWithValue("@Teritory", textBox3.Text);
            newContest.Parameters.AddWithValue("@IdSport", textBox4.Text);
            newContest.Parameters.AddWithValue("@IdMoney", textBox5.Text);
            newContest.Parameters.AddWithValue("@IdRezult", textBox6.Text);
            newContest.Parameters.AddWithValue("@IdMember", textBox7.Text);
            if (newContest.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("True");
            }
            else
            {
                MessageBox.Show("False");
            }
        }

        private void ClearTextBoxes()
        {
            textBox1.Text = null;
            textBox2.Text = null;
            textBox3.Text = null;
            textBox4.Text = null;
            textBox5.Text = null;
            textBox6.Text = null;
            textBox7.Text = null;
        }

        private void createTheContest(object sender, EventArgs e)
        {
            addToContest();
            ClearTextBoxes();
        }

        private void returnToMenu(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            Close();
            form2.Show();
        }

        private void ExitFromApplication(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
