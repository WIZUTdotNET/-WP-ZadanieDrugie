using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using ZadanieDrugie.ViewModels;

namespace ZadanieDrugie {
    public partial class DetailsPage : PhoneApplicationPage {
        public DetailsPage() {
            InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e) {
            if (DataContext == null) {
                string selectedAnimal = "";
                string animalGroup = "";
                if (NavigationContext.QueryString.TryGetValue("selectedAnimal", out selectedAnimal) && NavigationContext.QueryString.TryGetValue("animalGroup", out animalGroup))
                {
                    if (App.ViewModel != null)
                    {
                        switch (animalGroup)
                        {
                            case "Land":
                                DataContext = App.ViewModel.LandAnimals.Animals.FirstOrDefault(p => selectedAnimal != null && p.Name == selectedAnimal);
                                break;
                            case "Water":
                                DataContext = App.ViewModel.WaterAnimals.Animals.FirstOrDefault(p => selectedAnimal != null && p.Name == selectedAnimal);
                                break;
                            case "Air":
                                DataContext = App.ViewModel.AirAnimals.Animals.FirstOrDefault(p => selectedAnimal != null && p.Name == selectedAnimal);
                                break;
                            default:
                                break;
                        }
                    }
                }
            }
        }
    }
}