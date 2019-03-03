using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Controls;

namespace RoBATStateViz.Assets
{
    /// <summary>
    /// Interaction logic for RoBATStates.xaml
    /// </summary>
    public partial class RoBATStates : UserControl, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private int state;
        public int State
        {
            get => state;
            set
            {
                state = value;
                OnPropertyChanged();
            }
        }

        public RoBATStates()
        {
            InitializeComponent();
            DataContext = this;
        }

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
