using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;


namespace Organizer.Model.Serialization
{
    public class DataSerializer
    {
        public static void SerializeData(string fileName, DataModel data)
        {
            // create an instance of the type and serialize it
            var formatter = new DataContractSerializer(typeof(DataModel));
            // open stream for file and create if file does not exist
            var s = new FileStream(fileName, FileMode.Create);
            formatter.WriteObject(s, data);
            s.Close();
        }
        // read data from file
        public static DataModel DeserializeItem(string fileName)
        {
            var s = new FileStream(fileName, FileMode.Open);
            var formatter = new DataContractSerializer(typeof(DataModel));
            return (DataModel)formatter.ReadObject(s);
        }
    }
}
