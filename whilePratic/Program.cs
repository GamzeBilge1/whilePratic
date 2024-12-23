
//soru1
Console.WriteLine("****************SORU1******************");

int i = 1;
string motivation = "Kendime inanıyorum, ben bu yazılım işini hallederim!";

while (i <= 10)
{
    Console.WriteLine(i + "." + motivation);
    i++;
}

//soru2
Console.WriteLine("****************SORU2******************");

int j = 1;
while (j < 21)
{
    Console.WriteLine(j);
    j++;
}

//soru3
Console.WriteLine("****************SORU3******************");

int k = 0;

while (k < 21)
{
    if (k % 2 == 0)
    {
        Console.WriteLine(k);
    }
    k++;

}

//soru4
Console.WriteLine("****************SORU4******************");

int m = 50;
int sum = 0;

while (m <= 150)
{
    sum += m;
    m++;
}
Console.WriteLine(sum);


//soru5
Console.WriteLine("****************SORU5******************");

int tek = 0;
int cift = 0;
int x = 1;

while (x < 121)
{
    if (x % 2 == 0)
    {
        cift += x;
    }
    else
    {
        tek += x;
    }
    x++;
}
Console.WriteLine("cift sayıların toplamı: " + cift + "\ntek sayıların toplamı: " + tek);