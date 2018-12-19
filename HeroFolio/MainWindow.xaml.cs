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
            int strAbility1, dexAbility1, conAbility1, intAbility1, wisAbility1, chaAbility1;
            int strAbilityMod1=0, dexAbilityMod1=0, conAbilityMod1 = 0, intAbilityMod1 = 0, wisAbilityMod1 = 0, chaAbilityMod1 = 0;

            strAbility1 = int.Parse(strAbility.Text);
            dexAbility1 = int.Parse(dexAbility.Text);
            conAbility1 = int.Parse(conAbility.Text);
            intAbility1 = int.Parse(intAbility.Text);
            wisAbility1 = int.Parse(wisAbility.Text);
            chaAbility1 = int.Parse(chaAbility.Text);

            if (strAbility1 >= 10)
            {
                strAbilityMod1 = greaterThan(strAbility1);
            }
            else
            {
                strAbilityMod1 = lessThan(strAbility1);
            }
            if (dexAbility1 >= 10)
            {
                dexAbilityMod1 = greaterThan(dexAbility1);
            }
            else
            {
                dexAbilityMod1 = lessThan(dexAbility1);
            }
            if (conAbility1 >= 10)
            {
                conAbilityMod1 = greaterThan(conAbility1);
            }
            else
            {
                conAbilityMod1 = lessThan(conAbility1);
            }
            if (intAbility1 >= 10)
            {
                intAbilityMod1 = greaterThan(intAbility1);
            }
            else
            {
                intAbilityMod1 = lessThan(intAbility1);
            }
            if (wisAbility1 >= 10)
            {
                wisAbilityMod1 = greaterThan(wisAbility1);
            }
            else
            {
                wisAbilityMod1 = lessThan(wisAbility1);
            }
            if (chaAbility1 >= 10)
            {
                chaAbilityMod1 = greaterThan(chaAbility1);
            }
            else
            {
                chaAbilityMod1 = lessThan(chaAbility1);
            }
            strAbilityMod.Text = strAbilityMod1.ToString();
            dexAbilityMod.Text = dexAbilityMod1.ToString();
            conAbilityMod.Text = conAbilityMod1.ToString();
            intAbilityMod.Text = intAbilityMod1.ToString();
            wisAbilityMod.Text = wisAbilityMod1.ToString();
            chaAbilityMod.Text = chaAbilityMod1.ToString();
            AbilityEdit.Visibility=Visibility.Hidden;
            strAbility.IsReadOnly = true;
            dexAbility.IsReadOnly = true;
            conAbility.IsReadOnly = true;
            intAbility.IsReadOnly = true;
            wisAbility.IsReadOnly = true;
            chaAbility.IsReadOnly = true;
            return;
        }

        private int greaterThan(int ability)
        {
            int mod = 0;
            ability = ability - 10;
            //accounts for ability being odd(id. 11 or 13 ect.)
            ability = (ability % 2 == 0) ? ability : ability - 1;

            for (int i=0; i < ability; i += 2)
            {
                mod++;
            }
            return mod;
        }

        private int lessThan(int ability)
        {
            int mod = 0;
            //accounts for ability being odd(id. 9 or 7 ect.)
            ability = (ability % 2 == 0) ? ability : ability - 1;

            for(int i = 10; i > ability; i -= 2)
            {
                mod--;
            }
            return mod;
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            AbilityEdit.Visibility = Visibility.Visible;
            strAbility.IsReadOnly = false;
            dexAbility.IsReadOnly = false;
            conAbility.IsReadOnly = false;
            intAbility.IsReadOnly = false;
            wisAbility.IsReadOnly = false;
            chaAbility.IsReadOnly = false;
        }
    }
}
