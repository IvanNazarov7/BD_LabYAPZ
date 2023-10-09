using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Org.BouncyCastle.Asn1.Cms;
using MySqlX.XDevAPI.Relational;

namespace Код
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        Form2 form2;

        public DataTable CheckLogin(string login, string password) {
            DB db = new DB();
            MySqlCommand LoginInDatabase = new MySqlCommand("select * from Акаунт_користувача where Логін = @uL and Пароль = @uP", db.getConnection()) ;
            LoginInDatabase.Parameters.AddWithValue("@ul", login);
            LoginInDatabase.Parameters.AddWithValue("@uP", password);
            MySqlDataAdapter adapter = new MySqlDataAdapter() { SelectCommand = LoginInDatabase };
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public void LoginToDatabase(object sender, EventArgs e)
        {
            string login = Логін.Text;
            string password = Пароль.Text;
            if (CheckLogin(login, password).Rows.Count == 1)
            {
                form2 = new Form2();
                form2.Show();
                Hide();            
            }
        }
    }
}
