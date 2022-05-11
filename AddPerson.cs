using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Профсоюзная_база
{
    public partial class AddPerson : Form
    {
        public string conString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=E:\\Maks\\Документы\\Университет\\2 курс\\2 семестр\\БД\\Профсоюзная база\\Profcom_DB.mdf;Integrated Security=True;Connect Timeout=30;User Instance=False";

        public AddPerson()
        {
            InitializeComponent();
        }

        private void AddPerson_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Должности". При необходимости она может быть перемещена или удалена.
            this.должностиTableAdapter.Fill(this.dataSet1.Должности);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Гендер". При необходимости она может быть перемещена или удалена.
            this.гендерTableAdapter.Fill(this.dataSet1.Гендер);
            comboBox1.DataSource = this.dataSet1.Гендер;
            comboBox1.DisplayMember = "Пол";
            comboBox1.ValueMember = "Код_пола";
            comboBox2.DataSource = this.dataSet1.Должности;
            comboBox2.DisplayMember = "Должность";
            comboBox2.ValueMember = "Код_должности";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(conString);
            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {
                SqlCommand personadd = new SqlCommand(
                    $"INSERT INTO [Члены_профсоюза] (Фамилия, Имя, Отчество, Дата_рождения, Код_пола, Код_должности) VALUES (N'{textBox1.Text}', N'{textBox2.Text}', N'{textBox3.Text}', N'{dateTimePicker1.Value}', N'{comboBox1.SelectedValue}', N'{comboBox2.SelectedValue}')", con);
                SqlCommand query = new SqlCommand("SELECT SCOPE_IDENTITY()", con);
                personadd.ExecuteNonQuery();
                int a = Convert.ToInt16(query.ExecuteScalar());
                SqlCommand phoneadd = new SqlCommand(
                    $"INSERT INTO [Телефоны] (Код_ЧП, Номер_телефона) VALUES (N'{a}', N'{textBox4.Text}')", con);
                phoneadd.ExecuteNonQuery();
                }
            con.Close();

                Person main = new Person();
                Person obj = (Person)Application.OpenForms["Person"];
                obj.load();
                MessageBox.Show("Сотрудник добавлен");
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
