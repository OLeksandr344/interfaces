using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace int2
{
    internal class MusicTrack : IPlayable, IRecordable
    {
        public string Title { get; set; }
        public string Artist { get; set; }
        public double Duration { get; set; }
        public MusicTrack(string title, string artist, double duration)
        {
            Title = title;
            Artist = artist;
            Duration = duration;
        }

        public void Play()
        {
            Console.WriteLine($"{Title} by {Artist} is playing. {Duration} ");
        }

        public void Pause()
        {
            Console.WriteLine($"{Title} by {Artist} is paused.");
        }

        public void Stop()
        {
            Console.WriteLine($"{Title} by {Artist} is stoped.");
        }

        public void Record()
        {
            Console.WriteLine($"{Title} by {Artist} is recorded.");
        }
    }
}
