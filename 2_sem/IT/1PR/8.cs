using System.Text.RegularExpressions;

{
    Regex myReg = new Regex(@"^[A-Za-zА-Яа-я]{1}[A-Za-z0-9А-Яа-я-]{4,11}$");
    Console.WriteLine(myReg.IsMatch("12alexfomin"));
    Console.WriteLine(myReg.IsMatch("al-fomlser56"));
    Console.WriteLine(myReg.IsMatch("-alexandors78"));
    Console.WriteLine(myReg.IsMatch("iamALser04"));
    Console.WriteLine(myReg.IsMatch("fom_ALser04"));
    Console.WriteLine(myReg.IsMatch("fomaALSERE91"));
    Console.ReadLine();
}