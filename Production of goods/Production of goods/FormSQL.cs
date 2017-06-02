using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Production_of_goods
{
    public partial class FormSQL : Form
    {

        private static FormSQL f;
        public static FormSQL fs
        {
            get
            {
                if (f == null || f.IsDisposed) f = new FormSQL();
                return f;
            }
        }

        //Объявляем метод, на вход которого подаём строку запроса, а возвращаем объект DataTable
        DataTable FillDataGridView(string sqlSelect)
        {
            //Создаём объект cjnnection класса SqlConnection для соединения с БД
            //production_of_goodsConnectionString - строка описания соединения с источником данных
            SqlConnection connection = new SqlConnection(
                Properties.Settings.Default.production_of_goodsConnectionString
                );
            //Создаём объект command для SQL команды
            SqlCommand command = connection.CreateCommand();
            //Заносим текст SQL запроса через параметр sqlsSelect
            command.CommandText = sqlSelect;
            //Создаём объект adapter класса SqlDataAdapter
            SqlDataAdapter adapter = new SqlDataAdapter();
            //Задаём адаптеру нужную команду, в данном случае команду Select
            adapter.SelectCommand = command;
            //Создаём объект Table для последующего отображения результата запроса
            DataTable table = new DataTable();
            //Заполним набор данных результатом запроса
            adapter.Fill(table);
            return table;
        }
        public FormSQL()
        {
            InitializeComponent();
        }

        private void radioButtonResources_CheckedChanged(object sender, EventArgs e)
        {
            dataGridViewSelect.DataSource = FillDataGridView("SELECT * FROM resource");
        }

        private void radioButtonManufacturers_CheckedChanged(object sender, EventArgs e)
        {
            dataGridViewSelect.DataSource = FillDataGridView("SELECT * FROM manufacturer");
        }

        private void radioButtonCostomers_CheckedChanged(object sender, EventArgs e)
        {
            dataGridViewSelect.DataSource = FillDataGridView("SELECT * FROM customer");
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBoxCustomerOrder_Enter(object sender, EventArgs e)
        {

        }

        private void buttonF_Select_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxCustomer.Text))
            {
                MessageBox.Show("Укажите имя ресурса", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (checkBoxMore.Checked && String.IsNullOrEmpty(textBoxMore.Text))
            {
                MessageBox.Show(
                    "Не указана прибыль в условии", "Внимание",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning
                );
                checkBoxMore.Checked = false;
                return;
            }

            string sqlSelect = "";
            if (radioButtonDet_Cat.Checked)
            {
                sqlSelect = @"SELECT s.adress,
                CAST (Sum(g.price) As decimal(16, 2)) AS Общая_стоимость
                FROM production_of_goods.dbo.resource g, production_of_goods.dbo.stock s
                WHERE g.resource_name LIKE @last_name AND g.id_stock = s.id_stock
                GROUP BY s.adress
                ";
                
            }
            else
            {
                if (radioButtonDet_Name.Checked)
                {
                //    sqlSelect = @"SELECT g.goods_name, g.category, c.organization_name, o.data_time
                //CAST (Sum(o.data_time) AS deciminal(16, 2)) AS Сумма
                //FROM order o, customer c, goods g
                //WHERE g.goods_id = o.goods_id AND o.id_customer = c.id_customer
                //GROUP BY g.goods_name";
                }

                else
                {
                //    sqlSelect = @"SELECT g.goods_name, g.category, c.organization_name, o.data_time 
                //CAST (Sum(o.data_time) AS deciminal(16, 2)) AS Сумма
                //FROM order o, customer c, goods g
                //WHERE g.goods_id = o.goods_id AND o.id_customer = c.id_customer
                //GROUP BY g.goods_name";
                }
            }

            if (checkBoxMore.Checked)
            {
                //sqlSelect += " HAVING Sum(o.data_time) > @amount";
            }

            if (checkBoxSum.Checked)
            {
                //sqlSelect += " ORDER BY Sum(o.data_time) desc";
            }

            SqlConnection connection = new SqlConnection(
                Properties.Settings.Default.production_of_goodsConnectionString
                );
            SqlCommand command = connection.CreateCommand();
            command.CommandText = sqlSelect;
            command.Parameters.AddWithValue("@last_name", textBoxCustomer.Text + "%");

            if (checkBoxMore.Checked)
            {
                try
                {
                    command.Parameters.Add("@amount", SqlDbType.Decimal).Value = Double.Parse(textBoxMore.Text);
                }

                catch
                {
                    MessageBox.Show(
                        "Прибыль в условии должна быть задана числом", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error
                        );
                    checkBoxMore.Checked = false;
                    return;
                }
            }

            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridViewFSelect.DataSource = table;

            if (table.Rows.Count == 0)
            {
                MessageBox.Show(
                    "Нет значений!", "Информация",
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                    );
            }
        }

        private void FormSQL_Load(object sender, EventArgs e)
        {

        }

        private void radioButtonDet_Cat_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
