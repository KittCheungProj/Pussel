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

namespace Puzzle_jigsaw
{
    /// <summary>
    /// Interaction logic for Puzzle_Pieces.xaml
    /// </summary>
    public partial class Puzzle_Pieces : Window
    {
        public Puzzle_Pieces()
        {
            InitializeComponent();
        }

        private void PuzzleImage_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void okBtn(object sender, RoutedEventArgs e)
        {
            this.Hide();
        }
    }
}
