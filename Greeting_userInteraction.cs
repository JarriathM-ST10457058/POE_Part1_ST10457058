using System;
using System.Collections.Generic;
using System.Drawing;
using POE_Part1_ST10457058;

namespace POE_Part1_ST10457058
{
    /**
    * @author Name: Jarriath
    * Surname: Marais
    * Student Number: ST10457058
    */
    public class Greeting_userInteraction
    {
        private string userName;
        private string botName = "ChatBot";

        // Method for Dictionary for chatbot responses
        private readonly Dictionary<string, string> botResponses = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
        {
            { "how are you", "I'm just a program, but I'm functioning well!" },
            { "purpose", "I'm here to assist you with basic cybersecurity and user interaction." },
            { "ask about", "You can ask me about password safety, phishing, safe browsing, malware, and more!" },
            { "phishing", "Phishing is a cyber attack where attackers trick people into revealing sensitive information, like passwords or credit card details." },
            { "password", "Use a mix of letters, numbers, and symbols. Avoid common words or personal details." },
            { "safe online", "Avoid clicking on suspicious links, use strong passwords, enable 2FA, and keep your software updated." },
            { "malware", "Malware is malicious software designed to harm, exploit, or otherwise compromise a computer system." },
            { "firewall", "A firewall protects your network by filtering incoming and outgoing traffic based on security rules." },
            { "vpn", "A Virtual Private Network encrypts your internet connection for privacy." },
            { "botnet", "A network of infected devices controlled by hackers." },
            { "spyware", "Software that secretly collects your data without permission." },
            { "attack", "A cybersecurity attack is an attempt to gain unauthorized access, disrupt, or steal data from a system." },
        };

        // Method to greet the user and get their name
        public void GreetUser()
            {
            Console.ForegroundColor = ConsoleColor.Magenta; //Change foreground colour
            Console.WriteLine($"{botName}: Enter your name ");
            Console.ResetColor();//reset foreground colour

            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write("User: ");
            userName = Console.ReadLine();
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine($"{botName}: Hello, {userName}! Welcome to our system.");
            Console.WriteLine("=========================================================================================");
            Console.ResetColor();
        }

        // Method to handle basic responses using a dictionary
        public void BasicResponseSystem()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine($"{botName}: Ask me a cybersecurity question or type 'exit' to quit.");
            Console.ResetColor();

            while (true) //Loop for responses
            {
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.Write($"{userName}: ");
                string userInput = Console.ReadLine().ToLower();
                Console.ResetColor();

                if (userInput == "exit")// If statement to exit program
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine($"{botName}: Goodbye, {userName}!");
                    Console.ResetColor();
                    break;
                }

                if (botResponses.ContainsKey(userInput))
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine($"{botName}: {botResponses[userInput]}"); //Input auto responses
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine($"{botName}: I’m not sure how to respond to that. Try asking something about cybersecurity.");
                }

                Console.ResetColor();
            }
        }

        // Method to handle input validation
        public void InputValidation()
        {
            string input;
            bool isValid = false;

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("=========================================================================================");
            Console.WriteLine($"{botName}: Enter a command ");
            Console.ResetColor();

            do
            {
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.Write($"{userName}: ");
                input = Console.ReadLine();
                Console.ResetColor();

                if (string.IsNullOrWhiteSpace(input))
                {
                    //Method for invalid input
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine($"{botName}: Invalid input. Please enter a valid command.");
                    Console.ResetColor();
                }
                else
                {
                    //Return input
                    isValid = true;
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine($"{botName}: You entered, '{input}'");
                    Console.ResetColor();
                }
            } while (!isValid);
        }
    }
}
