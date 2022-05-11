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
    public partial class Backup : Form
    {
        public Backup()
        {
            InitializeComponent();


        }
        public string conString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=E:\\Maks\\Документы\\Университет\\2 курс\\2 семестр\\БД\\Профсоюзная база\\Profcom_DB.mdf;Integrated Security=True;Connect Timeout=30;User Instance=False";

        private void button1_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;

            textBox1.Text = saveFileDialog1.FileName;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string directory = System.IO.Path.GetDirectoryName(Process.GetCurrentProcess().MainModule.FileName);
            SqlConnection con = new SqlConnection(conString);
            
                con.Open();
                String txtCmd = "Backup database [" + directory + @"\Profcom_DB.mdf] to disk='" + textBox1.Text.Trim() + "'";
                SqlCommand command = new SqlCommand(txtCmd, con);
                int result = command.ExecuteNonQuery();
                if (result == -1)
                    MessageBox.Show("Резервное копирование успешно завершено");
                con.Close();
        }
    }
}
