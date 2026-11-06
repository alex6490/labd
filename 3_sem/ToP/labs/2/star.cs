using System;
class Star
{
    string name = "неопределено";
    string scientist = "неопределено"; //Кто открыл звезду 
    int age; //возраст в миллионах годах
    int rad; //радиус звезды в тысячах километрах
    int temperature; //Абсолютная температура звезды в кельвинах

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
            if (value<2000 || value>210000)
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
    public string Science
    {
        set
        {
            if (value!=null)
            {
                scientist = value;
            }
            else
            {
                Console.WriteLine("Введите ученого открывшего эту звезду");
            }
        }
        get {return scientist;}
    }
    public Star
    (
        string name = "NONE",
        string scientist = "NONE",
        int age =100,
        int rad = 100,
        int temperature = 100
    )
    {
        this.name= name;
        this.scientist = scientist;
        this.age = age;
        this.rad = rad;
        this.temperature = temperature;
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
public void ChangeScientist(string newScientist)
{

    scientist = newScientist;

}
    public void Print()
    {
        Console.WriteLine
        ($"Имя звезды: {name}\n" +
        $"Ученый открывший звезду: {scientist}\n" +
        $"Возраст звезды: {age}\n" +
        $"Радиус звезды: {rad}\n" +
        $"Температура звезды: {temperature}" + "\n");
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
        star5.ChangeScientist("Джон Гершель");
        star1.Print();
        star2.Print();
        star3.Print();
        star4.Print();
        star5.Print();
    }
}
