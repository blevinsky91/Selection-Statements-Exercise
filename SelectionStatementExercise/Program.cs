namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");

            var r = new Random();
            var favNumber = r.Next(1,1000);
            Console.WriteLine("Try to guess my favorite number");
            var userInput = int.Parse(Console.ReadLine());

            if (favNumber < 9)
            {
                Console.WriteLine("too low");
            }
            else if (favNumber > 9)
            {
                Console.WriteLine("too high");
            }
            else if (favNumber == 9)
            {
                Console.WriteLine("You got it!");
            }
            else
            {
                Console.WriteLine("Nevermind");
            }

        }
    }
}
