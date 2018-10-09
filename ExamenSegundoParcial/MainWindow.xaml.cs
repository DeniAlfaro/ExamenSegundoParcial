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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ExamenSegundoParcial
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

        private void btnSiguiente_Click(object sender, RoutedEventArgs e)
        {
            if (informacionPersonal.NombreIP.Text == "" || informacionPersonal.ApellidoIP.Text == "" || informacionPersonal.Apellido2IP.Text == "" || informacionPersonal.EdadIP.Text == "")
            {
                informacionPersonal.error.Visibility = Visibility.Visible;
                
            } else
            {
                contacto.Visibility = Visibility.Visible;
            }

            if (contacto.correoC.Text == "" || contacto.telefonoC.Text == "" || contacto.celularC.Text == "")
            {
                contacto.error2.Visibility = Visibility.Visible;
            }
            else
            {
                informacionPago.Visibility = Visibility.Visible;
                btnFinalizar.Visibility = Visibility.Visible;
            }
        }

        private void btnFinalizar_Click(object sender, RoutedEventArgs e)
        {

            btnSiguiente.Visibility = Visibility.Hidden;
            btnFinalizar.Visibility = Visibility.Visible;
            
            if (informacionPago.numeroTarjeta.MaxLength > 16 || informacionPago.numeroTarjeta.MaxLength < 16)
            {
                informacionPago.error3.Visibility = Visibility.Visible;
            }
        }
    }
}
