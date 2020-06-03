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
    /// Логика взаимодействия для LoginForm.xaml
    /// </summary>
    public partial class Card : UserControl
    {
        public Card()
        {
            InitializeComponent();
        }
        public string FName
        {
            get { return (string)GetValue(FNameProperty); }
            set { SetValue(FNameProperty, value); }
        }
        public static readonly DependencyProperty FNameProperty =
         DependencyProperty.Register(
         "FName", // имя параметра в разметке
         typeof(string), // тип данных параметра
         typeof(Card), // тип данных элемента управления
         new PropertyMetadata(string.Empty,FNameChanged));
        private static void FNameChanged(DependencyObject obj, DependencyPropertyChangedEventArgs args)
        {
            var FNameForm = obj as Card;
            FNameForm.FNameLabel.Content = FNameForm.FName;
        }
        public string SName
        {
            get { return (string)GetValue(SNameProperty); }
            set { SetValue(SNameProperty, value); }
        }
        public static readonly DependencyProperty SNameProperty =
         DependencyProperty.Register(
         "SName", // имя параметра в разметке
         typeof(string), // тип данных параметра
         typeof(Card), // тип данных элемента управления
         new PropertyMetadata(string.Empty, SNameChanged));
        private static void SNameChanged(DependencyObject obj, DependencyPropertyChangedEventArgs args)
        {
            var SNameForm = obj as Card;
            SNameForm.SNameLabel.Content = SNameForm.SName;
        }
        public string Department
        {
            get { return (string)GetValue(DepartmentProperty); }
            set { SetValue(DepartmentProperty, value); }
        }
        public static readonly DependencyProperty DepartmentProperty =
         DependencyProperty.Register(
         "Department", // имя параметра в разметке
         typeof(string), // тип данных параметра
         typeof(Card), // тип данных элемента управления
         new PropertyMetadata(string.Empty, DepartmentChanged));
        private static void DepartmentChanged(DependencyObject obj, DependencyPropertyChangedEventArgs args)
        {
            var DepartmentForm = obj as Card;
            DepartmentForm.DepartmentLabel.Content = DepartmentForm.Department;
        }
        public string Status
        {
            get { return (string)GetValue(StatusProperty); }
            set { SetValue(StatusProperty, value); }
        }
        public static readonly DependencyProperty StatusProperty =
         DependencyProperty.Register(
         "Status", // имя параметра в разметке
         typeof(string), // тип данных параметра
         typeof(Card), // тип данных элемента управления
         new PropertyMetadata(string.Empty, StatusChanged));
        private static void StatusChanged(DependencyObject obj, DependencyPropertyChangedEventArgs args)
        {
            var StatusForm = obj as Card;
            StatusForm.StatusLabel.Content = StatusForm.Status;
        }
        public string FStatus
        {
            get { return (string)GetValue(FStatusProperty); }
            set { SetValue(FStatusProperty, value); }
        }
        public static readonly DependencyProperty FStatusProperty =
         DependencyProperty.Register(
         "FStatus", // имя параметра в разметке
         typeof(string), // тип данных параметра
         typeof(Card), // тип данных элемента управления
         new PropertyMetadata(string.Empty, FStatusChanged));
        private static void FStatusChanged(DependencyObject obj, DependencyPropertyChangedEventArgs args)
        {
            var FStatusForm = obj as Card;
            FStatusForm.FStatusLabel.Content = FStatusForm.FStatus;
        }
        public string PicImage
        {
            get { return (string)GetValue(PicImageProperty); }
            set { SetValue(PicImageProperty, value); }
        }
        public static readonly DependencyProperty PicImageProperty =
         DependencyProperty.Register(
         "PicImage", // имя параметра в разметке
         typeof(string), // тип данных параметра
         typeof(Card), // тип данных элемента управления
         new PropertyMetadata(string.Empty, PicImageChanged));
        private static void PicImageChanged(DependencyObject obj, DependencyPropertyChangedEventArgs args)
        {
            var PicImageForm = obj as Card;
            PicImageForm.Pic.Source = new BitmapImage(new Uri("pack://application:,,,/" + PicImageForm.PicImage));
        }
        public string ToolTipLike
        {
            get { return (string)GetValue(ToolTipLikeProperty); }
            set { SetValue(ToolTipLikeProperty, value); }
        }
        public static readonly DependencyProperty ToolTipLikeProperty =
         DependencyProperty.Register(
         "ToolTipLike", // имя параметра в разметке
         typeof(string), // тип данных параметра
         typeof(Card), // тип данных элемента управления
         new PropertyMetadata(string.Empty, ToolTipLikeChanged));
        private static void ToolTipLikeChanged(DependencyObject obj, DependencyPropertyChangedEventArgs args)
        {
            var ToolTipLikeForm = obj as Card;
            ToolTipLikeForm.LikeBut.ToolTip = ToolTipLikeForm.ToolTipLike;
        }
    }
}
