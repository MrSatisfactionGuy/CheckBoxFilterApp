using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckBoxFilterApp.Classes
{
    public class TelemetryDataDTO
    {
        public TelemetryDataDTO()
        {
            Application = string.Empty;
            Function = string.Empty;
            Description = string.Empty;
            CreateTime = DateTime.MinValue;
            //Application = "StringApplication";
            //Function = "StringFunction";
            //Description = "StringDescription";
            //CreateTime = DateTime.Now;
        }

        public TelemetryDataDTO(string application, string function, string description, DateTime createDate)
        {
            this.Application = application;
            this.Function = function;
            this.Description = description;
            this.CreateTime = createDate;
        }

        public string Application { get; set; }
        public string Function { get; set; }
        public string Description { get; set; }
        public DateTime CreateTime { get; set; }

    }
}
