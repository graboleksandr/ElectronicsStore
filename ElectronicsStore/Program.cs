using ElectronicsStore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



public class Program
{
    static List<Product> products = new List<Product>();

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
            Console.WriteLine("|    МАГАЗИН ЕЛЕКТРОТЕХНІКИ | ГОЛОВНЕ МЕНЮ      |");
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
                    ShowAnalytics();
                    break;
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
        Console.WriteLine("       Дякуємо за покупку!");
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
    public static void ServiceAndWarrantyMenu()
    {

        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("==========================================================");
        Console.WriteLine("|   УПРАВЛІННЯ ГАРАНТІЄЮ та СЕРВІСНИМ ОБСЛУГОВУВАННЯМ   |");
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
        Console.WriteLine("|                       ПОСТАЧАННЯ                       |");
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
        Console.WriteLine("|                    КАТАЛОГ ТОВАРУ                      |");
        Console.WriteLine("==========================================================");

        Console.WriteLine("1.Додати товар");
        Console.WriteLine("2.Переглянути товар");
        Console.WriteLine("3.Якість товару");
        Console.WriteLine("4.Утворення товару");
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
                AddProduct();
                break;
            case 2:
                ViewProducts();
                break;
            case 3:
                Console.WriteLine("Ця функція тимчасово не доступна!");
                Console.WriteLine("Натисніть будь-яку клавішу щоб продовжити...");
                Console.ReadKey();
                ShowProducts();
                break;
            case 4:
                Console.WriteLine("Ця функція тимчасово не доступна!");
                Console.WriteLine("Натисніть будь-яку клавішу щоб продовжити...");
                Console.ReadKey();
                ShowProducts();
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
        int MAX_PRODUCTS = 5;
        while (true)
        {
            Console.Clear();
            Console.WriteLine("--- ДОДАВАННЯ ТОВАРУ ---");

            if (products.Count >= MAX_PRODUCTS)
            {
                Console.WriteLine($"Ліміт товарів досягнуто ({MAX_PRODUCTS})");
                Console.WriteLine("Натисніть Enter, щоб повернутися назад...");
                Console.ReadLine();
                ShowProducts();
            }

            Console.WriteLine($"Товар {products.Count + 1} з {MAX_PRODUCTS}");

            Console.Write("Назва: ");
            string name = Console.ReadLine();

            Console.Write("Категорія: ");
            string category = Console.ReadLine();

            Console.Write("Ціна: ");

            if (double.TryParse(Console.ReadLine(), out double price))
            {
                Product newProduct = new Product(name, category, price);
                products.Add(newProduct);

                Console.WriteLine("\nТовар успішно додано!");

                if (products.Count < MAX_PRODUCTS)
                {
                    Console.WriteLine("Чи бажаєте додати наступний товар? (Так-1, Ні-0): ");
                    if (Check() == 1)
                    {
                        AddProduct();
                    }
                    else
                    {
                        ShowProducts();
                    }
                }
                else
                {
                    Console.WriteLine("Досягнуто максимальної кількості товарів. Натисніть Enter...");
                    Console.ReadLine();
                    ShowProducts();
                }
            }
            else
            {
                Console.WriteLine("Некоректна ціна. Введення скасовано. Натисніть Enter...");
                Console.ReadLine();
                AddProduct();
            }
        }
    }

    public static void ViewProducts()
    {
        Console.Clear();
        Console.WriteLine("--- ПЕРЕГЛЯД ---");

        if (products.Count == 0)
        {
            Console.WriteLine("Список порожній");
        }
        else
        {
            int i = 1;
            foreach (Product item in products)
            {
                Console.WriteLine($"{i}. {item.Name} ({item.Category}) - {item.Price} грн");
                i++;
            }
        }
        Console.WriteLine("Натисніть будь-яку клавішу щоб продовжити...");
        Console.ReadKey();
        ShowProducts();

    }

    static void ShowAnalytics()
    {
        Console.Clear();
        Console.WriteLine("--- АНАЛІТИКА ІНВЕНТАРЮ ---");

        int totalCount = products.Count;
        Console.WriteLine($"Загальна кількість товарів: {totalCount}");

        if (totalCount == 0)
        {
            Console.WriteLine("Інвентар порожній. Немає даних для аналізу");
        }
        else
        {
            double totalPriceSum = products.Sum(p => p.Price);
            Console.WriteLine($"Сумарна вартість усіх товарів: {totalPriceSum:N2} грн");
            Console.WriteLine("------------------------------------------");

            Product maxPriceProduct = products.OrderByDescending(p => p.Price).FirstOrDefault();

            Product minPriceProduct = products.OrderBy(p => p.Price).FirstOrDefault();

            Console.WriteLine("Найдорожчий товар:");
            Console.WriteLine($"Назва: {maxPriceProduct.Name} | Ціна: {maxPriceProduct.Price:N2} грн");

            Console.WriteLine("\n Найдешевший товар:");
            Console.WriteLine($"Назва: {minPriceProduct.Name} | Ціна: {minPriceProduct.Price:N2} грн");
        }

        Console.WriteLine("\nНатисніть Enter, щоб повернутися в меню...");
        Console.ReadLine();
    }
}


