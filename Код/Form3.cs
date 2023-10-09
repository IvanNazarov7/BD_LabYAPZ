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

namespace Код
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        DB dB = new DB();

        private void RegMember()
        {
            string command1 = "insert into Учасник_клубу (ПІБ, Дата_народження, Контактні_дані, Дата_вступу, Досвід) value (@Name, @Birthday, @Phone, @TheDataOfOneOfUs, @Exp)";
            MySqlCommand reg1 = new MySqlCommand(command1, dB.getConnection());
            reg1.Parameters.AddWithValue("@Name", textBox1.Text);
            reg1.Parameters.AddWithValue("@TheDataOfOneOfUs", textBox8.Text);
            reg1.Parameters.AddWithValue("@Birthday", textBox9.Text);
            reg1.Parameters.AddWithValue("@Phone", textBox2.Text);
            reg1.Parameters.AddWithValue("@Exp", textBox3.Text);
            dB.openConnection();

            if (reg1.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Користувача зареєстровано");
            }
            else
            {
                MessageBox.Show("Помилка реєстрації");
            }

            dB.closeConnection();
        }

        private void RegAccountMember()
        {
            string command2 = "insert into Учасник_клубу (Логін, Пароль, ID_ролі, ID_учасника) value (@Login, @Password, @IdRole, @IdMember)";
            MySqlCommand reg2 = new MySqlCommand(command2, dB.getConnection());
            reg2.Parameters.AddWithValue("@Login", textBox4.Text);
            reg2.Parameters.AddWithValue("@Password", textBox5.Text);
            reg2.Parameters.AddWithValue("@IdRole", textBox7.Text);
            reg2.Parameters.AddWithValue("@IdMember", textBox6.Text);
            dB.openConnection();

            if (reg2.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Акаунт користувача зареєстровано");
            }
            else
            {
                MessageBox.Show("Помилка реєстрації");
            }

            dB.closeConnection();
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
            textBox8.Text = null;
            textBox9.Text = null;
        }

        private void NewMember(object sender, EventArgs e)
        {
            RegMember();
            RegAccountMember();
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
