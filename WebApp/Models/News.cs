using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models
{
    public class News
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string TitleGeo { get; set; }
        public string Description { get; set; }
        public string DesctiptionGeo { get; set; }
        public string Tumb { get; set; }

        public string Slag { get; set; }
        public string lang { get; set; }

    }
}
