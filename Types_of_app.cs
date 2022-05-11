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
    public partial class Types_of_app : Form
    {
        public Types_of_app()
        {
            InitializeComponent();
        }

        private void типы_заявленийBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.типы_заявленийBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void Types_of_app_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Типы_заявлений". При необходимости она может быть перемещена или удалена.
            this.типы_заявленийTableAdapter.Fill(this.dataSet1.Типы_заявлений);

        }
    }
}
