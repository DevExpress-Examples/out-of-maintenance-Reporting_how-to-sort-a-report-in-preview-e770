<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/Form1.cs) (VB: [Form1.vb](./VB/Form1.vb))
* [XtraReport1.cs](./CS/XtraReport1.cs) (VB: [XtraReport1.vb](./VB/XtraReport1.vb))
<!-- default file list end -->
# How to sort a report in preview


<p>This example demonstrates how to implement sorting in print preview.</p>
<p>For this, handle the <strong>PreviewClick</strong> event of a column header control (e.g. <strong>XRLabel</strong> or <strong>XRTableCell</strong>), then specify a report's sorting options via its <strong>Detail.SortFields</strong> property, and at last refresh the document by calling the <strong>CreateDocument</strong> method.</p>
<p><strong>Note</strong>: It's also very convenient to store the data field name in the control's <strong>Tag</strong> property, instead of trying to parse the control's binding.<br /><br />See also:<br /><a href="https://www.devexpress.com/Support/Center/p/T210208">Print Preview - How to implement a drop-down menu for sorting report data</a></p>

<br/>


