using DataObjects;
using MPDPRISM.Model;
using Newtonsoft.Json;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using Xamarin.Forms;

namespace MPDPRISM.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        public DelegateCommand IllList { get; set; }
        public MainPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Title = "Main Page";
            //var client = new HttpClient();
            //client.BaseAddress = new Uri("http://mobilepedia.azurewebsites.net");
            //var db = new MobileDbContext();
            //var symptoms = client.GetAsync("api/symptom").Result;
            //IEnumerable<Symptom> dsymptoms = JsonConvert.DeserializeObject<IEnumerable<Symptom>>(Convert.ToString(symptoms));
            
        }
    }
}
