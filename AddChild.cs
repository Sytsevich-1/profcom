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
    public partial class AddChild : Form
    {
        public AddChild()
        {
            InitializeComponent();
        }
        public string conString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=E:\\Maks\\Документы\\Университет\\2 курс\\2 семестр\\БД\\Профсоюзная база\\Profcom_DB.mdf;Integrated Security=True;Connect Timeout=30;User Instance=False";

        private void AddChild_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Гендер". При необходимости она может быть перемещена или удалена.
            this.гендерTableAdapter.Fill(this.dataSet1.Гендер);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Должности". При необходимости она может быть перемещена или удалена.
            this.должностиTableAdapter.Fill(this.dataSet1.Должности);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Телефоны". При необходимости она может быть перемещена или удалена.
            this.телефоныTableAdapter.Fill(this.dataSet1.Телефоны);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Члены_профсоюза". При необходимости она может быть перемещена или удалена.
            this.члены_профсоюзаTableAdapter.Fill(this.dataSet1.Члены_профсоюза);

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
                    String script = "AddChild";
                    con = new SqlConnection(conString);
                    con.Open();
                    SqlCommand personadd = new SqlCommand(script, con);
                    personadd.CommandType = System.Data.CommandType.StoredProcedure;
                    personadd.Parameters.AddWithValue("@Фамилия", textBox1.Text);
                    personadd.Parameters.AddWithValue("@Имя", textBox2.Text);
                    personadd.Parameters.AddWithValue("@Отчество", textBox3.Text);
                    personadd.Parameters.AddWithValue("@Дата_рождения", Convert.ToDateTime(dateTimePicker2.Text));
                    personadd.Parameters.AddWithValue("@Код_пола", comboBox7.SelectedValue);

                    personadd.Parameters.AddWithValue("@mother", comboBox1.Text);
                    personadd.Parameters.AddWithValue("@dad", comboBox6.Text);

                    personadd.Parameters.AddWithValue("@idmother", comboBox1.SelectedValue);
                    personadd.Parameters.AddWithValue("@iddad", comboBox6.SelectedValue);
                    personadd.ExecuteNonQuery();
                    con.Close();

                    /*SqlCommand personadd = new SqlCommand(
                       $"INSERT INTO [Дети] (Фамилия, Имя, Отчество, Дата_рождения, Код_пола) VALUES (N'{textBox1.Text}', N'{textBox2.Text}', N'{textBox3.Text}', N'{Convert.ToDateTime(dateTimePicker2.Text)}', N'{comboBox7.SelectedValue}')", con);
                    SqlCommand query = new SqlCommand("SELECT SCOPE_IDENTITY()", con);
                    personadd.ExecuteNonQuery();
                    int a = Convert.ToInt16(query.ExecuteScalar());
                    if (comboBox1.Text == "" && comboBox6.Text == "")
                    {
                        MessageBox.Show("Вы не выбрали родителя!");
                    }
                    else if (comboBox1.Text != "" && comboBox6.Text == "")
                    {
                        
                        SqlCommand phoneadd = new SqlCommand(
                        $"INSERT INTO [Дети_родители] (Код_ЧП, Код_дети) VALUES (N'{comboBox1.SelectedValue}', N'{a}')", con);
                        phoneadd.ExecuteNonQuery();
                    }
                    else if (comboBox1.Text == "" && comboBox6.Text != "")
                    {
                        
                        SqlCommand phoneadd = new SqlCommand(
                        $"INSERT INTO [Дети_родители] (Код_ЧП, Код_дети) VALUES (N'{comboBox6.SelectedValue}', N'{a}')", con);
                        phoneadd.ExecuteNonQuery();
                    }
                    else if (comboBox1.Text != "" && comboBox6.Text != "")
                    {
                        
                        SqlCommand phoneadd1 = new SqlCommand(
                        $"INSERT INTO [Дети_родители] (Код_ЧП, Код_дети) VALUES (N'{comboBox1.SelectedValue}', N'{a}')", con);
                        phoneadd1.ExecuteNonQuery();
                        SqlCommand phoneadd2 = new SqlCommand(
                        $"INSERT INTO [Дети_родители] (Код_ЧП, Код_дети) VALUES (N'{comboBox6.SelectedValue}', N'{a}')", con);
                        phoneadd2.ExecuteNonQuery();
                    }*/
                }
                con.Close();

                Child main = new Child();
                Child obj = (Child)Application.OpenForms["Child"];
                obj.load();
                MessageBox.Show("Иждивенец добавлен");
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
