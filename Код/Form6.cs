using System;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace Код
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }
        private DataTable Command(string commandString)
        {
            DB db = new DB();
            MySqlCommand Command = new MySqlCommand(commandString, db.getConnection());
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter() { SelectCommand = Command };
            adapter.Fill(table);
            return table;
        }

        private void SelectionAllClub_sMembers(object sender, EventArgs e)
        {            
            
            string Сommand = "select * from Учасник_клубу";
            dataGridView1.DataSource = Command(Сommand);
            
        }

        private void SelectionAllFinanceOperations(object sender, EventArgs e)
        {
            
            string Сommand = "select * from Фінансові_операції";
            dataGridView1.DataSource = Command(Сommand);
            
        }

        private void SelectionAllEvents(object sender, EventArgs e)
        {
            
            string Сommand = "SELECT 'Тренування' AS Тип_заходу, Тренування.Назва AS Назва_заходу, Тренування.Дата AS Дата_заходу FROM Тренування UNION SELECT 'Змагання' AS Тип_заходу, Змагання.Назва AS Назва_заходу, Змагання.Дата AS Дата_заходу FROM Змагання";
            dataGridView1.DataSource = dataGridView1.DataSource = Command(Сommand); ;
        }

        private void ReturnToMenu(object sender, EventArgs e)
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
