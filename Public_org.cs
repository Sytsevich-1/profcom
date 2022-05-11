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
    public partial class Public_org : Form
    {
        public Public_org()
        {
            InitializeComponent();
        }

        private void общественные_организацииBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.общественные_организацииBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void Public_org_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Общественные_организации". При необходимости она может быть перемещена или удалена.
            this.общественные_организацииTableAdapter.Fill(this.dataSet1.Общественные_организации);

        }
    }
}
