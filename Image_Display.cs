using System;
using System.Drawing;
using System.IO;

namespace POE_Part1_ST10457058
{
    public class Image_Display
    {
        public Image_Display()
        {
            //Image path
            string paths = AppDomain.CurrentDomain.BaseDirectory;
            string new_path = paths.Replace("bin\\Debug\\", "");
            string full_path = Path.Combine(new_path, "Logo.jpeg");
            Console.WriteLine(full_path);

            //Image map Height and width
            Bitmap Logo = new Bitmap(full_path);
            Logo = new Bitmap(Logo, new Size(80, 40));

            Console.ForegroundColor = ConsoleColor.Magenta;

            for (int height = 0; height < Logo.Height; height++)
            {
                for (int width = 0; width < Logo.Width; width++)
                {
                    //Image colour
                    Color pixelColor = Logo.GetPixel(width, height);
                    int grayscale = (pixelColor.R + pixelColor.G + pixelColor.B) / 3;
                    char asciiChar = grayscale > 200 ? '.' : grayscale > 150 ? '*' : grayscale > 100 ? 'o' : grayscale > 50 ? '#' : '@';
                    Console.Write(asciiChar);
                }
                Console.WriteLine();
            }
            Console.ResetColor();
        }
    }
}