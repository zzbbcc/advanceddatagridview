using System;
using System.Data;
using System.Windows.Forms;

namespace TestForm
{
    public partial class FormMain : Form
    {
        private static bool SpeedTest = true;
        private static int NumWin = 10;
        private static bool LoadDt = true;

        private DataTable _dt = null;

        private Timer timer1 = new Timer
        {
            Interval = 5000
        };

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            if (LoadDt)
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

            timer1.Enabled = true;
            timer1.Tick += new System.EventHandler(OnTimerEvent);
        }

        private void OnTimerEvent(object sender, EventArgs e)
        {
            btnGCCollect_Click(sender, e);
        }

        private void btnFormDGVShow_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < NumWin; i++)
            {
                FormDGV f1 = new FormDGV(_dt);
                f1.Show();

                if (!SpeedTest)
                {
                    while (!f1.IsDisposed)
                    {
                        Application.DoEvents();
                        System.Threading.Thread.Sleep(100);
                    }
                }
            }
        }

        private void btnFormDGVShowMenuStripShow_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < NumWin; i++) {
                FormDGV f1 = new FormDGV(_dt, showMenuStrip:true);
                f1.Show();

                if(!SpeedTest) {
                    while(!f1.IsDisposed) {
                        Application.DoEvents();
                        System.Threading.Thread.Sleep(100);
                    }
                }
            }
        }

        private void btnFormDGVShowDialog_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < NumWin; i++)
            {
                using (FormDGV f2 = new FormDGV(_dt))
                {
                    f2.ShowDialog();
                }
            }
        }

        private void btnFormGVShow_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < NumWin; i++)
            {
                FormGV f1 = new FormGV(_dt);
                f1.Show();

                if (!SpeedTest)
                {
                    while (!f1.IsDisposed)
                    {
                        Application.DoEvents();
                        System.Threading.Thread.Sleep(100);
                    }
                }
            }
        }

        private void btnFormGVShowDialog_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < NumWin; i++)
            {
                using (FormGV f2 = new FormGV(_dt))
                {
                    f2.ShowDialog();
                }
            }
        }

        private void btnGCCollect_Click(object sender, EventArgs e)
        {
            GC.Collect();
            lbMemoryUsage.Text = (GC.GetTotalMemory(false) / (1024 * 1024)).ToString() + " MB";
        }

        private void btnDGVShowOnce_Click(object sender, EventArgs e)
        {
            new FormDGV(_dt, keepOnLoad:true).Show();
        }
    }
}
