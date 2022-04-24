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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void члены_профсоюзаBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet11.Члены_профсоюза". При необходимости она может быть перемещена или удалена.
            this.члены_профсоюзаTableAdapter.Fill(this.dataSet11.Члены_профсоюза);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet11.Гендер". При необходимости она может быть перемещена или удалена.
            this.гендерTableAdapter.Fill(this.dataSet11.Гендер);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet11.ЧП_общая". При необходимости она может быть перемещена или удалена.
            this.чП_общаяTableAdapter.Fill(this.dataSet11.ЧП_общая);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

    }
}
