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
    }
}
