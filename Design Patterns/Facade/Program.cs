
using Facade.Classes;
using Facade.Services;

namespace Facade
{
    class Program
    {
        public static void Main(string[] args)
        {
            var videoConverter = new VideoConverter();
            var simpleConverter = new SimpleConverter(videoConverter);
            var videoFile = new VideoFile("VideoName.ogg");

            var result = simpleConverter.Convert(videoFile, "MPEG4");
        }
    }

}

