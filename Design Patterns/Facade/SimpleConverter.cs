﻿using Facade.Classes;
using Facade.Classes.Codec;
using Facade.Constants;
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
            Codec destinationCodec = format == Codecs.MP4 ? new MPEG4Codec() : new OGGCodec();

            return _videoConverter.Convert(file, destinationCodec);
        }
    }
}
