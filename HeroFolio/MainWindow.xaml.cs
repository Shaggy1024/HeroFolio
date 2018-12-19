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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace HeroFolio
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

        private void MenuItem_Click_Exit(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void MenuItem_Click_Save(object sender, RoutedEventArgs e)
        {
            
        }

        private void MenuItem_Click_SaveAs(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int strAbility1;
            int strAbilityMod1=0;

            strAbility1 = int.Parse(strAbility.Text);
            if (strAbility1 == 10 || strAbility1 == 11)
            {
                strAbilityMod1 = 1;
                strAbilityMod.Text = strAbilityMod1.ToString();
            }
            else if (strAbility1 == 12 || strAbility1 == 13)
            {
                strAbilityMod1 = 2;
                strAbilityMod.Text = strAbilityMod1.ToString();
            }
            else if (strAbility1 == 14 || strAbility1 == 15)
            {
                strAbilityMod1 = 3;
                strAbilityMod.Text = strAbilityMod1.ToString();
            }
            else if (strAbility1 == 16 || strAbility1 == 17)
            {
                strAbilityMod1 = 4;
                strAbilityMod.Text = strAbilityMod1.ToString();
            }
            else if (strAbility1 == 18 || strAbility1 == 19)
            {
                strAbilityMod1 = 5;
                strAbilityMod.Text = strAbilityMod1.ToString();
            }
            AbilityEdit.Visibility=Visibility.Hidden;
            strAbility.IsReadOnly = true;
            return;
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            AbilityEdit.Visibility = Visibility.Visible;
            strAbility.IsReadOnly = false;
        }
    }
}
