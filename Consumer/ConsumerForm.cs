using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Consumer
{
    public partial class ConsumerForm : Form
    {
        private BusyForm calculateForm;
        private LemonwayClient _client;
        private string _jsonResult;
        private string _xmlFormat;

        public ConsumerForm()
        {
            InitializeComponent();
            calculateForm = new BusyForm();
        }
        

        private void btn_fibonacci_Click(object sender, EventArgs e)
        {
            calculateForm.ShowDialog();
            var result = calculateForm.Result;
            MessageBox.Show(result.ToString());
        }

        private string XmlSample => @"
                                    <person>
                                      <gender> female </gender>
                                      <firstname > Anna </firstname>
                                      <lastname> Smith </lastname>
                                    </person>";

        private void ConsumerForm_Load(object sender, EventArgs e)
        {
            _client = new LemonwayClient();
            rtb_xml.Text = XmlSample;
            tssl_event.Text = "event :";
        }

        private void btn_convertToJson_Click(object sender, EventArgs e)
        {
            tsb_progress.Visible = true;
            tssl_event.Text = "event : Convert to Json";
            _xmlFormat = rtb_xml.Text;
            bg_worker.RunWorkerAsync();
        }

        private void bg_worker_DoWork(object sender, DoWorkEventArgs e)
        {

            _jsonResult = _client.XmlToJson(_xmlFormat);
        }


        private void bg_worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            tssl_event.Text = "event :";
            tsb_progress.Visible = false;
            rtb_json.Text = _jsonResult;
        }
    }
}
