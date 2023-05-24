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
    /// Логика взаимодействия для VacancyMore.xaml
    /// </summary>
    public partial class VacancyMore : Window
    {
        public VacancyMore()
        {
            InitializeComponent();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void bt_MainWindow_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();

            mainWindow.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            mainWindow.Show();

            mainWindow.tbLoginMW.Text = "";
            mainWindow.tbPassMW.Password = "";

            Close();
        }

        private void bt_DialoguesEmployer_Click(object sender, RoutedEventArgs e)
        {
            Dialogues dialogues = new Dialogues();
            dialogues.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            dialogues.Show();
            dialogues.bt_DialoguesWorker.IsEnabled = false;

            Close();
        }

        private void bt_PersonalEmployer_Click(object sender, RoutedEventArgs e)
        {
            Worker worker = new Worker();
            worker.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            worker.Show();
            worker.bt_PersonalWorker.IsEnabled = false;

            worker.lb_LoginW.Content = lb_Login.Content;
            worker.lb_NameSurname.Content = lb_NameSurname.Content;

            Close();
        }

        private void bt_Vidguk_Click(object sender, RoutedEventArgs e)
        {

        }

        private void bt_SearchVacancy_Click(object sender, RoutedEventArgs e)
        {
            ListVacancy listVacancy = new ListVacancy();
            listVacancy.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            listVacancy.Show();
            listVacancy.bt_PersonalWorker.IsEnabled = false;

            listVacancy.lb_LoginW.Content = lb_Login.Content;
            listVacancy.lb_NameSurname.Content = lb_NameSurname.Content;

            Close();
        }
    }
}
