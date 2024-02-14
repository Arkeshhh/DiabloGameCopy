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
    /// Логика взаимодействия для CharacterCreateWindow.xaml
    /// </summary>
    public partial class CharacterCreateWindow : Window
    {
        public CharacterCreateWindow()
        {
            InitializeComponent();
        }

        virtual public void ReturnButton_Click(object sender, RoutedEventArgs e)
        {
          MainWindow MainWindow = new MainWindow();
          MainWindow.Show();
          this.Close();
        }

        private void SelectWarrior_MouseDown(object sender, MouseButtonEventArgs e)
        {
            CharacterStatsWindow characterStatsWindow = new CharacterStatsWindow();
            characterStatsWindow.Show();
            this.Close();
        }

        private void SelectAssasin_MouseDown(object sender, MouseButtonEventArgs e)
        {
            CharacterStatsWindow characterStatsWindow = new CharacterStatsWindow();
            characterStatsWindow.Show();
            this.Close();
        }

        private void SelectSorcerer_MouseDown(object sender, MouseButtonEventArgs e)
        {
            CharacterStatsWindow characterStatsWindow = new CharacterStatsWindow();
            characterStatsWindow.Show();
            this.Close();
        }

    }
}
