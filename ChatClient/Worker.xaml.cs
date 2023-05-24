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
using ChatClient.DataBase;

namespace ChatClient
{
    /// <summary>
    /// Логика взаимодействия для Worker.xaml
    /// </summary>
    public partial class Worker : Window
    {
        public Worker()
        {
            InitializeComponent();
        }

        private void bt_PersonalWorker_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void bt_DialoguesWorker_Click(object sender, RoutedEventArgs e)
        {
            Dialogues dialogues = new Dialogues();
            dialogues.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            dialogues.Show();
            dialogues.bt_DialoguesWorker.IsEnabled = false;

            Close();
        }

        private void bt_SearchVacancies_Click(object sender, RoutedEventArgs e)
        {
            ListVacancy listVacancy = new ListVacancy();

            listVacancy.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            listVacancy.Show();
            listVacancy.bt_SearchVacancies.IsEnabled = false;

            listVacancy.lb_LoginW.Content = lb_LoginW.Content;
            listVacancy.lb_NameSurname.Content = lb_NameSurname.Content;

            Close();
        }

        private void bt_EditWorker_Click(object sender, RoutedEventArgs e)
        {
            personalWorker personalWorker = new personalWorker();

            string login = lb_LoginW.Content.ToString();

            var CurrentUser = AppData.db.personalWorker.FirstOrDefault(u => u.Login == login);


            if (CurrentUser != null)
            {
                CurrentUser.Name = tb_NameWorker.Text;
                CurrentUser.Surname = tb_SurnameWorker.Text;
                CurrentUser.Patronymic = tb_PatronymicWorker.Text;
                CurrentUser.EducationWorker = tb_EducationWorker.Text;
                CurrentUser.DataOfBirthWorker = tb_DataOfBirthWorker.Text;
                CurrentUser.ActivityWorker = tb_ActivityWorker.Text;

                AppData.db.SaveChanges();

                MessageBox.Show("Дані збережено!");
            }
            else
            {
                MessageBox.Show("Помелка збереження даних!");
            }
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
    }
}
