using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLocatorPattern.AudioPlayerFactory
{
    public class ApplicationFacade
    {
        AudioFile _AudioFile = null;
        IPlaybackService playBackService = null;

        public ApplicationFacade(AudioFile file)
        {
            _AudioFile = file;
        }

        public void Play()
        {
            Console.WriteLine("Requesting playback for {0}", _AudioFile.Title);
            playBackService = ServiceLocatorPattern.GetService<IPlaybackService>();

        }
    }
}
