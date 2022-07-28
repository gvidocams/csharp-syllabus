using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneKeyPad
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Type a sentence to know how to write it in a phone keypad: ");
            var userSentence = Console.ReadLine();

            Console.WriteLine($"\nKeypad sequence is {PhoneKeyPad(userSentence)}");
        }

        static string PhoneKeyPad(string sentence)
        {
            char[] lowercaseLetters = sentence.ToLower().ToCharArray();

            List<int> numbersCombos = new List<int>();

            foreach(char c in lowercaseLetters)
            {
                switch(c)
                {
                    case 'a':
                        numbersCombos.Add(2);
                        break;
                    case 'b':
                        numbersCombos.Add(22);
                        break;
                    case 'c':
                        numbersCombos.Add(222);
                        break;
                    case 'd':
                        numbersCombos.Add(3);
                        break;
                    case 'e':
                        numbersCombos.Add(33);
                        break;
                    case 'f':
                        numbersCombos.Add(333);
                        break;
                    case 'g':
                        numbersCombos.Add(4);
                        break;
                    case 'h':
                        numbersCombos.Add(44);
                        break;
                    case 'i':
                        numbersCombos.Add(444);
                        break;
                    case 'j':
                        numbersCombos.Add(5);
                        break;
                    case 'k':
                        numbersCombos.Add(55);
                        break;
                    case 'l':
                        numbersCombos.Add(555);
                        break;
                    case 'm':
                        numbersCombos.Add(6);
                        break;
                    case 'n':
                        numbersCombos.Add(66);
                        break;
                    case 'o':
                        numbersCombos.Add(666);
                        break;
                    case 'p':
                        numbersCombos.Add(7);
                        break;
                    case 'q':
                        numbersCombos.Add(77);
                        break;
                    case 'r':
                        numbersCombos.Add(777);
                        break;
                    case 's':
                        numbersCombos.Add(7777);
                        break;
                    case 't':
                        numbersCombos.Add(8);
                        break;
                    case 'u':
                        numbersCombos.Add(88);
                        break;
                    case 'v':
                        numbersCombos.Add(888);
                        break;
                    case 'w':
                        numbersCombos.Add(9);
                        break;
                    case 'x':
                        numbersCombos.Add(99);
                        break;
                    case 'y':
                        numbersCombos.Add(999);
                        break;
                    case 'z':
                        numbersCombos.Add(9999);
                        break;
                    case ' ':
                        numbersCombos.Add(0);
                        break;
                    case ',':
                        numbersCombos.Add(1);
                        break;
                    case '.':
                        numbersCombos.Add(11);
                        break;
                    case '?':
                        numbersCombos.Add(111);
                        break;
                    case '!':
                        numbersCombos.Add(1111);
                        break;
                }
            }

            return String.Join(" ", numbersCombos);
        }
    }
}
