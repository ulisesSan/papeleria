
namespace papeSraErika
{
    class ProductMap
    {
        private string barCode;
        private string productName;
        private string _brand;
        private string brand;
        private string description;
        private string _description;
        private string price;
        private string _price;
        private int stock;
        private int _stock;

        public string BarCode { get => barCode; set => barCode = value; }
        public string ProductName { get => productName; set => productName = value; }
        public string Brand { get => Brand; set => _brand = value; }
        public string Description { get => Description; set => _description = value; }
        public string Price { get => Price; set => _price = value; }
        public int Stock { get => Stock; set => _stock = value; }
    }
}
