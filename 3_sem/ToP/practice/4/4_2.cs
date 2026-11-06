namespace mathem
{
    static class VolumeCalc
    {
        public static double FindBallVolume(double r)
        {
            return 4/3*Math.PI*Math.Pow(r,3);
        }
        public static double FindCylinderVolume(double h, double r)
        {
            return Math.PI*r*r*h;
        }
        public static double FindVolumeP(double a, double b, double c)
        {
            return a*b*c;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            double BallV = VolumeCalc.FindBallVolume(5.64);
            double CylinderV = VolumeCalc.FindCylinderVolume(4.89, 3.23);
            double ParV = VolumeCalc.FindVolumeP(4.89, 3.17, 6.96);
            Console.WriteLine($"Объем Шара" + BallV);
            Console.WriteLine($"Объем Цилиндра" + CylinderV);
            Console.WriteLine($"Объем Параллелепипеда" + ParV);
        }
    }
}