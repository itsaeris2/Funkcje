
Console.WriteLine("1 Silnia 2 Prostokąt 3 Kwadrat 4 Trójkąt 5 Koło");
int wybor = Parsein("Podaj wybór:");
    switch (wybor)
    {
        case 1:
        int n = Parsein("Podaj n:");
        if (n >= 0 && n <= 12)
            Console.WriteLine(silnia(n));
        else
            Console.WriteLine("Błędna liczba");
        break;

    case 2:
        Console.WriteLine(poleprostokata(Parsein("Podaj a:"), Parsein("Podaj b:")));
        break;

    case 3:
        Console.WriteLine(polekwadratu(Parsein("Podaj a:")));
        break;

    case 4:
        Console.WriteLine(poletrojkata(Parsein("Podaj a:"), Parsein("Podaj h:")));
        break;

    case 5:
        Console.WriteLine(polekola(Parsein("Podaj r:")));
        break;
    }

int silnia(int a)
{
    if (a == 0 || a == 1)
    {
        return 1;
    }
    else
    {
        return a * silnia(a - 1);
    }
}

int Parsein(string text)
{
    while (true)
    {
        Console.WriteLine(text);
        if (int.TryParse(Console.ReadLine(), out int liczbe))
        {
            return liczbe;
        }
    }
}

int poleprostokata(int a, int b)
{
    return a * b;
}

int polekwadratu(int a)
{
    return a * a;
}

double poletrojkata(int a, int h)
{
    return a * h / 2.0;
}

double polekola(int r)
{
    return 3.14 * (r * r);
}
