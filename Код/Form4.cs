using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Код
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        private void addAFinanceOperation()
        {
            DB dB = new DB();
            string command1 = "insert into Фінансові_операції (Назва, Сума, Дата, Опис) value (@Name, @Sum, @DATA, @Opus)";
            MySqlCommand newMoney = new MySqlCommand(command1, dB.getConnection());
            newMoney.Parameters.AddWithValue("@Name", textBox1.Text);
            newMoney.Parameters.AddWithValue("@Sum", textBox3.Text);
            newMoney.Parameters.AddWithValue("@DATA", textBox2.Text);
            newMoney.Parameters.AddWithValue("@Opus", textBox4.Text);
            MessageBox.Show("Операцію зареєстровано");
            if (newMoney.ExecuteNonQuery() == 1)
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
        }

        private void createAFinanceOperation(object sender, EventArgs e)
        {
            addAFinanceOperation();
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
