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
        public void LoadData() {
            LandAnimals = LoadLandAnimals();
            AirAnimals = LoadAirAnimals();
            WaterAnimals = LoadWaterAnimals();

            IsDataLoaded = true;
        }

        private AnimalGroup LoadWaterAnimals() {
            AnimalGroup data = new AnimalGroup();
            data.GroupName = "Water";

            data.Animals.Add(new AnimalData {
                Name = "Blue Whale",
                Size = "Length: 30 metres",
                Weight = "Weight: 190 tonnes",
                LifeSpan = "Life span: 90 years",
                Pictures = new List<AnimalPicture> {
                        new AnimalPicture{FileName = basePath + data.GroupName + "/Whale/Whale1.jpg"},
                        new AnimalPicture{FileName = basePath + data.GroupName + "/Whale/Whale2.jpg"},
                        new AnimalPicture{FileName = basePath + data.GroupName + "/Whale/Whale3.jpg"}
                    }
            });

            data.Animals.Add(new AnimalData {
                Name = "Shark",
                Size = "Max length: 20 metres",
                Weight = "Weight up to 12 tonnes",
                LifeSpan = "Average lifetime: 25 years",
                Pictures = new List<AnimalPicture> {
                        new AnimalPicture{FileName = basePath + data.GroupName + "/Shark/Shark1.jpg"},
                        new AnimalPicture{FileName = basePath + data.GroupName + "/Shark/Shark2.jpg"},
                        new AnimalPicture{FileName = basePath + data.GroupName + "/Shark/Shark3.jpg"}
                    }
            });

            data.Animals.Add(new AnimalData {
                Name = "Killer Whale",
                Size = "Length: 7 to 9 metres",
                Weight = "Weight: 6 tonnes",
                LifeSpan = "Life span: ca 50 years",
                Pictures = new List<AnimalPicture> {
                        new AnimalPicture{FileName = basePath + data.GroupName + "/KillerWhale/KillerWhale1.jpg"},
                        new AnimalPicture{FileName = basePath + data.GroupName + "/KillerWhale/KillerWhale2.jpg"},
                        new AnimalPicture{FileName = basePath + data.GroupName + "/KillerWhale/KillerWhale2.jpg"}
                    }
            });

            return data;
        }

        private AnimalGroup LoadAirAnimals() {
            AnimalGroup data = new AnimalGroup();
            data.GroupName = "Air";

            data.Animals.Add(new AnimalData {
                Name = "Eagle",
                Size = "Typical wingspan: 1.8 - 2.3 metres",
                Weight = "Weight: 3 - 6.3 kg",
                LifeSpan = "Average lifespan: 20 y",
                Pictures = new List<AnimalPicture> {
                        new AnimalPicture{FileName = basePath + data.GroupName + "/Eagle/Eagle1.jpg"},
                        new AnimalPicture{FileName = basePath + data.GroupName + "/Eagle/Eagle2.jpg"},
                        new AnimalPicture{FileName = basePath + data.GroupName + "/Eagle/Eagle3.jpg"}
                    }
            });

            data.Animals.Add(new AnimalData {
                Name = "Hummingbird",
                Size = "Size: 6 - 22 cm",
                Weight = "Weight: 2 - 20 g",
                LifeSpan = "Average lifespan: 3 - 5 y",
                Pictures = new List<AnimalPicture> {
                        new AnimalPicture{FileName = basePath + data.GroupName + "/Hummingbird/Hummingbird1.jpg"},
                        new AnimalPicture{FileName = basePath + data.GroupName + "/Hummingbird/Hummingbird2.jpg"},
                        new AnimalPicture{FileName = basePath + data.GroupName + "/Hummingbird/Hummingbird3.jpg"}
                    }
            });

            return data;
        }

        private AnimalGroup LoadLandAnimals() {
            AnimalGroup data = new AnimalGroup();
            data.GroupName = "Land";

            data.Animals.Add(new AnimalData {
                Name = "Elephant",
                Size = "Weight: 7 tonnes",
                Weight = "Height: 4 metres",
                LifeSpan = "Lifespan: 60-70 y",
                Pictures = new List<AnimalPicture> {
                        new AnimalPicture{FileName = basePath + data.GroupName + "/Elephant/Elephant1.jpg"},
                        new AnimalPicture{FileName = basePath + data.GroupName + "/Elephant/Elephant2.jpg"},
                        new AnimalPicture{FileName = basePath + data.GroupName + "/Elephant/Elephant3.jpg"}
                    }
            });

            data.Animals.Add(new AnimalData {
                Name = "Lion",
                Size = "Total length: 350 cm",
                Weight = "Male weight: 150–250 kg",
                LifeSpan = "Male lifetime: ca. 10 y",
                Pictures = new List<AnimalPicture> {
                        new AnimalPicture{FileName = basePath + data.GroupName + "/Lion/Lion1.jpg"},
                        new AnimalPicture{FileName = basePath + data.GroupName + "/Lion/Lion2.jpg"},
                        new AnimalPicture{FileName = basePath + data.GroupName + "/Lion/Lion3.jpg"}
                    }
            });

            return data;
        }
    }
}