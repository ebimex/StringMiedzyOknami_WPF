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
    /// Logika interakcji dla klasy DrugieOkno.xaml
    /// </summary>
    public partial class DrugieOkno : Window
    {
        public DrugieOkno(string tekstPierwszegOkna)
        {
            InitializeComponent();
            this.tekstDrugiegoOkna = tekstPierwszegOkna;

            tbx_TekstDoPrzekazania.Text = tekstDrugiegoOkna;
        }

        string tekstDrugiegoOkna;

        private void btn_NoweOkno_Click(object sender, RoutedEventArgs e)
        {
            TrzecieOkno trzecieOkno = new TrzecieOkno(tekstDrugiegoOkna);

            trzecieOkno.ShowDialog();
        }

        private void btn_exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
