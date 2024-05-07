using System.Xml.Linq;

namespace DomashanClasss
{
    internal class Program
    {
        //Zad Person
        static void Main(string[] args)
        {
            Console.Write("Write name: ");

            person person = new person();
            person.Name = Console.ReadLine();

            Console.Write("Write age, bitte: ");
            person.Age = int.Parse(Console.ReadLine());

            Console.WriteLine($"HELLO! my name is {person.Name} and I'm {person.Age} years old!");
            //predavam tva deto znam i mi e v uma kao za 00:00 chasa, sorry...
        }
    }
}
