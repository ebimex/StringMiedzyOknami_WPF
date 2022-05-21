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

namespace StringMiedzyOknami
{
    /// <summary>
    /// Logika interakcji dla klasy TrzecieOkno.xaml
    /// </summary>
    public partial class TrzecieOkno : Window
    {
        public TrzecieOkno(string tekstDrugiegoOkna)
        {
            InitializeComponent();

            this.tekstTrzeciegoOkna = tekstDrugiegoOkna;

            tbx_TekstDoPrzekazania.Text = tekstTrzeciegoOkna;
        }

        string tekstTrzeciegoOkna;

        private void btn_exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
