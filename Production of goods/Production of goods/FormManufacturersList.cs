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
    
    public partial class FormManufacturersList : Form
    {
        private static FormManufacturersList f;
        public static FormManufacturersList fm
        {
            get
            {
                if (f == null || f.IsDisposed) f = new FormManufacturersList();
                return f;
            }
        }

        public FormManufacturersList()
        {
            InitializeComponent();
        }

        private void manufacturerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.manufacturerBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.production_of_goodsDataSet);

        }

        private void FormManufacturersList_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "production_of_goodsDataSet.manufacturer". При необходимости она может быть перемещена или удалена.
            this.manufacturerTableAdapter.Fill(this.production_of_goodsDataSet.manufacturer);

        }
    }
}
