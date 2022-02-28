using System;

namespace UserNameData
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sisesta eesnimi
            //Kuvatakse pikkus
            //Esimese tähe kuvamine
            //Kuvab nime tagurpidi
            //Main meetodis ei tohi olla rohkem kolmest reast koodist

            Console.WriteLine("Eesnimi:");
            string userName = Console.ReadLine();

            GetUserNameData(userName);


        }

        public static void GetUserNameData(string userInput)
        {
            Console.WriteLine($"Sinu nimi {userInput.Length} sümbolit pikk");
            Console.WriteLine($"Sinu nime esimene täht on {userInput[0]}");

            for(int i = userInput.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(userInput[i]);
            }
        }
    }
}
