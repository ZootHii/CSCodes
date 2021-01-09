namespace AdoNetDemo
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal UnitPrice { get; set; }
        public int StockAmount { get; set; }
        
        // This code did not work IDK why
        /*public int _id;
        public string _name;
        public decimal _unitPrice;
        public int _stockAmount;

        public Product(int id, string name, decimal unitPrice, int stockAmount)
        {
            _id = id;
            _name = name;
            _unitPrice = unitPrice;
            _stockAmount = stockAmount;
        }*/
    }
}