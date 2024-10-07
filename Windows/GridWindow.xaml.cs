using System;
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
    /// Interaction logic for GridWindow.xaml
    /// </summary>
    public partial class GridWindow : Window
    {
        public GridWindow()
        {
            InitializeComponent();
        }

        private void MoveRowButtonBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int row = Convert.ToInt32(RowInputTextBox.Text);
                int column = Convert.ToInt32(ColumnInputTextBox.Text);

                if (row >= 0 && row < 4 && column >= 0 && column < 4)
                {
                    Grid.SetColumn(MovingButton, column);
                    Grid.SetRow(MovingButton, row);

                    MovingButton.Content = $"Row {row} Column {column}";

                    if (MovingButton.Visibility == Visibility.Collapsed)
                    {
                        MovingButton.Visibility = Visibility.Visible;
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a row & column number between 0 to 3", "error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("please nummbers.", "error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            catch (OverflowException)
            {
                MessageBox.Show("numbers too big. big number scary.", "error", MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }
    }
}
