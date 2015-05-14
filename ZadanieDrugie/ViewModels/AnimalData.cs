using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadanieDrugie.ViewModels {
    public class AnimalData {
        public string Name { get; set; }
        public string Weight { get; set; }
        public string Size { get; set; }
        public string LifeSpan { get; set; }
        public List<AnimalPicture> Pictures { get; set; }

        public AnimalData() {
            Pictures = new List<AnimalPicture>();
        }
    }
}
