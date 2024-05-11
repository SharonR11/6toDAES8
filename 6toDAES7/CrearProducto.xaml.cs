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
using Business;

namespace _6toDAES7
{
    /// <summary>
    /// Lógica de interacción para CrearProducto.xaml
    /// </summary>
    public partial class CrearProducto : Window
    {
        public CrearProducto()
        {
            InitializeComponent();
        }
        private void btnRegistrar_Click(object sender, RoutedEventArgs e)
        {
            string name = txtNombre.Text;
            double price = double.Parse(txtPrice.Text); 
            int stock = int.Parse(txtStock.Text); 

            ProductBusiness business = new ProductBusiness();
            business.InsertProduct(name, price, stock);

            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();

        }

    }
}
