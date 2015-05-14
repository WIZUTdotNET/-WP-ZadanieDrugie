using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadanieDrugie.ViewModels {
    public class AnimalViewModel {

        public AnimalGroup LandAnimals { get; set; }
        public AnimalGroup AirAnimals { get; set; }
        public AnimalGroup WaterAnimals { get; set; }

        public bool IsDataLoaded { get; private set; }
        public void LoadData()
        {
            LandAnimals = LoadLandAnimals();
            AirAnimals = LoadAirAnimals();
            WaterAnimals = LoadWaterAnimals();

            IsDataLoaded = true;
        }

        private AnimalGroup LoadWaterAnimals() {
            throw new NotImplementedException();
        }

        private AnimalGroup LoadAirAnimals() {
            throw new NotImplementedException();
        }

        private AnimalGroup LoadLandAnimals() {
            throw new NotImplementedException();
        }



    }
}
