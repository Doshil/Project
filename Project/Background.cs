using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    internal class Background:Experience
    {
        public override void DisplayExperience()
        {
            Console.Clear();
            Console.WriteLine("SELECT FROM THE MENU BELOW TO SEE DETAILS");
            Console.WriteLine();
            Console.WriteLine("1. Ceridian Mauritius(2022)");
            Console.WriteLine("2. Seasense Boutique Hotel & Spa(2020)");
            Console.WriteLine("3. Go Back");

            while (true)
            {

                switch (Convert.ToInt32(Console.ReadLine()))
                {
                    case 1:
                        {
                            DisplayCeridian();
                        }
                        break;
                    case 2:
                        {
                            DisplaySeasense();
                        }
                        break;
                    case 3:
                        {
                            Console.Clear();
                            Program program = new Program();
                            program.DisplayMainMenu();
                        }
                        break;
                    default:
                        Console.Clear();
                        Background background = new Background();
                        background.DisplayExperience();
                        //Program program2 = new Program();
                        //program2.DisplayMainMenu();
                        break;
                }
            }
        }
        public void DisplayCeridian()
        {
            Console.WriteLine("COMPANY NAME: Ceridian HCM Mauritius");
            Console.WriteLine("DATE JOINED: 05-September-2022");
            Console.WriteLine("POSITION: Intern");
            Console.WriteLine("DEPARTMENT: Product & Technology");
        }
        public void DisplaySeasense()
        {
            Console.WriteLine("COMPANY NAME: Seasense Boutique Hotel & Spa");
            Console.WriteLine("DATE JOINED: 15-January-2020");
            Console.WriteLine("POSITION: Trainee Waiter");
            Console.WriteLine("DEPARTMENT: Food & Beverages");
        }
    }
}
