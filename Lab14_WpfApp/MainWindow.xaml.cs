using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace Lab14_WpfApp
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public enum Type
    {
        food, chemicals
    }

    public class Product
    {
        public string NameProduct { get; set; }
        public string ImageProduct { get; set; }
        public int PriceProduct { get; set; }
        public Type Type { get; set; }
    }


    public partial class MainWindow : Window
    {
        public List<Product> products;
        public MainWindow()
        {
            InitializeComponent();
            products = new List<Product>();
            products.Add(new Product()
            {
                NameProduct = "Стиральный порошок",
                PriceProduct = 250,
                Type = Type.chemicals,
                ImageProduct = "Picture/Tide1,8.jpg"
            });

            products.Add(new Product()
            {
                NameProduct = "Яблоки",
                PriceProduct = 68,
                Type = Type.food,
                ImageProduct = "Picture/apple.jpg"
            });

            products.Add(new Product()
            {
                NameProduct = "Средство для мытья посуды",
                PriceProduct = 65,
                Type = Type.chemicals,
                ImageProduct = "Picture/Fairy.jpeg"
            });

            products.Add(new Product()
            {
                NameProduct = "Конфеты",
                PriceProduct = 240,
                Type = Type.food,
                ImageProduct = "Picture/Tango.jpg"
            });


            lst.ItemsSource = products;

        }
    }





}
