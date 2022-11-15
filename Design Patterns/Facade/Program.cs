using Facade.Classes;
using Facade.Constants;
using Facade.Services;

namespace Facade
{
    class Program
    {
        public static void Main(string[] args)
        {
            var videoConverter = new VideoConverter();
            var simpleConverter = new SimpleConverter(videoConverter);
            var videoFile = new VideoFile("VideoName", Codecs.OGG);

            var result = simpleConverter.Convert(videoFile, Codecs.MP4);

            Console.WriteLine(result.GetName());
        }
    }
}

