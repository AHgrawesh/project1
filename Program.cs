namespace project1
{
    class project1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please, enter the lowest number");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Please, enter the highest number");
            int n2 = int.Parse(Console.ReadLine());
            int x = n1, y = n2, z;

            bool Prime = true;
            Console.WriteLine("Prime Numbers between {0} to {1} : ", n1, n2);
            for (x = 2; x <= y; x++)
            {
                for (z = 2; z <= y; z++)
                {
                    if (x != z && x % z == 0)
                    {
                        Prime = false;
                        break;
                    }
                }
                if (Prime)
                {
                    Console.Write("\t" + x);
                }
                Prime = true;
            }
            Console.ReadKey();
        }
    }

}