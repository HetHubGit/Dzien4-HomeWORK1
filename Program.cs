internal class Program
{
    private static void Main(string[] args)
    {
        string name;
        string gender;
        Console.WriteLine("Proszę Wpisać Imię:\t");// Pomimo wpisania polską czcionką w konsoli nie odbiera tego w if'ach dlatego zmieniłem linię 23 na nie polską
        name = Console.ReadLine();
        Console.WriteLine("Proszę podać płeć:\t");
        gender = Console.ReadLine();
        Console.WriteLine("Podaj wiek tej osoby:\t");
        int age = Convert.ToInt32(Console.ReadLine());


        if (name == "Ewa" && age == 30)
        {
            Console.WriteLine("kobieta poniżej 30 lat");
        }
        if (gender == "Kobieta" && age < 30)
        {
            Console.WriteLine("Ewa lat 30.");
        }
        if (gender == "Mezczyzna" && age <= 17) // czyli tutaj jeśli wpiszę: Mężczyzna - kompiler tego nie uznaje, czy szefuńcio wie jak to obejść?
        {
            Console.WriteLine("Mężczyzna niepełnoletni");
        }
        else
        {
            Console.WriteLine("Nie zwraca NIC.");
        }
    }
}