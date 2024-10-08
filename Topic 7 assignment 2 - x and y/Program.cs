namespace Topic_7_assignment_2___x_and_y
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("I shall count up  from -10");
            int numba;
            numba = -10;
            int numba2;
            
            for (int i = 1; i <= 22; i = i + 1)
            {
                Console.WriteLine("OG NUMBER: " + numba);
                numba = numba + 1;
                numba2 = numba * numba;
                Console.WriteLine("OG NUMBER SQUARED: " + numba2);
                if (numba == 12)
                {
                    Console.WriteLine("it's over");
                }
            }
            Console.ReadLine();
            //I could not figure out how to format the code like the way it was shown in the instructions





        }
    }
}
