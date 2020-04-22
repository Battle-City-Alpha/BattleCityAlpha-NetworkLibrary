using BCA.Common.Enums;

namespace BCA.Common
{
    public class Customization
    {
        public CustomizationType CustomizationType { get; set; }
        public int Id { get; set; }
        public bool IsHost { get; set; }
        public string URL { get; set; }

        public Customization(CustomizationType type, int id, bool isHost, string url)
        {
            CustomizationType = type;
            Id = id;
            IsHost = isHost;
            URL = url;
        }

    }
}
