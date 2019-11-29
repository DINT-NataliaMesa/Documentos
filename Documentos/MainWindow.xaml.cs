using System;
using System.Windows;

namespace Documentos
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        Configuracion configuracion;

        private void NuevoDocumentoButton_Click(object sender, RoutedEventArgs e)
        {

            NuevoDocumento nuevoDocumento = new NuevoDocumento();
            nuevoDocumento.Owner = this;
            nuevoDocumento.Title = "Documento " + OwnedWindows.Count;

            if (configuracion != null)
            {
                nuevoDocumento.ContenidoDocumento.Width = Convert.ToDouble(configuracion.AnchoTextBox.Text);
                nuevoDocumento.ContenidoDocumento.Height = Convert.ToDouble(configuracion.AltoTextBox.Text);
            }
            else
            {
                nuevoDocumento.ContenidoDocumento.Width = 500;
                nuevoDocumento.ContenidoDocumento.Height = 500;
            }
            
            
            nuevoDocumento.Show();
        }

        private void ConfiguracionButton_Click(object sender, RoutedEventArgs e)
        {
            configuracion = new Configuracion();

            configuracion.Owner = this;
            configuracion.ShowDialog();

        }
    }
}
