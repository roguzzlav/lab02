Console.WriteLine("Podaj liczbę: ");
string num = Console.ReadLine();
int.TryParse(num, out int numConvert);

if(numConvert==0)
{
    Console.WriteLine("Liczba jest parzysta");
}
else if(numConvert%2==0)
{
    Console.WriteLine("Liczba jest zerem");
}
else
{
    Console.WriteLine("Liczba jest nieparzysta");
}