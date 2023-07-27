using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD_Test
{
    public class Main_VM : INotifyPropertyChanged
    {
        public Main_VM()
        {
            People = new ObservableCollection<Person>();
            People.CollectionChanged += ListView_OC_Changed;
            People.Add(new Person("1", "Lilly", "Fox"));
            People.Add(new Person("2", "Ryan", "Bloggs"));
            People.Add(new Person("3", "Len", "White"));
            People.Add(new Person("4", "Liam", "Lister"));
        }


        public void ListView_OC_Changed(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.Action == System.Collections.Specialized.NotifyCollectionChangedAction.Remove)
            {
                foreach (Person item in e.OldItems)
                {
                    //Removed items
                    item.PropertyChanged -= ListView_OC_PropChanged;
                }
            }
            else if (e.Action == NotifyCollectionChangedAction.Add)
            {
                foreach (Person item in e.NewItems)
                {
                    //Added items
                    item.PropertyChanged += ListView_OC_PropChanged;
                }
            }
        }

        public void ListView_OC_PropChanged(object sender, PropertyChangedEventArgs e)
        {
            //This will get called when the property of an object inside the collection changes
            Debug.WriteLine($"Prop Changed... {e.PropertyName}");
        }

        private ObservableCollection<Person> _fn;
        public ObservableCollection<Person> People
        {
            get { return _fn; }
            set { _fn = value; OnPropertyChanged("People"); }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string name)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(name));
            }
        }
    }
}
