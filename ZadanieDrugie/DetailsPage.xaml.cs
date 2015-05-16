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
                if (NavigationContext.QueryString.TryGetValue("selectedAnimal", out selectedAnimal)) {
                    if (App.ViewModel != null) {
                        DataContext =
                            App.ViewModel.LandAnimals.Animals.Concat(App.ViewModel.AirAnimals.Animals)
                                .Concat(App.ViewModel.WaterAnimals.Animals)
                                .FirstOrDefault(p => selectedAnimal != null && p.Name == selectedAnimal);
                    }
                }
            }
        }
    }
}