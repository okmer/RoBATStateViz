﻿using System;
using System.ComponentModel;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Shapes;

namespace RoBATStateViz.Assets
{
    /// <summary>
    /// Interaction logic for RoBATOutputs.xaml
    /// </summary>
    public partial class RoBATOutputs : UserControl, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private bool[] outputs = new bool[8];

        public bool Output1
        {
            get => outputs[0];
            set
            {
                outputs[0] = value;
                OnPropertyChanged();
            }
        }

        public bool Output2
        {
            get => outputs[1];
            set
            {
                outputs[1] = value;
                OnPropertyChanged();
            }
        }

        public bool Output3
        {
            get => outputs[2];
            set
            {
                outputs[2] = value;
                OnPropertyChanged();
            }
        }

        public bool Output4
        {
            get => outputs[3];
            set
            {
                outputs[3] = value;
                OnPropertyChanged();
            }
        }

        public bool Output5
        {
            get => outputs[4];
            set
            {
                outputs[4] = value;
                OnPropertyChanged();
            }
        }

        public bool Output6
        {
            get => outputs[5];
            set
            {
                outputs[5] = value;
                OnPropertyChanged();
            }
        }

        public bool Output7
        {
            get => outputs[6];
            set
            {
                outputs[6] = value;
                OnPropertyChanged();
            }
        }

        public bool Output8
        {
            get => outputs[7];
            set
            {
                outputs[7] = value;
                OnPropertyChanged();
            }
        }

        public RoBATOutputs()
        {
            InitializeComponent();
            DataContext = this;
        }

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private void EllipseO_MouseDown(object sender, MouseButtonEventArgs e)
        {
            var ellipse = sender as Ellipse;

            if (Keyboard.IsKeyDown(Key.LeftShift) && Keyboard.IsKeyDown(Key.LeftCtrl))
            {
                var dataContext = ellipse.DataContext;

                Type dcType = dataContext?.GetType();
                PropertyInfo dcPropInfo = dcType.GetProperty($"Output{ellipse.Name.Substring(ellipse.Name.Length - 1)}");

                bool? currentValue = dcPropInfo?.GetValue(dataContext) as bool?;

                dcPropInfo?.SetValue(dataContext, !currentValue.Value, null);
            }
        }
    }
}
