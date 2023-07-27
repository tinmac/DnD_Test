using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD_Test
{
    public class Person : INotifyPropertyChanged
    {
        public Person(string index, string first, string last)
        {
            Index = index;
            FirstName = first;
            LastName = last;
        }

        private string _Index;
        public string Index
        {
            get { return _Index; }
            set { _Index = value; OnPropertyChanged("Index"); }
        }


        private string _FirstName;
        public string FirstName
        {
            get { return _FirstName; }
            set { _FirstName = value; OnPropertyChanged("FirstName"); }
        }


        private string _LastName;
        public string LastName
        {
            get { return _LastName; }
            set { _LastName = value; OnPropertyChanged("LastName"); }
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
