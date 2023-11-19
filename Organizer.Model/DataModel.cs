using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.IO;
using Organizer.Model.Serialization;

namespace Organizer.Model
{
    [DataContract]
    public class DataModel
    {
        [DataMember]
        public IEnumerable<Task> Tasks { get; set; }
        [DataMember]
        public IEnumerable<Project> Projects { get; set; }
        [DataMember]
        public IEnumerable<Book> Events { get; set; }
        public DataModel()
        {
            Tasks = new List<Task>()
            {
                new Task()
                {
                    Name = "Enter new task here", Description = "Enter some description", Status = TaskStatus.New
                }
            };
            Projects = new List<Project>()
            {
                new Project()
            };
            Events = new List<Book>()
            {
                new Book()
            };
        }

        public static string DataPath = "organizer.dat";

        public static DataModel Load()
        {
            if (File.Exists(DataPath))
            {
                return DataSerializer.DeserializeItem(DataPath);
            }
            return new DataModel();
        }

        public void Save()
        {
            DataSerializer.SerializeData(DataPath, this);
        }
    }
}
