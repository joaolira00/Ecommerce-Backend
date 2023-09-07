namespace Entities
{
    public class Products
    {
        private string? productName;
        private string? category;
        private double? price;
        private int? sales;

        public string? GetProductName()
        {
            return productName;
        }

        public void SetProductName(string _productName)
        {
            productName = _productName;
        }

        public string? GetCategory()
        {
            return category;
        }

        public void SetCategory(string _category)
        {
            category = _category;
        }

        public double? GetPrice()
        {
            return price;
        }

        public void SetPrice(double _price)
        {
            price = _price;
        }

        public int? GetSales()
        {
            return sales;
        }

        public void SetSales(int _sales)
        {
            sales = _sales;
        }
    }
}