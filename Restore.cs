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
using System.Diagnostics;

namespace Профсоюзная_база
{
    public partial class Restore : Form
    {
        public Restore()
        {
            InitializeComponent();
        }
        public string conString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=E:\\Maks\\Документы\\Университет\\2 курс\\2 семестр\\БД\\Профсоюзная база\\Profcom_DB.mdf;Integrated Security=True;Connect Timeout=30;User Instance=False";

        private void button1_Click(object sender, EventArgs e)
        {

            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;

            textBox1.Text = openFileDialog1.FileName;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string directory = System.IO.Path.GetDirectoryName(Process.GetCurrentProcess().MainModule.FileName);
            SqlConnection con = new SqlConnection(conString);
            con.Open();

            SqlCommand master = new SqlCommand("use master", con);
            master.ExecuteNonQuery();

            SqlCommand alter1 = new SqlCommand("alter database [" + directory + @"\Profcom_DB.mdf] SET Single_User WITH Rollback Immediate", con);
            alter1.ExecuteNonQuery();

            String txtCmd = "Restore database [" + directory + @"\Profcom_DB.mdf] from disk='" + textBox1.Text.Trim() + "'";
            SqlCommand command = new SqlCommand(txtCmd, con);
            int result = command.ExecuteNonQuery();

            SqlCommand alter2 = new SqlCommand("alter database [" + directory + @"\Profcom_DB.mdf] SET Multi_User", con);
            alter2.ExecuteNonQuery();

            if (result == -1)
                MessageBox.Show("Восстановление из резервной копии успешно завершено");
            con.Close();
            Person pe = new Person();
            pe.load();
        }
    }
}
