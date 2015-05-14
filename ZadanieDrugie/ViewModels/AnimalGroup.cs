using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadanieDrugie.ViewModels {
    public class AnimalGroup {
        public string GroupName { get; set; }
        public List<AnimalData> Animals { get; set; }

        public AnimalGroup()
        {
            Animals = new List<AnimalData>();
        }
    }
}
