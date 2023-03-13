 class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");
            int day = int.Parse(Console.ReadLine());
            int time = int.Parse(Console.ReadLine());
            int breakf = 5;
            int week = 2;
            int coffe = 3;
            string input;

            while (true)
            {
                input = Console.ReadLine();
                if (input == "End")
                {
                    break;
                }
                else if (input == "Breakfast Sef" && time >= 11)
                {
                    Console.WriteLine("Sorry your order is not available");
                }
                else if (input == "Breakfast Sef")
                {
                    breakf--;
                    if (breakf == 0)
                    {
                         Console.WriteLine("Sorry your order is out of stock");
                    }
                }
                else if (input == "Weekend Set" && week <= 5)
                {
                    Console.WriteLine("Sorry your order is not available");
                }
                else if (input == "Weekend Set")
                {
                    week--;
                    if (week == 0)
                    {
                         Console.WriteLine("Sorry your order is out of stock");
                    }
                }
                else if (input == "Coffee")
                {
                    coffe--;
                    if (coffe == 0)
                    {
                         Console.WriteLine("Sorry your order is out of stock");
                    }
                }
                else 
                {
                    Console.WriteLine("Please enter a valid menu");
                }
            }
            Environment.Exit(0);
    }
}