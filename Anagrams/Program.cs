using System;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {

            bool runAgain = true;

            while (runAgain)
            {
                {
                    Console.WriteLine("Wprowadź pierwszy wyraz:");
                    string firstInput = Console.ReadLine();

                    Console.WriteLine("Wprowadź drugi wyraz:");
                    string secondInput = Console.ReadLine();


                    bool result = AreAnagrams(firstInput, secondInput);

                    if (result)
                    {
                        Console.WriteLine("Podane wyrazy są anagramami.");
                    }
                    else
                    {
                        Console.WriteLine("Podane wyrazy nie są anagramami.");
                    }
                }


                static bool AreAnagrams(string firstInput, string secondInput)
                {
                    firstInput = new string(firstInput.ToLower().Where(c => !char.IsWhiteSpace(c)).ToArray());
                    secondInput = new string(secondInput.ToLower().Where(c => !char.IsWhiteSpace(c)).ToArray());
                    if (firstInput.Length != secondInput.Length)
                    {
                        return false;
                    }


                    char[] firstCharsArray = firstInput.ToLower().ToCharArray();
                    char[] secondCharsArray = secondInput.ToLower().ToCharArray();


                    Array.Sort(firstCharsArray);
                    Array.Sort(secondCharsArray);


                    for (int i = 0; i < firstCharsArray.Length; i++)
                    {
                        if (firstCharsArray[i] != secondCharsArray[i])
                        {
                            return false;
                        }
                    }

                    return true;
                }

                Console.WriteLine("\nCzy chcesz jeszcze raz? (tak/nie):");
                string ans = Console.ReadLine().ToLower();

                while (ans != "tak" && ans != "nie")
                {
                    Console.WriteLine("napisz 'tak' lub 'nie'");
                    ans = Console.ReadLine();
                }
                if (ans != "tak")
                {
                    runAgain = false;
                    Console.WriteLine("Dziękuję za skorzystanie z programu. Do zobaczenia!");
                }
            }
        }
    }
}














