namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String name;
            int age;
            double height;
            const int LEGAL_DRINKING_AGE = 21;
            //test

            Console.Write("Please enter your name:");
            name = Console.ReadLine();

            Console.Write("\nPlease enter your age:");
            age = Convert.ToInt32(Console.ReadLine());
            while (age < 0)
            {
                Console.Write("\nInvalid age");
                age = Convert.ToInt32(Console.ReadLine());

            }


            if (age >= 18)
            {
                Console.WriteLine("Welcome to the adult section");
            }
            else
            {
                Console.WriteLine("You are still a minor.");
            }
            if (age >= LEGAL_DRINKING_AGE)
            {
                Console.WriteLine("You are legally allowed to drink.");
            }
            else
            {
                Console.WriteLine("Sorry, you are underage for drinking.");
            }



            Console.WriteLine("\nAge Check:");
            Console.WriteLine("Welcome, " + name + " You're eligible for additional features.");

            Console.WriteLine("\nLegal Drinking Age Verification:");
            Console.WriteLine("Cheers, " + name + "! You're legally allowed to enjoy alcoholic beverages.");

            Console.Write("\nPlease enter your height in meters:");
            height = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nPersonal Details Presentation:");

            String personalInfo = "Your Personal Information: " + name + ", " + age + " years old, " + height + " meters tall";
            Console.WriteLine(personalInfo);

            //end

        }
    }
}
