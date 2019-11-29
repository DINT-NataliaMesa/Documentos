using System;
using System.Collections.Generic;
using System.IO;
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
    /// Lógica de interacción para NuevoDocumento.xaml
    /// </summary>
    public partial class NuevoDocumento : Window
    {
        public NuevoDocumento()
        {
            InitializeComponent();
        }

        private void GuardarButton_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.SaveFileDialog dialog = new Microsoft.Win32.SaveFileDialog();

            dialog.Title = "Guardar como";
            dialog.Filter = "Archivos de texto|*.txt";
            dialog.InitialDirectory = Environment.GetFolderPath(Environment
                                                                .SpecialFolder
                                                                .MyComputer);

            

            if ((bool)dialog.ShowDialog())
            {
                if (dialog.FileName != "")
                {
                    File.WriteAllText(dialog.FileName,
                                  ContenidoDocumento.Text);
                }
                
            }            
        }

        private void Doc_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string tituloMessageBox = "Cerrar";
            string mensajeMessageBox = "¿Seguro que quieres cerrar?";
            MessageBoxButton botonesMessageBox = MessageBoxButton.YesNo;
            MessageBoxImage iconoMessageBox = MessageBoxImage.Question;

            MessageBoxResult result = MessageBox.Show(mensajeMessageBox,
                                                      tituloMessageBox,
                                                      botonesMessageBox,
                                                      iconoMessageBox);

            e.Cancel = (result == MessageBoxResult.Yes) ? false : true;
        }
    }
}
