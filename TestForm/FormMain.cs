using System;
using System.Windows.Forms;

namespace TestForm
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            btnFormDGVShow.Click += new EventHandler(btnFormDGVShow_Click);
            btnFormDGVShowDialog.Click += new EventHandler(btnFormDGVShowDialog_Click);
            btnGCCollect.Click += new EventHandler(btnGCCollect_Click);
        }

        private void btnFormDGVShow_Click(object sender, EventArgs e)
        {
            new FormDGV().Show();
        }

        private void btnFormDGVShowDialog_Click(object sender, EventArgs e)
        {
            new FormDGV().ShowDialog();
        }

        private void btnGCCollect_Click(object sender, EventArgs e)
        {
            GC.Collect();
            lbMemoryUsage.Text = (GC.GetTotalMemory(false) / (1024 * 1024)).ToString() + " MB";
        }
    }
}
