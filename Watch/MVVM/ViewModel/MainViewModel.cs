using System;
using System.ComponentModel;
using Watch.MVVM.Model;

namespace Watch.MVVM.ViewModel 
{
    class MainViewModel : INotifyPropertyChanged
    {
        private readonly System.Windows.Forms.Timer _timer = new System.Windows.Forms.Timer();

        private string _time;
        private string _day;
        private string _data;
        private string _batary;

        public string Time
        {
            get
            {
                return _time;
            }
            set
            {
                _time = value;
                OnPropertyChanged("Time");

            }
        }

        public string Day
        {
            get
            {
                return _day;
            }
            set
            {
                _day = value;
                OnPropertyChanged("Day");
            }
        }

        public string Data
        {
            get
            {
                return _data;
            }
            set
            {
                _data = value;
                OnPropertyChanged("Data");
            }
        }

        public string Batary
        {
            get
            {
                return _batary;
            }
            set
            {
                _batary = value;
                OnPropertyChanged("Batary");
            }
        }

        public MainViewModel()
        {
            startClock();
        }

        private void startClock()
        {
            _timer.Enabled = true;
            _timer.Tick += Timer_Tick;
            _timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            Time = MainModel.SetTime();
            Day = MainModel.SetDay();
            Data = MainModel.SetDate();
            Batary = MainModel.SetBataryLevel();
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
