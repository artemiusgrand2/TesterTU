using System.ComponentModel;

namespace TesterTU.Models
{
    public class ModelOutput : INotifyPropertyChanged
    {
        public bool IsOn { get; set; }

        int _value;

        public int Value
        {
            get
            {
                return _value;
            }
            set
            {
                _value = value;
                OnPropertyChanged("Value");
            }
        }

        public int Index { get; private set; }

        public ModelOutput(int index)
        {
            Index = index;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
