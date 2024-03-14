using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba1;

internal static class Program
{
    public static void Main(string[] args)
    {
        //1 задание
        var p1 = new vadim(5, 6);
        var p2 = new vadim(5, 6);
        var p3 = p1 - p2;
        var p4 = -p1;
        Console.WriteLine(p3.ToString());
        Console.WriteLine(p4.ToString());

        //2 задание
        var vr1 = new EuropeanDateTime();
        var vr2 = new AmericanDateTime();
        Console.WriteLine(vr1.PrintCurrentDateTime());
        Console.WriteLine(vr2.PrintCurrentDateTime());
        var vr3 = new Edecorator(vr1);
        var vr4 = new Adecorator(vr2);
        Console.WriteLine(vr3.PrintCurrentDateTime());
        Console.WriteLine(vr4.PrintCurrentDateTime());



        //3 задание
        var batya = new graf("Раис");
        var sonbatya = new graf("Арсен", batya);
        var sonsonbatya = new graf("Вадим", sonbatya);
        var dochasonbatya1 = new graf("Диана", sonbatya);
        var dochasonbatya2 = new graf("Риана", sonbatya);
        batya.PrintGraf();
    }
}
