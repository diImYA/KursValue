using System;

namespace Game
{
    class Home
    {
         MenuChoise choise = new MenuChoise();
         Settings set = new Settings();
         public  void HomeSelect()
        {
            while(true)
            {
            string[] menu = {"START GAME","Settings","Exit"};

            int select = choise.Menu(menu);

            if(select == 0) Console.WriteLine("Comming soon");
            else if(select == 1) set.Options();
            else if(select == 2) Environment.Exit(0);
            }
        } 
            
    }
        
 }
