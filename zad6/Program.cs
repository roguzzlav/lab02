Console.WriteLine("Podaj kierunek wyprawy:");
string direction = Console.ReadLine();

string directionConvert = direction.ToLower();
switch (directionConvert)
{
    case "polnoc":
    case "północ":
        Console.WriteLine("Wyruszasz w stronę gór");
        break;
    case "południe":
    case "poludnie":
        Console.WriteLine("Wyruszasz w stronę pustyni");
        break;
    case "wschod":
    case "wschód":
        Console.WriteLine("Wyruszasz w stronę lasu");
        break;
    case "zachod":
    case "zachód":
        Console.WriteLine("Wyruszasz w stronę morza");
        break;
    default:
        Console.WriteLine("Nieznany kierunek");
        break;
}