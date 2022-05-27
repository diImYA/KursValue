using System;

namespace Game
{
    class Settings
    {
         private MenuChoise choise = new MenuChoise();
         private Sound song = new Sound();
         private Home home = new Home();
         
        public void Options()
        {
             string[] set = {"Sound Play","Sound Pause","Sound Stop","Back"};
             int select = choise.Menu(set);
             
             if(select == 0 && song.SoundPlay() == false)
             song.SoundPlay();
             else if(select == 1) song.SoundPause();
             else if(select == 2) song.SoundStop();
             else if(select == 3) home.HomeSelect();
           
        }
            
    }
        
 }
