using RoBATStateViz.Assets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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

namespace RoBATStateViz
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void IncButton_Click(object sender, RoutedEventArgs e)
        {
            StateViz.State += 1;
            UpdateInputs(StateViz.State);
            UpdateOutputs(StateViz.State);
        }

        private void DecButton_Click(object sender, RoutedEventArgs e)
        {
            StateViz.State -= 1;
            UpdateInputs(StateViz.State);
            UpdateOutputs(StateViz.State);
        }

        private void UpdateInputs(int enabledIndex)
        {
            Type myType = typeof(RoBATInputs);

            for (int i = 1; i <= 8; i++)
            {
                PropertyInfo myPropInfo = myType.GetProperty($"Input{i}");
                myPropInfo?.SetValue(InputsViz, i == enabledIndex, null);
            }
        }

        private void UpdateOutputs(int enabledIndex)
        {
            Type myType = typeof(RoBATOutputs);

            for (int i = 1; i <= 8; i++)
            {
                PropertyInfo myPropInfo = myType.GetProperty($"Output{i}");
                myPropInfo?.SetValue(OutputsViz, i == enabledIndex, null);
            }
        }
    }
}
