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

namespace GC1
{
    /// <summary>
    /// Логика взаимодействия для CharacterStatsWindow.xaml
    /// </summary>
    public partial class CharacterStatsWindow : Window
    {
        public CharacterStatsWindow()
        {
            InitializeComponent();
        }

        private void ReturnButton_Click(object sender, RoutedEventArgs e)
        {
           CharacterCreateWindow characterCreateWindow = new CharacterCreateWindow();
           characterCreateWindow.Show();
           this.Close();
        }
    }
}
