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
    public partial class Person : Form
    {
        public Person()
        {
            InitializeComponent();
        }
        public SqlConnection con;
        public SqlCommand com;
        public string conString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=E:\\Maks\\Документы\\Университет\\2 курс\\2 семестр\\БД\\Профсоюзная база\\Profcom_DB.mdf;Integrated Security=True;Connect Timeout=30;User Instance=False";

        public void load()
        {
            string script = "Select * from Члены_профсоюза";
            con = new SqlConnection(conString);
            con.Open();
            SqlDataAdapter ms_data = new SqlDataAdapter(script, conString);
            DataTable table = new DataTable();
            ms_data.Fill(table);
            dataGridView1.DataSource = table;
            con.Close();
        }
        public void Form1_Load(object sender, EventArgs e)
        {
            load();
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Телефоны". При необходимости она может быть перемещена или удалена.
            this.телефоныTableAdapter.Fill(this.dataSet1.Телефоны);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Должности". При необходимости она может быть перемещена или удалена.
            this.должностиTableAdapter.Fill(this.dataSet1.Должности);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Гендер". При необходимости она может быть перемещена или удалена.
            this.гендерTableAdapter.Fill(this.dataSet1.Гендер);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Члены_профсоюза". При необходимости она может быть перемещена или удалена.
            this.члены_профсоюзаTableAdapter.Fill(this.dataSet1.Члены_профсоюза);
        }

        public void loaddata()
        {
            load();
            //this.члены_профсоюзаTableAdapter.Fill(this.dataSet1.Члены_профсоюза);
            //this.personTableAdapter.Fill(this.dataSet1.Person);
        }

        private void номераТелефоновToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Phone af = new Phone();
            af.Owner = this;
            af.Show();
        }

        public void dataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Вы уверены, что хотите удалить данного сотрудника?", "Удаление", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
            dataGridView1.Refresh();
        }

        private void toolStripAdd_Click(object sender, EventArgs e)
        {
            AddPerson af = new AddPerson();
            af.Owner = this;
            af.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.членыпрофсоюзаBindingSource.EndEdit();
            this.члены_профсоюзаTableAdapter.Update(this.dataSet1);
        }
    }
}
