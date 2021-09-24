﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace UnusArmatusLattro.Views
{
    /// <summary>
    /// Interaction logic for GameOverView.xaml
    /// </summary>
    public partial class GameOverView : UserControl
    {
        Storyboard story = new Storyboard();
        public GameOverView()
        {
            InitializeComponent();
            ColorAnimation color = new ColorAnimation();
            color.From = Colors.Yellow;
            color.To = Colors.Red;
            color.Duration = TimeSpan.FromSeconds(.2);
            color.RepeatBehavior = RepeatBehavior.Forever;
            color.AutoReverse = true;
            
            story.Children.Add(color);
            Storyboard.SetTarget(color, Border);
            Storyboard.SetTargetProperty(color, new PropertyPath("(Border.BorderBrush).(SolidColorBrush.Color)"));

        }

        private void Load(object sender, RoutedEventArgs e)
        {
            txtUserName.Focus();
        }

        private void TextboxGotFocus(object sender, RoutedEventArgs e)
        {
            story.Begin();
        }

        private void TextboxLostFocus(object sender, RoutedEventArgs e)
        {
            story.Stop();
        }
    }
}
