using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MorseCode
{
    class Program
    {


        static void Main(string[] args)
        {

            var morseFile = "morse.csv";
            var translations = "output.csv";

            // ************** Create Dictionary of Index/Value pairs

            Dictionary<string, string> morseDiction = new Dictionary<string, string>();
            morseDiction = new Dictionary<string, string>();
            using (var writing = new StreamReader(morseFile))
            {
                while (writing.Peek() > -1)
                {
                    var line = writing.ReadLine().Split(',');// ["B","..--"]
                    morseDiction.Add(line[0], line[1]);
                }
            }

            // Question 

            Console.WriteLine("Input a word you would like to convert to Morse Code");
            string conVerto = Console.ReadLine();
            conVerto = conVerto.ToUpper().Replace(" ", "");
            Console.WriteLine($"You would like to convert {conVerto}");
            Console.ReadKey();

            // convert string to characters and return translation from Morse
            // convert to Character Array
            char[] conAir = conVerto.ToCharArray();

            // conAir is an array--Proof
            foreach (var lettuce in conAir)
            {
                Console.Write($"   {lettuce}");
                var herepart = lettuce.ToString();
                Console.WriteLine($" =  {morseDiction[herepart]}");

                var collector = new List<string>
                {
                    morseDiction[herepart]
                };
            }

            using (var writer = new StreamWriter(translations))
            {
                foreach (var scrubby in conAir)
                {
                   writer.WriteLine(scrubby);
                }
            }


            //File.WriteAllLines("text.txt", collector.Select(x => string.Join(",", x)));

            // Write to CSV

            //using (var writer = new StreamWriter(translations))
            //{
            //    writer.WriteLine();

            //    foreach (var lettuce in conAir)
            //    {
            //        writer.WriteLine();
            //    }
            //}


        }
    }
}
