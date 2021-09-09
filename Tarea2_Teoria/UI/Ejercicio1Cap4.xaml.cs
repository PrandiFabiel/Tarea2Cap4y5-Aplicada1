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
    /// Interaction logic for Ejercicio1Cap4.xaml
    /// </summary>
    public partial class Ejercicio1Cap4 : Window
    {
        public Ejercicio1Cap4()
        {
            InitializeComponent();
        }

        private void MostrarTablaButton_Click(object sender, RoutedEventArgs e)
        {
            int num;
            int resultado;

            num = Convert.ToInt32(Ejercicio1Cap4TextBox.Text);

            for (int i = 1; i <= 10; i++)
            {
                resultado = num * i;
                ResultadoEjercicio1Cap4TextBox.Text += (num + "x" + i + "=" + resultado.ToString() + "\n");
            }
                
        }

        private void LimpiarButton_Click(object sender, RoutedEventArgs e)
        {
            ResultadoEjercicio1Cap4TextBox.Clear(); 
        }
    }
}
