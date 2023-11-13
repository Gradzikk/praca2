using System;

// Klasa bazowa Figura
class Figura
{
    public virtual double ObliczPolePowierzchni()
    {
        return 0;
    }
}

// Klasa reprezentująca koło
class Kolo : Figura
{
    public double Promien { get; set; }

    public Kolo(double promien)
    {
        Promien = promien;
    }

    public override double ObliczPolePowierzchni()
    {
        return Math.PI * Promien * Promien;
    }
}

// Klasa reprezentująca prostokąt
class Prostokat : Figura
{
    public double Dlugosc { get; set; }
    public double Szerokosc { get; set; }

    public Prostokat(double dlugosc, double szerokosc)
    {
        Dlugosc = dlugosc;
        Szerokosc = szerokosc;
    }

    public override double ObliczPolePowierzchni()
    {
        return Dlugosc * Szerokosc;
    }
}

// Klasa reprezentująca trójkąt
class Trojkat : Figura
{
    public double BokA { get; set; }
    public double BokB { get; set; }

    public Trojkat(double bokA, double bokB)
    {
        BokA = bokA;
        BokB = bokB;
    }

    public override double ObliczPolePowierzchni()
    {
        return 0.5 * BokA * BokB;
    }
}

class Program
{
    static void Main()
    {
        Figura[] figury = new Figura[]
        {
            new Kolo(5),
            new Prostokat(3, 4),
            new Trojkat(6, 8)
        };

        foreach (var figura in figury)
        {
            Console.WriteLine($"Pole powierzchni: {figura.ObliczPolePowierzchni()}");
        }
    }
}