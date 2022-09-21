using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    internal class Program
    {
       public void DisplayIntro()
       {
            Console.WriteLine("DOSHIL SHARMA SOBRON");
            Console.WriteLine();
            Console.WriteLine("PROFILE");
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("Aspiring Software Engineer, currently in second year at");
            Console.WriteLine("the University of Mauritius.");
            Console.WriteLine("-------------------------------------------------------");
        }

        public void DisplayMainMenu()
        { 
            Console.WriteLine("MAIN MENU");
            Console.WriteLine();
            Console.WriteLine("1. Experience / Job History");
            Console.WriteLine("2. Education / Training");
            Console.WriteLine("3. Skills");
            Console.WriteLine("4. Technological Skills");
            Console.WriteLine("5. Contact Details");

        }
        

        public void DisplaySkills()
        {
            Console.Clear();
            Console.WriteLine("SKILLS");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("*Problem Solving");
            Console.WriteLine("*Leadership");
            Console.WriteLine("*Time management");
            Console.ReadLine();
        }

        public void ShowTechnologicalSkills()
        {
            Console.Clear();
            Console.WriteLine("C#"); 
            Console.WriteLine("C++");
            Console.WriteLine("JAVA");
            Console.WriteLine("HTML");
            Console.WriteLine("CSS");
            Console.WriteLine("Javascript");
            Console.ReadLine();
        }

        public void Contact()
        {
            Console.Clear();
            Console.WriteLine("TEL: 1234567");
            Console.WriteLine("Email: doshilsobron@gmail.com");
        }

    }
}
