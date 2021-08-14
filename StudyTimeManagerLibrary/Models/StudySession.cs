using System.ComponentModel;

namespace StudyTimeManagerLibrary.Models
{
    /// <summary>
    /// Represents a study session
    /// </summary>
    class StudySession : INotifyPropertyChanged
    {
        private Module? module;
        private DayOfWeek day;
        private decimal duration;

        /// <summary>
        /// Module of study session
        /// </summary>
        public Module? Module
        {
            get => module;
            set { module = value; OnPropertyChanged("Module"); }
        }

        /// <summary>
        /// Day of study session
        /// </summary>
        public DayOfWeek Day 
        { 
            get => day;
            set { day = value; OnPropertyChanged("Day"); } 
        }

        /// <summary>
        /// Duration of study session
        /// </summary>
        public decimal Duration
        {
            get => duration;
            set { duration = value; OnPropertyChanged("Duration"); }
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        /// <summary>
        /// Helper method to call PropertyChanged EventHander
        /// </summary>
        /// <param name="propertyName">Name of property which is changing</param>
        private void OnPropertyChanged(string propertyName)
        {
            //if PropertyChanged Event is not null invoke 
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
