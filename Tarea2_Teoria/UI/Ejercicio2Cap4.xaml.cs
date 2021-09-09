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
    /// Interaction logic for Ejercicio2Cap4.xaml
    /// </summary>
    public partial class Ejercicio2Cap4 : Window
    {
        public Ejercicio2Cap4()
        {
            InitializeComponent();
        }

        private void ElevarButton_Click(object sender, RoutedEventArgs e)
        {
            double num;
            double potencia;
            double resultado; 

            num = Convert.ToDouble(Ejercicio2Cap4TextBoxNum.Text);
            potencia = Convert.ToDouble(Ejercicio2Cap4TextBoxPotencia.Text);

            resultado = Math.Pow(num, potencia);

            Ejercicio2Cap4TextBoxResultado.Text = resultado.ToString();
        }

        private void LimpiarButton_Click(object sender, RoutedEventArgs e)
        {
            Ejercicio2Cap4TextBoxNum.Clear();
            Ejercicio2Cap4TextBoxPotencia.Clear();
            Ejercicio2Cap4TextBoxResultado.Clear();

        }
    }
}
