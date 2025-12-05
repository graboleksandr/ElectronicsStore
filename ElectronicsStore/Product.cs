using System;

namespace ElectronicsStore
{
    struct Product
    {
        public int Id;
        public string Name;
        public string Category;
        public double Price;

        public Product(int id, string name, string category, double price)
        {
            this.Id = id;
            this.Name = name;
            this.Price = price;
            this.Category = category;
        }
        public void Print(int index = -1)
        {
            if (index == -1)
            {
                Console.WriteLine($"Id: {Id}, Назва: {Name}, Ціна: {Price} грн, Опис: {Category}");
                return;
            }

            Console.WriteLine($"Index: {index}, Id: {Id}, Назва: {Name}, Ціна: {Price} грн, Опис: {Category}");
        }
    }
}
