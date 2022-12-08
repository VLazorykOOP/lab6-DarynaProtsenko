using System;

namespace Lab6
{
    //1.9. Іграшка, продукт, товар, молочний продукт.
    //2.9  До побудованої ієрархії класів з завдання 1 додати
    //конструктори та деструктори
    class Tovar
    {
        protected string name;
        protected double price;
        public Tovar()
        {
            name = "none";
            price = 0;
            Console.WriteLine("Tovar contructor");
        }

        protected Tovar(string n, double p)
        {
            name = n;
            price = p;
            Console.WriteLine("Tovar contructor");
        }

        ~Tovar()
        {
            Console.WriteLine("Tovar destructor");
        }

        public void Show()
        {
            Console.WriteLine($"Name: {name}, price: {price}");
        }
    }

    class Toy : Tovar
    {
        private int minAge;

        public Toy()
        {
            minAge = 3;
            name = "Toy";
            price = 40;
            Console.WriteLine("Toy contructor");
        }

        public Toy(int age, string n, double p)
        {
            minAge = age;
            name = n;
            price = p;
            Console.WriteLine("Toy contructor");
        }

        ~Toy()
        {
            Console.WriteLine("Toy destructor");
        }

        public void Show()
        {
            Console.WriteLine($"Name: {name}, price: {price}, minAge: {minAge}");
        }
    }

    class Product : Tovar
    {
        private int creationYear;

        public Product()
        {
            creationYear = 2022;
            name = "Product";
            price = 12;
            Console.WriteLine("Product contructor");
        }

        public Product(int year, string n, double p)
        {
            creationYear = year;
            name = n;
            price = p;
            Console.WriteLine("Product contructor");
        }

        ~Product()
        {
            Console.WriteLine("Product destructor");
        }

        public void Show()
        {
            Console.WriteLine($"Name: {name}, price: {price}, creationYear: {creationYear}");
        }
    }

    class MolochniyProduct : Tovar
    {
        public string country;
        public MolochniyProduct()
        {
            country = "Ukraine";
            name = "MolochniyProduct";
            price = 25;
            Console.WriteLine("MolochniyProduct contructor");
        }

        public MolochniyProduct(string cntry, string n, double p)
        {
            country = cntry;
            name = n;
            price = p;
            Console.WriteLine("MolochniyProduct contructor");
        }

        ~MolochniyProduct()
        {
            Console.WriteLine("MolochniyProduct destructor");
        }

        public void Show()
        {
            Console.WriteLine($"Name: {name}, price: {price}, country: {country}");
        }
    }


    //3.9. Створити інтерфейс Клієнт із методами, що дозволяють
    //вивести на екран інформацію про клієнтів банку, а також визначити
    //відповідність клієнта критерію пошуку. Створити похідні класи:
    //Вкладник (прізвище, дата відкриття внеску, розмір внеску, відсоток по
    //внескові), Кредитор (прізвище, дата видачі кредиту, розмір кредиту,
    //відсоток по кредиту, остача боргу), Організація (назва, дата відкриття
    //рахунку, номер рахунку, сума на рахунку) зі своїми методами висновку
    //інформації на екран, і визначення відповідності даті (відкриття внеску,
    //видачі кредиту, відкриття рахунку). Створити базу (масив) з n клієнтів,
    //вивести повну інформацію з бази на екран, а також організувати пошук
    //клієнтів, що почали співробітничати з банком у задану дату.

    internal interface Client
    {
        void Show();
        void Search(DateTime date);
    }

    class Vkladnyk : Client
    {
        private string SecondName;
        private DateTime dateOpenVnesok;
        private double sizeOfVnesok;
        private double percent;

        public Vkladnyk()
        {
            SecondName = "";
            dateOpenVnesok = DateTime.Today;
            sizeOfVnesok = 0;
            percent = 0;
        }

        public Vkladnyk(string name, DateTime date, double vnesok, double per)
        {
            SecondName = name;
            dateOpenVnesok = date;
            sizeOfVnesok = vnesok;
            percent = per;
        }

        public void Show()
        {
            Console.WriteLine($"Second name: {SecondName}");
            Console.WriteLine($"Date of open vnesok: {dateOpenVnesok}");
            Console.WriteLine($"Size of vnesok: {sizeOfVnesok}");
            Console.WriteLine($"Percent: {percent}");
        }

        public void Search(DateTime date)
        {
            if (date == dateOpenVnesok)
            {
                Show();
            }
        }
    }

    class Creditor : Client
    {
        private string SecondName;
        private DateTime dateVidachiKredity;
        private double sizeOfKredit;
        private double percent;
        private double ostacha;

        public Creditor()
        {
            SecondName = "";
            dateVidachiKredity = DateTime.Today;
            sizeOfKredit = 0;
            percent = 0;
            ostacha = 0;
        }

        public Creditor(string name, DateTime date, double kredit, double per, double ost)
        {
            SecondName = name;
            dateVidachiKredity = date;
            sizeOfKredit = kredit;
            percent = per;
            ostacha = ost;
        }

        public void Show()
        {
            Console.WriteLine($"Second name: {SecondName}");
            Console.WriteLine($"Date of getting kredit: {dateVidachiKredity}");
            Console.WriteLine($"Size of kredit: {sizeOfKredit}");
            Console.WriteLine($"Percent: {percent}");
            Console.WriteLine($"Ostacha: {ostacha}");
        }

        public void Search(DateTime date)
        {
            if (date == dateVidachiKredity)
            {
                Show();
            }
        }
    }

    class Organization : Client
    {
        private string nazva;
        private DateTime dateVidkrittyaRahunku;
        private double nomerRahunku;
        private double sumOnRahunok;

        public Organization()
        {
            nazva = "";
            dateVidkrittyaRahunku = DateTime.Today;
            nomerRahunku = 0;
            sumOnRahunok = 0;
        }

        public Organization(string name, DateTime date, double nomer, double sum)
        {
            nazva = name;
            dateVidkrittyaRahunku = date;
            nomerRahunku = nomer;
            sumOnRahunok = sum;
        }

        public void Show()
        {
            Console.WriteLine($"Nazva: {nazva}");
            Console.WriteLine($"Date vidkrittya rahunku: {dateVidkrittyaRahunku}");
            Console.WriteLine($"Nomer rahunky: {nomerRahunku}");
            Console.WriteLine($"Sum: {sumOnRahunok}");
        }

        public void Search(DateTime date)
        {
            if (date == dateVidkrittyaRahunku)
            {
                Show();
            }
        }
    }



    static class Program
    {
        static void Main()
        {
            Tovar tovar = new Tovar();
            tovar.Show();
            Console.WriteLine();

            Toy toy = new Toy();
            toy.Show();
            Console.WriteLine();

            Product product = new Product();
            product.Show();
            Console.WriteLine();

            MolochniyProduct molochniyProduct = new MolochniyProduct();
            molochniyProduct.Show();
            Console.WriteLine();
           




            Client[] clients = new Client[3];
            clients[0] = new Vkladnyk("Vkladnyk", DateTime.Today, 1000, 0.3);
            clients[1] = new Creditor("Creditor", DateTime.Today.AddDays(-1), 2000, 15, 1000);
            clients[2] = new Organization("Organization", DateTime.Today, 123, 30000);
            Console.WriteLine("Printing all clients: ");
            for (int i = 0; i < 3; i++)
            {
                clients[i].Show(); ;
                Console.WriteLine();
            }
            Console.WriteLine($"Printing clients with date: {DateTime.Today}");
            for (int i = 0; i < 3; i++)
            {
                clients[i].Search(DateTime.Today); ;
            }
        }
    }
}
