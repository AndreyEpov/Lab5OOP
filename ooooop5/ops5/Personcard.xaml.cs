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
    /// Логика взаимодействия для Personcard.xaml
    /// </summary>
    public partial class Personcard : UserControl
    {
        public Personcard()
        {
            InitializeComponent();


        }
        public string Login
        {
            get { return (string)GetValue(LoginProperty); }
            set { SetValue(LoginProperty, value); }
        }
        private static void LoginChanged(DependencyObject obj, DependencyPropertyChangedEventArgs args)
        {
            var loginForm = obj as Personcard;
            loginForm.LabelName.Content = loginForm.Login;
        }


        public static readonly DependencyProperty LoginProperty = DependencyProperty.Register(
        "Login", // имя параметра в разметке
        typeof(string), // тип данных параметра
        typeof(Personcard), // тип данных элемента управления
        new PropertyMetadata(string.Empty, LoginChanged));

        public string Work
        {
            get { return (string)GetValue(WorkProperty); }
            set { SetValue(WorkProperty, value); }
        }
        private static void WorkChanged(DependencyObject obj, DependencyPropertyChangedEventArgs args)
        {
            var WorkForm = obj as Personcard;
            WorkForm.LabelWork.Content = WorkForm.Work;
        }


        public static readonly DependencyProperty WorkProperty = DependencyProperty.Register(
        "Work", // имя параметра в разметке
        typeof(string), // тип данных параметра
        typeof(Personcard), // тип данных элемента управления
        new PropertyMetadata(string.Empty, WorkChanged));

        public string Phone
        {
            get { return (string)GetValue(PhoneProperty); }
            set { SetValue(PhoneProperty, value); }
        }
        private static void PhoneChanged(DependencyObject obj, DependencyPropertyChangedEventArgs args)
        {
            var PhoneForm = obj as Personcard;
            PhoneForm.LabelPhone.Content = PhoneForm.Phone;
        }


        public static readonly DependencyProperty PhoneProperty = DependencyProperty.Register(
        "Phone", // имя параметра в разметке
        typeof(string), // тип данных параметра
        typeof(Personcard), // тип данных элемента управления
        new PropertyMetadata(string.Empty, PhoneChanged));

        public string MyImage
        {
            get { return (string)GetValue(MyImageProperty); }
            set { SetValue(MyImageProperty, value); }
        }
        public static readonly DependencyProperty MyImageProperty =
         DependencyProperty.Register(
         "MyImage", // имя параметра в разметке
         typeof(string), // тип данных параметра
         typeof(Personcard), // тип данных элемента управления
         new PropertyMetadata(string.Empty, MyImageChanged));
        private static void MyImageChanged(DependencyObject obj, DependencyPropertyChangedEventArgs args)
        {
            var MyImageForm = obj as Personcard;
            MyImageForm.image.Source = new BitmapImage(new Uri("pack://application:,,,/" + MyImageForm.MyImage));
        }

        public string ToolCall
        {
            get { return (string)GetValue(ToolCallProperty); }
            set { SetValue(ToolCallProperty, value); }
        }
        public static readonly DependencyProperty ToolCallProperty =
         DependencyProperty.Register(
         "ToolCall", // имя параметра в разметке
         typeof(string), // тип данных параметра
         typeof(Personcard), // тип данных элемента управления
         new PropertyMetadata(string.Empty, ToolCallChanged));
        private static void ToolCallChanged(DependencyObject obj, DependencyPropertyChangedEventArgs args)
        {
            var ToolCallForm = obj as Personcard;
            ToolCallForm.Call.ToolTip = ToolCallForm.ToolCall;
        }
    
    }
}
