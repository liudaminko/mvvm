using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;


namespace Organizer.Model
{
    [DataContract]
    public class Souvenir
    {
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public int Price { get; set; }
        [DataMember]
        public int Amount { get; set; }
        [DataMember]
        public ItemStatus status { get; set; }

    } 
}
