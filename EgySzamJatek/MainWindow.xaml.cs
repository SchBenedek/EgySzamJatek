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
using System.IO;

namespace EgySzamJatek
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Jatekos> jatokes = new List<Jatekos>();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void beolvas(object sender, RoutedEventArgs e)
        {
            StreamReader sr = new StreamReader("egyszamjatek.txt");
            while(!sr.EndOfStream)
            {
                string line= sr.ReadLine();
                string[] data = line.Split(" ");
                string nev = data[data.Length - 1];
                int[] sz=new int[10];
                Jatekos j = new Jatekos(nev);
                for (int i=0; i<sz.Length; i++)
                {
                    j.Szamok[i] = Convert.ToInt32(data[i]);
                }
                jatokes.Add(j);
            }
            MessageBox.Show("Sikeres Beolvasás!", "üzenet", MessageBoxButton.OK, MessageBoxImage.Asterisk);
            sr.Close();
        }
        private void beolvasasstop()
        {
            if (jatokes.Count == 0)
            {
                MessageBox.Show("nincs Beolvasás!", "üzenetüzenet", MessageBoxButton.YesNoCancel, MessageBoxImage.Question);
                
            }
            
        }
        private void jatekosSzam_MouseDown(object sender, MouseButtonEventArgs e)
        {
            beolvasasstop();
            jatekosSzam.Content = "Játékosok száma: " + jatokes.Count();

                
        }
        private void fordulok_MouseDown(object sender, MouseButtonEventArgs e)
        {
            int a = 0;
            for(int i=0; i<1; i++)
            {
                a= jatokes[i].Szamok.Length;
            }
            fordulok.Content = "Fordulók száma: " + a;
        }
    }
}
