using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Documentos
{
    /// <summary>
    /// Lógica de interacción para Configuracion.xaml
    /// </summary>
    public partial class Configuracion : Window
    {
        public Configuracion()
        {
            InitializeComponent();
        }

        private void AceptarButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow window = (Owner as MainWindow).Docs;

            WindowCollection collection = window.OwnedWindows;

            foreach (Window item in collection)
            {
                (item as NuevoDocumento).ContenidoDocumento.Width = Convert.ToDouble(AnchoTextBox.Text);
                (item as NuevoDocumento).ContenidoDocumento.Height = Convert.ToDouble(AltoTextBox.Text);

                break;                
            }

            this.Close();

        }

        private void CancelarButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
