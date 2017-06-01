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
    public partial class FormStocks : Form
    {

        private static FormStocks f;
        public static FormStocks fs
        {
            get
            {
                if (f == null || f.IsDisposed) f = new FormStocks();
                return f;
            }
        }

        public FormStocks()
        {
            InitializeComponent();
        }

        private void stockBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.stockBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.production_of_goodsDataSet);

        }

        int idCurrent = -1;
        public int ShowSelectForm(int id)
        {
            toolStripButton1.Visible = true;
            idCurrent = id;
            if (ShowDialog() == DialogResult.OK)
            {
                return
                    (int)((DataRowView)stockBindingSource.Current)["id_stock"];
            }
            else
            {
                return -1;
            }
        }

        private void FormStocks_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "production_of_goodsDataSet.stock". При необходимости она может быть перемещена или удалена.
            this.stockTableAdapter.Fill(this.production_of_goodsDataSet.stock);

            
        }

        private void stockDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void FormStocks_Shown(object sender, EventArgs e)
        {
            stockBindingSource.Position = stockBindingSource.Find("id_stock", idCurrent);
        }
    }
}
