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
    public partial class EditPerson : Form
    {
        public EditPerson()
        {
            InitializeComponent();
        }
        public string conString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=E:\\Maks\\Документы\\Университет\\2 курс\\2 семестр\\БД\\Профсоюзная база\\Profcom_DB.mdf;Integrated Security=True;Connect Timeout=30;User Instance=False";

        private void EditPerson_Load(object sender, EventArgs e)
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

            textBox1.Text = Person.GridValues.Col1;
            textBox2.Text = Person.GridValues.Col2;
            textBox3.Text = Person.GridValues.Col3;
            dateTimePicker1.Value = Person.GridValues.Col4;
            comboBox1.Text = Person.GridValues.Col5;
            comboBox2.Text = Person.GridValues.Col6;
            textBox4.Text = Person.GridValues.Col7;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(conString);
                con.Open();
                if (con.State == System.Data.ConnectionState.Open)
                {
                    SqlCommand personadd = new SqlCommand("UPDATE [Члены_профсоюза] SET [Фамилия] = @Фамилия, [Имя] = @Имя, [Отчество] = @Отчество, [Дата_рождения] = @Датарождения, [Код_пола] = @Кодпола, [Код_должности] = @Коддолжности WHERE Код_ЧП = @Id", con);
                personadd.Parameters.AddWithValue("@Фамилия", textBox1.Text);
                personadd.Parameters.AddWithValue("@Имя", textBox2.Text);
                personadd.Parameters.AddWithValue("@Отчество", textBox3.Text);
                personadd.Parameters.AddWithValue("@Датарождения", dateTimePicker1.Value);
                personadd.Parameters.AddWithValue("@Кодпола", comboBox1.SelectedValue);
                personadd.Parameters.AddWithValue("@Коддолжности", comboBox2.SelectedValue);
                personadd.Parameters.AddWithValue("@Id", Person.GridValues.Col0);
                    SqlCommand phoneadd = new SqlCommand("UPDATE [Телефоны] SET [Номер_телефона] = @Номер WHERE Код_ЧП = @Id", con);
                phoneadd.Parameters.AddWithValue("@Номер", textBox4.Text);
                phoneadd.Parameters.AddWithValue("@Id", Person.GridValues.Col0);

                personadd.ExecuteNonQuery();
                phoneadd.ExecuteNonQuery();
                }
                con.Close();

                Person obj = (Person)Application.OpenForms["Person"];
                obj.load();
                MessageBox.Show("Данные успешно изменены");
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
    }
}
