namespace ElectronicsStore
{
    struct Product
    {
        public string Name;
        public string Category;
        public double Price;

        public Product(string name, string category, double price)
        {
            this.Name = name;
            this.Price = price;
            this.Category = category;
        }
    }
}