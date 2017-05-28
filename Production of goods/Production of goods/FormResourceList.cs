using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Production_of_goods
{
    public partial class FormResourceList : Form
    {
        public FormResourceList()
        {
            InitializeComponent();
        }

        private void resourceBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.resourceBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.production_of_goodsDataSet);

        }

        private void FormResourceList_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "production_of_goodsDataSet.resource". При необходимости она может быть перемещена или удалена.
            this.resourceTableAdapter.Fill(this.production_of_goodsDataSet.resource);

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
