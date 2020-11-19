using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.function
{
    public partial class Singlelist : Form
    {
        public Singlelist()
        {
            InitializeComponent();
            dataGridViewChild.Columns[0].ReadOnly = true;
            dataGridViewChild.Rows[0].ReadOnly = true;
        }
        public Singlelist(DataTable dataTable)
        {
            InitializeComponent();
            dataGridViewChild.Columns[0].ReadOnly = true;
            int len = dataGridViewChild.Columns.Count;
            foreach (DataRow dr in dataTable.Rows)
            {
                int ind = dataGridViewChild.Rows.Add();
                dataGridViewChild.Rows[ind].Cells[0].Value = dr["inglenumberw"].ToString();
                dataGridViewChild.Rows[ind].Cells[1].Value = dr["buyChecklist"].ToString();
                dataGridViewChild.Rows[ind].Cells[2].Value = dr["attach"].ToString();
                dataGridViewChild.Rows[ind].Cells[3].Value = dr["price"].ToString();

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
