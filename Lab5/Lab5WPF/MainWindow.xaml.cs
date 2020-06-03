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

namespace Lab5WPF
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            PersonCard.LikeBut.ToolTip = "Like a boss";
            PersonCard.FName = "Шрек";
            PersonCard.SName = "Болотный";
            PersonCard.Department = "Спасение принцесс";
            PersonCard.Status = "Принц";
            PersonCard.FStatus = "Холост";
            PersonCard.PicImage = "pics/bubcha.png";
        }
    }
}
