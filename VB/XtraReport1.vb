Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.XtraReports.UI
' ...

Namespace PreviewSort
	Partial Public Class XtraReport1
		Inherits DevExpress.XtraReports.UI.XtraReport
		Public Sub New()
			InitializeComponent()
			currentSortCell = xrTableCell1
		End Sub

		Private currentSortCell As XRTableCell

		Public Sub SetReportParameter(ByVal orderID As Integer)
			nwindDataSet1.Clear()
			orderDetailsTableAdapter.Fill(nwindDataSet1.OrderDetails, orderID)
			lbOrderID.Text = orderID.ToString()
		End Sub

		Private Sub OnCellPreviewClick(ByVal sender As Object, ByVal e As PreviewMouseEventArgs) Handles xrTableCell1.PreviewClick, xrTableCell4.PreviewClick, xrTableCell7.PreviewClick, xrTableCell2.PreviewClick, xrTableCell13.PreviewClick
			' Turn off sorting.
			Me.Detail.SortFields.Clear()
			currentSortCell.Text = currentSortCell.Text.Remove(currentSortCell.Text.Length - 1, 1)

			' Create a new field to sort.
			Dim grField As New GroupField()
			grField.FieldName = (CType(sender, XRControl)).Tag.ToString()
			grField.SortOrder = XRColumnSortOrder.Ascending

			' Add sorting.
			Me.Detail.SortFields.Add(grField)
			CType(sender, XRLabel).Text = (CType(sender, XRLabel)).Text & "*"
			currentSortCell = CType(sender, XRTableCell)

			' Recreate the report document.
			Me.CreateDocument()
		End Sub

	End Class
End Namespace
