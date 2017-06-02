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

        private void radioButtonDelete_CheckedChanged(object sender, EventArgs e)
        {
            panel.Visible = !radioButtonDelete.Checked;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = FillDataGridView("SELECT * FROM production_of_goods.dbo.resource");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (radioButtonInsert.Checked)
                Insert_1();
            else
            if (radioButtonUpdate.Checked)
                Update_1();
            else
            if (radioButtonDelete.Checked)
                Delete_1();
            else
                MessageBox.Show("Вы не выбрали действие", "Внимание",
               MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }


        void Insert_1()
        {
            if (
                String.IsNullOrEmpty(textBoxIdResource.Text) ||
                (String.IsNullOrEmpty(textBoxResourceName.Text) ||
                (String.IsNullOrEmpty(textBoxVolume.Text) ||
                (String.IsNullOrEmpty(textBoxPrice.Text))))
                )
            {
                MessageBox.Show(
                    "Обязательно введите код блюда, название, тип и цену блюда", "Внимание",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int id_resource = 0;
            if (!int.TryParse(textBoxIdResource.Text, out id_resource))
            {
                MessageBox.Show("Некоректное значение кода блюда!", "Внимание",
               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int id_stock = 0;
            if (!int.TryParse(textBoxIdStock.Text, out id_stock))
            {
                MessageBox.Show("Некоректное значение кода блюда!", "Внимание",
               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            double price = 0;
            if (!double.TryParse(textBoxPrice.Text, out price))
            {
                MessageBox.Show("Некоректное значение цены!", "Внимание",
               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string sqlInsert = @"INSERT INTO production_of_goods.dbo.resource(id_resourse, id_stock, resource_name, volume,
price)
 VALUES (@id_resource, @id_stock, @Name, @Volume, @Price)";
            SqlConnection connection = new SqlConnection(Properties.Settings.Default.production_of_goodsConnectionString);
            connection.Open();
            SqlCommand command = connection.CreateCommand();
            command.CommandText = sqlInsert;
            command.Parameters.AddWithValue("@id_resource", textBoxIdResource.Text);
            command.Parameters.AddWithValue("@id_stock", textBoxIdStock.Text);
            command.Parameters.AddWithValue("@Name", textBoxResourceName.Text);
            command.Parameters.AddWithValue("@Volume", textBoxVolume.Text);
            //или другим способом, если необходимо явное указание типа данных
            //command.Parameters.Add("@Volume", SqlDbType.NVarChar).Value = textBoxVolume.Text;
            command.Parameters.AddWithValue("@Price", price);
            //command.Parameters.AddWithValue("@Weight", weight);
            //if (!String.IsNullOrEmpty(listBoxEd_dish.Text))
            //    command.Parameters.AddWithValue("@Ed", listBoxEd_dish.Text);
            //else
            //    command.Parameters.AddWithValue("@Ed", DBNull.Value);
            //command.Parameters.AddWithValue("@Firm", checkBoxFirm.Checked);
            //if (!String.IsNullOrEmpty(fileImage))
            //    command.Parameters.AddWithValue("@Photo",
            //   File.ReadAllBytes(fileImage));
            //else
            //{
            //    command.Parameters.Add("@Photo", SqlDbType.VarBinary);
            //    command.Parameters["@Photo"].Value = DBNull.Value;
            //}
            //command.Parameters.AddWithValue("@Sostav", textBoxIng_dish.Text);
            try
            {
                command.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                MessageBox.Show("Ошибка выполнения запроса.\n" + err.Message,
               "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            connection.Close();
            button1_Click(this, EventArgs.Empty);
        }



        void Delete_1()
        {
            if (String.IsNullOrEmpty(textBoxIdResource.Text))
            {
                MessageBox.Show("Обязательно укажите код блюда данные которого необходимо удалить", "Внимание",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
            }

            int id_resource = 0;
            if (!int.TryParse(textBoxIdResource.Text, out id_resource))
            {
                MessageBox.Show("Некоректное значение кода блюда!", "Внимание",
               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string sqlDelete = @"DELETE FROM production_of_goods.dbo.resource WHERE id_resourse = @id_resource";
            SqlConnection connection = new SqlConnection(Properties.Settings.Default.production_of_goodsConnectionString);
            connection.Open();
            SqlCommand command = connection.CreateCommand();
            command.CommandText = sqlDelete;
            command.Parameters.AddWithValue("@id_resource", id_resource);
            try
            {
                command.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Ошибка удаления");
            }
            connection.Close();
            button1_Click(this, EventArgs.Empty);
        }

        private void radioButtonInsert_CheckedChanged(object sender, EventArgs e)
        {

        }



        void Update_1()
        {
            if (String.IsNullOrEmpty(textBoxIdResource.Text))
            {
                MessageBox.Show("Обязательно укажите код блюда, для которого будете менять данные", "Внимание",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int id_resource;
            if (!int.TryParse(textBoxIdResource.Text, out id_resource))
            {
                MessageBox.Show("Некоректное значение кода блюда!", "Внимание",
               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            double price = 0;
            if ((!String.IsNullOrEmpty(textBoxPrice.Text)) &&
           (!double.TryParse(textBoxPrice.Text, out price)))
            {
                MessageBox.Show("Некоректное значение цены!", "Внимание",
               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

           // double weight = 0;
           // if ((!String.IsNullOrEmpty(textBoxWeight_dish.Text)) &&
           //(!double.TryParse(textBoxWeight_dish.Text, out weight)))
           // {
           //     MessageBox.Show("Некоректное значение веса!", "Внимание",
           //    MessageBoxButtons.OK, MessageBoxIcon.Warning);
           //     return;
           // }

            string sqlUpdate = "UPDATE production_of_goods.dbo.resource SET {0} WHERE id_resourse = @id_resource";
 SqlConnection connection = new
SqlConnection(Properties.Settings.Default.production_of_goodsConnectionString);
            connection.Open();

            SqlCommand command = connection.CreateCommand();
            string sqlValues = "";
            command.Parameters.AddWithValue("@id_stock", textBoxIdStock.Text);

            if (!String.IsNullOrEmpty(textBoxIdResource.Text))
                sqlValues += "id_resourse=@id_resource,";

            if (!String.IsNullOrEmpty(textBoxIdStock.Text))
                sqlValues += "id_stock=@id_stock,";

            if (!String.IsNullOrEmpty(textBoxResourceName.Text))
                sqlValues += "resource_name=@Name,";

            if (!String.IsNullOrEmpty(textBoxVolume.Text))
                sqlValues += "volume=@Volume,";

            if (!String.IsNullOrEmpty(textBoxPrice.Text))
                sqlValues += "price=@Price,";

            sqlValues = sqlValues.Substring(0, sqlValues.Length - 1);
            command.CommandText = String.Format(sqlUpdate, sqlValues);

            if (!String.IsNullOrEmpty(textBoxResourceName.Text))
                command.Parameters.AddWithValue("@Name", textBoxResourceName.Text);

            if (!String.IsNullOrEmpty(textBoxIdResource.Text))
                command.Parameters.AddWithValue("@id_resource", textBoxIdResource.Text);

            if (!String.IsNullOrEmpty(textBoxVolume.Text))
                command.Parameters.AddWithValue("@Volume", textBoxVolume.Text);

            if (!String.IsNullOrEmpty(textBoxPrice.Text))
                command.Parameters.AddWithValue("@Price", textBoxPrice.Text);




            //или другим способом, если необходимо явное указание типа данных
            //if (!String.IsNullOrEmpty(textBoxType_dish.Text))
            //    command.Parameters.Add("@Type", SqlDbType.NVarChar).Value =
            //   textBoxType_dish.Text;
            //if (!String.IsNullOrEmpty(textBoxPrice_dish.Text))
            //    command.Parameters.AddWithValue("@Price", price);

            //if (!String.IsNullOrEmpty(textBoxWeight_dish.Text))
            //    command.Parameters.AddWithValue("@Weight", weight);
            //if (!String.IsNullOrEmpty(listBoxEd_dish.Text))
            //    command.Parameters.AddWithValue("@Ed", listBoxEd_dish.Text);
            //if (!String.IsNullOrEmpty(fileImage))
            //    command.Parameters.AddWithValue("@Photo",
            //   File.ReadAllBytes(fileImage));
            //if (!String.IsNullOrEmpty(textBoxIng_dish.Text))
            //    command.Parameters.AddWithValue("@Sostav",
            //   textBoxIng_dish.Text);

            //command.Parameters.AddWithValue("@Firm", checkBoxFirm.Checked);
            //command.Parameters.AddWithValue("@id_resource", id_resource);
            
            try
            {
                command.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                MessageBox.Show("Ошибка выполнения запроса:\n" + err.Message,
               "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            connection.Close();
            button1_Click(this, EventArgs.Empty);
        }




    }
}
