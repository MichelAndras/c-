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

            static void Main()
            {
                ConsoleKey key;
                Console.Clear();
                DrawCursor();

                do
                {
                    key = Console.ReadKey(true).Key;  
                    switch (key)
                    {
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
                        case ConsoleKey.Spacebar:
                            Console.SetCursorPosition(cursorX, cursorY);
                            Console.ForegroundColor = currentColor;  
                            Console.Write(currentChar);  
                            break;
                        case ConsoleKey.D1:
                            currentColor = ConsoleColor.Red;  
                            break;
                        case ConsoleKey.D2:
                            currentColor = ConsoleColor.Green;  
                            break;
                        case ConsoleKey.D3:
                            currentColor = ConsoleColor.Blue;  
                            break;
                        case ConsoleKey.D4:
                            currentChar = '█';  
                            break;
                        case ConsoleKey.D5:
                            currentChar = '▓';  
                            break;
                        case ConsoleKey.D6:
                            currentChar = '▒';  
                            break;
                        case ConsoleKey.D7:
                            currentChar = '░';  
                            break;
                    }

                    DrawCursor();  
                    ShowCurrentSettings();  
                } while (key != ConsoleKey.Escape);  
            }

            
            static void DrawCursor()
            {
                Console.SetCursorPosition(cursorX, cursorY);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write('0'); 
                Console.SetCursorPosition(cursorX, cursorY);
            }

            
            static void ShowCurrentSettings()
            {
                Console.SetCursorPosition(0, Console.WindowHeight - 1);
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write($"Current Color: {currentColor}, Current Char: {currentChar}   "); 
                Console.SetCursorPosition(cursorX, cursorY);
            }
        }
    }
}
    

