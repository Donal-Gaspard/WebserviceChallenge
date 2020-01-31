using System;
using System.ComponentModel;
using System.Threading;
using System.Windows.Forms;

namespace Consumer
{
    public partial class BusyForm : Form
    {
        private const int CP_NOCLOSE_BUTTON = 0x200;
        public int Result { get; set; }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams myCp = base.CreateParams;
                myCp.ClassStyle = myCp.ClassStyle | CP_NOCLOSE_BUTTON;
                return myCp;
            }
        }

        public BusyForm()
        {
            InitializeComponent();
        }

        private void BusyForm_Load(object sender, EventArgs e)
        {
            bg_worker.RunWorkerAsync();
        }

        private void bg_worker_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                var client = new LemonwayClient();
                Thread.Sleep(2000);
                Result = client.Fibonacci(10);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bg_worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Close();
        }
    }
}