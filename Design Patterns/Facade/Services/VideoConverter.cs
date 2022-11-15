using Facade.Classes;
using Facade.Classes.Codec;

namespace Facade.Services
{
    public class VideoConverter
    {
        public VideoFile Convert(VideoFile file, Codec codec)
        {
            return new VideoFile(file.Name,
                codec.GetType().Name == "MPEG4Codec" ? "mpeg4" : "ogg");
        }
    }
}
