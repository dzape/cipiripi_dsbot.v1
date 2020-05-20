using System.Collections.Generic;
using System.Runtime.Serialization;

namespace cipiripi_discord_bot.Data
{
    [DataContract]
    class GamesData
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string Title { get; set; }        
        
        [DataMember]
        public List<string> Genres { get; set; }

        public override string ToString()
        {
            return $"{Title} ({string.Join(",", Genres)})";
        }
    }
}

