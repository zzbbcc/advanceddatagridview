using System;
using System.Data;
using System.Windows.Forms;

namespace TestForm
{
    public partial class FormDGV : Form
    {
        public FormDGV()
        {
            InitializeComponent();
            btnSetTable.Click += new EventHandler(btnSetTable_Click);
        }

        private void btnSetTable_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("col1", typeof(DateTime));
            dt.Rows.Add(new DateTime(2020, 6, 17));
            dt.Rows.Add(new DateTime(2019, 1, 1));
            dgv.DataSource = dt;
        }
    }
}
