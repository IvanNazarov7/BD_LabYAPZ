using System;
using System.Windows.Forms;

namespace Код
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            RegisterForm = new Form3();
            MoneyForm = new Form4();
            ContestForm = new Form5();
            SQL = new Form6();
        }
        Form3 RegisterForm;
        Form4 MoneyForm;
        Form5 ContestForm;
        Form6 SQL;

        private void Register_Click(object sender, EventArgs e)
        {
                RegisterForm.Show();
                Close();
        }

        private void Money_Click(object sender, EventArgs e)
        {
                MoneyForm.Show();
                Close();
        }

        private void Contest_Click(object sender, EventArgs e)
        {
                ContestForm.Show();
                Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SQL.Show();
            Close();
        }

        private void ExitFromApplication(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
