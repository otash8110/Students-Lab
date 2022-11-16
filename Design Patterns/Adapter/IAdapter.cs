using System.Text.Json;
using System.Xml;

namespace Adapter
{
    public interface IAdapter
    {
        JsonDocument GetResult(XmlDocument book);
    }
}
