using System.Media;
using System;

namespace POE_Part1_ST10457058
{   // 1.
 /**
 * @author Name: Jarriath
 * Surname: Marais
 * Student Number: ST10457058
 */
    public class Intro_Sound
    {
        public Intro_Sound()
        {
            Console.ForegroundColor = ConsoleColor.Magenta; //Chnage Bot Colour to Magenta
            Console.WriteLine("Hello! Welcome to the Cybersecurity Awareness Bot. I’m here to help you stay safe online.");
            Console.WriteLine("=========================================================================================");
            Console.ResetColor(); //Reset Colour

            SoundPlayer greeting = new SoundPlayer("C:\\Users\\RC_Student_lab\\source\\repos\\POE_Part1_ST10457058\\bin\\Debug\\IntroSound_Greeting.wav");
                greeting.Play();
        }
    }
}