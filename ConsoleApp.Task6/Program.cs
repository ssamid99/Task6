using System;
using System.Text.RegularExpressions;
using ClassLibrary.Helpers;

namespace ConsoleApp.Task6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            // 1) Verilmish metnde { a}
            // simvolun sayi { b}
            // simvolun sayinda nece defe coxdur ?
            string word = Monitor.ReadString("Metn daxil edin: ");
           
            int countA = 0;
            int countB = 0;
            double b;
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == 'a')
                {
                    countA++;
                }
                else if (word[i] == 'b')
                {
                    countB++;
                }
              
            }
            b = countA * 1.0 / countB;
            Console.WriteLine(countA);
            Console.WriteLine(countB);
            Console.WriteLine(b);
            
            
            //2) Verilmish metnde sol terefden tek yerde dayanan simvollarin hamisi { a}
            //simvoludurmu ?
            string word = Monitor.ReadString("Metn daxil edin: ");

            int countA = 0;
            int countB = 0;

            
            for(int i = 0; i < word.Length; i ++)
            {
                if(i % 2 != 0)
                {
                   countA++;
                   if(soz[i] == 'a')
                   {
                    countB++;
                   }
                }                                              
            }
            if(countA == countB)
            {
                Console.WriteLine("tek yerde dayanan simvollarin hamisi {a} simvoludur");
            }
            else
            {
                Console.WriteLine("tek yerde dayanan simvollarin hamisi { a} simvolu deyil");
            }
            
            Console.WriteLine($"Tek yerde dayanan simvol sayi: {countA}");
            Console.WriteLine($"a simvolunun sayi: {countB}");
            
           // 3) Verilmish metnde sol terefden tek yerde dayanan simvollardan necesi { b}
           // -ye beraberdir.

            string word = Monitor.ReadString("Metn daxil edin: ");
            int countA = 0;
            int countB = 0;
            for (int i = 0; i < word.Length; i++)
            {
                if (i % 2 != 0)
                {
                    countA++;
                  if (word[i] == 'b')
                  {
                    countB++;
                  }
                }
            }  
            Console.WriteLine($"Tek yerde dayanan simvol sayi: {countA}");
            Console.WriteLine($"'b' simvolunun sayi: {countB}");
            
            // 4) Verilmish metnde sol terefden ilk rast gelinen { a}
            // simvolunun yeri tek ededdi yoxsa cut ?
            string word = Monitor.ReadString("Metn daxil edin: ");
            int s = word.IndexOf('a');
            Console.WriteLine($"'a' simvolunun yeri: {s}");
            if(s % 2 == 0)
            {
                Console.WriteLine("{a} simvolunun yeri cut ededdir.");
            }
            else
            {
                Console.WriteLine("{a} simvolunun yeri tek ededdir.");
            }
            
            //5) Verilmish metnde sol terefden saydiqda { a},{ b},{ c}
            //simollarindan hansi birinci gelir?
            string word = Monitor.ReadString("Metn daxil edin: ");
            char[] symbols = { 'a', 'b', 'c' };
            int index = word.IndexOfAny(symbols);
            Console.WriteLine($"index nomresi ve simvol: {index}.{word[index]}");

            //6) Verilmish metnde { a}
            //simvolunun sol terefden ve sag terefden indexleri eydidirmi?
            string word = Monitor.ReadString("Metn daxil edin:");
            
            int index1 = word.IndexOf('a');
            string newText = "";
            for(int i = word.Length - 1; i >= 0; i--)
            {
                newText += word[i]; 
            }
            int index2 = newText.IndexOf('a');
            if(index1 == index2)
            {
                Console.WriteLine($"Indexler eynidir:\n" +
                    $"index1: {index1}\n" +
                    $"index2: {index2}");
            }
            else
            {
                Console.WriteLine($"Indexler eyni deyil:\n" +
                    $"index1: {index1}\n" +
                    $"index2: {index2}");
            }
            
            //7) Verilmish metnde { a}
            //simvolu { b}
            //simvolundan qabaq ve oda { c}
            //simvolundan qabaq gelirmi ?
            string word = Monitor.ReadString("Metn daxil edin: ");
            int a = word.IndexOf('a');
            int b = word.IndexOf('b');
            int c = word.IndexOf('c');
           
            if(a < b && b < c)
            {
                Console.WriteLine($"'a' simvolu 'b' simvolundan qabaq ve oda 'c' simvolundan qabaq gelir: \n" +
                    $"'a' = {a}\n" +
                    $"'b' = {b}\n" +
                    $"'c' = {c}");
            }
            else
            {
                Console.WriteLine("'a' simvolu 'b' simvolundan qabaq ve oda 'c' simvolundan qabaq gelmir.");
            }

            //8) Verilmish metnde ilk qabagima cixan { a}
            //simvolundan sonra gelen simvolu 10 defe dalbadal cap et.
            string word = Monitor.ReadString("Metn daxil edin: ");
            int q = word.IndexOf('a');
            q = q + 1;
            int a = 1;
            while (a < 11)
            {
                Console.WriteLine($"{a}.simvolun indexi ve simvol: {q},{word[q]}");
                a++;
            }

            //9) Verilmish metinde ilk 3 simvol, son 3 simvolun tersine formasina beraberdirmi.?
            string word = Monitor.ReadString("Metn daxil edin: ");
            string word1 = word.Substring(0, 3);
            string word2 = word.Substring(word.Length - 3, 3);
            string newText = "";
            for(int i = word2.Length - 1; i >= 0; i--)
            {
                newText += word2[i]; 
            }
            Console.WriteLine(word1);
            Console.WriteLine(newText);
            if(word1 == newText)
            {
                Console.WriteLine("ilk 3 simvol, son 3 simvolun tersine formasina beraberdir");
            }
            else
            {
                Console.WriteLine("ilk 3 simvol, son 3 simvolun tersine formasina beraber deyil");
            }

            //10) Verilmish metinde butun reqemleri legv et.
            string word = Monitor.ReadString("Metn daxil edin: ");
            string newText = Regex.Replace(word, @"-?\d", "");
            Console.WriteLine(word);
            Console.WriteLine(newText);

            //11) Verilmish metinde butun { a}
            //simvollarinin qabagina { b}
            //simvolunu ve
            //eyni zamandan butun { b}
            //simvollarinin qabagina { a}
            //simvolunu yaz.
            string word = Monitor.ReadString("Metn daxil edin: ");
            string newWord1 = "";
            string newWord2 = "";
            for(int i = word.Length - 1; i >= 0; i--)
            {
                newWord1 += word[i];
                if(word[i] == 'a')
                {
                    newWord1 += 'b';
                }
                if(word[i] == 'b')
                {
                    newWord1 += 'a';
                }
            }
            for(int i = newWord1.Length - 1;i >= 0; i--)
            {
                newWord2 += newWord1[i];
            }
            Console.WriteLine(newWord2);
           
            //12) Verilmish metinde en ilk ve en son { a}
            //simvolundan bashqa yerde qalan butun { a}
            //simvollarini yox et.
            string word = Monitor.ReadString("Input a text: ");
            string newText = "";

            for (int i = 0; i < word.Length; i++)
            {
                if (i != 0 && i != word.Length - 1)
                {
                    if (word[i] != 'a')
                    {
                        newText += word[i];
                    }
                }
                else
                {
                    newText += word[i];
                }
            }

            Console.WriteLine(newText);
            
            // 13) Verilmish metnde butun simvollari ardicil sekilde
            // biri balaca, biri boyuk formada cap et.

            string word = Monitor.ReadString("Metn daxil edin: ");

            string newWord = "";
            string words = "";
            for (int i = 0; i < word.Length; i++)
            {
                if (i % 2 == 0)
                {
                    words = Convert.ToString(word[i]).ToLower();
                    newWord += words;
                }
                else
                {
                    words = Convert.ToString(word[i]).ToUpper();
                    newWord += words;
                }
            }

            Console.WriteLine(newWord);
            
            //14) Verilmish metinde butun tek yerde dayanan simvollari ondan sonra gelen simvolun BOYUK formasi ile evez et.

            string word = Monitor.ReadString("Metn daxil edin : ");

            string newWord = "";
            string words = "";
            string words2 = "";

            for (int i = 0; i < word.Length; i++)
            {
                if (i % 2 == 0 && i != word.Length - 1)
                {
                    words2 = Convert.ToString(word[i + 1]).ToUpper();
                    words = Convert.ToString(word[i]);
                    words = words.Replace(words, words2);

                    newWord += words;
                }
                else
                {
                    newWord += word[i];
                }
            }

            Console.WriteLine(newWord);
            












        }
    }
}
