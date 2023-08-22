using System.ComponentModel.Design;

namespace CaesarCipher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string alphabet = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯабвгдеёжзийклмнопрстуфхцчшщъыьэюя";

            //Console.WriteLine(alphabet.IndexOf('а'));



            Console.WriteLine("Вы хотите зашифровать (Y) сообщение или расшифровать (N)?:");
            string isChipher = Console.ReadLine();
            Console.WriteLine("На какое кол-во делений смещение по часовой стрелке? (положительное число):");
            int countbias = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите сообщение:");
            string message = Console.ReadLine();

            string chifredMessage = "";

            if (isChipher == "N")
            {
                countbias = 33 - countbias;
            }

            foreach (char letter in message)
            {
                if (alphabet.IndexOf(letter) != -1)
                {
                    if (alphabet.IndexOf(letter) < 33)
                    {
                        int bias = alphabet.IndexOf(letter) + countbias;
                        if (bias > 32) { bias -= 33; }
                        chifredMessage += alphabet[bias];
                    }
                    else
                    {
                        int bias = alphabet.IndexOf(letter) + countbias;
                        if (bias > 65) { bias -= 33; }
                        chifredMessage += alphabet[bias];
                    } 
                    
                }
                else
                {
                    chifredMessage += letter;
                }
            }

            Console.WriteLine($"Ваше сообщение: {chifredMessage}");
        }
    }
}