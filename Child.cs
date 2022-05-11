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
    public partial class Child : Form
    {
        public Child()
        {
            InitializeComponent();
        }
        public SqlConnection con;
        public SqlCommand com;
        public string conString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=E:\\Maks\\Документы\\Университет\\2 курс\\2 семестр\\БД\\Профсоюзная база\\Profcom_DB.mdf;Integrated Security=True;Connect Timeout=30;User Instance=False";

        public void load()
        {
            string script = "SELECT Члены_профсоюза.Код_ЧП, Члены_профсоюза.Фамилия, Члены_профсоюза.Имя, Члены_профсоюза.Отчество, Дети.Фамилия AS Expr1, Дети.Имя AS Expr2, Дети.Отчество AS Expr3, Дети.Дата_рождения,"+
                         "Гендер.Пол FROM Гендер INNER JOIN Дети ON Гендер.Код_пола = Дети.Код_пола INNER JOIN Члены_профсоюза ON Гендер.Код_пола = Члены_профсоюза.Код_пола INNER JOIN "+
                         "Дети_родители ON Дети.Код_дети = Дети_родители.Код_дети AND Члены_профсоюза.Код_ЧП = Дети_родители.Код_ЧП";
            con = new SqlConnection(conString);
            con.Open();
            SqlDataAdapter ms_data = new SqlDataAdapter(script, conString);
            DataTable table = new DataTable();
            ms_data.Fill(table);
            dataGridView1.DataSource = table;
            dataGridView1.Columns[0].HeaderText = "Номер_родителя";
            dataGridView1.Columns[1].HeaderText = "Фамилия_род";
            dataGridView1.Columns[2].HeaderText = "Имя_род";
            dataGridView1.Columns[3].HeaderText = "Отчество_род";
            dataGridView1.Columns[4].HeaderText = "Фамилия_реб";
            dataGridView1.Columns[5].HeaderText = "Имя_реб";
            dataGridView1.Columns[6].HeaderText = "Отчество_реб";
            con.Close();
        }
        public void del()
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Вы действительно хотите удалить запись? Это действие нельзя отменить", "Удаление записи", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    string id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                    con.Open();
                    SqlCommand del = new SqlCommand(@"DELETE FROM Члены_профсоюза WHERE Код_ЧП = @id", con);
                    del.Parameters.AddWithValue("id", id);
                    del.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Запись была успешно удалена из базы данных", "Удаление записи", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Выберите запись для удаления", "Удаление записи", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void Form1_Load(object sender, EventArgs e)
        {
            load();
        }

        public void dataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            del();
        }

        private void toolStripAdd_Click(object sender, EventArgs e)
        {
            //AddChild af = new AddChild();
            //af.Owner = this;
            //af.Show();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            del();
            load();
        }

        private void пользователиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Users af = new Users();
            af.Owner = this;
            af.Show();
        }
    }
}
