using System;

namespace UserNameDatatask
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sisesta eesnimi:
            //Sisesta numbrid 1-3
            //Kui valitakse 1, siis kuvatakse nimi tagurpidi
            //Kui valitakse 2, kuvatakse esimest tähte
            //Kui valitakse 3 siis kuvatakse eesnime pikkus

            
                Console.WriteLine("Eesnimi:");
                string userNumberOne = Console.ReadLine(); ;
                

                Console.WriteLine("valige number 1-3");
                int userOperator = Convert.ToInt32(Console.ReadLine());

                switch (userOperator)
                {
                    case 1:
                        AddTwoNumbers(userNumberOne);
                        break;
                    case 2:
                        DivideTwoNumbers(userNumberOne);
                        break;
                    case 3:
                        MinusTwoNumbers(userNumberOne);
                        break;

                    default:
                        Console.WriteLine("proovi uuesti");
                        break;
                }
            }

            public static void AddTwoNumbers(string userNumber)
            {
            for (int i = userNumber.Length - 1; i >= 0; i--)
            {
                Console.Write(userNumber[i]);
            }
        }

            public static void DivideTwoNumbers(string userNumber2)
            {
            Console.WriteLine($"Sinu nime esimene täht on {userNumber2[0]}");
        }
            public static void MinusTwoNumbers(string userNumber3)
            {
            Console.WriteLine($"Sinu nimi {userNumber3.Length} sümbolit pikk");
        }
            
            
    }
}
