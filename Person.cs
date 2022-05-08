using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Профсоюзная_база
{
    public partial class Person : Form
    {
        public Person()
        {
            InitializeComponent();
        }


        public void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Person". При необходимости она может быть перемещена или удалена.
            this.personTableAdapter.Fill(this.dataSet1.Person);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Телефоны". При необходимости она может быть перемещена или удалена.
            this.телефоныTableAdapter.Fill(this.dataSet1.Телефоны);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Должности". При необходимости она может быть перемещена или удалена.
            this.должностиTableAdapter.Fill(this.dataSet1.Должности);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Гендер". При необходимости она может быть перемещена или удалена.
            this.гендерTableAdapter.Fill(this.dataSet1.Гендер);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Члены_профсоюза". При необходимости она может быть перемещена или удалена.
            this.члены_профсоюзаTableAdapter.Fill(this.dataSet1.Члены_профсоюза);

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

        private void toolStripSave_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.членыпрофсоюзаBindingSource.EndEdit();
            this.члены_профсоюзаTableAdapter.Update(this.dataSet1);
        }
    }
}
