using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Controls;

namespace RoBATStateViz.Assets
{
    /// <summary>
    /// Interaction logic for RoBATInputs.xaml
    /// </summary>
    public partial class RoBATInputs : UserControl, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private bool[] inputs = new bool[8];

        public bool Input1
        {
            get => inputs[0];
            set
            {
                inputs[0] = value;
                OnPropertyChanged();
            }
        }

        public bool Input2
        {
            get => inputs[1];
            set
            {
                inputs[1] = value;
                OnPropertyChanged();
            }
        }

        public bool Input3
        {
            get => inputs[2];
            set
            {
                inputs[2] = value;
                OnPropertyChanged();
            }
        }

        public bool Input4
        {
            get => inputs[3];
            set
            {
                inputs[3] = value;
                OnPropertyChanged();
            }
        }

        public bool Input5
        {
            get => inputs[4];
            set
            {
                inputs[4] = value;
                OnPropertyChanged();
            }
        }

        public bool Input6
        {
            get => inputs[5];
            set
            {
                inputs[5] = value;
                OnPropertyChanged();
            }
        }

        public bool Input7
        {
            get => inputs[6];
            set
            {
                inputs[6] = value;
                OnPropertyChanged();
            }
        }

        public bool Input8
        {
            get => inputs[7];
            set
            {
                inputs[7] = value;
                OnPropertyChanged();
            }
        }

        public RoBATInputs()
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
