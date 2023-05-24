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
    /// Логика взаимодействия для Employer.xaml
    /// </summary>
    public partial class Employer : Window
    {
        public Employer()
        {
            InitializeComponent();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void bt_PersonalEmployer_Click(object sender, RoutedEventArgs e)
        {

        }

        private void bt_CreateVacancy_Click(object sender, RoutedEventArgs e)
        {
            CreateVacancy createVacancy = new CreateVacancy();
            createVacancy.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            createVacancy.Show();
            createVacancy.bt_CreateVacancy.IsEnabled = false;
            createVacancy.lb_NameSurname.Content = lb_NameSurname.Content;
            createVacancy.lb_Login.Content = lb_Login.Content;
            

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

        private void bt_MyVacancy_Click(object sender, RoutedEventArgs e)
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

        private void bt_EditEmployer_Click(object sender, RoutedEventArgs e)
        {
            personalWorker personalWorker = new personalWorker();

            string login = lb_Login.Content.ToString();

            var CurrentUser = AppData.db.personalWorker.FirstOrDefault(u => u.Login == login);


            if (CurrentUser != null)
            {
                CurrentUser.Name = tb_NameEmployer.Text;
                CurrentUser.Surname = tb_SurnameEmployer.Text;
                CurrentUser.Patronymic = tb_PatronymicEmployer.Text;
                CurrentUser.DataOfBirthWorker = tb_DataOfBirthEmployer.Text;
                CurrentUser.Company = tb_Company.Text;

                AppData.db.SaveChanges();

                MessageBox.Show("Дані збережено!");
            }
            else
            {
                MessageBox.Show("Помелка збереження даних!");
            }
        }

    }
}
