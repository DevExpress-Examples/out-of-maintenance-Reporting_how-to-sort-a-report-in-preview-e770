Imports Microsoft.VisualBasic
Imports System
Namespace PreviewSort
	Partial Public Class XtraReport1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary> 
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
			Me.xrTable2 = New DevExpress.XtraReports.UI.XRTable()
			Me.xrTableRow2 = New DevExpress.XtraReports.UI.XRTableRow()
			Me.clProductName = New DevExpress.XtraReports.UI.XRTableCell()
			Me.clSupplier = New DevExpress.XtraReports.UI.XRTableCell()
			Me.clUnitPrice = New DevExpress.XtraReports.UI.XRTableCell()
			Me.clQuantity = New DevExpress.XtraReports.UI.XRTableCell()
			Me.clDiscount = New DevExpress.XtraReports.UI.XRTableCell()
			Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand()
			Me.xrTable1 = New DevExpress.XtraReports.UI.XRTable()
			Me.xrTableRow1 = New DevExpress.XtraReports.UI.XRTableRow()
			Me.xrTableCell1 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.xrTableCell4 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.xrTableCell7 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.xrTableCell2 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.xrTableCell13 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand()
			Me.lbOrderID = New DevExpress.XtraReports.UI.XRLabel()
			Me.xrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
			Me.xrPageInfo1 = New DevExpress.XtraReports.UI.XRPageInfo()
			Me.nwindDataSet1 = New PreviewSort.nwindDataSet()
			Me.orderDetailsTableAdapter = New PreviewSort.nwindDataSetTableAdapters.OrderDetailsTableAdapter()
			CType(Me.xrTable2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.xrTable1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.nwindDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
			' 
			' Detail
			' 
			Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrTable2})
			Me.Detail.Height = 25
			Me.Detail.Name = "Detail"
			Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.Detail.SortFields.AddRange(New DevExpress.XtraReports.UI.GroupField() { New DevExpress.XtraReports.UI.GroupField("ProductName", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
			Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' xrTable2
			' 
			Me.xrTable2.BorderColor = System.Drawing.Color.Black
			Me.xrTable2.Borders = (CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide))
			Me.xrTable2.BorderWidth = 1
			Me.xrTable2.Font = New System.Drawing.Font("Times New Roman", 9.75F)
			Me.xrTable2.Location = New System.Drawing.Point(0, 0)
			Me.xrTable2.Name = "xrTable2"
			Me.xrTable2.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.xrTable2.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() { Me.xrTableRow2})
			Me.xrTable2.Size = New System.Drawing.Size(650, 25)
			Me.xrTable2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' xrTableRow2
			' 
			Me.xrTableRow2.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() { Me.clProductName, Me.clSupplier, Me.clUnitPrice, Me.clQuantity, Me.clDiscount})
			Me.xrTableRow2.Name = "xrTableRow2"
			Me.xrTableRow2.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.xrTableRow2.Size = New System.Drawing.Size(650, 25)
			Me.xrTableRow2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' clProductName
			' 
			Me.clProductName.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "OrderDetails.ProductName", "")})
			Me.clProductName.Location = New System.Drawing.Point(0, 0)
			Me.clProductName.Name = "clProductName"
			Me.clProductName.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.clProductName.Size = New System.Drawing.Size(165, 25)
			Me.clProductName.Text = "clProductName"
			Me.clProductName.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
			' 
			' clSupplier
			' 
			Me.clSupplier.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "OrderDetails.Supplier", "")})
			Me.clSupplier.Location = New System.Drawing.Point(165, 0)
			Me.clSupplier.Name = "clSupplier"
			Me.clSupplier.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.clSupplier.Size = New System.Drawing.Size(225, 25)
			Me.clSupplier.Text = "clSupplier"
			Me.clSupplier.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
			' 
			' clUnitPrice
			' 
			Me.clUnitPrice.BorderWidth = 1
			Me.clUnitPrice.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "OrderDetails.UnitPrice", "")})
			Me.clUnitPrice.Location = New System.Drawing.Point(390, 0)
			Me.clUnitPrice.Name = "clUnitPrice"
			Me.clUnitPrice.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.clUnitPrice.Size = New System.Drawing.Size(71, 25)
			Me.clUnitPrice.Text = "clUnitPrice"
			Me.clUnitPrice.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
			' 
			' clQuantity
			' 
			Me.clQuantity.BorderWidth = 1
			Me.clQuantity.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "OrderDetails.Quantity", "")})
			Me.clQuantity.Location = New System.Drawing.Point(461, 0)
			Me.clQuantity.Name = "clQuantity"
			Me.clQuantity.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.clQuantity.Size = New System.Drawing.Size(87, 25)
			Me.clQuantity.Text = "clQuantity"
			Me.clQuantity.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
			' 
			' clDiscount
			' 
			Me.clDiscount.BorderWidth = 1
			Me.clDiscount.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "OrderDetails.Discount", "")})
			Me.clDiscount.Location = New System.Drawing.Point(548, 0)
			Me.clDiscount.Name = "clDiscount"
			Me.clDiscount.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.clDiscount.Size = New System.Drawing.Size(102, 25)
			Me.clDiscount.Text = "clDiscount"
			Me.clDiscount.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
			' 
			' PageHeader
			' 
			Me.PageHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrTable1})
			Me.PageHeader.Height = 43
			Me.PageHeader.Name = "PageHeader"
			Me.PageHeader.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.PageHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' xrTable1
			' 
			Me.xrTable1.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(224))))), (CInt(Fix((CByte(214))))), (CInt(Fix((CByte(211))))))
			Me.xrTable1.BorderColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(189))))), (CInt(Fix((CByte(177))))), (CInt(Fix((CByte(183))))))
			Me.xrTable1.Borders = (CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) Or DevExpress.XtraPrinting.BorderSide.Right) Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide))
			Me.xrTable1.BorderWidth = 2
			Me.xrTable1.Font = New System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold)
			Me.xrTable1.Location = New System.Drawing.Point(0, 0)
			Me.xrTable1.Name = "xrTable1"
			Me.xrTable1.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.xrTable1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() { Me.xrTableRow1})
			Me.xrTable1.Size = New System.Drawing.Size(650, 43)
			Me.xrTable1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' xrTableRow1
			' 
			Me.xrTableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() { Me.xrTableCell1, Me.xrTableCell4, Me.xrTableCell7, Me.xrTableCell2, Me.xrTableCell13})
			Me.xrTableRow1.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(204)))
			Me.xrTableRow1.Name = "xrTableRow1"
			Me.xrTableRow1.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.xrTableRow1.Size = New System.Drawing.Size(650, 43)
			Me.xrTableRow1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' xrTableCell1
			' 
			Me.xrTableCell1.BorderWidth = 1
			Me.xrTableCell1.Location = New System.Drawing.Point(0, 0)
			Me.xrTableCell1.Name = "xrTableCell1"
			Me.xrTableCell1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrTableCell1.Size = New System.Drawing.Size(165, 43)
			Me.xrTableCell1.Tag = "ProductName"
			Me.xrTableCell1.Text = "Product Name*"
			Me.xrTableCell1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
'			Me.xrTableCell1.PreviewClick += New DevExpress.XtraReports.UI.PreviewMouseEventHandler(Me.OnCellPreviewClick);
			' 
			' xrTableCell4
			' 
			Me.xrTableCell4.BorderWidth = 1
			Me.xrTableCell4.Location = New System.Drawing.Point(165, 0)
			Me.xrTableCell4.Name = "xrTableCell4"
			Me.xrTableCell4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrTableCell4.Size = New System.Drawing.Size(225, 43)
			Me.xrTableCell4.Tag = "Supplier"
			Me.xrTableCell4.Text = "Supplier"
			Me.xrTableCell4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
'			Me.xrTableCell4.PreviewClick += New DevExpress.XtraReports.UI.PreviewMouseEventHandler(Me.OnCellPreviewClick);
			' 
			' xrTableCell7
			' 
			Me.xrTableCell7.BorderWidth = 1
			Me.xrTableCell7.Location = New System.Drawing.Point(390, 0)
			Me.xrTableCell7.Name = "xrTableCell7"
			Me.xrTableCell7.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrTableCell7.Size = New System.Drawing.Size(71, 43)
			Me.xrTableCell7.Tag = "UnitPrice"
			Me.xrTableCell7.Text = "Unit Price"
			Me.xrTableCell7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
'			Me.xrTableCell7.PreviewClick += New DevExpress.XtraReports.UI.PreviewMouseEventHandler(Me.OnCellPreviewClick);
			' 
			' xrTableCell2
			' 
			Me.xrTableCell2.BorderWidth = 1
			Me.xrTableCell2.Location = New System.Drawing.Point(461, 0)
			Me.xrTableCell2.Name = "xrTableCell2"
			Me.xrTableCell2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrTableCell2.Size = New System.Drawing.Size(87, 43)
			Me.xrTableCell2.Tag = "Quantity"
			Me.xrTableCell2.Text = "Quantity"
			Me.xrTableCell2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
'			Me.xrTableCell2.PreviewClick += New DevExpress.XtraReports.UI.PreviewMouseEventHandler(Me.OnCellPreviewClick);
			' 
			' xrTableCell13
			' 
			Me.xrTableCell13.BorderWidth = 1
			Me.xrTableCell13.Location = New System.Drawing.Point(548, 0)
			Me.xrTableCell13.Name = "xrTableCell13"
			Me.xrTableCell13.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrTableCell13.Size = New System.Drawing.Size(102, 43)
			Me.xrTableCell13.Tag = "Discount"
			Me.xrTableCell13.Text = "Discount"
			Me.xrTableCell13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
'			Me.xrTableCell13.PreviewClick += New DevExpress.XtraReports.UI.PreviewMouseEventHandler(Me.OnCellPreviewClick);
			' 
			' ReportHeader
			' 
			Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.lbOrderID, Me.xrLabel1, Me.xrPageInfo1})
			Me.ReportHeader.Name = "ReportHeader"
			' 
			' lbOrderID
			' 
			Me.lbOrderID.Font = New System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(204)))
			Me.lbOrderID.Location = New System.Drawing.Point(400, 17)
			Me.lbOrderID.Name = "lbOrderID"
			Me.lbOrderID.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.lbOrderID.Size = New System.Drawing.Size(117, 33)
			Me.lbOrderID.Text = "lbOrderID"
			Me.lbOrderID.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
			' 
			' xrLabel1
			' 
			Me.xrLabel1.CanShrink = True
			Me.xrLabel1.Font = New System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(204)))
			Me.xrLabel1.Location = New System.Drawing.Point(25, 17)
			Me.xrLabel1.Name = "xrLabel1"
			Me.xrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrLabel1.Size = New System.Drawing.Size(366, 33)
			Me.xrLabel1.Text = "Details of the customer order"
			Me.xrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
			' 
			' xrPageInfo1
			' 
			Me.xrPageInfo1.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(204)))
			Me.xrPageInfo1.Location = New System.Drawing.Point(383, 67)
			Me.xrPageInfo1.Name = "xrPageInfo1"
			Me.xrPageInfo1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrPageInfo1.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime
			Me.xrPageInfo1.Size = New System.Drawing.Size(245, 16)
			Me.xrPageInfo1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
			' 
			' nwindDataSet1
			' 
			Me.nwindDataSet1.DataSetName = "nwindDataSet"
			Me.nwindDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
			' 
			' orderDetailsTableAdapter
			' 
			Me.orderDetailsTableAdapter.ClearBeforeFill = True
			' 
			' XtraReport1
			' 
			Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.Detail, Me.PageHeader, Me.ReportHeader})
			Me.DataAdapter = Me.orderDetailsTableAdapter
			Me.DataMember = "OrderDetails"
			Me.DataSource = Me.nwindDataSet1
			Me.Version = "8.1"
			CType(Me.xrTable2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.xrTable1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.nwindDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

		End Sub

		#End Region

		Private Detail As DevExpress.XtraReports.UI.DetailBand
		Private PageHeader As DevExpress.XtraReports.UI.PageHeaderBand
		Private ReportHeader As DevExpress.XtraReports.UI.ReportHeaderBand
		Private xrTable2 As DevExpress.XtraReports.UI.XRTable
		Private xrTableRow2 As DevExpress.XtraReports.UI.XRTableRow
		Private clProductName As DevExpress.XtraReports.UI.XRTableCell
		Private clSupplier As DevExpress.XtraReports.UI.XRTableCell
		Private clUnitPrice As DevExpress.XtraReports.UI.XRTableCell
		Private clQuantity As DevExpress.XtraReports.UI.XRTableCell
		Private clDiscount As DevExpress.XtraReports.UI.XRTableCell
		Private xrTable1 As DevExpress.XtraReports.UI.XRTable
		Private xrTableRow1 As DevExpress.XtraReports.UI.XRTableRow
		Private WithEvents xrTableCell1 As DevExpress.XtraReports.UI.XRTableCell
		Private WithEvents xrTableCell4 As DevExpress.XtraReports.UI.XRTableCell
		Private WithEvents xrTableCell7 As DevExpress.XtraReports.UI.XRTableCell
		Private WithEvents xrTableCell2 As DevExpress.XtraReports.UI.XRTableCell
		Private WithEvents xrTableCell13 As DevExpress.XtraReports.UI.XRTableCell
		Private lbOrderID As DevExpress.XtraReports.UI.XRLabel
		Private xrLabel1 As DevExpress.XtraReports.UI.XRLabel
		Private xrPageInfo1 As DevExpress.XtraReports.UI.XRPageInfo
		Private nwindDataSet1 As nwindDataSet
		Private orderDetailsTableAdapter As PreviewSort.nwindDataSetTableAdapters.OrderDetailsTableAdapter
	End Class
End Namespace
