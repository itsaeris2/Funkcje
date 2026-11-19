using System.ComponentModel.Design;
using System.Data;

Console.WriteLine("Podaj 1 na Silnie 2 na pole prostokąta 3 na pole kwadratu 4 na pole trójkąta 5 na pole koła");
int wybor = Parsein();
switch (wybor)
{
    case 1:
        silnia(int a);
        break;
    case 2:
        poleprostokata(int a, int b);
        break;
    case 3:
        polekwadratu(int a);
        break;
    case 4:
        poletrojkata(int a, int h);
        break;
    case 5:
        polekola(int r);
        break;
}
int silnia(int a)
{
        if(a == 1)
        {
            return a;
        }
        else
        {
            return a * silnia(a - 1);
        }
}
int Parsein(int text)
{
    while(true)
    {
        Console.WriteLine(text);
        if (int.TryParse(Console.ReadLine(),out int liczbe))
        {
            return liczbe;
        }
    }
}
int poleprostokata(int a ,int b)
{
    return (a * b);
}
int polekwadratu(int a)
{
    return a * a;
}
int poletrojkata(int a, int h)
{
    return a * h / 2;
}
double polekola(int r)
{
    return 3.14 * r * r;
}

