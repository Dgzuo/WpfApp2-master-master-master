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

namespace WpfApp2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
           
        }

        private void ok_Click(object sender, RoutedEventArgs e)
        {
            int time = int.Parse(Code.Text);
            switch(time)
            {
            case 48:
                    {
                        int Sume= int.Parse(Code.Text);
                        time*= 15;
                        resault.Text = "Одесса" + " " + time.ToString() + "Грив";
                    }
                    break;

                case 44:
                    {
                        int Sume = int.Parse(Code.Text);
                        time *= 16;
                        resault.Text = "Киев" + "" + time.ToString() + "Грив";
                    }
                    break;

                case 46:
                    {
                        int Sume = int.Parse(Code.Text);
                        time *= 18;
                        resault.Text = "харьков" + "" + time.ToString() + "Грив";
                    }
                    break;

                case 45:
                    {
                        int Sume = int.Parse(Code.Text);
                        time *= Sume;
                        resault.Text = "Винница" + "" + time.ToString() + "Грив";
                    }
                    break;

            }
            
        }
    }
}
