using Facade.Classes;
using Facade.Classes.Codec;
using Facade.Services;

namespace Facade
{
    public class SimpleConverter
    {
        private readonly VideoConverter _videoConverter;

        public SimpleConverter(VideoConverter videoConverter)
        {
            _videoConverter = videoConverter;
        }

        public VideoFile Convert(VideoFile file, string format)
        {
            Codec destinactionCodec;

            if (format == "MPEG4")
            {
                destinactionCodec = new MPEG4Codec();
            } else
            {
                destinactionCodec= new OGGCodec();
            }

            return _videoConverter.Convert(file, destinactionCodec);
        }
    }
}
