Console.WriteLine("Podaj liczbę punktów życia: ");
int hp = int.Parse(Console.ReadLine());

Console.WriteLine("Podaj liczbę mikstur: ");
int potions = int.Parse(Console.ReadLine());

Console.WriteLine("Czy masz klucz?");
string key = Console.ReadLine();
bool.TryParse(key, out bool keyFlag);


Console.WriteLine("Czy ma mapę?");
string map = Console.ReadLine();
bool.TryParse(map, out bool mapFlag);


bool zyje = hp>0;
bool maPelneZdrowie = hp==100;
bool maZaopatrzenie = potions>0;
bool maPrzedmiotNawigacyjny = keyFlag==true || mapFlag==true;
bool wymagaLeczenia =  !maPelneZdrowie;
bool gotowyDoWyprawy = zyje==true && maZaopatrzenie==true && maPrzedmiotNawigacyjny==true;

Console.Write($"Żyje: {zyje} \n Ma pełne zdrowie: {maPelneZdrowie} \n Wymaga leczenia: {wymagaLeczenia} \n Ma zaopatrzenie: {maZaopatrzenie} \n Ma klucz lub mapę: {maPrzedmiotNawigacyjny} \n Gotowy do wyprawy: {gotowyDoWyprawy}");