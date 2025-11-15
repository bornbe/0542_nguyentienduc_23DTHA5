using System;

public class PhuongTrinhBacNhat
{
    protected double B { get; set; }
    protected double C { get; set; }

    public PhuongTrinhBacNhat(double b, double c)
    {
        B = b;
        C = c;
    }

    public virtual string Giai()
    {
        Console.WriteLine($"\nGiai phuong trinh bac nhat: {B}x + {C} = 0");

        if (B == 0)
        {
            if (C == 0)
            {
                return "Phuong trinh co vo so nghiem.";
            }
            return "Phuong trinh vo nghiem.";
        }

        double x = -C / B;
        return $"Phuong trinh co nghiem duy nhat: x = {x}";
    }
}

public class PhuongTrinhBacHai : PhuongTrinhBacNhat
{
    protected double A { get; set; }

    public PhuongTrinhBacHai(double a, double b, double c) : base(b, c)
    {
        A = a;
    }

    public override string Giai()
    {
        if (A == 0)
        {
            Console.WriteLine("\na = 0 => day la phuong trinh bac nhat");
            return base.Giai();
        }

        Console.WriteLine($"\nGiai phuong trinh bac hai: {A}x^2 + {B}x + {C} = 0");

        double delta = B * B - 4 * A * C;
        Console.WriteLine($"Delta = {delta}");

        if (delta < 0)
        {
            double phanThuc = -B / (2 * A);
            double phanAo = Math.Sqrt(-delta) / (2 * A);

            return $"2 nghiem phuc:\n" +
                   $"x1 = {phanThuc} + {phanAo}i\n" +
                   $"x2 = {phanThuc} - {phanAo}i";
        }
        else if (delta == 0)
        {
            double x = -B / (2 * A);
            return $"Nghiem kep: x1 = x2 = {x}";
        }
        else
        {
            double x1 = (-B + Math.Sqrt(delta)) / (2 * A);
            double x2 = (-B - Math.Sqrt(delta)) / (2 * A);

            return $"2 nghiem phan biet:\n" +
                   $"x1 = {x1}\n" +
                   $"x2 = {x2}";
        }
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        PhuongTrinhBacHai pt1 = new PhuongTrinhBacHai(1, -3, 2);
        Console.WriteLine("\n--- Vi du 1 ---");
        Console.WriteLine(pt1.Giai());

        PhuongTrinhBacHai pt2 = new PhuongTrinhBacHai(0, 5, -10);
        Console.WriteLine("\n--- Vi du 2 ---");
        Console.WriteLine(pt2.Giai());

        PhuongTrinhBacHai pt3 = new PhuongTrinhBacHai(1, 1, 1);
        Console.WriteLine("\n--- Vi du 3 ---");
        Console.WriteLine(pt3.Giai());

        PhuongTrinhBacHai pt4 = new PhuongTrinhBacHai(0, 0, 5);
        Console.WriteLine("\n--- Vi du 4 ---");
        Console.WriteLine(pt4.Giai());
    }
}
