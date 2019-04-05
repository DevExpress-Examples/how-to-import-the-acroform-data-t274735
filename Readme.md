<!-- default file list -->
*Files to look at*:

* [MainWindow.xaml](./CS/ImportFormData/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/ImportFormData/MainWindow.xaml))
* [MainWindow.xaml.cs](./CS/ImportFormData/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](./VB/ImportFormData/MainWindow.xaml.vb))
<!-- default file list end -->
# How to import the AcroForm data


This example demonstrates how you can import the AcroForm data  (interactive forms) either from XML or FDF format  to a PDF document.


<h3>Description</h3>

For this, do the following.<br />Load a document with interactive forms (e.g., from a file path)&nbsp;to which the data will be imported,&nbsp;into the PDF Viewer&nbsp;using the <a href="https://documentation.devexpress.com/#WPF/DevExpressXpfDocumentViewerDocumentViewerControl_OpenDocumenttopic">DocumentViewerControl.OpenDocument</a> method.<br /><br />To import the&nbsp;AcroForm data either from the XML or FDF format: call the <a href="https://documentation.devexpress.com/#WPF/DevExpressXpfPdfViewerPdfViewerControl_ImportFormDatatopic">PdfViewerControl.ImportFormData&nbsp;</a>&nbsp;method after the document is loaded in the&nbsp;<a href="https://documentation.devexpress.com/#WPF/DevExpressXpfPdfViewerPdfViewerControl_DocumentLoadedtopic">PdfViewerControl.DocumentLoaded </a> event handler.<br />The import method invokes the <strong>Open</strong> dialog window, where you can specify&nbsp;the file name and file format (XML or FDF) from which a PDF document with interactive form is loaded.<br /><br />To&nbsp;save&nbsp;the imported document,&nbsp;(e.g., to a file),&nbsp;call the <a href="https://documentation.devexpress.com/#WPF/DevExpressXpfPdfViewerPdfViewerControl_SaveDocumenttopic">PdfViewerControl.SaveDocument </a>method with a specified file name, including a file path where the imported document&nbsp;will be&nbsp;located.

<br/>


