using DevExpress.Xpf.PdfViewer;
using System.Windows;

namespace ImportFormData {

    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
            Viewer.OpenDocument("..\\..\\FormFillDemo.pdf");
        }

        private void Viewer_DocumentLoaded(object sender, RoutedEventArgs e) {
            Viewer.ImportFormData();
            Viewer.SaveDocument("..\\..\\ImportedDocument.pdf");
        }

        private void Viewer_DocumentClosing(DependencyObject d, DocumentClosingEventArgs e) {
            e.SaveDialogResult = MessageBoxResult.Cancel;
            e.Handled = true;
        }
    }
}
