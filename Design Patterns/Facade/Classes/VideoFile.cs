namespace Facade.Classes
{
    public class VideoFile
    {
        public string Name { get; set; }
        public string Codec { get; set; }

        public VideoFile(string name, string codec)
        {
            Name = name;
            Codec = codec;
        }

        public string GetName()
        {
            return $"{Name}.{Codec}";
        }
    }
}
