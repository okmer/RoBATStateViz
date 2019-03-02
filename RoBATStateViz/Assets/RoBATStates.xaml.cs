using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

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
