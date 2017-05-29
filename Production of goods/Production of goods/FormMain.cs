﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Production_of_goods.Properties;

namespace Production_of_goods
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = MessageBox.Show("Вы действительно хотите закрыть программу?",
                "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Question) !=
                DialogResult.Yes;
        }

        private void информацияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("(С) ТУСУР, ФБ, Шушменцев Антон Васильевич, группа 735, 2017",
                "О программе", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void производителиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormManufacturersList.fm.Show();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "production_of_goodsDataSet.goods_manufacturer". При необходимости она может быть перемещена или удалена.
            this.goods_manufacturerTableAdapter.Fill(this.production_of_goodsDataSet.goods_manufacturer);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "production_of_goodsDataSet.customer". При необходимости она может быть перемещена или удалена.
            this.customerTableAdapter.Fill(this.production_of_goodsDataSet.customer);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "production_of_goodsDataSet.order". При необходимости она может быть перемещена или удалена.
            this.orderTableAdapter.Fill(this.production_of_goodsDataSet.order);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "production_of_goodsDataSet.stock". При необходимости она может быть перемещена или удалена.
            this.stockTableAdapter.Fill(this.production_of_goodsDataSet.stock);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "production_of_goodsDataSet.resource". При необходимости она может быть перемещена или удалена.
            this.resourceTableAdapter.Fill(this.production_of_goodsDataSet.resource);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "production_of_goodsDataSet.goods". При необходимости она может быть перемещена или удалена.
            this.goodsTableAdapter.Fill(this.production_of_goodsDataSet.goods);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "production_of_goodsDataSet.manufacturer". При необходимости она может быть перемещена или удалена.
            this.manufacturerTableAdapter.Fill(this.production_of_goodsDataSet.manufacturer);

        }

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Settings.Default.Save();
        }

        private void покупательToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ресурсыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormResourceTable.fr.ShowForm();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void goodsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void goodsDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if
            (
                (goodsDataGridView.Rows[e.RowIndex].Cells["categoryDataGridViewTextBoxColumn"].Value == null) ||
                (goodsDataGridView.Rows[e.RowIndex].Cells["categoryDataGridViewTextBoxColumn"].Value.ToString() == "")
            )
            {
                e.CellStyle.BackColor = Color.LightGreen;
            }
            else
            {
                if
                (
                    (goodsDataGridView.Rows[e.RowIndex].Cells["categoryDataGridViewTextBoxColumn"].Value.ToString() == "Категория 1")
                )
                {
                    e.CellStyle.BackColor = Color.SkyBlue;
                }
                else
                {
                    e.CellStyle.BackColor = Color.Pink;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.manufacturerBindingSource.EndEdit();
            this.manufacturerTableAdapter.Update(this.production_of_goodsDataSet.manufacturer);
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.goodsBindingSource.EndEdit();
            this.goodsTableAdapter.Update(this.production_of_goodsDataSet.goods);
        }

        private void button5_Click(object sender, EventArgs e)
        {
        }

        private void button6_Click(object sender, EventArgs e)
        {
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.orderBindingSource.EndEdit();
            this.orderTableAdapter.Update(this.production_of_goodsDataSet.order);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.customerBindingSource.EndEdit();
            this.customerTableAdapter.Update(this.production_of_goodsDataSet.customer);
        }

        private void toolStripMain_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter_1(object sender, EventArgs e)
        {

        }

        private void customerDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void resourcebindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void toolStripButton61_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton54_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton40_Click(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox5_Enter_1(object sender, EventArgs e)
        {

        }

        private void toolStripLabel4_Click(object sender, EventArgs e)
        {

        }

        private void товарыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGoodsList fg = new FormGoodsList();
            fg.Show();
        }
    }
}
