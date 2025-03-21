using LINQ;

namespace MaxLINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Max LINQ");
            Console.WriteLine("Tee valik numbriga");

            Console.WriteLine("1. Kõige vanem inimene");
            Console.WriteLine("2. Kõige suurem Id");
            Console.WriteLine("3. Kõige suurem IQ");
            Console.WriteLine("4. Kõige suurem inimene");
            Console.WriteLine("5. Rohkem raha");

            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    MaxLINQ1();
                    break;
                case "2":
                    MaxLINQ2();
                    break;
                case "3":
                    MaxLINQ3();
                    break;
                case "4":
                    MaxLINQ4();
                    break;
                case "5":
                    MaxLINQ5();
                    break;
                
            }

        }
        public static void MaxLINQ1()
        {
            var oldestPerson = PeopleList.people
                .Max(x => x.Age);
            Console.WriteLine("Kõige vanem inimene on " + oldestPerson + " aastane.");
        }

        public static void MaxLINQ2()
        {
            var idPerson = PeopleList.people
                .Max(x => x.Id);
            Console.WriteLine("Kõige suurem Id on " + idPerson + ".");
        }
        public static void MaxLINQ3()
        {
            var IQPerson = PeopleList.people
                .Max(x => x.IQ);
            Console.WriteLine("Kõige suurem IQ on " + IQPerson + ".");
        }
        public static void MaxLINQ4()
        {
            var kõrgusPerson = PeopleList.people
                .Max(x => x.Kõrgus);
            Console.WriteLine("Kõige suurem inimene " + kõrgusPerson + ".");
        }
        public static void MaxLINQ5()
        {
            var rahaPerson = PeopleList.people
                .Max(x => x.Raha);
            Console.WriteLine("Kõige rohkem raha " + rahaPerson + ".");
        }
    }
}
