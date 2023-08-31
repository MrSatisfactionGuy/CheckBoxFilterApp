using CheckBoxFilterApp.Classes;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace CheckBoxFilterApp.Controller
{
    internal class SerialziationController
    {
        private readonly string fileName = "test.xml";

        //private readonly string localPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

        public bool SerializeLocal(List<TelemetryDataDTO> savingList, string persistPath)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<TelemetryDataDTO>));
            //FileInfo fileInfo = new FileInfo();
            string fullPath = Path.Combine(persistPath, fileName);
            using (StreamWriter sw = new StreamWriter(fullPath))
            {
                xmlSerializer.Serialize(sw, savingList);
            }

            return true;
        }

        public List<TelemetryDataDTO> ReadFromLocal(string persistPath)
        {
            List<TelemetryDataDTO> readedList = new List<TelemetryDataDTO> ();
            XmlSerializer xml = new XmlSerializer(typeof(List<TelemetryDataDTO>));
            string fullPath = Path.Combine(persistPath, fileName);

            using (Stream stream = new FileStream(fullPath, FileMode.Open, FileAccess.Read, FileShare.Read))
            {
                return readedList = (List<TelemetryDataDTO>)xml.Deserialize(stream);
                //return readedList;
            }

            return readedList;
        }



        
    
    }
}
