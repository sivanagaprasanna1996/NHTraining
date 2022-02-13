
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day15pro14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamWriter sw = new StreamWriter("E:\\assignments\\file programs\\siva\\sivaquiz");
            int score = 0, ans;
            string name;
            Console.WriteLine("Enter your name");
            name = Console.ReadLine();
            Console.WriteLine("******************");
            Console.WriteLine("Hi{0},Welcome to quiz ", name);
            Console.WriteLine("******************");
            sw.WriteLine(name);



            Console.WriteLine("Q1.telangana capital");
            Console.WriteLine("1.banglore   2.chennai  3.vizag 4.hyd");
            ans = Convert.ToInt32(Console.ReadLine());
            if (ans == 4)
                score += 20;

            Console.WriteLine("Q2.present lok sabha is the");
            Console.WriteLine("1.14th   2.15th  3.16th 4.17th");
            ans = Convert.ToInt32(Console.ReadLine());
            if (ans == 4)
                score += 20;


            Console.WriteLine("Q3.OS abbreviation:");
            Console.WriteLine("1.order of significance  2.open software   3. Optical sensor  4.Operating system ");
            ans = Convert.ToInt32(Console.ReadLine());
            if (ans == 4)
                score += 20;

            Console.WriteLine("Q4.MPG extension refers which kind of file?");
            Console.WriteLine("1.document file  2.ms office  3.animation file  4.image file");
            ans = Convert.ToInt32(Console.ReadLine());
            if (ans == 3)
                score += 20;


            Console.WriteLine("Q5.which indian captain got the last world world cup");
            Console.WriteLine("1.kapil dev  2.sachin 3.kohli  4.dhoni");
            ans = Convert.ToInt32(Console.ReadLine());
            if (ans == 4)
                score += 20;
            sw.WriteLine(score);
            sw.Close();
            Console.WriteLine("******************");
            Console.WriteLine("Thank you for taking test, Admin will inform your result");


            Console.ReadLine();



        }
    }
}


