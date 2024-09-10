<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128658606/24.2.1%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T274735)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->
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


<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=how-to-import-the-acroform-data-t274735&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=how-to-import-the-acroform-data-t274735&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
