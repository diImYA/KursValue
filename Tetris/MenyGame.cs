using System;

namespace Game
{
    class MenuChoise
    {
        
        public int Menu(string[] array)
        {
            
            int cursorTop = Console.CursorTop;
            int selectMenu = 0;
            while(true)
            {
            Console.CursorTop = cursorTop;
            Console.CursorLeft = 0;
            Console.CursorVisible = false;

            for(int i = 0;i < array.Length;i++)
            {
                if (selectMenu == i)
                {
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Black;
                }
                Console.WriteLine(array[i]);
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
            }
                ConsoleKey currentKey = Console.ReadKey(true).Key;

                if(currentKey == ConsoleKey.Enter)
                {
                    Console.CursorVisible = true;
                    
                    return selectMenu;
                }
                else if(currentKey == ConsoleKey.DownArrow) selectMenu++;
                else if (currentKey == ConsoleKey.UpArrow) selectMenu--;

                if(selectMenu < 0)selectMenu = array.Length - 1;
                else if (selectMenu == array.Length) selectMenu = 0;
            }
            
        }
    }
}