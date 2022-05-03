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
    public partial class Phone : Form
    {
        public Phone()
        {
            InitializeComponent();
        }

        private void Phone_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet11.Phone". При необходимости она может быть перемещена или удалена.
            this.phoneTableAdapter.Fill(this.dataSet11.Phone);

        }
    }
}
