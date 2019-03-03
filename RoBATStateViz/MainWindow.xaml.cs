using System;
using System.Diagnostics;
using System.Reflection;
using System.Windows;
using System.Windows.Threading;
using RoBATStateViz.Assets;
using RoBATStateViz.Helpers;

namespace RoBATStateViz
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string windowTitle;
        private DispatcherTimer dispatcherTimer;

        public MainWindow()
        {
            InitializeComponent();

            windowTitle = Title;
            dispatcherTimer = new DispatcherTimer();
            dispatcherTimer.Tick += (s, e) =>
            {
                var uptime = DateTime.Now - Process.GetCurrentProcess().StartTime;
                Title = $"{windowTitle} [{uptime.ToCompactPrettyString()}]";
            };
            dispatcherTimer.Interval = new TimeSpan(0, 0, 5);
            dispatcherTimer.Start();
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
