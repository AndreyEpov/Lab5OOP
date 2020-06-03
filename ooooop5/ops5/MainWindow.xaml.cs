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

namespace ops5
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            PC.LabelName.Content = "Andrey A.V";
            PC.LabelWork.Content = "SibGUCCI/student";
            PC.LabelPhone.Content = "+795160000";
            PC.MyImage = "Image/123.jpg";
            PC.Call.ToolTip = "Неправильно набран номер";

        }

    }
}
