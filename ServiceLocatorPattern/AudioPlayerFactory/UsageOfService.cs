using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLocatorPattern.AudioPlayerFactory
{
    public class UsageOfService
    {
        IPlaybackService playbackService = new DXPlaybackService();

        public UsageOfService()
        {
            ServiceLocatorPattern.Register<IPlaybackService>(playbackService);
        }
        
        public void NowPlay()
        {
            AudioFile file = new AudioFile { Title = "Haaa", FilePath = "C:\\temp.wave" };

            ApplicationFacade facad = new ApplicationFacade(file);
            facad.Play();
            Console.ReadLine();
        }

    }
}
