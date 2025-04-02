using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POE_Part1_ST10457058;

namespace POE_Part1_ST10457058
{
 /**
 * @author Name: Jarriath
 * Surname: Marais
 * Student Number: ST10457058
 */
    internal class Program
    {
        static void Main(string[] args)
        {
            new Image_Display() { };
            new Intro_Sound() { };
            new Greeting_userInteraction() { };
            Greeting_userInteraction ui = new Greeting_userInteraction();

            // Calling the methods to display in sequence
            ui.GreetUser();
            ui.BasicResponseSystem();
            ui.InputValidation();

        }
    }
}
