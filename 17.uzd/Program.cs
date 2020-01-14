using System;

namespace _17.uzd
{
    class Program
    {
        static void Main(string[] args)
        {
            bool x = true;
            int i = 1;
            while (i <= 20)
            {
                Console.WriteLine($"{i} {x}");
                i++;
            }

            x = false;

            Console.WriteLine(x);

        }
    }
}


// Deklarēt programmā bool tipa mainīgo, kura sākotnējā vērtība ir TRUE. 
// Izveidot while ciklu, kurš atkārtojas tik ilgi kamēr mainīgā vērtība ir TRUE. 
// Mainīgā vērtību uz FALSE ir jānomaina, tad, kad cikls ir atkārtojies 20 reizes.