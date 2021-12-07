using System;
using System.Collections.Generic;

namespace pracadomowalab3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<char> rightLetters = new List<char> {'X','X','X','X','X','X'};
            char[] xWord=new char[6];
            xWord[0] = 'c';
            xWord[1] = 'h';
            xWord[2] = 'r';
            xWord[3] = 'z';
            xWord[4] = 'a';
            xWord[5] = 'n';

            char[] letters = new char[12];
                
            int sum = 12;
            int count=0;
            /* foreach (char t in rightLetters)
             {
                 Console.Write($"{t} ");
             }*/
            do
            {

                for (int i = 0; i < letters.Length; i++)
                {

                    Console.WriteLine("Podaj litere: ");
                    letters[i] = Console.ReadLine()[0];

                    for (int j = 0; j < 6; j++)
                    {

                        if (xWord[j] == letters[i])
                        {
                            rightLetters.RemoveAt(j);
                            rightLetters.Insert(j, letters[i]);

                            count += 1;
                            foreach (char t in rightLetters)
                            {
                                Console.Write($"{t} ");
                            }

                        }

                    }

                    sum -= 1;
                    Console.WriteLine("Pozostalo {0} prob ", sum);
                    if ((count == 6) && (sum > 0))
                    {
                        Console.WriteLine("WYGRALES");
                        break;

                    }
                    if (sum == 0)
                    {
                        Console.WriteLine("PRZEGRALES");
                        break;
                    }


                }



            } while ((sum > 0) || (count != 6));
            
           






        }
    }
}
