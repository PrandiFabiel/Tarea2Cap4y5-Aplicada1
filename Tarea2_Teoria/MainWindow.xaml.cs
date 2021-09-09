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
using Tarea2_Teoria.UI;

namespace Tarea2_Teoria
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

        private void Ejercicio1Cap4MenuItem_Click(object sender, RoutedEventArgs e)
        {
            Ejercicio1Cap4 ejercicio1Cap4 = new UI.Ejercicio1Cap4();
            ejercicio1Cap4.Show(); 

        }

        private void Ejercicio2Cap4MenuItem_Click(object sender, RoutedEventArgs e)
        {
            Ejercicio2Cap4 ejercicio2Cap4 = new UI.Ejercicio2Cap4();
            ejercicio2Cap4.Show(); 
        }

        private void Ejercicio5Cap4MenuItem_Click(object sender, RoutedEventArgs e)
        {
            Ejercicio5Cap4 ejercicio5Cap4 = new UI.Ejercicio5Cap4();
            ejercicio5Cap4.Show(); 
        }

        private void Ejercicio4Cap5MenuItem_Click(object sender, RoutedEventArgs e)
        {
            Ejercicio4Cap5 ejercicio4Cap5 = new UI.Ejercicio4Cap5();
            ejercicio4Cap5.Show(); 
        }

        private void Ejercicio5Cap5MenuItem_Click(object sender, RoutedEventArgs e)
        {
            Ejercicio5Cap5 ejercicio5Cap5 = new UI.Ejercicio5Cap5();
            ejercicio5Cap5.Show(); 
        }
    }
}
