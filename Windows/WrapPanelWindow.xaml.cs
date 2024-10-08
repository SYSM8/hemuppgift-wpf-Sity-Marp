﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfAssignment
{
    /// <summary>
    /// Interaction logic for WrapPanelWindow.xaml
    /// </summary>
    public partial class WrapPanelWindow : Window
    {
        public WrapPanelWindow()
        {
            InitializeComponent();
        }

        private void VerticalBtn_Click(object sender, RoutedEventArgs e)
        {
            if (VerticalBtn.IsChecked == true )
            {
                EllipseWrapPanel.Orientation = Orientation.Vertical;
            }

        }

        private void HorizontalBtn_Click(object sender, RoutedEventArgs e)
        {
            if (HorizontalBtn.IsChecked == true )
            {
                EllipseWrapPanel.Orientation = Orientation.Horizontal;
            }

        }
    }
}
