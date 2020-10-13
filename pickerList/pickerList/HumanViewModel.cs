using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Xamarin.Forms;

namespace pickerList
{
    public class HumanViewModel : BaseViewModel
    {
        //public ObservableCollection<Human> Humans { get { return HumanData.Humans; } set { Humans = value; OnPropertyChanged("Humans"); } }
        //private ObservableCollection<Human> _Humans;
        //public ObservableCollection<Human> Humans
        //{
        //    get { return _Humans; }
        //    set
        //    {
        //        _Humans = value;
        //        OnPropertyChanged("Humans");
        //    }
        //}
        public ObservableCollection<Human> Results { get; set; }

        // The Result property
        private Human result;

        public Human Result
        {
            get { return result; }
            set
            {
                result = value;
                OnPropertyChanged("Result");

            }
        }
        Human selectedHuman;
        public Human SelectedHuman
        {
            get { return selectedHuman; }
            set
            {
                if (SelectedHuman != value)
                {
                    selectedHuman = value;
                    OnPropertyChanged();
                }
            }
        }
        public ICommand AddLabel => new Command(() => AddMe());
        public HumanViewModel()
        {
            Results = new ObservableCollection<Human>();
        }
        private void AddMe()
        {

            Results.Add(new Human
            {
                Name = "a",
                Location = "astern Africa (Middle AwaEsh Valley, Ethiopia)",
                Details = "s bipedal (walked upright), probably similar in body and brain size to a modern chimpanzee, and had canines that resemble those in later hominins but that still project beyond the tooth row. ",
                ImageUrl = "https://i.pinimg.com/originals/47/ea/3b/47ea3b98a3a4bbd66a0cf054cca1cdd3.jpg"
            });

        }
    }

}
public class Human
{
    public string Name { get; set; }
    public string Location { get; set; }
    public string Details { get; set; }
    public string ImageUrl { get; set; }
}