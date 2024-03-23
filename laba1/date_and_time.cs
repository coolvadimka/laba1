using System.Globalization;
using System.Net.Mail;
using System.Runtime.InteropServices;
using System.Text;

namespace laba1;

public abstract class Time
{
    public abstract string PrintCurrentDateTime();
}

public class EuropeanDateTime : Time
{
    CultureInfo myCIintl = new CultureInfo("es-ES", false);
    public override string PrintCurrentDateTime()
    {
        return DateTime.Now.ToString(myCIintl);
    }
}

public class AmericanDateTime : Time
{
    CultureInfo myCIintl = new CultureInfo("en-US", false);
    public override string PrintCurrentDateTime()
    {
        return DateTime.Now.ToString(myCIintl);
    }
}

public abstract class Decorator : Time
{
    public readonly Time izm;
    public Decorator(Time izm){
        this.izm = izm;
    }
    public override string PrintCurrentDateTime()
    {
        return izm.PrintCurrentDateTime();
    }
}

public class Adecorator : Decorator
{
    public Adecorator(AmericanDateTime izm) : base(izm) { }
    public override string PrintCurrentDateTime()
    {
        StringBuilder Text = new StringBuilder(izm.PrintCurrentDateTime());
        Text.Append(" - America");
        return Text.ToString();
    }
}

public class Edecorator : Decorator
{
    public Edecorator(EuropeanDateTime izm) : base(izm) { }
    public override string PrintCurrentDateTime()
    {
        StringBuilder Text = new StringBuilder(izm.PrintCurrentDateTime());
        Text.Append(" - Europa");
        return Text.ToString();
    }
}