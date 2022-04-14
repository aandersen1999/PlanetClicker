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

namespace PlanetClicker
{
    /// <summary>
    /// Interaction logic for PlanetButton.xaml
    /// </summary>
    public partial class PlanetButton : UserControl
    {
        public PlanetButton()
        {
            InitializeComponent();
        }

        private void OnPlanetClick(object sender, MouseButtonEventArgs e)
        {
            Application.Current.Shutdown();
        }

        
    }
}
