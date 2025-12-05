using ElectronicsStore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



public class Program


{
    static List<Product> products = new List<Product>();

    static int productCount = 0;

    const int MAX_PRODUCTS = 5;
    public static void Main(string[] args)
    {

        string username = "admin";
        string password = "12345";
        string enteredName;
        string enteredPassword;
        int attempts = 0;
        int maxAttempts = 4;

        while (attempts < maxAttempts)
        {
            Console.WriteLine("Введіть логін: ");
            enteredName = Console.ReadLine();
            Console.WriteLine("Введіть пароль: ");
            enteredPassword = Console.ReadLine();
            if (enteredName == username && enteredPassword == password)
            {
                break;

            }
            else
            {
                attempts++;
                int counterAttempts = maxAttempts - attempts;

                if (counterAttempts > 0)
                {
                    Console.WriteLine($"Невірно, кількість спроб: {counterAttempts}");
                    Console.WriteLine("Спрбуйте ще раз");
                }
                else
                {
                    Console.WriteLine("Ви вичерпали всі спроби. Спробуйте пізніше.");
                    return;
                }
            }
        }
        MainMenu();
    }

    public static void MainMenu()
    {

        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.InputEncoding = System.Text.Encoding.UTF8;
        bool exit = true;
        while (exit)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("=================================================");
            Console.WriteLine("|    МАГАЗИН ЕЛЕКТРОТЕХНІКИ | ГОЛОВНЕ МЕНЮ      |");
            Console.WriteLine("=================================================");
            Console.WriteLine("");

            Console.WriteLine("================ ОСНОВНІ БІЗНЕС-ПРОЦЕСИ ===================");
            Console.WriteLine("1. Продаж ");
            Console.WriteLine("2. Товар ");
            Console.WriteLine("3. Постачання ");
            Console.WriteLine("4. Гарантія та Сервіс ");
            Console.WriteLine("");
            Console.WriteLine("======================== АНАЛІТИКА ========================");
            Console.WriteLine("5. Аналітика ");
            Console.WriteLine("");
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine("0. Вихід з програми");
            Console.WriteLine("");
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine("Вибуріть номер опції (0-5): ");
            Console.ResetColor();

            double choice = Check();


            switch (choice)
            {
                case 1:
                    CatalogAndInventory();
                    break;
                case 2:
                    ShowProducts(); break;
                case 3:
                    SupplyAndDelivery(); break;
                case 4:
                    ServiceAndWarrantyMenu(); break;
                case 5:
                    ShowAnalytics(); break;
                case 0:
                    exit = false;
                    Console.WriteLine("Вихід з програми. До побачення!");
                    break;
                default:
                    Console.WriteLine("Невірний вибір. Будь ласка, спробуйте ще раз.");
                    Console.WriteLine("Натисніть будь-яку клавішу, щоб повернутися до головного меню...");
                    Console.ReadKey();
                    break;
            }
        }
    }


    public static void CatalogAndInventory()
    {
        Console.Clear();
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.InputEncoding = System.Text.Encoding.UTF8;
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("================ Покупка ==================");
        Console.ResetColor();
        Console.WriteLine();

        //Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Товари які є в наявності: ");
        Console.WriteLine("Телевізор - 10000 грн/шт");
        Console.WriteLine("Телефон - 20000 грн/шт");
        Console.WriteLine("Ноутбук - 30000 грн/шт");
        Console.WriteLine("PS 5 - 25000 грн/шт");
        Console.WriteLine("Планшет - 15000 грн/шт");
        Console.WriteLine("Геймпад - 3000 грн/шт");
        //Console.ResetColor();
        Console.ReadLine();
        Console.WriteLine();

        //Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("==== Введіть кількість товарів яких вам потрібно ====");
        Console.WriteLine();

        double TVPrice = 10000;
        double PhonePrice = 20000;
        double LaptopPrice = 30000;
        double PS5Price = 25000;
        double TabletPrice = 15000;
        double GamepadPrice = 3000;

        Console.Write("Введіть кількість телевізорів (шт): ");

        double amountTV = Check();

        Console.Write("Введіть кількість телефонів (шт): ");
        double amountPhone = Check();

        Console.Write("Введіть кількість ноутбуків (шт): ");
        double amountLaptop = Check();

        Console.Write("Введіть кількість PS 5 (шт): ");
        double amountPS5 = Check();

        Console.Write("Введіть кількість планшетів (шт): ");
        double amountTablet = Check();

        Console.Write("Введіть кількість геймпадів (шт): ");
        double amountGamepad = Check();
        //Console.ResetColor();
        Console.WriteLine("\n");

        //Console.ForegroundColor = ConsoleColor.Yellow;
        double totalTV = amountTV * TVPrice;
        double totalPhone = amountPhone * PhonePrice;
        double totalLaptop = amountLaptop * LaptopPrice;
        double totalPS5 = amountPS5 * PS5Price;
        double totalTablet = amountTablet * TabletPrice;
        double totalGamepad = amountGamepad * GamepadPrice;
        double totalPrice = totalTV + totalPhone + totalLaptop + totalPS5 + totalTablet + totalGamepad;

        Console.WriteLine("Загальна сума: " + totalPrice + " грн");

        double randomDiscount;
        if (totalPrice >= 500000)
        {
            randomDiscount = 50;
        }
        else if (totalPrice >= 250000)
        {
            randomDiscount = 30;
        }
        else if (totalPrice >= 100000)
        {
            randomDiscount = 10;
        }
        else
        {
            randomDiscount = 0;
        }
        randomDiscount = Math.Round(randomDiscount, 0);
        Console.WriteLine("Знижка: " + randomDiscount + "%");

        double discountAmount = totalPrice * (randomDiscount / 100);
        discountAmount = Math.Round(discountAmount, 2);
        Console.WriteLine("Сума зі знижкою: " + discountAmount + " грн");

        double SqrtrValue = Math.Sqrt(totalPrice);
        SqrtrValue = Math.Round(SqrtrValue, 2);
        Console.WriteLine("Квадратний корінь від загальної суми: " + SqrtrValue);
        //Console.ResetColor();
        Console.ReadLine();

        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("       Дякуємо за покупку!");
        Console.WriteLine();
        Console.WriteLine("Ви придбали: ");
        Console.WriteLine("Телевізор - " + amountTV + " шт");
        Console.WriteLine("Телефон - " + amountPhone + " шт");
        Console.WriteLine("Ноутбук - " + amountLaptop + " шт");
        Console.WriteLine("PS 5 - " + amountPS5 + " шт");
        Console.WriteLine("Планшет - " + amountTablet + " шт");
        Console.WriteLine("Геймпад - " + amountGamepad + " шт");
        Console.WriteLine("Гарного дня, до зустрічі!");
        Console.WriteLine("Натисніть будь-яку клавішу щоб продовжити...");
        Console.ReadKey();
        Console.ResetColor();
        return;
    }
    public static double Check()
    {
        double isNumber = 0;
        try
        {
            isNumber = double.Parse(Console.ReadLine());
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Непередбачена помилка: {ex.Message}");
            Console.WriteLine("Введіть число ще раз ");
            return Check();
        }
        return isNumber;
    }
    public static double Check(string prompt)
    {
        Console.WriteLine(prompt);
        return Check();
    }
    public static void ServiceAndWarrantyMenu()
    {

        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("==========================================================");
        Console.WriteLine("|   УПРАВЛІННЯ ГАРАНТІЄЮ та СЕРВІСНИМ ОБСЛУГОВУВАННЯМ   |");
        Console.WriteLine("==========================================================");

        Console.WriteLine("1.ЗАРЕЄСТРУВАТИ НОВИЙ ГАРАНТІЙНИЙ ВИПАДОК");
        Console.WriteLine("2.ПЕРЕВІРИТИ ТЕРМІН ГАРАНТІЇ ТОВАРУ");
        Console.WriteLine("3.ПЕРЕГЛЯНУТИ СЕРВІСНІ ЗАМОВЛЕННЯ");
        Console.WriteLine("4.ВИДАЧА ТОВАРУ з Ремонту");
        Console.WriteLine("");
        Console.WriteLine("----------------------------------------------------------");
        Console.WriteLine("0.ВЕРНУТИСЯ ДО ГОЛОВНОГО МЕНЮ");
        Console.WriteLine();
        Console.WriteLine("----------------------------------------------------------");
        Console.Write("Введіть номер опції (0-4): ");
        double choice1 = Check();

        switch (choice1)
        {
            case 1:
                Console.WriteLine("Ця функція тимчасово не доступна!");
                Console.WriteLine("Натисніть будь-яку клавішу щоб продовжити...");
                Console.ReadKey();
                ServiceAndWarrantyMenu();
                break;
            case 2:
                Console.WriteLine("Ця функція тимчасово не доступна!");
                Console.WriteLine("Натисніть будь-яку клавішу щоб продовжити...");
                Console.ReadKey();
                ServiceAndWarrantyMenu();
                break;
            case 3:
                Console.WriteLine("Ця функція тимчасово не доступна!");
                Console.WriteLine("Натисніть будь-яку клавішу щоб продовжити...");
                Console.ReadKey();
                ServiceAndWarrantyMenu();
                break;
            case 4:
                Console.WriteLine("Ця функція тимчасово не доступна!");
                Console.WriteLine("Натисніть будь-яку клавішу щоб продовжити...");
                Console.ReadKey();
                ServiceAndWarrantyMenu();
                break;
            case 0:
                break;
            default:
                Console.WriteLine("Некоректний вибір. Спробуйте ще раз.");
                Console.ReadKey();
                ServiceAndWarrantyMenu();
                break;
        }
        Console.ResetColor();
    }
    public static void SupplyAndDelivery()
    {

        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("==========================================================");
        Console.WriteLine("|                       ПОСТАЧАННЯ                       |");
        Console.WriteLine("==========================================================");

        Console.WriteLine("1.Логістика та склад");
        Console.WriteLine("2.Методи доставки");
        Console.WriteLine("3.Терміни та вартість");
        Console.WriteLine("4.Прийом товару покупцем");
        Console.WriteLine("");
        Console.WriteLine("----------------------------------------------------------");
        Console.WriteLine("0.ВЕРНУТИСЯ ДО ГОЛОВНОГО МЕНЮ");
        Console.WriteLine();
        Console.WriteLine("----------------------------------------------------------");
        Console.Write("Введіть номер опції (0-4): ");
        double choice1 = Check();

        switch (choice1)
        {
            case 1:
                Console.WriteLine("Ця функція тимчасово не доступна!");
                Console.WriteLine("Натисніть будь-яку клавішу щоб продовжити...");
                Console.ReadKey();
                SupplyAndDelivery();
                break;
            case 2:
                Console.WriteLine("Ця функція тимчасово не доступна!");
                Console.WriteLine("Натисніть будь-яку клавішу щоб продовжити...");
                Console.ReadKey();
                SupplyAndDelivery();
                break;
            case 3:
                Console.WriteLine("Ця функція тимчасово не доступна!");
                Console.WriteLine("Натисніть будь-яку клавішу щоб продовжити...");
                Console.ReadKey();
                SupplyAndDelivery();
                break;
            case 4:
                Console.WriteLine("Ця функція тимчасово не доступна!");
                Console.WriteLine("Натисніть будь-яку клавішу щоб продовжити...");
                Console.ReadKey();
                SupplyAndDelivery();
                break;
            case 0:
                break;
            default:
                Console.WriteLine("Некоректний вибір. Спробуйте ще раз.");
                Console.ReadKey();
                SupplyAndDelivery();
                break;
        }
        Console.ResetColor();
    }
    public static void ShowProducts()
    {

        Console.Clear();
        Console.ForegroundColor = ConsoleColor.DarkMagenta;
        Console.WriteLine("==========================================================");
        Console.WriteLine("|                    КАТАЛОГ ТОВАРУ                      |");
        Console.WriteLine("==========================================================");

        Console.WriteLine("1.Додати товар");
        Console.WriteLine("2.Переглянути товар");
        Console.WriteLine("3.Пошук товару");
        Console.WriteLine("4.Видалення товару");
        Console.WriteLine("5.Сортування товару");
        Console.WriteLine("");
        Console.WriteLine("----------------------------------------------------------");
        Console.WriteLine("0.ВЕРНУТИСЯ ДО ГОЛОВНОГО МЕНЮ");
        Console.WriteLine();
        Console.WriteLine("----------------------------------------------------------");
        Console.Write("Введіть номер опції (0-5): ");
        double choice1 = Check();

        switch (choice1)
        {
            case 1:
                AddProduct();
                break;
            case 2:
                ViewProducts();
                break;
            case 3:
                SearchProduct();
                break;
            case 4:
                DeleteProduct();
                break;
            case 5:
                SortProducts();
                break;
            case 0:
                MainMenu();
                break;
            default:
                Console.WriteLine("Некоректний вибір. Спробуйте ще раз.");
                Console.ReadKey();
                ShowProducts();
                break;
        }
        Console.ResetColor();
    }

    public static void AddProduct()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("--- ДОДАВАННЯ ---");

            if (productCount >= MAX_PRODUCTS)
            {
                Console.WriteLine("Досягнуто максимальну кількість товарів (5). Неможливо додати новий товар.");
                Pause();
                ShowProducts();
                return;
            }

            Console.Write("Назва: ");
            string name = Console.ReadLine();

            Console.Write("Категорія: ");
            string category = Console.ReadLine();

            Console.Write("Ціна: ");
            double price = Check();

            int id = productCount + 1;

            Product newProduct = new Product(id, name, category, price);
            products.Add(newProduct);

            Console.WriteLine("Товар додано!");

            productCount++;

            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Чи хочете додати ще один товар?");
            Console.WriteLine("Так - 1, Ні - 0");

            double choice = Check();

            if (choice != 1)
            {
                ShowProducts();
                return;
            }
        }
    }
    public static void ViewProducts()
    {
        Console.Clear();
        Console.WriteLine("--- ПЕРЕГЛЯД ---");

        if (products.Count == 0)
        {
            Console.WriteLine("Список порожній.");
        }
        else
        {
            int i = 1;
            foreach (Product item in products)
            {
                Console.WriteLine("--------------------------------------------------------------------------");
                Console.WriteLine("{0,-5} {1,-35} {2,-15} {3,15:N2}", i, item.Name, item.Category, item.Price);
                Console.WriteLine("--------------------------------------------------------------------------");
                i++;
            }
        }
        Pause();
        ShowProducts();
    }

    static void ShowAnalytics()
    {
        Console.Clear();
        Console.WriteLine("======================= АНАЛІТИКА КАТАЛОГУ =======================");

        if (products.Count == 0)
        {
            Console.WriteLine("Список порожній.");
            Pause();
            return;
        }
        double totalSum = 0;
        double maxPrice = double.MinValue;
        double minPrice = double.MaxValue;
        string cheapProduct = "";
        string exspensiveProduct = "";

        foreach (Product item in products)
        {
            totalSum += item.Price;

            if (item.Price > maxPrice)
            {
                maxPrice = item.Price;
                exspensiveProduct = item.Name;
            }
            if (item.Price < minPrice)
            {
                minPrice = item.Price;
                cheapProduct = item.Name;
            }
        }


        double averagePrice = 0;
        if (products.Count > 0)
        {
            averagePrice = totalSum / products.Count;
        }

        Console.WriteLine($"Кількість товарів: {productCount}");
        Console.WriteLine($"---------------------------------");
        Console.WriteLine($"Загальна сума: {totalSum:N2}");
        Console.WriteLine($"Середня ціна: {averagePrice:N2}");

        if (products.Count > 0)
        {
            Console.WriteLine($"Найдорожчий товар: {exspensiveProduct} - {maxPrice:N2} грн");
            Console.WriteLine($"Найдешевший товар: {cheapProduct} - {minPrice:N2} грн");
        }
        Pause();
    }
    public static void Pause()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Нажміть будь-яку клавішу на клавіатурі...");
        Console.ReadKey();
        Console.ResetColor();
    }
    public static void SearchProduct()
    {
        Console.Clear();
        Console.WriteLine("----Пошук товару----");
        Console.WriteLine("-Введіть товар який хочете знайти-");
        string querty = Console.ReadLine();
        Console.WriteLine($"Шукаємо: {querty}...");

        bool exists = false;
        int foundIndex = -1;
        for (int i = 0; i < products.Count; i++)
        {
            if (products[i].Name.ToLower() == querty.ToLower())
            {
                foundIndex = i;
                exists = true;
                break;
            }
        }
        if (exists)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nЗнайдено товар!");
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine($"Назва: {products[foundIndex].Name}");
            Console.WriteLine($"Категорія: {products[foundIndex].Category}");
            Console.WriteLine($"Ціна: {products[foundIndex].Price:N2} грн");
            Console.WriteLine("---------------------------------------------------");
            Console.ResetColor();
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine($"Товар з назвою '{querty}' не знайдено.");
            Console.ResetColor();
        }
        Pause();
        ShowProducts();
    }
    public static void DeleteProduct()
    {
        Console.Clear();
        Console.WriteLine("=== Всі товари === ");
        for (int i = 0; i < products.Count; i++)
        {
            products[i].Print(i);
        }

        int choice = (int)Check("Оберіть індекс для видалення");
        if (choice >= products.Count)
        {
            Console.WriteLine("Такого індекса немає");
            Pause();
            ShowProducts();
        }
        else
        {
            Console.WriteLine("Товар видалено");
            products.RemoveAt(choice);
            Pause();
            ShowProducts();
        }
    }
    public static void SortProducts()
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("================ СОРТУВАННЯ ТОВАРУ ЗА ЦІНОЮ ===============");
        Console.ResetColor();

        if (products.Count == 0)
        {
            Console.WriteLine("Список товарів порожній. Нічого сортувати.");
            Pause();
            ShowProducts();
            return;
        }

        Console.WriteLine("Оберіть тип сортування:");
        Console.WriteLine("1. За зростанням ціни (від дешевих до дорогих)");
        Console.WriteLine("2. За спаданням ціни (від дорогих до дешевих)");
        Console.WriteLine("0. Назад");
        Console.Write("Введіть номер опції (0-2): ");

        double choice = Check();
        bool sorted = false;

        switch (choice)
        {
            case 1:
                products.Sort((p1, p2) => p1.Price.CompareTo(p2.Price));
                Console.WriteLine("\n Товари відсортовано за зростанням ціни.");
                sorted = true;
                break;
            case 2:
                products.Sort((p1, p2) => p2.Price.CompareTo(p1.Price));
                Console.WriteLine("\n Товари відсортовано за спаданням ціни.");
                sorted = true;
                break;
            case 0:
                ShowProducts();
                return;
            default:
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Некоректний вибір. Спробуйте ще раз.");
                Console.ResetColor();
                Pause();
                SortProducts();
                return;
        }

        if (sorted)
        {
            Console.WriteLine("--------------------------------------------------------------------------------------------------------");
            Console.WriteLine("{0,-5} {1,-35} {2,-15} {3,15}", "№", "Назва", "Категорія", "Ціна (грн)");
            Console.WriteLine("--------------------------------------------------------------------------------------------------------");
            for (int i = 0; i < products.Count; i++)
            {
                Console.WriteLine("{0,-5} {1,-35} {2,-15} {3,15:N2}", (i + 1), products[i].Name, products[i].Category, products[i].Price);
            }
            Console.WriteLine("---------------------------------------------------------------------------------------------------------");
        }

        Pause();
        ShowProducts();
    }
}


