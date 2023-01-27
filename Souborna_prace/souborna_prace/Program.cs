// See https://aka.ms/new-console-template for more information
Console.WriteLine("Vítejte v našem seznamu žáků");

string[] seznam = { "Vojta Magnusek, Matěj Michalík, Janek Lojda, Serhii Kučyr, Tomáš Divíšek, Pavel Blažek, Bohdan Mik, Ondra Holemář, Kuba Valášek, Filip Veverka, Jakub Zelený, Adam Jonáš, David Matějka, Vojta Kučera, Matěj Svoboda, Martin Částek, Jaroslav Jiroušek, Jakub Čtrvtečka, Dominik Marek, Matěj Zahradník" };
Array.Sort(seznam);
foreach (string serazeno in seznam) 
Console.WriteLine(serazeno);

Console.WriteLine("Zadejte žáka");
Console.WriteLine("Zadejte jméno žáka");
string zasobnik = Console.ReadLine();
Console.WriteLine("Zadejte příjmení žáka");                                         /*seznam je seřazený vzestupně*/
string zasobnik_2 = Console.ReadLine();
Console.WriteLine("Zadejte bydliště žáka");
string zasobnik_3 = Console.ReadLine();
Console.WriteLine("Zadejte obor žáka");
string zasobnik_4 = Console.ReadLine();
Console.ReadKey();

Console.WriteLine("Zadejte žáka");
Console.Write("Zadejte jméno žáka");
string zasobnik_5 = Console.ReadLine();
Console.Write("Zadejte příjmení žáka");                                                /*sezanm je seřazený sestupně*/
string zasobik_6 = Console.ReadLine();
Console.Write("Zadejte bydliště žáka");
string zasobnik_7 = Console.ReadLine();
Console.Write("Zadejte obor žáka");
string zasobnik_8 = Console.ReadLine();
Console.ReadKey();
