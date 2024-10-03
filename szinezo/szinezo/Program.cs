using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace szinezo
{
    internal class Program
    {
        class ConsoleDrawer
        {
            static int cursorX = 0;
            static int cursorY = 0;
            static ConsoleColor currentColor = ConsoleColor.White;
            static char currentChar = '█';
            public static void DrawCursor()
            {
                Console.SetCursorPosition(cursorX, cursorY);
                //Console.ForegroundColor = ConsoleColor.White;
                Console.Write(currentChar);
                Console.SetCursorPosition(cursorX, cursorY);
            }
            static void ShowCurrentSettings()
            {
                Console.SetCursorPosition(0, Console.WindowHeight - 1);
                //Console.ForegroundColor = ConsoleColor.White;
                Console.Write($"Current Color: {currentColor}, Current Char: {currentChar}   ");
                Console.SetCursorPosition(cursorX, cursorY);
            }
            /*
            static void DrawBorder(int width, int height)
            {
                // Draw top border
                Console.WriteLine("╔" + new string('═', width - 2) + "╗");

                // Draw sides
                for (int i = 0; i < height - 2; i++)
                {
                    Console.WriteLine("║" + new string(' ', width - 2) + "║");
                }

                // Draw bottom border
                Console.WriteLine("╚" + new string('═', width - 2) + "╝");
            }
            */
            static void Main()
            {
                ConsoleKey key;
                Console.Clear();
                DrawCursor();


                //DrawBorder(20, 10);

                do
                {
                    key = Console.ReadKey(true).Key;
                    switch (key)
                    {
                        case ConsoleKey.Spacebar:
                            DrawCursor();

                            break;
                        case ConsoleKey.UpArrow:
                            if (cursorY > 0) cursorY--;
                            break;
                        case ConsoleKey.DownArrow:
                            if (cursorY < Console.WindowHeight - 1) cursorY++;
                            break;
                        case ConsoleKey.LeftArrow:
                            if (cursorX > 0) cursorX--;
                            break;
                        case ConsoleKey.RightArrow:
                            if (cursorX < Console.WindowWidth - 1) cursorX++;
                            break;

                        case ConsoleKey.NumPad1:
                            currentColor = ConsoleColor.Green;
                            Console.ForegroundColor = currentColor;
                            break;
                        case ConsoleKey.NumPad2:
                            currentColor = ConsoleColor.Blue;
                            Console.ForegroundColor = currentColor;
                            break;
                        case ConsoleKey.NumPad0:
                            currentColor = ConsoleColor.Black;
                            Console.ForegroundColor = currentColor;
                            break;
                        case ConsoleKey.NumPad3:
                            currentColor = ConsoleColor.Red;
                            Console.ForegroundColor = currentColor;
                            break;
                        case ConsoleKey.NumPad4:
                            currentColor = ConsoleColor.White;
                            Console.ForegroundColor = currentColor;
                            break;
                        case ConsoleKey.NumPad5:
                            currentColor = ConsoleColor.Yellow;
                            Console.ForegroundColor = currentColor;
                            break;
                        case ConsoleKey.NumPad6:
                            currentColor = ConsoleColor.Magenta;
                            Console.ForegroundColor = currentColor;
                            break;
                        case ConsoleKey.NumPad7:
                            currentColor = ConsoleColor.Cyan;
                            Console.ForegroundColor = currentColor;
                            break;
                        case ConsoleKey.NumPad8:
                            currentColor = ConsoleColor.DarkRed;
                            Console.ForegroundColor = currentColor;
                            break;
                        case ConsoleKey.NumPad9:
                            currentColor = ConsoleColor.Gray;
                            Console.ForegroundColor = currentColor;
                            break;
                        /*
                    case ConsoleKey.D1:
                        currentColor = ConsoleColor.Red;  
                        break;
                    case ConsoleKey.D2:
                        currentColor = ConsoleColor.Green;  
                        break;
                    case ConsoleKey.D3:
                        currentColor = ConsoleColor.Blue;  
                        break;
                    */

                        case ConsoleKey.F1:
                            currentChar = '█';
                            break;
                        case ConsoleKey.F2:
                            currentChar = '▓';
                            break;
                        case ConsoleKey.F3:
                            currentChar = '▒';
                            break;
                        case ConsoleKey.F4:
                            currentChar = '░';
                            break;

                    }

                    //DrawCursor();  
                    ShowCurrentSettings();
                } while (key != ConsoleKey.Escape);
            }






        }
    }
}


