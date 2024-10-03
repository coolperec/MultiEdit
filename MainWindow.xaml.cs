using System.Windows;
using System.Windows.Controls;

namespace MultiEdit
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        // Предварительно сохраненный стиль
        private Style originalStyle;

        private void ChangeStyleButton_Click(object sender, RoutedEventArgs e)
        {
            // Сохраняем оригинальный стиль перед изменением
            if (originalStyle == null)
            {
                originalStyle = LargeTextBox1.Style;
            }

            // Изменить стиль большого текстового поля в первой колонне
            (LargeTextBox1 as FrameworkElement).Style = (Style)Resources["SmallTextBoxStyle"];
            // Изменить стиль большого текстового поля во второй колонне
            (LargeTextBox2 as FrameworkElement).Style = (Style)Resources["SmallTextBoxStyle"];
        }
        private void RevertStyleButton_Click(object sender, RoutedEventArgs e)
        {
            // Если оригинальный стиль был сохранен, восстанавливаем его
            if (originalStyle != null)
            {
                (LargeTextBox1 as FrameworkElement).Style = originalStyle;
                (LargeTextBox2 as FrameworkElement).Style = originalStyle;
            }
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}