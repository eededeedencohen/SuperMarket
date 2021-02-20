using PL.Commands;
using PL.Models;
using System.Windows.Input;

namespace PL.ViewModels
{
    public class ProductViewModel : ViewModel
    {

        private Product _product;

        public Product Product
        {
            get { return _product; }
            set { _product = value; }

        }

        public ICommand SaveProduct { get; set; }


        public ProductViewModel()
        {
            Product = new Product()
            {
                qrCode = "aaa",
                price = 22,
                imagePath = @"C:\Users\עדן\source\repos\SuperMarket\PL\Images\חלב תנובה.png",
                name = "bbb"

            };
            SaveProduct = new SaveProductCommand();
        }


        //private string qrBarcode { get; set; }
        //private string name { get; set; }
        //private string imagePath { get; set; }
        //private double price { get; set; }
    }
}
