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

namespace pp._7
{
    /// <summary>
    /// Логика взаимодействия для ChatOwnerWindow.xaml
    /// </summary>
    public partial class ChatOwnerWindow : Window
    {
        public ChatOwnerWindow()
        {
            InitializeComponent();
            s.TextChanged += s_TextChanged;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
           
                this.Close(); // Закрыть текущее окно
            
        }

        private void s_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox.Text == "Сообщение")
            {
                textBox.Text = string.Empty;
                textBox.Foreground = new SolidColorBrush(Colors.Black); // Изменение цвета текста, если нужно
            }
        }

        private void d_Click(object sender, RoutedEventArgs e)
        {
            // Проверка, пустой ли TextBox перед отправкой сообщения
            if (string.IsNullOrWhiteSpace(s.Text) || s.Text == "Сообщение")
            {
                MessageBox.Show("Пожалуйста, введите сообщение перед отправкой.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                // Здесь  код для отправки сообщения
                SendMessage(s.Text);
                s.Clear(); // Очистка TextBox после отправки сообщения
            }
        }

        private void SendMessage(string message)
        {
            // Здесь ваш код для отправки сообщения
        }
    }
}
