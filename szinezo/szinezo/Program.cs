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
            
            static void DrawBorder()
            {
                // Draw top border
                Console.Write("╔" + new string('═', Console.WindowWidth - 2) + "╗");

                // Draw sides
                for (int i = 1; i < Console.WindowHeight - 2; i++)
                {
                    Console.Write("║" + new string(' ', Console.WindowWidth - 2) + "║");
                }

                // Draw bottom border
                Console.Write("╚" + new string('═', Console.WindowWidth - 2) + "╝");
                Console.SetCursorPosition(0, 0);
            }
            static string[] buttons = { "Mentés", "Szerkeztés", "Törlés", "Kilépés" };

            static int selectedButtons = 0;
            static void DrawButtons()
            {
                


                int buttonWidth = 14;
                int buttonHeight = 4;
                int verticalSpacing = 2;

                int startX = (Console.WindowWidth - buttonWidth) / 2;
                int startY = (Console.WindowHeight - (buttons.Length * (buttonHeight + verticalSpacing))) / 2;

                for (int i = 0; i < buttons.Length; i++)
                {
                    int buttonPosY = startY + i * (buttonHeight + verticalSpacing);

                    Console.SetCursorPosition(startX, buttonPosY);
                    Console.Write('╔');
                    for (int j = 1; j <= buttonWidth - 2; j++)
                    {
                        Console.Write('═');
                    }
                    Console.Write('╗');

                    Console.SetCursorPosition(startX, buttonPosY + 1);
                    Console.Write('║');
                    
                     if (i  == selectedButtons)
                        {
                            Console.BackgroundColor = ConsoleColor.Gray;
                            Console.ForegroundColor = ConsoleColor.Black;
                        }
                        else
                        {
                            Console.ResetColor();
                        }
                        
                    int textPadding = (buttonWidth - buttons[i].Length - 2) / 2;
                    Console.Write(new string(' ', textPadding) + buttons[i] + new string(' ', buttonWidth - buttons[i].Length - 2 - textPadding));
                    Console.ResetColor();
                    Console.Write('║');

                    Console.SetCursorPosition(startX, buttonPosY + 2);
                    Console.Write('╚');
                    for (int j = 1; j <= buttonWidth - 2; j++)
                    {
                        Console.Write('═');
                    }
                    Console.Write('╝');
                }
            }
            static void NavigateButtons()
            {
                ConsoleKeyInfo buttonKey;
                do
                {
                    DrawButtons();
                    buttonKey = Console.ReadKey(true);
                    if (buttonKey.Key == ConsoleKey.UpArrow)
                    {
                        selectedButtons = (selectedButtons - 1 + buttons.Length) % buttons.Length;
                    }
                    else if (buttonKey.Key == ConsoleKey.DownArrow)
                    {
                        selectedButtons = (selectedButtons + 1) % buttons.Length;
                    }
                    else if (buttonKey.Key == ConsoleKey.Enter)
                    {
                        ButtonHandle(selectedButtons);
                    }
                    else if (buttonKey.Key == ConsoleKey.Escape)
                    {   
                        break;
                    }
                } while (true);
            }

            static void ButtonHandle(int buttonIndex)
            {
                switch (buttonIndex)
                {
                    case 0:
                        // Handle "Létrehozás" button click
                        break;
                    case 1:
                        // Handle "Módosítás" button click
                        break;
                    case 2:
                        // Handle "Törlés" button click
                        break;
                    case 3:
                        // Handle "Kilépés" button click
                        break;
                }
            }

            static void Main()
            {
                ConsoleKey key;
                Console.Clear();
                DrawCursor();
                

                DrawBorder();
                DrawButtons();
                NavigateButtons();
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


