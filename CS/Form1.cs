using System;
using System.Windows.Forms;
// ...

namespace PreviewSort {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            XtraReport1 report = new XtraReport1();
            report.SetReportParameter(11077);
            report.ShowPreview();
        }

    }
}