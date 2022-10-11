using System;

namespace ConsoleApp2
{
    class Program
    {
        public enum Drink
        {
            WithMilk = 1,
            Cappuccino = 2,
            Latte = 3,
            Moccachino = 4, 
            Espresso = 5
        }

        public class CoffeMachine
        {
            private string model;
            private uint coffe, milk, water, sugar, wallet;
            private uint maxCoffe, maxMilk, maxWater, maxSugar; // setter getter
            
            public CoffeMachine(string model) => this.model = model; // конструктор з початковим встановленням імені кофейного автомата

            public uint Coffe // геттер та сеттер з перевіркою вхідних даних
            {
                get => this.coffe;
                set
                {
                    if ((this.coffe + value) <= this.maxCoffe && value != 0) 
                    { // перевірка щоб вхідна кількість сировини була менша за максимальну та не дорівнювала нулю
                        this.coffe += value;
                        Console.WriteLine("Успішно!");
                    }                 
                    else
                    {
                        Console.WriteLine("Ведена кількість кави перевищую максимальну або введені некоректні дані");
                    }
                        
                }
            }
            public uint Milk // геттер та сеттер з перевіркою вхідних даних
            {
                get => this.milk;
                set
                {
                    if ((this.milk + value) <= this.maxMilk && value != 0)
                    {// перевірка щоб вхідна кількість сировини була менша за максимальну та не дорівнювала нулю
                        this.milk += value;
                        Console.WriteLine("Успішно!");
                    }
                    else
                        Console.WriteLine("Ведена кількість молока перевищую максимальну або введені некоректні дані");
                }
            }
            public uint Water // геттер та сеттер з перевіркою вхідних даних
            {
                get => this.water;
                set
                {
                    if ((this.water + value) <= this.maxWater && value != 0)
                    {// перевірка щоб вхідна кількість сировини була менша за максимальну та не дорівнювала нулю
                        this.water += value;
                        Console.WriteLine("Успішно!");
                    }
                    else
                        Console.WriteLine("Ведена кількість води перевищую максимальну або введені некоректні дані");
                }
            }      
            public uint Sugar // геттер та сеттер з перевіркою вхідних даних
            {
                get => this.sugar;
                set
                {
                    if ((this.sugar + value) <= this.maxSugar && value != 0)
                    {// перевірка щоб вхідна кількість сировини була менша за максимальну та не дорівнювала нулю
                        this.sugar += value;
                        Console.WriteLine("Успішно!");
                    }
                    else
                        Console.WriteLine("Ведена кількість цукру перевищую максимальну або введені некоректні дані");
                }
            } 
            public uint Wallet // геттер та сеттер з перевіркою вхідних даних
            {
                get => this.wallet;
                set 
                {
                    if (value != 0)
                    { //перевірка на 0 бо інші перевірки могли не пропустити некоректні дані і тому писати "Успішно!" безглуздо
                        this.wallet += value;
                        Console.WriteLine("Успішно!");
                    }
                }
            }

            public uint MaxCoffe // геттер та сеттер з перевіркою вхідних даних
            {
                get => this.maxCoffe;
                set
                {
                    if (value >= this.coffe && value != 0)
                    {// перевірка щоб нова макс кількість сировини не перевищувала поточну та не дорівнювала 0
                        this.maxCoffe = value;
                        Console.WriteLine("Успішно!");
                    }
                    else
                        Console.WriteLine("Ведена максимальна кількість кави менша за поточну кількість кави або введені некоректні дані");
                }
            }
            public uint MaxMilk // геттер та сеттер з перевіркою вхідних даних
            {
                get => this.maxMilk;
                set
                {// перевірка щоб нова макс кількість сировини не перевищувала поточну та не дорівнювала 0
                    if (value >= this.milk && value != 0)
                    {
                        this.maxMilk = value;
                        Console.WriteLine("Успішно!");
                    }
                    else
                        Console.WriteLine("Ведена максимально кількість молока менша за поточну кількість молока або введені некоректні дані");
                }
            }
            public uint MaxWater // геттер та сеттер з перевіркою вхідних даних
            {
                get => this.maxWater;
                set
                {// перевірка щоб нова макс кількість сировини не перевищувала поточну та не дорівнювала 0
                    if (value >= this.water && value != 0)
                    {
                        this.maxWater = value;
                        Console.WriteLine("Успішно!");
                    }
                    else
                        Console.WriteLine("Ведена максимально кількість води менша за поточну кількість води або введені некоректні дані");
                }
            }
            public uint MaxSugar // геттер та сеттер з перевіркою вхідних даних
            {
                get => this.maxSugar;
                set
                {// перевірка щоб нова макс кількість сировини не перевищувала поточну та не дорівнювала 0
                    if (value >= this.sugar && value != 0)
                    {
                        this.maxSugar = value;
                        Console.WriteLine("Успішно!");
                    }
                    else
                        Console.WriteLine("Ведена максимально кількість сахару менша за поточну кількість сахару або введені некоректні дані");
                }
            }

            public void ToDoWithMilk() // метод приготування кави з молоком
            {
                if (this.coffe < 5 || this.milk < 5)
                    Console.WriteLine("Замало кофе або молока для приготування напою, потрібно мінімум 5");
                else
                {
                    this.coffe -= 5;
                    this.milk -= 5;
                    this.wallet += 5;
                    Console.WriteLine("Кофе з молоком приготовано");
                }
            }
            public void ToDoCappuccino() // метод приготування Капучіно
            {
                if (this.coffe < 5 || this.water < 5)
                    Console.WriteLine("Замало кофе або води для приготування напою, потрібно мінімум 5");
                else
                {
                    this.coffe -= 5;
                    this.water -= 5;
                    this.wallet += 10;
                    Console.WriteLine("Капуччіно приготовано");
                }
            }
            public void ToDoLatte() // метод приготування Латте
            {
                if (this.coffe < 5 || this.milk < 5 || this.sugar < 5)
                    Console.WriteLine("Замало кофе, молока або цукру для приготування напою, потрібно мінімум 5");
                else
                {
                    this.coffe -= 5;
                    this.milk -= 5;
                    this.sugar -= 5;
                    this.wallet += 15;
                    Console.WriteLine("Латте приготовано");
                }
            }
            public void ToDoMoccachino() // метод приготування Моккачіно
            {
                if (this.coffe < 5 || this.milk < 5 || this.water < 5)
                    Console.WriteLine("Замало кофе, молока або води для приготування напою, потрібно мінімум 5");
                else
                {
                    this.coffe -= 5;
                    this.milk -= 5;
                    this.water -= 5;
                    this.wallet += 20;
                    Console.WriteLine("Моккачіно приготовано");
                }
            }
            public void ToDoEspresso() // метод приготування Еспрессо
            {
                if (this.coffe < 5 || this.water < 5 || this.sugar < 5)
                    Console.WriteLine("Замало кофе, води або цукру для приготування напою, потрібно мінімум 5");
                else
                {
                    this.coffe -= 5;
                    this.water -= 5;
                    this.sugar -= 5;
                    this.wallet += 25;
                    Console.WriteLine("Моккачіно приготовано");
                }
            }

            public void ToDoFewDrinks(uint totalPrice, Drink[] drink) // метод приготування декількох напоїв
            {
                for (int i = 0; i < drink.Length; i++)
                {
                    switch (drink[i])
                    {
                        case Drink.WithMilk:
                            this.ToDoWithMilk();
                            break;
                        case Drink.Cappuccino:
                            this.ToDoCappuccino();
                            break;
                        case Drink.Latte:
                            this.ToDoLatte();
                            break;
                        case Drink.Moccachino:
                            this.ToDoMoccachino();
                            break;
                        case Drink.Espresso:
                            this.ToDoEspresso();
                            break;
                        default:
                            break;
                    }
                }               
            }

            public uint CheckInput() // метод для перевірки що введено додатне число
            {
                uint input = 0;
                try
                {
                    input = uint.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Введені некоректні дані");
                }
                return input;
            }
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode; // для коректного відображення 'і'
            bool exit = true;
            string model;

            Console.WriteLine("Введіть модель автомата");
            model = Console.ReadLine().Trim(); // прибирання зайвих пробілів зі строки
            
            while (model.Length == 0) // перевірка на порожню строку
            {
               Console.WriteLine("Введена пуста строка, спробуйте ще раз");
               model = Console.ReadLine().Trim();
            }
            
            CoffeMachine coffeMachine = new CoffeMachine(model);
            Console.WriteLine("Кавовий автомат " + model +  " успішно створено!");            
            
            while (exit)
            {
                Console.WriteLine();
                Console.WriteLine("Введіть номер наступної дії з автоматом серед перерахованих");
                Console.WriteLine("1. Ввести максимальну кількість кави, молока води та цукру в автоматі");
                Console.WriteLine("2. Поповнити касу");
                Console.WriteLine("3. Поповнити запас кави / молока / води / цукру");
                Console.WriteLine("4. Приготувати один напій");
                Console.WriteLine("5. Приготувати декілька напоїв");
                Console.WriteLine("6. Отримати поточну кількість грошей у автоматі");
                Console.WriteLine("7. Отримати поточний запас кави / молока / води / цукру");
                Console.WriteLine("8. Отримати поточний максимальний запас кави / молока / води / цукру");
                Console.WriteLine("9. Закрити програму");

                int.TryParse(Console.ReadLine(), out int todo); // TryParse бо у switch є default
               
                switch (todo)
                {
                    case 1: // 1. Ввести максимальну кількість кави, молока води та цукру в автоматі
                        Console.WriteLine("Введіть максимальну кількість кави");
                        uint input = coffeMachine.CheckInput(); // перевірка на додатне число
                        coffeMachine.MaxCoffe = input; // виклик setter
                        
                        Console.WriteLine("Введіть максимальну кількість молока");
                        input = coffeMachine.CheckInput(); // перевірка на додатне число
                        coffeMachine.MaxMilk = input; // виклик setter

                        Console.WriteLine("Введіть максимальну кількість води");
                        input = coffeMachine.CheckInput(); // перевірка на додатне число
                        coffeMachine.MaxWater = input; // виклик setter 

                        Console.WriteLine("Введіть максимальну кількість цукру");
                        input = coffeMachine.CheckInput(); // перевірка на додатне число
                        coffeMachine.MaxSugar = input; // виклик setter

                        break;
                    case 2: // 2. Поповнити касу
                        Console.WriteLine("Введіть кількість грошей для поповнення касси автомата");
                        input = coffeMachine.CheckInput(); // перевірка на додатне число
                        coffeMachine.Wallet = input; // виклик setter                       
                        break;
                    case 3: // 3. Поповнити запас кави / молока / води / цукру
                        Console.WriteLine("Введіть номер продукту який хочете поповнити");
                        Console.WriteLine("1. Кава");
                        Console.WriteLine("2. Молоко");
                        Console.WriteLine("3. Вода");
                        Console.WriteLine("4. Цукор");

                        int.TryParse(Console.ReadLine(), out int tofill); // TryParse бо у switch є default

                        switch (tofill)
                        {
                            case 1:
                                Console.WriteLine("Введіть кількість кави");
                                input = coffeMachine.CheckInput(); // перевірка на додатне число
                                coffeMachine.Coffe = input; // виклик setter
                                break;
                            case 2:
                                Console.WriteLine("Введіть кількість молока");
                                input = coffeMachine.CheckInput(); // перевірка на додатне число
                                coffeMachine.Milk = input; // виклик setter
                                break;
                            case 3:
                                Console.WriteLine("Введіть кількість води");
                                input = coffeMachine.CheckInput(); // перевірка на додатне число
                                coffeMachine.Water = input; // виклик setter
                                break;
                            case 4:
                                Console.WriteLine("Введіть кількість цукра");
                                input = coffeMachine.CheckInput(); // перевірка на додатне число
                                coffeMachine.Sugar = input; // виклик setter
                                break;
                            default:
                                Console.WriteLine("Введені некоректні дані");
                                break;
                        }
                        break;
                    case 4: // 4. Приготувати один напій
                        Console.WriteLine();
                        Console.WriteLine("Введіть номер напою");
                        Console.WriteLine("1. Кофе з молоком");
                        Console.WriteLine("2. Каппучіно");
                        Console.WriteLine("3. Латте");
                        Console.WriteLine("4. Мокачіно");
                        Console.WriteLine("5. Еспрессо");

                        int.TryParse(Console.ReadLine(), out int todoDrink); // TryParse бо у switch є default

                        switch (todoDrink)
                        {
                            case 1:
                                coffeMachine.ToDoWithMilk(); // виклик методу приготування напою
                                break;
                            case 2:
                                coffeMachine.ToDoCappuccino(); // виклик методу приготування напою
                                break;
                            case 3:
                                coffeMachine.ToDoLatte(); // виклик методу приготування напою
                                break;
                            case 4:
                                coffeMachine.ToDoMoccachino(); // виклик методу приготування напою
                                break;
                            case 5:
                                coffeMachine.ToDoEspresso(); // виклик методу приготування напою
                                break;
                            default:
                                Console.WriteLine("Введені некоректні дані");
                                break;
                        }
                        break;
                    case 5: // 5. Приготувати декілька напоїв
                        Console.WriteLine();
                        Console.WriteLine("Введіть номера напоїв які хочете приготувати через кому");
                        Console.WriteLine("1. Кофе з молоком");
                        Console.WriteLine("2. Каппучіно");
                        Console.WriteLine("3. Латте");
                        Console.WriteLine("4. Мокачіно");
                        Console.WriteLine("5. Еспрессо");

                        uint totalPrice = 0;
                        uint badTries = 0;

                        string[] stroka = Console.ReadLine().Split(','); // прибирання зайвих пробілів зі строки
                        Drink[] myDrinks = new Drink[stroka.Length]; // enum з номерами напоїв

                        for (int i = 0; i < stroka.Length; i++)
                        {
                            try
                            {// перевірка кожного введеного через кому елемента 
                                input = uint.Parse((stroka[i]));
                                if (input <= 5)
                                {
                                    myDrinks[i] = (Drink)input;
                                }
                            }
                            catch (Exception)
                            {// щоб при декількох некоректних значеннях повідомлення про це вивелось лише 1 раз
                                badTries++;
                            }
                        }
                        if (badTries > 0) // чи були некоректні дані?
                            Console.WriteLine("Частина або всі дані які були введені були проігноровани через некоректність");

                        for (int i = 0; i < myDrinks.Length; i++)
                        {// для підрахунку ціни всіх напоїв згідно завдання
                            switch (myDrinks[i])
                            {
                                case Drink.WithMilk:
                                    totalPrice += 5;
                                    break;
                                case Drink.Cappuccino:
                                    totalPrice += 10;
                                    break;
                                case Drink.Latte:
                                    totalPrice += 15;
                                    break;
                                case Drink.Moccachino:
                                    totalPrice += 20;
                                    break;
                                case Drink.Espresso:
                                    totalPrice += 25;
                                    break;
                                default:
                                    break;
                            }
                        }

                        coffeMachine.ToDoFewDrinks(totalPrice, myDrinks); // метод для приготування декількох напоїв
                        break;
                    case 6: // 6. Отримати поточну кількість грошей у автоматі
                        Console.WriteLine("Поточна кількість грошей у касі = " + coffeMachine.Wallet);                        
                        break;
                    case 7: // 7. Отримати поточний запас кави / молока / води / цукру
                        Console.WriteLine("Поточний запас кави = " + coffeMachine.Coffe);
                        Console.WriteLine("Поточний запас молока = " + coffeMachine.Milk);
                        Console.WriteLine("Поточний запас води = " + coffeMachine.Water);
                        Console.WriteLine("Поточний запас цукру = " + coffeMachine.Sugar);
                        break;
                    case 8: // 8. Отримати поточний максимальний запас кави / молока / води / цукру
                        Console.WriteLine("Поточний максимальний запас кави = " + coffeMachine.MaxCoffe);
                        Console.WriteLine("Поточний максимальний запас молока = " + coffeMachine.MaxMilk);
                        Console.WriteLine("Поточний максимальний запас води = " + coffeMachine.MaxWater);
                        Console.WriteLine("Поточний максимальний запас цукру = " + coffeMachine.MaxSugar);
                        break;
                    case 9: // 9. Закрити програму
                        exit = false;
                        break;
                    default:
                        Console.WriteLine("Введені некоректні дані");
                        break;
                }
            }           
        }
    }
}
