using System;
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

        }

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Settings.Default.Save();
        }
    }
}
