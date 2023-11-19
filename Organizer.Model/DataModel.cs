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
        public IEnumerable<Souvenir> Souvenirs { get; set; }
        [DataMember]
        public IEnumerable<EBook> EBooks { get; set; }
        [DataMember]
        public IEnumerable<Book> Books { get; set; }
        public DataModel()
        {
            Souvenirs = new List<Souvenir>()
            {
                new Souvenir()
                {
                    Name = "Enter new task here", Price = 90, Amount = 100
                }
            };
            EBooks = new List<EBook>()
            {
                new EBook()
            };
            Books = new List<Book>()
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
