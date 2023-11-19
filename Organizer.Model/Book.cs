using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;


namespace Organizer.Model
{
    [DataContract]
    public class Book
    {
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Author { get; set; }
        [DataMember]
        public int Pages { get; set; }
        [DataMember]
        public int Price { get; set; }

        [DataMember]
        public int Amount { get; set; }
        [DataMember]
        public ItemStatus Status { get; set; }
    }

    [DataContract]
    public enum ItemStatus
    {
        [EnumMember]
        Liked,
        [EnumMember]
        NotLiked
    }
}
