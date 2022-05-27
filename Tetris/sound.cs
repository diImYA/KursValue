using System;
using NAudio.Wave;

namespace Game
{
    class Sound
    {
        
        public bool SoundPlay()
        {
            using(var audioFile = new AudioFileReader(@"C:\Users\gurin\Downloads\sa.mp4"))
            using(var outputDevice = new WaveOutEvent())
            {
                outputDevice.Init(audioFile);
                outputDevice.Play();
                
                
                while (outputDevice.PlaybackState == PlaybackState.Playing)
                {
                    Thread.Sleep(1000);
                }
            }
            return true;
        }
        public void SoundStop()
        {
            WaveOutEvent outs = new WaveOutEvent();
            outs.Stop();
        }
        public void SoundPause()
        {
            WaveOutEvent outs = new WaveOutEvent();
            outs.Pause();
        }
        
    }
}