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
    public partial class Payments : Form
    {
        public Payments()
        {
            InitializeComponent();
        }

        private void основания_МПBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.основания_МПBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void Payments_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Основания_МП". При необходимости она может быть перемещена или удалена.
            this.основания_МПTableAdapter.Fill(this.dataSet1.Основания_МП);

        }
    }
}
