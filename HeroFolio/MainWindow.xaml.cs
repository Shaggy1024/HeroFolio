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
            strAbilityMod.Text = VerifyHighLow(int.Parse(strAbility.Text)).ToString();
            dexAbilityMod.Text = VerifyHighLow(int.Parse(dexAbility.Text)).ToString();
            conAbilityMod.Text = VerifyHighLow(int.Parse(conAbility.Text)).ToString();
            intAbilityMod.Text = VerifyHighLow(int.Parse(intAbility.Text)).ToString();
            wisAbilityMod.Text = VerifyHighLow(int.Parse(wisAbility.Text)).ToString();
            chaAbilityMod.Text = VerifyHighLow(int.Parse(chaAbility.Text)).ToString();
                                    
            AbilityEdit.Visibility=Visibility.Hidden;
            strAbility.IsReadOnly = true;
            dexAbility.IsReadOnly = true;
            conAbility.IsReadOnly = true;
            intAbility.IsReadOnly = true;
            wisAbility.IsReadOnly = true;
            chaAbility.IsReadOnly = true;
            return;
        }

        private int VerifyHighLow(int abilityScore)
        {
            int abilityMod;
            if (abilityScore >= 10)
            {
                abilityMod = greaterThan(abilityScore);
            }
            else
            {
                abilityMod = lessThan(abilityScore);
            }
            return abilityMod;
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
