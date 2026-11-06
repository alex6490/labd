using System;
class Market<T>
{
    public T id;
    public T ID {get;set;}
    protected string name = ""; //наименование магазина
    protected int personal; //количество сотрудников
    protected double rate; //средняя оценка клиентов по 10 бальной шкале 
    protected int order; //количество продаж за год
    protected string bossName = ""; //имя управляющего
    public static int count;
    public static int minQUA = 1;
    public static double maxRate = 10.0;
    public static double minRate = 0.0;
    public string Name
    {
        set{name=value;}
        get{return name;}
    }
    public int Personal
    {
        set
        {
            if (personal>=minQUA)
                personal=value;
        }
        get{return personal;}
    }
    public double Rate
    {
        set
        {
            if (rate<=maxRate && rate>=minRate)
                rate=value;
        }
        get{return rate;}
    }
    public int Order
    {
        set{order=value;}
        get{return order;}
    }
    public string BossName
    {
        set{bossName=value;}
        get{return bossName;}
    }
    public static int Count
    {
        get{return count;}
    }
    public Market(T id, string name)
    {
        ID = id;
        this.name = name;
        ++count;
    }
    public Market(T id, string name, int personal):this(id, name)
    {
        if (personal >= minQUA)
            this.personal = personal;
    }
    public Market(T id, string name, int personal, double rate, int order, string bossName):this(id, name, personal)
    {
        if (rate<=maxRate && rate>=minRate)
            this.rate=rate;
        this.order = order;
        this.bossName = bossName;
    }
    public virtual void Print()
    {
        Console.WriteLine($"ID: {id}");
        Console.WriteLine($"Название магазина: {name}");
        Console.WriteLine($"Количество сотрудников: {personal}");
    }
    public void Printf()
    {
        Print();
        Console.WriteLine($"Средняя оценка: {rate}");
        Console.WriteLine($"Количество продаж в год: {order}");
        Console.WriteLine($"Имя управляющего: {bossName}\n");
    }
    public void personalInc()
    {
        personal++;
    }
}
class MarketPlace<T, K> : Market<T>
{
    public static K? minFlow; //Минимальный ежедневный клиентопоток маркетплейсов
    private string web = ""; //Название площадки в интернете
    private int oppCount; //Количество собственных ПВЗ
    private string delivery = ""; //Способы доставки
    private double monetaryTurnover; //Денежный оборот площадки за месяц в миллиардах рублей
    private int accountCount; //Количество зарегестрированых пользователей
    public static int minOppCount = 0;
    public static int countnON = 0;
    public static int minAccountCount = 0;
    public static int maxAccountCount = 100000000; //Количество аккаунтов ограничено сетевыми ресурсами рунета и самих платформ,
                                                   //неактивные более 6 месяцев аккаунты автоматически удаляются
    public string Web
    {
        set{web=value;}
        get{return web;}
    }
    public int OppCount
    {
        set
        {
            if (oppCount >= minOppCount)
                oppCount = value;
        }
        get{return oppCount;}
    }
    public string Delivery
    {
        set{delivery=value;}
        get{return delivery;}
    }
    public double MonetaryTurnover
    {
        set{monetaryTurnover=value;}
        get{return monetaryTurnover;}
    }
    public int AccountCount
    {
        set
        {
            if (minAccountCount<accountCount && accountCount<maxAccountCount)
                accountCount = value;
        }
        get {return accountCount;}
    }
    public MarketPlace(T id, string name, int personal, string web, int oppCount, string delivery, double monetaryTurnover, int accountCount)
            :base(id, name, personal)
    {
        this.web=web;
        if (oppCount>minOppCount)
            this.oppCount=oppCount;
        this.delivery=delivery;
        this.monetaryTurnover=monetaryTurnover;
        if (accountCount>minAccountCount && accountCount<maxAccountCount)
            this.accountCount=accountCount;
        ++countnON;
    }
    public override void Print()
    {
        base.Print();
        Console.WriteLine($"Название площадки в интернете: {web}");
        Console.WriteLine($"Количество собственных ПВЗ: {oppCount}");
        Console.WriteLine($"Способы доставки реализованные на площадке: {delivery}");
        Console.WriteLine($"Денежный оборот в месяц: {monetaryTurnover}");
        Console.WriteLine($"Каличество зарегестрированых пользователей: {accountCount}\n");
    }
    public static int CountON
    {
        get{return countnON;}
    }
    public void OppInk()
    {
        oppCount++;
    }
}
class OffLineMarket<T, L>: Market<T>
{
    public static L? minPers;
    private string type = ""; //Тип точек по размерам
    private string llc = ""; //Название компании
    private int points; //Количество открытых точек
    private int assortiment; //Количество товара в ассортименте 
    private double tax; //Уплаченные компанией налоги (в милллионах рублей)
    public static int minPoints = 1; //Даже не сеть
    public static int minAssortiment = 100; //Меньше сотни - ларек
    public static double minTax = 1.0; //Кто-то явно уклоняется от налогов
    public static int countOFF;
    public string Type
    {
        set{type=value;}
        get{return type;}
    }
    public string LLC
    {
        set{llc=value;}
        get{return llc;}
    }
    public int Points
    {
        set
        {
            if (points>minPoints)
                points=value;
        }
        get{return points;}
    }
    public int Assortiment
    {
        set
        {
            if (assortiment>minAssortiment)
                assortiment=value;
        }
        get{return assortiment;}
    }
    public double Tax
    {
        set
        {
            if (tax>minTax)
                tax=value;
        }
        get{return tax;}
    }
    public OffLineMarket(T id, string name, int personal, string type, string llc, int points, int assortiment, double tax)
            :base(id, name, personal)
    {
        this.type=type;
        this.llc=llc;
        if (points>minPoints)
            this.points=points;
        if (assortiment>minAssortiment)
            this.assortiment=assortiment;
        if (tax>minTax)
            this.tax=tax;
        ++countOFF;
    }
    public static int CountOFF
    {
        get{return countOFF;}
    }
    public override void Print()
    {
        base.Print();
        Console.WriteLine($"Тип точки по размеру: {type}");
        Console.WriteLine($"Официальное название компании: {llc}");
        Console.WriteLine($"Количество магазинов компании: {points}");
        Console.WriteLine($"Количество товаров в ассортименте: {assortiment}");
        Console.WriteLine($"Уплаченный налог: {tax}млн рублей\n");
    }
    public void AssortimentInk()
    {
        assortiment++;
    }
}
class Program
{
    public static void Main()
    {
        Market<int> m1 = new Market<int>(1, "Ozon", 53000, 9.78, 311000000, "Ольга Юрьевна Окмянская");
        Market<string> m2 = new Market<string>("2", "Красное & Белое", 155000, 7.67, 287000000, "Сергей Петрович Студенников");
        Market<long> m3 = new Market<long>(3, "Яндекс Маркет", 27000, 8.95, 18000000, "Алексей Валерьевич Шлюнкин");
        m1.Printf();
        m2.Printf();
        m3.Printf();
        m1.personalInc();
        m3.personalInc();
        Console.WriteLine($"Название магазина: {m1.Name}, численность штата: {m1.Personal}");
        Console.WriteLine($"Название магазина: {m3.Name}, численность штата: {m3.Personal}");
        
        MarketPlace<int, int> o1 = new MarketPlace<int, int>(4, "WB", 100000, "Wildberries.ru", 94000, "Курьером, ПВЗ, Почта России", 508.3, 56476570);
        MarketPlace<string, string> o2 = new MarketPlace<string, string>("5", "Яндекс Маркет", 12000, "MarketYandex.ru", 15000, "По клику, ПВЗ, Самовывоз в магазин", 100.7, 20000000);
        MarketPlace<uint, double> o3 = new MarketPlace<uint, double>(6,"СберМегамаркет", 3000, "Market.Sber.ru", 1000, "Самовывоз, курьер", 2.067, 6800000);
        MarketPlace<int, int>.minFlow = 1000000;
        MarketPlace<string, string>.minFlow = "990657";
        MarketPlace<uint, double>.minFlow = 765459.79;
        o1.Print();
        o2.Print();
        o3.Print();
        o1.OppInk();
        o2.OppInk();
        Console.WriteLine($"Название площадки: {o1.Name}, количество ПВЗ: {o1.OppCount}");
        Console.WriteLine($"Название площадки: {o2.Name}, количество ПВЗ: {o2.OppCount}");

        OffLineMarket<byte, sbyte> s1 = new OffLineMarket<byte, sbyte>(7, "Пятерочка", 260000, "Супермаркет", "X5 retail", 26000, 5000, 788.765);
        OffLineMarket<ulong, float> s2 = new OffLineMarket<ulong, float>(8, "Магнит", 368000, "Супермаркет", "ПАО Магнит", 33440, 20000, 896.665);
        OffLineMarket<short, decimal> s3 = new OffLineMarket<short, decimal>(9, "Глобус", 46500, "Гипермаркет", "Globus DE Reatail", 152, 65000, 487.978);
        OffLineMarket<byte, sbyte>.minPers = 100;
        OffLineMarket<ulong, float>.minPers = 185.0f;
        OffLineMarket<short, decimal>.minPers = 564;
        s1.Print();
        s2.Print();
        s3.Print();
        s2.AssortimentInk();
        s3.AssortimentInk();
        Console.WriteLine($"Название магазина: {s2.Name}, количество товаров в ассортименте: {s2.Assortiment}");
        Console.WriteLine($"Название магазина: {s3.Name}, количество товаров в ассортименте: {s3.Assortiment}");

        Console.WriteLine($"Количество магазинов {Market<int>.Count+Market<string>.Count+Market<long>.Count}");
        Console.WriteLine($"Количество интернет магазинов {MarketPlace<int, int>.countnON+MarketPlace<string, string>.CountON+MarketPlace<uint,double>.CountON}");
        Console.WriteLine($"Количество стационарных магазинов {OffLineMarket<byte,sbyte>.CountOFF+OffLineMarket<ulong,float>.CountOFF+OffLineMarket<short,decimal>.CountOFF}");
        Console.WriteLine($"Минимальный клиентопоток за день 1: {MarketPlace<int,int>.minFlow}");
        Console.WriteLine($"Минимальный клиентопоток за день 2: {MarketPlace<string, string>.minFlow}");
        Console.WriteLine($"Минимальный клиентопоток за день 3: {MarketPlace<uint,double>.minFlow}");
        Console.WriteLine($"Минимальный персонал 1: {OffLineMarket<byte,sbyte>.minPers}");
        Console.WriteLine($"Минимальный персонал 2: {OffLineMarket<ulong,float>.minPers}");
        Console.WriteLine($"Минимальный персонал 3: {OffLineMarket<short,decimal>.minPers}");
    }
}