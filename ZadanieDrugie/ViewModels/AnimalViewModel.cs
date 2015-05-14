using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadanieDrugie.ViewModels {
    public class AnimalViewModel {
        string basePath = "Assets/Animals/";

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

        private AnimalGroup LoadWaterAnimals()
        {
            AnimalGroup data = new AnimalGroup();
            data.GroupName = "Water";

            data.Animals.Add(new AnimalData {
                    Name = "Blue Whale",
                    Size = "Length: 30 metres",
                    Weight = "Weight: 190 tonnes",
                    LifeSpan = "Life span: 90 years",
                    Pictures = new List<AnimalPicture> {
                        new AnimalPicture(basePath + "Whale/Whale1.jpg"),
                        new AnimalPicture(basePath + "Whale/Whale2.jpg"),
                        new AnimalPicture(basePath + "Whale/Whale3.jpg")
                    }});

            return data;
        }
        

        private AnimalGroup LoadAirAnimals() {
            throw new NotImplementedException();
        }

        private AnimalGroup LoadLandAnimals() {
            throw new NotImplementedException();
        }



    }
}
