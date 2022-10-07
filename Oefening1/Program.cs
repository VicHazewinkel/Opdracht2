// See https://aka.ms/new-console-template for more information
using Oefening1;

Koe koe = new Koe(5, "koe"); 
Console.WriteLine(  koe.Zegt() + " " + koe.Weegt())  ;
Console.WriteLine(koe.Zegt() + koe.Gewicht); // uitspraak verborgen (private) 

Slang slang = new Slang(2, "slang");
Console.WriteLine(slang.Zegt() + " " + slang.Weegt());
Console.WriteLine(slang.Zegt() + slang.Gewicht); // uitspraak verborgen (private)

Varken Varken = new Varken(4 , "Varken");
Console.WriteLine(Varken.Zegt() + " " + Varken.Weegt());
Console.WriteLine(Varken.Zegt() + Varken.Gewicht); // uitspraak verborgen (private)