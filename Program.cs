/*
Utskrift i konsollen kan feks se sånn her ut: 
Hei, jeg heter Bjarne! Jeg er 40 år gammel og jeg har svart hår
Se på meg, nå løper jeg i åkeren.
Nå sitter jeg og gamer litt farmingsimulator!

Hei, jeg heter Kurt! Jeg er 55 år gammel og jeg har brunt hår
Nå er jeg ute på fisketur.
Se, jeg kan også klatre høyt i klatreparken!

*/

using System;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Hva heter du?");
      string navn = Console.ReadLine();


        bool theSwitch = true; 
        int alder = 0;
        while (theSwitch)
        {
            try
            {
                Console.WriteLine("Hvor gammel er du?");
                alder = Convert.ToInt32(Console.ReadLine());
                theSwitch = false;
            }
            catch (FormatException)
            {
                Console.WriteLine("Du må et tall!!!");
            }
        }
        
        if (alder >= 60)
        {
            Console.WriteLine("snart blir du pensjonist :)");
        }
       Console.WriteLine("Hva gjør du nå");
        string hobby = Console.ReadLine();  
        
       Console.WriteLine($"""
               Hei, jeg heter {navn}! Jeg er {alder} år gammel og jeg har hobby {hobby}               
               """);
    }
}

//asdlnælkævasbnælknasælknsaæ