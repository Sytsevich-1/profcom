﻿using System;
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
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

        }
        public SqlConnection con;
        public SqlCommand com;
        public string conString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=E:\\Maks\\Документы\\Университет\\2 курс\\2 семестр\\БД\\Профсоюзная база\\Profcom_DB.mdf;Integrated Security=True;Connect Timeout=30;User Instance=False";

        public void load()
        {
            string script = "SELECT Члены_профсоюза.Код_ЧП, Члены_профсоюза.Фамилия, Члены_профсоюза.Имя, Члены_профсоюза.Отчество, Члены_профсоюза.Дата_рождения, Гендер.Пол, Должности.Должность," +
                         "Телефоны.Номер_телефона FROM Гендер INNER JOIN Члены_профсоюза ON Гендер.Код_пола = Члены_профсоюза.Код_пола INNER JOIN Должности ON Члены_профсоюза.Код_должности = Должности.Код_должности INNER JOIN " +
                         "Телефоны ON Члены_профсоюза.Код_ЧП = Телефоны.Код_ЧП";
            con = new SqlConnection(conString);
            con.Open();
            SqlDataAdapter ms_data = new SqlDataAdapter(script, conString);
            DataTable table = new DataTable();
            ms_data.Fill(table);
            dataGridView1.DataSource = table;
            dataGridView1.Columns[0].HeaderText = "Номер";
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
            AddPerson af = new AddPerson();
            af.Owner = this;
            af.Show();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            del();
            load();
        }

        private void пользователиToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Users af = new Users();
            af.Owner = this;
            af.Show();
        }

        private void детиСотрудниковToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Child af = new Child();
            af.Owner = this;
            af.Show();
        }

        public void toolStripButton2_Click(object sender, EventArgs e)
        {
            var curruentRow = dataGridView1.CurrentCell.RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[curruentRow];

            GridValues.Col0 = selectedRow.Cells[0].Value.ToString();
            GridValues.Col1 = selectedRow.Cells[1].Value.ToString();
            GridValues.Col2 = selectedRow.Cells[2].Value.ToString();
            GridValues.Col3 = selectedRow.Cells[3].Value.ToString();
            GridValues.Col4 = (DateTime)selectedRow.Cells[4].Value;
            GridValues.Col5 = selectedRow.Cells[5].Value.ToString();
            GridValues.Col6 = selectedRow.Cells[6].Value.ToString();
            GridValues.Col7 = selectedRow.Cells[7].Value.ToString();

            EditPerson af = new EditPerson();
            af.Owner = this;
            af.Show();
        }
        public static class GridValues
        {
            public static string Col0 { get; set; }
            public static string Col1 { get; set; }
            public static string Col2 { get; set; }
            public static string Col3 { get; set; }
            public static DateTime Col4 { get; set; }
            public static string Col5 { get; set; }
            public static string Col6 { get; set; }
            public static string Col7 { get; set; }

        }
    }
}
