using Jonesify.MVM.Model;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jonesify.MVM.View_Model
{ 
   
  
    internal class MainViewModel
    {
       public ObservableCollection<Item> Songs { get; set; }
        public MainViewModel()
        {
            Songs = new ObservableCollection<Item>();
        }

        void PopulateCollection()
        {
            var client = new RestClient();
            client.Authenticator = new OAuth2AuthorizationRequestHeaderAuthenticator("");
        }
    }
}
