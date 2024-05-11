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
    /// Логика взаимодействия для ChatUserWindow.xaml
    /// </summary>
    public partial class ChatUserWindow : Window
    {
        public ChatUserWindow()
        {
            InitializeComponent();
            w.TextChanged += w_TextChanged;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
                this.Close(); // Закрыть текущее окно
            
        }

        private void w_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox != null && textBox.Text == "Сообщение")
            {
                textBox.Text = string.Empty;
                textBox.Foreground = new SolidColorBrush(Colors.Black);
            }  
            
        }

        private void e_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(w.Text))
            {
                MessageBox.Show("Пожалуйста, введите сообщение перед отправкой.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            {
                SendMessage(w.Text);
                w.Clear(); 
            }
        }

        private void SendMessage(string message)
        {
            
        }
    }
}
