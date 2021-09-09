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

namespace Tarea2_Teoria.UI
{
    /// <summary>
    /// Interaction logic for Ejercicio5Cap4.xaml
    /// </summary>
    public partial class Ejercicio5Cap4 : Window
    {
        public Ejercicio5Cap4()
        {
            InitializeComponent();
        }

        private void PromedioButton_Click(object sender, RoutedEventArgs e)
        {
            int edad1;
            int edad2;
            int edad3;
            double promedio;

            edad1 = Convert.ToInt32(Ejercicio5Cap4TextBoxEdad1.Text);
            edad2 = Convert.ToInt32(Ejercicio5Cap4TextBoxEdad2.Text);
            edad3 = Convert.ToInt32(Ejercicio5Cap4TextBoxEdad3.Text);

            promedio = (edad1 + edad2 + edad3) / 3;

            Ejercicio5Cap4TextBoxPromedio.Text = promedio.ToString(); 
        }

        private void LimpiarButton_Click(object sender, RoutedEventArgs e)
        {
            Ejercicio5Cap4TextBoxEdad1.Clear();
            Ejercicio5Cap4TextBoxEdad2.Clear();
            Ejercicio5Cap4TextBoxEdad3.Clear();
            Ejercicio5Cap4TextBoxPromedio.Clear();
        }
    }
}
