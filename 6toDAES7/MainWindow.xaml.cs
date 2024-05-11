using Business;
using Entity;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _6toDAES7
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
        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            ProductBusiness business = new ProductBusiness();
            dgProduct.ItemsSource = business.Get();
        }
        private void Button_Click4(object sender, RoutedEventArgs e)
        {
            ProductBusiness business = new ProductBusiness();
            string productName = txtProductName.Text;
            dgProduct.ItemsSource = business.GetByName(productName);
        }
        private void Button_Click5(object sender, RoutedEventArgs e)
        {
            CrearProducto crearProducto = new CrearProducto();
            this.Close();
            crearProducto.ShowDialog();
        }
        private void ButtonEliminar_Click(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;
            Product product = btn.DataContext as Product; // Suponiendo que tu clase Product tenga un objeto con los datos del producto

            ProductBusiness business = new ProductBusiness();
            business.DeleteProduct(product.product_id);

            ProductBusiness businessList = new ProductBusiness();
            dgProduct.ItemsSource = businessList.Get();
        }



    }
}