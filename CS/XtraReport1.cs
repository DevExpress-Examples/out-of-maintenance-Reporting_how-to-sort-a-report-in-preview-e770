using System;
using DevExpress.XtraReports.UI;
// ...

namespace PreviewSort {
    public partial class XtraReport1 : DevExpress.XtraReports.UI.XtraReport {
        public XtraReport1() {
            InitializeComponent();
            currentSortCell = xrTableCell1;
        }

        private XRTableCell currentSortCell;

        public void SetReportParameter(int orderID) {
            nwindDataSet1.Clear();
            orderDetailsTableAdapter.Fill(nwindDataSet1.OrderDetails, orderID);
            lbOrderID.Text = orderID.ToString();
        }

        private void OnCellPreviewClick(object sender, PreviewMouseEventArgs e) {
            // Turn off sorting.
            this.Detail.SortFields.Clear();
            currentSortCell.Text = currentSortCell.Text.Remove(currentSortCell.Text.Length - 1, 1);

            // Create a new field to sort.
            GroupField grField = new GroupField();
            grField.FieldName = ((XRControl)sender).Tag.ToString();
            grField.SortOrder = XRColumnSortOrder.Ascending;

            // Add sorting.
            this.Detail.SortFields.Add(grField);
            ((XRLabel)sender).Text = ((XRLabel)sender).Text + "*";
            currentSortCell = (XRTableCell)sender;

            // Recreate the report document.
            this.CreateDocument();
        }

    }
}
