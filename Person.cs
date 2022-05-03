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
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.AllPerson". При необходимости она может быть перемещена или удалена.
            this.allPersonTableAdapter.Fill(this.dataSet1.AllPerson);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Должности". При необходимости она может быть перемещена или удалена.
            this.должностиTableAdapter.Fill(this.dataSet1.Должности);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Гендер". При необходимости она может быть перемещена или удалена.
            this.гендерTableAdapter.Fill(this.dataSet1.Гендер);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Члены_профсоюза". При необходимости она может быть перемещена или удалена.
            this.члены_профсоюзаTableAdapter.Fill(this.dataSet1.Члены_профсоюза);

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.членыпрофсоюзаBindingSource.EndEdit();
            this.члены_профсоюзаTableAdapter.Update(this.dataSet1);
        }

        private void номераТелефоновToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Phone af = new Phone();
            af.Owner = this;
            af.Show();
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            AddPerson af = new AddPerson();
            af.Owner = this;
            af.Show();
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Удалить запись?", "Удаление", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
        }

        private void dataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Удалить запись?", "Удаление", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }
    }
}
