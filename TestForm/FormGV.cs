using System;
using System.Data;
using System.Windows.Forms;

namespace TestForm
{
    public partial class FormGV : Form
    {
        private DataTable _dt = null;

        private Timer _timer1 = new Timer
        {
            Interval = 100
        };

        public FormGV()
        {
            InitializeComponent();
        }

        public FormGV(DataTable dt)
            : this()
        {
            if (dt == null)
            {
                _dt = new DataTable();
                _dt.Columns.Add("col1", typeof(DateTime));
                _dt.Columns.Add("col2", typeof(int));

                DateTime now = DateTime.Now;
                for (int i = 0; i < 1000; i++)
                {
                    DataRow dr = _dt.NewRow();
                    dr["col1"] = now.AddDays(i);
                    dr["col2"] = i;
                    _dt.Rows.Add(dr);
                }
            }
            else
                _dt = dt;
        }

        private void ormDGV_Load(object sender, EventArgs e)
        {
            gv.DataSource = _dt;

            _timer1.Enabled = true;
            _timer1.Tick += new System.EventHandler(OnTimerEvent);
        }

        private void OnTimerEvent(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
