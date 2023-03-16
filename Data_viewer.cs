using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex2023
{
    public partial class Data_viewer : Form
    {
        public Data_viewer()
        {
            InitializeComponent();
        }

        private void Data_viewer_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "trade2023DataSet.Product". При необходимости она может быть перемещена или удалена.
            this.productTableAdapter.Fill(this.trade2023DataSet.Product);

        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Add_data fm = new Add_data(true);
            fm.Show();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            Del_data fm = new Del_data();
            fm.Show();
        }
    }
}
