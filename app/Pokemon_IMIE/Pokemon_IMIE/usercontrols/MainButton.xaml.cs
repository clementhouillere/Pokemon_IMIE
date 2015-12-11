﻿using Pokemon_IMIE.Pages;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The User Control item template is documented at http://go.microsoft.com/fwlink/?LinkId=234236

namespace Pokemon_IMIE.usercontrols
{
    public sealed partial class MainButton : UserControl
    {
        public MainButton()
        {
            this.InitializeComponent();
            this.DataContext = this;
        }

        public String Label
        {
            get { return (string)GetValue(LabelProperty);}
            set { SetValue(LabelProperty, value); }
        }

        public static readonly DependencyProperty LabelProperty =
            DependencyProperty.Register("Label", typeof(string), typeof(MainButton), null);

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Tapped(object sender, TappedRoutedEventArgs e)
        {
           String name = ((Page)((Frame) Window.Current.Content).Content).Name;
            switch (name)
            {
                case "page1":
                    (Window.Current.Content as Frame).Navigate(typeof(CreateUser));
                    break;               
            }
        }
    }
}
