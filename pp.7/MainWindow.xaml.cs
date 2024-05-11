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

namespace pp._7
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            z.TextChanged += TextBox_TextChanged;
            v.TextChanged += TextBox_TextChanged_1;
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox != null && (textBox.Text == "Введите свое имя пользователя" || textBox.Text == "IP адрес чата"))
            {
                textBox.Text = string.Empty;
                textBox.Foreground = new SolidColorBrush(Colors.Black);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(z.Text) || z.Text == "Введите свое имя пользователя")
            {
                MessageBox.Show("Введите свое имя пользователя.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                ChatUserWindow chatOwnerWindow = new ChatUserWindow(); // для новый чата
                chatOwnerWindow.Show(); 
                this.Close(); // Закрыть текущее окно
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(v.Text) || v.Text == "IP адрес чата")
            {
                MessageBox.Show("Введите IP адрес чата.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                ChatOwnerWindow chatUser1Window = new ChatOwnerWindow(); // подключится
                chatUser1Window.Show(); 
                this.Close(); // Закрыть текущее окно
            }
        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox != null && string.IsNullOrWhiteSpace(textBox.Text))
            {
                if (textBox.Name == "z")
                {
                    textBox.Text = "Введите свое имя пользователя";
                    textBox.Foreground = new SolidColorBrush(Colors.Gray);
                }
                else if (textBox.Name == "v")
                {
                    textBox.Text = "IP адрес чата";
                    textBox.Foreground = new SolidColorBrush(Colors.Gray);
                }
            }
        }
    }
}


