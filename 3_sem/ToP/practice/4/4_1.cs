using System;
class Star
{
    string name = "неопределено";
    readonly string scientist = "неопределено"; //Кто открыл звезду 
    int age; //возраст в миллионах годах
    int rad; //радиус звезды в тысячах километрах
    int temperature; //Абсолютная температура звезды в кельвинах
    int distantion; //расстояние от Земли в световых годах
    static int maxDistant = 25;
    static int maxTemp = 210000;
    public const string type = "Звезда";
    public static int MaxTemp
    {
        get{return maxTemp;}
        set{if(value>=210000) maxTemp = value;}
    }

    static int count = 0;
    public static int CT => count;
    public string Name
    {
        set
        {
            if (value!=null)
            {
                name=value;
            }
            else
            {
                Console.WriteLine("Введите имя звезды");
            }
        }
        get {return name;}
    }
    public int Age
    {
        set
        {
            if (value<1 || value>13800)
            {
                Console.WriteLine("Звезды с таким возрастом не существует");
            }
            else
                age=value;
        }
        get{return age;}
    }
    public int Temp
    {
        set
        {
            if (value<2000 || value>MaxTemp)
            {
                Console.WriteLine("Температура находится за допустимым диапазоном");
            }
            else
                temperature=value;
        }
        get{return temperature;}
    }
    public int Radius
    {
        set
        {
            if (value<45 || value>1500000)
            {
                Console.WriteLine("Звезды с таким радиусом не существует");
            }
            else
                rad = value;
        }
        get{return rad;}
    }
    public int Distantion
    {
        get{return distantion;}
        set{distantion=value;}
    }
    public Star
    (
        string name = "NONE",
        string scientist = "NONE",
        int age =100,
        int rad = 100,
        int temperature = 100,
        int distantion = 0
    )
    {
        this.name= name;
        this.scientist = scientist;
        this.age = age;
        this.rad = rad;
        if (temperature<=MaxTemp)
        {
            this.temperature=temperature;
        }
        this.distantion = distantion;
        count++;
    }
    static Star()
    {
        if (DateTime.Now.Year == 2100)
        {
            maxDistant = 25;
        }
        else if (DateTime.Now.Year >=2050)
        {
            maxDistant = 12;
        }
        else
        {
            maxDistant = 5;
        }
        count = 0;
        maxTemp = 210000;
    }
    public static void CheckDistanceFromEarth(Star star)
    {
        if (star.Distantion <= maxDistant)
        {
            Console.WriteLine("До звезды теоретически возможно добраться человеку");
        }
        else
        {
            Console.WriteLine("До звезды невозможно добраться");
        }
    }
public void IncreaseAge(int years)
{
    age += years;
}
public void ChangeTemperature(int newTemperature)
{
    temperature = newTemperature;
}
public void ChangeRadius(int newRadius)
{
    rad = newRadius;
}
public void ChangeName(string newName)
{
    name = newName;
}
    public void Print()
    {
        Console.WriteLine
        ($"{type}\n" +
        $"Имя звезды: {name}\n" +
        $"Ученый открывший звезду: {scientist}\n" +
        $"Возраст звезды: {age}\n" +
        $"Радиус звезды: {rad}\n" +
        $"Температура звезды: {temperature}\n" +
        $"Расстояние от Земли: {distantion}" + "\n");
    }
}
public class Program
{
    public static void Main()
    {
        Star star1 = new Star("Солнце", "Галилей", 4600, 69, 5500);
        Star star2 = new Star("Сириус A", "Гиппарх", 242, 114, 9940);
        Star star3 = new Star("Бетельгейзе", "Гиппарх", 108, 700, 3500);
        Star star4 = new Star("Ригель", "Птолемей", 8, 74, 11000);
        Star star5 = new Star("Проксима Центавра", "Роберт Иннес", 4850, 154, 3000);
        Console.WriteLine("Исходные данные:");
        star1.Print();
        star2.Print();
        star3.Print();
        star4.Print();
        star5.Print();
        Console.WriteLine("Модифицированные данные:");
        star1.ChangeTemperature(6000);
        star2.ChangeRadius(1200);
        star3.IncreaseAge(5);
        star4.ChangeName("Ригель A");
        star1.Print();
        star3.Print();
        star4.Print();
        star5.Print();
        Console.WriteLine("Количество звезд: " + Star.CT);
        star2.Distantion=9;
        star2.Print();
        Star.CheckDistanceFromEarth(star2);
    }
}
