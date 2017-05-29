﻿using System;
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
    public partial class FormStockList : Form
    {
        public FormStockList()
        {
            InitializeComponent();
        }

        private void resourceBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            
        }

        private void FormStockList_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "production_of_goodsDataSet.stock". При необходимости она может быть перемещена или удалена.
            this.stockTableAdapter.Fill(this.production_of_goodsDataSet.stock);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "production_of_goodsDataSet.order". При необходимости она может быть перемещена или удалена.
            this.orderTableAdapter.Fill(this.production_of_goodsDataSet.order);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "production_of_goodsDataSet.resource". При необходимости она может быть перемещена или удалена.
            this.resourceTableAdapter.Fill(this.production_of_goodsDataSet.resource);

        }

        private void id_resourseLabel_Click(object sender, EventArgs e)
        {

        }

        private void resource_nameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void id_stockTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void resource_nameLabel_Click(object sender, EventArgs e)
        {

        }

        private void id_resourseTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void volumeLabel_Click(object sender, EventArgs e)
        {

        }

        private void priceTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void volumeTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void id_stockLabel_Click(object sender, EventArgs e)
        {

        }

        private void priceLabel_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigator1_RefreshItems(object sender, EventArgs e)
        {

        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.resourceBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.production_of_goodsDataSet);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Моя обработка ошибок", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
