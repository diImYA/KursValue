using System;
using System.Drawing;
namespace Game
{
    public class ProgramTetris
    {
        
        static void Main()
        {
            
            Sound song = new Sound();
            Home home = new Home();
            song.SoundPlay();
            home.HomeSelect();
            Console.ReadKey();
        
             
            
        }

    }
}