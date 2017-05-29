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
    public partial class FormGoodsList : Form
    {
        public FormGoodsList()
        {
            InitializeComponent();
        }

        private void goodsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.goodsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.production_of_goodsDataSet);

        }

        private void FormGoodsList_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "production_of_goodsDataSet.goods". При необходимости она может быть перемещена или удалена.
            this.goodsTableAdapter.Fill(this.production_of_goodsDataSet.goods);

        }

        string fileImage = "";
        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialogPhoto.Title = "Укажите файл для фото";
            if (openFileDialogPhoto.ShowDialog() == DialogResult.OK)
            {
                fileImage = openFileDialogPhoto.FileName;
                try
                {
                    photoPictureBox.Image = new Bitmap(openFileDialogPhoto.FileName);
                }
                catch
                {
                    MessageBox.Show("Выбран не тот формат файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else fileImage = "";
        }
    }
}
