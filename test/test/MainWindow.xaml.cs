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

namespace test
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Controller_Patienten cp;

        public MainWindow()
        {
            InitializeComponent();
            cp = new Controller_Patienten();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            cp.PatientHinzufuegen(t1.Text.ToString(), t2.Text.ToString(), t3.Text.ToString());
            list.Items.Clear();
            foreach (Model_Patient p in cp.Patienten)
            {
                list.Items.Add(p.Vorname + " " + p.Nachname);
            }
        }
    }
}
