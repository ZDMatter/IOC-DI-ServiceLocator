using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLocatorPattern.AudioPlayerFactory
{
    public interface IPlaybackService
    {
        void PlayFile(string filePath);
    }
}
