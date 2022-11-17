using Facade.Classes;
using Facade.Classes.Codec;
using Facade.Constants;

namespace Facade.Services
{
    public class VideoConverter
    {
        public VideoFile Convert(VideoFile file, Codec codec)
        {
            return new VideoFile(file.Name,
                codec.Name == Codecs.MP4 ? Codecs.MP4 : Codecs.OGG);
        }
    }
}
