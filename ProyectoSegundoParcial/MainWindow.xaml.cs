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

namespace ProyectoSegundoParcial
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnAgregar_Click(object sender, RoutedEventArgs e)
        {
            grdJoyeria.Children.Clear();
            switch (cmbBJoyeria.SelectedIndex)
            {
                case 0:
                    grdJoyeria.Children.Add(new Aretes());
                    G.Visibility = Visibility.Visible;
                    C.Visibility = Visibility.Visible;
                    break;
                case 1:
                    grdJoyeria.Children.Add(new Pulseras());
                    G.Visibility = Visibility.Visible;
                    C.Visibility = Visibility.Visible;
                    break;
                case 2:
                    grdJoyeria.Children.Add(new Collares());
                    G.Visibility = Visibility.Visible;
                    C.Visibility = Visibility.Visible; break;
                case 3:
                    grdJoyeria.Children.Add(new Anillos());
                    G.Visibility = Visibility.Visible;
                    C.Visibility = Visibility.Visible;
                    break;
                case 4:
                    grdJoyeria.Children.Add(new Joyeros());
                    G.Visibility = Visibility.Visible;
                    C.Visibility = Visibility.Visible;
                    break;
                case 5:
                    grdJoyeria.Children.Add(new Medallas());
                    G.Visibility = Visibility.Visible;
                    C.Visibility = Visibility.Visible;
                    break;
                default:

                    break;
            }
        }

        private void guardar(object sender, RoutedEventArgs e)
        {
            switch (cmbBJoyeria.SelectedIndex)
            {
                case 0:

                    if (string.IsNullOrEmpty(((Aretes)grdJoyeria.Children[0]).AretesCodigo.Text) ||
                   string.IsNullOrEmpty(((Aretes)grdJoyeria.Children[0]).AretesDescripcion.Text) ||
                    string.IsNullOrEmpty(((Aretes)grdJoyeria.Children[0]).Aretes3.Text) ||
                     string.IsNullOrEmpty(((Aretes)grdJoyeria.Children[0]).Aretes4.Text) ||
                    string.IsNullOrEmpty(((Aretes)grdJoyeria.Children[0]).Aretes5.Text) ||
                    string.IsNullOrEmpty(((Aretes)grdJoyeria.Children[0]).Aretes6.Text) ||
                    ((Aretes)(grdJoyeria.Children[0])).APagos.SelectedIndex == 0 ||
                    ((Aretes)(grdJoyeria.Children[0])).Aretes1.IsChecked == false &&
                    ((Aretes)(grdJoyeria.Children[0])).Aretes2.IsChecked == false &&
                    ((Aretes)(grdJoyeria.Children[0])).AcheckBox1.IsChecked == false &&
                    ((Aretes)(grdJoyeria.Children[0])).AcheckBox2.IsChecked == false &&
                    ((Aretes)(grdJoyeria.Children[0])).AcheckBox3.IsChecked == false &&
                    ((Aretes)(grdJoyeria.Children[0])).AcheckBox4.IsChecked == false &&
                    ((Aretes)(grdJoyeria.Children[0])).AcheckBox5.IsChecked == false)
                        Campos.Visibility = Visibility.Visible;
                    else
                    {

                        C.Visibility = Visibility.Hidden;
                        G.Visibility = Visibility.Hidden;

                        Campos.Visibility = Visibility.Hidden;
                        grdJoyeria.Children.Clear();
                    }
                    break;

                case 1:

                    if (string.IsNullOrEmpty(((Pulseras)grdJoyeria.Children[0]).PulserasCodigo.Text) ||
                   string.IsNullOrEmpty(((Pulseras)grdJoyeria.Children[0]).PulserasDescripcion.Text) ||
                    string.IsNullOrEmpty(((Pulseras)grdJoyeria.Children[0]).Pulseras3.Text) ||
                     string.IsNullOrEmpty(((Pulseras)grdJoyeria.Children[0]).Pulseras4.Text) ||
                    string.IsNullOrEmpty(((Pulseras)grdJoyeria.Children[0]).Pulseras5.Text) ||
                    string.IsNullOrEmpty(((Pulseras)grdJoyeria.Children[0]).Pulseras6.Text) ||
                    ((Pulseras)(grdJoyeria.Children[0])).PPagos.SelectedIndex == 0 ||
                    ((Pulseras)(grdJoyeria.Children[0])).Pulseras1.IsChecked == false &&
                    ((Pulseras)(grdJoyeria.Children[0])).Pulseras2.IsChecked == false &&
                    ((Pulseras)(grdJoyeria.Children[0])).PcheckBox1.IsChecked == false &&
                    ((Pulseras)(grdJoyeria.Children[0])).PcheckBox2.IsChecked == false &&
                    ((Pulseras)(grdJoyeria.Children[0])).PcheckBox3.IsChecked == false &&
                    ((Pulseras)(grdJoyeria.Children[0])).PcheckBox4.IsChecked == false &&
                    ((Pulseras)(grdJoyeria.Children[0])).PcheckBox5.IsChecked == false)
                        Campos.Visibility = Visibility.Visible;

                    else
                    {

                        C.Visibility = Visibility.Hidden;
                        G.Visibility = Visibility.Hidden;

                        Campos.Visibility = Visibility.Hidden;
                        grdJoyeria.Children.Clear();
                    }
                    break;

                case 2:
                    if (string.IsNullOrEmpty(((Joyeros)grdJoyeria.Children[0]).JoyerosCodigo.Text) ||
                   string.IsNullOrEmpty(((Joyeros)grdJoyeria.Children[0]).JoyerosDescripcion.Text) ||
                    string.IsNullOrEmpty(((Joyeros)grdJoyeria.Children[0]).Joyeros3.Text) ||
                     string.IsNullOrEmpty(((Joyeros)grdJoyeria.Children[0]).Joyeros4.Text) ||
                    string.IsNullOrEmpty(((Joyeros)grdJoyeria.Children[0]).Joyeros5.Text) ||
                    string.IsNullOrEmpty(((Joyeros)grdJoyeria.Children[0]).Joyeros6.Text) ||
                    ((Joyeros)(grdJoyeria.Children[0])).JPagos.SelectedIndex == 0 ||
                    ((Joyeros)(grdJoyeria.Children[0])).Joyeros1.IsChecked == false &&
                    ((Joyeros)(grdJoyeria.Children[0])).Joyeros2.IsChecked == false &&
                    ((Joyeros)(grdJoyeria.Children[0])).JcheckBox1.IsChecked == false &&
                    ((Joyeros)(grdJoyeria.Children[0])).JcheckBox2.IsChecked == false &&
                    ((Joyeros)(grdJoyeria.Children[0])).JcheckBox3.IsChecked == false &&
                    ((Joyeros)(grdJoyeria.Children[0])).JcheckBox4.IsChecked == false &&
                    ((Joyeros)(grdJoyeria.Children[0])).JcheckBox5.IsChecked == false)
                        Campos.Visibility = Visibility.Visible;
                    else
                    {

                        C.Visibility = Visibility.Hidden;
                        G.Visibility = Visibility.Hidden;
                        Campos.Visibility = Visibility.Hidden;

                        grdJoyeria.Children.Clear();
                    }
                    break;

                case 3:
                    if (string.IsNullOrEmpty(((Anillos)grdJoyeria.Children[0]).AnillosDescripcion.Text) ||
                    string.IsNullOrEmpty(((Anillos)grdJoyeria.Children[0]).Anillos3.Text) ||
                    string.IsNullOrEmpty(((Anillos)grdJoyeria.Children[0]).Anillos4.Text) ||
                    string.IsNullOrEmpty(((Anillos)grdJoyeria.Children[0]).Anillos5.Text) ||
                    string.IsNullOrEmpty(((Anillos)grdJoyeria.Children[0]).Anillos6.Text) ||
                    ((Anillos)(grdJoyeria.Children[0])).AnPagos.SelectedIndex == 0 ||
                    ((Anillos)(grdJoyeria.Children[0])).Anillos1.IsChecked == false &&
                    ((Anillos)(grdJoyeria.Children[0])).Anillos2.IsChecked == false &&
                    ((Anillos)(grdJoyeria.Children[0])).AncheckBox1.IsChecked == false &&
                    ((Anillos)(grdJoyeria.Children[0])).AncheckBox2.IsChecked == false &&
                    ((Anillos)(grdJoyeria.Children[0])).AncheckBox3.IsChecked == false &&
                    ((Anillos)(grdJoyeria.Children[0])).AncheckBox4.IsChecked == false &&
                    ((Anillos)(grdJoyeria.Children[0])).AncheckBox5.IsChecked == false)
                        Campos.Visibility = Visibility.Visible;

                    else
                    {

                        C.Visibility = Visibility.Hidden;

                        Campos.Visibility = Visibility.Hidden;
                        G.Visibility = Visibility.Hidden;
                        grdJoyeria.Children.Clear();
                    }
                    break;

                case 4:
                    if (string.IsNullOrEmpty(((Collares)grdJoyeria.Children[0]).CollaresDescripcion.Text) ||
                   string.IsNullOrEmpty(((Collares)grdJoyeria.Children[0]).Collares3.Text) ||
                   string.IsNullOrEmpty(((Collares)grdJoyeria.Children[0]).Collares4.Text) ||
                   string.IsNullOrEmpty(((Collares)grdJoyeria.Children[0]).Collares5.Text) ||
                   string.IsNullOrEmpty(((Collares)grdJoyeria.Children[0]).Collares6.Text) ||
                   ((Collares)(grdJoyeria.Children[0])).CPagos.SelectedIndex == 0 ||
                   ((Collares)(grdJoyeria.Children[0])).Collares1.IsChecked == false &&
                   ((Collares)(grdJoyeria.Children[0])).Collares2.IsChecked == false &&
                   ((Collares)(grdJoyeria.Children[0])).CcheckBox1.IsChecked == false &&
                   ((Collares)(grdJoyeria.Children[0])).CcheckBox2.IsChecked == false &&
                   ((Collares)(grdJoyeria.Children[0])).CcheckBox3.IsChecked == false &&
                   ((Collares)(grdJoyeria.Children[0])).CcheckBox4.IsChecked == false &&
                   ((Collares)(grdJoyeria.Children[0])).CcheckBox5.IsChecked == false)
                    {
                        Campos.Visibility = Visibility.Visible;
                    }

                    else
                    {

                        C.Visibility = Visibility.Hidden;
                        G.Visibility = Visibility.Hidden;

                        Campos.Visibility = Visibility.Hidden;
                        grdJoyeria.Children.Clear();
                    }
                    break;

                case 5:

                    if (string.IsNullOrEmpty(((Medallas)grdJoyeria.Children[0]).MedallasDescripcion.Text) ||
              string.IsNullOrEmpty(((Medallas)grdJoyeria.Children[0]).Medallas3.Text) ||
              string.IsNullOrEmpty(((Medallas)grdJoyeria.Children[0]).Medallas4.Text) ||
              string.IsNullOrEmpty(((Medallas)grdJoyeria.Children[0]).Medallas5.Text) ||
              string.IsNullOrEmpty(((Medallas)grdJoyeria.Children[0]).Medallas6.Text) ||
              ((Medallas)(grdJoyeria.Children[0])).MPagos.SelectedIndex == 0 ||
              ((Medallas)(grdJoyeria.Children[0])).Medallas1.IsChecked == false &&
              ((Medallas)(grdJoyeria.Children[0])).Medallas2.IsChecked == false &&
              ((Medallas)(grdJoyeria.Children[0])).McheckBox1.IsChecked == false &&
              ((Medallas)(grdJoyeria.Children[0])).McheckBox2.IsChecked == false &&
              ((Medallas)(grdJoyeria.Children[0])).McheckBox3.IsChecked == false &&
              ((Medallas)(grdJoyeria.Children[0])).McheckBox4.IsChecked == false &&
              ((Medallas)(grdJoyeria.Children[0])).McheckBox5.IsChecked == false)
                    
                       Campos.Visibility = Visibility.Hidden;

                    else
                    {

                        C.Visibility = Visibility.Hidden;
                        G.Visibility = Visibility.Hidden;

                        Campos.Visibility = Visibility.Hidden;
                        grdJoyeria.Children.Clear();
                    }
                    break;


            }
        }

        private void cancelar(object sender, RoutedEventArgs e)
        {
            grdJoyeria.Children.Clear();
            grdJoyeria.Visibility = Visibility.Hidden;
            C.Visibility = Visibility.Hidden;
            G.Visibility = Visibility.Hidden;
            Campos.Visibility = Visibility.Hidden;
            cmbBJoyeria.SelectedItem = null;
        }

    }
}
