using System;
using System.Data;
using System.Windows.Forms;

namespace TestForm
{
    public partial class FormDGV : Form
    {
        private DataTable _dt = null;
        private bool _showMenuStrip = false;
        private bool _keepOnLoad = false;

        private Timer _timer1 = new Timer
        {
            Interval = 100
        };

        public FormDGV()
        {
            InitializeComponent();
        }

        public FormDGV(DataTable dt, bool showMenuStrip = false, bool keepOnLoad = false)
            : this()
        {
            _showMenuStrip = showMenuStrip;
            _keepOnLoad = keepOnLoad;

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

        private void FormDGV_Load(object sender, EventArgs e)
        {
            dgv.DataSource = _dt;

            if(!_keepOnLoad) 
            { 
                _timer1.Enabled = true;
                _timer1.Tick += new System.EventHandler(OnTimerEvent);
            }

            if(_showMenuStrip)
                dgv.ShowAllMenuStrip();
        }

        private void OnTimerEvent(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
