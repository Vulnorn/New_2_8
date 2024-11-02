namespace New_2_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userPassvord;
            string userInput;
            int numberAttempts = 3;
            string secretMassage = "Секретное сообщение";
            

            Console.WriteLine($"Придумайте пароль");
            userPassvord = Console.ReadLine();
            
            while (numberAttempts>0)
            {
            Console.WriteLine($"Для ввывода секретного сообщения введите пароль. (У Вас {numberAttempts} попыток):");
                userInput = Console.ReadLine();

                if (userPassvord == userInput)
                {
                    Console.WriteLine($"{secretMassage}");
                    Console.ReadKey();
                    return;
                }
                else
                {
                    numberAttempts--;
                }
            }
        }
    }
}