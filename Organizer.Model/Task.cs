﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;


namespace Organizer.Model
{
    [DataContract]
    public class Task
    {
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Description { get; set; }
        [DataMember]
        public TaskStatus Status { get; set; }

        
    }

    [DataContract]
    public enum TaskStatus
    {
        [EnumMember]
        New,
        [EnumMember]
        InProgress,
        [EnumMember]
        Closed
    }
}
