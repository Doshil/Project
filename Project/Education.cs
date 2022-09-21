using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    internal class Education
    {
        public void DisplayEducation()
        {
            Console.Clear();
            Console.WriteLine("BSc (Hons) Software Engineering");
            Console.WriteLine("Level: 2");
            Console.WriteLine("University of Mauritius");
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine("SELECT LEVEL TO SEE DETAILS OF MODULES COVERED IN EACH YEAR");
            Console.WriteLine("1. Year 1");
            Console.WriteLine("2. Year 2");
            Console.WriteLine("3. Additional Training");
            Console.WriteLine("4. Go back");

            while (true)
            {
                switch (Convert.ToInt32(Console.ReadLine()))
                {
                    case 1:
                        {
                            DisplayYearOne();
                        }
                        break;
                    case 2:
                        {
                            DisplayYearTwo();
                        }
                        break;
                    case 3:
                        {
                            Additional();
                        }
                        break;
                    case 4:
                        {
                            Console.Clear();
                            Program program = new Program();
                            program.DisplayMainMenu();
                        }
                        break;
                    default:
                        Console.Clear();
                        Program program2 = new Program();
                        //program2.DisplayMainMenu();
                        break;
                }
            }
        }
        public void DisplayYearOne()
        {

            Console.WriteLine("MODULE : GRADE");
            Console.WriteLine("Communication and Business Skills for IT         A");
            Console.WriteLine("Software Aanalysis and Modelling                 B");
            Console.WriteLine("Database Systems                                 B");
            Console.WriteLine("Software Engineering Principles                  B");
            Console.WriteLine("Software Design Fundamentals and Programming     A");
            Console.WriteLine("Discrete Structures                              C");
            //Console.ReadLine();

        }
        public void DisplayYearTwo()
        {
            Console.WriteLine("MODULE : GRADE");
            Console.WriteLine("Communication and Business Skills for IT    A");
            Console.WriteLine("Software Aanalysis and Modelling    B");
            Console.WriteLine("Database Systems    B");
            Console.ReadLine();

        }

        public void Additional()
        {
            Console.WriteLine("HCIA 5G");
            Console.WriteLine("Rosetta Stone");
            Console.ReadLine();
        }
    }
}
