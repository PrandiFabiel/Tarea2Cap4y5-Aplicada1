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
    /// Interaction logic for Ejercicio4Cap5.xaml
    /// </summary>
    public partial class Ejercicio4Cap5 : Window
    {
        public Ejercicio4Cap5()
        {
            InitializeComponent();
        }

        private void FactorialButton_Click(object sender, RoutedEventArgs e)
        {
            int num;
            int resultado;

            num = Convert.ToInt32(Ejercicio4Cap5TextBoxNum.Text);

            resultado = factorial(num);

            Ejercicio4Cap5TextBoxResultado.Text = resultado.ToString(); 
            
        }

        private void LimpiarButton_Click(object sender, RoutedEventArgs e)
        {
            Ejercicio4Cap5TextBoxNum.Clear();
            Ejercicio4Cap5TextBoxResultado.Clear();
        }

        static int factorial(int n)
        {
            int fact = 1;
            for (int i = 1; i <= n; i++)
            {
                fact *= i;
            }
            return fact; 
        }

    }
}
