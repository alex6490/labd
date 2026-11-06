namespace test
{
    struct Star
    {
        public string Name{set;get;}
        public int Age{set;get;}
        public int Temp{set;get;}
        public int Radius{set;get;}
        public string Science{set;get;}
        public Star
        (
            string name = "NONE",
            string scientist = "NONE",
            int age =0,
            int rad =0,
            int temperature =0
        )
        {
            Name= name;
            Science = scientist;
            Age = age;
            Radius = rad;
            Temp = temperature;
        }
        public void UPDstr(string newN, string newS)
        {
            Name = newN;
            Science = newS;
        }
        public void UPDpar(int newA, int newR, int newT)
        {
            Age=newA;
            Radius=newR;
            Temp=newT;
        }
    }
    class Program
    {
        static void Print(Star star)
        {
            Console.WriteLine($"Название звезды: {star.Name}");
            Console.WriteLine($"Ученый открывший звезду: {star.Science}");
            Console.WriteLine($"Возраст звезды: {star.Age}");
            Console.WriteLine($"Радиус звезды: {star.Radius}");
            Console.WriteLine($"Температура повехности звезды: {star.Temp}");
        }
        static void Main(string[] args)
        {
            Star star1 = new Star("Солнце", "Галилей", 4600, 69, 5500);
            Star star2 = new Star("Сириус A", "Гиппарх", 242, 114, 9940);
            Star star3 = new Star("Бетельгейзе", "Гиппарх", 108, 700, 3500);
            Star star4 = new Star("Ригель", "Птолемей", 8, 74, 11000);
            Star star5 = new Star("Проксима Центавра", "Роберт Иннес", 4850, 154, 3000);
            Console.WriteLine("Исходные данные:");
            Print(star1);
            Print(star2);
            Print(star3);
            Print(star4);
            Print(star5);
            Console.WriteLine("Модифицированные данные:");
            star1.UPDstr("Стивенсон 218", "Неизвестен");
            star1.UPDpar(4758, 15000, 100000);
            Print(star1);
            Star star0 = star3 with {Name = "Beta"};
            Print(star0);
        }
    }
}