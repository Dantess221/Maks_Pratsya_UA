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

namespace ChatClient
{
    /// <summary>
    /// Логика взаимодействия для Dialogues.xaml
    /// </summary>
    public partial class Dialogues : Window
    {
        public Dialogues()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void bt_GoChatWorker_Click(object sender, RoutedEventArgs e)
        {
            Chat chat = new Chat();
            MainWindow mainWindow = new MainWindow();
            tb_UserNameChatWorker.Text = mainWindow.tbLoginMW.Text;
            chat.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            //chat.tbUserNameChat.IsEnabled = false;
            chat.tbUserNameChat.Text = mainWindow.tbLoginMW.Text;
            chat.Show();

            Close();
        }

        private void bt_PersonalWorker_Click(object sender, RoutedEventArgs e)
        {
            Worker worker = new Worker();
            worker.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            worker.Show();
            worker.bt_PersonalWorker.IsEnabled = false;

            Close();
        }

        private void bt_SearchVacancies_Click(object sender, RoutedEventArgs e)
        {

        }

        private void bt_DialoguesWorker_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
