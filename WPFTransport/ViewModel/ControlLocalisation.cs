using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WPFTransport.ViewModel
{
   

   public class ControlLocalisation : INotifyPropertyChanged
    
    {
      
        public ControlLocalisation()
        {
        }


        public string Coord { get { return "Latitude : " + Latitude + "Longitude : " + Longitude; } }

        public LignesEtArrets lignesEtArrets { get; set; }



       
            private string _latitude;
            private string _longitude;
            private string _rayon;
            private bool _isValid;

            public event PropertyChangedEventHandler PropertyChanged;

            public string Latitude
            {
                get
                {
                    return _latitude;
                }
                set
                {
                    if (_latitude != value)
                    {
                        _latitude = value;
                        OnPropertyChanged();
                        OnPropertyChanged("Coord");
                        SetIsValid();
                    }
                }
            }


            public string Longitude
            {
                get
                {
                    return _longitude;
                }
                set
                {
                    if (_longitude != value)
                    {
                        _longitude = value;
                        OnPropertyChanged();
                        OnPropertyChanged("Coord");
                        SetIsValid();
                    }
                }
            }

            public string Rayon
            {
                get
                {
                    return _rayon;
                }
                set
                {
                    if (_rayon != value)
                    {
                        _rayon = value;
                        OnPropertyChanged();
                        OnPropertyChanged("Coord");
                        SetIsValid();
                    }
                }
            }



            public bool IsValid
            {
                get
                {
                    return _isValid;
                }
                set
                {
                    if (_isValid != value)
                    {
                        _isValid = value;
                        OnPropertyChanged();
                    }
                }
            }

         
            private void SetIsValid()
            {
                IsValid = !string.IsNullOrEmpty(Longitude) && !string.IsNullOrEmpty(Latitude) && !string.IsNullOrEmpty(Rayon);
            }

          
            private void OnPropertyChanged([CallerMemberName] string propertyName = "")
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
        




    }
}
