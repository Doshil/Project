using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Project
{
    internal class MainProgram   
    {
       
        static void Main(string[] args)
        {
            Program test = new Program();
            test.DisplayIntro();
            test.DisplayMainMenu();

            while (true)
            {


                switch (Convert.ToInt32(Console.ReadLine()))
                {
                    case 1:
                        {
                            Background background = new Background();
                            background.DisplayExperience();
                        }
                        break;
                    case 2:
                        {
                            Education edu = new Education();
                            edu.DisplayEducation();

                        }
                        break;

                    case 3:
                        {
                            
                            test.DisplayMainMenu();
                            test.DisplaySkills();
                            
                        }
                        break;
                    case 4:
                        {
                            
                            test.DisplayMainMenu();
                            test.ShowTechnologicalSkills();

                        }
                        break;
                    case 5:
                        {
                            test.Contact();
                        }
                        break;
                   default:
                        Console.Clear();
                        Program program2 = new Program();
                        program2.DisplayMainMenu();
                        break;

                }
            }

        }

    }
 
}
