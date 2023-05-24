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
    /// Логика взаимодействия для CreateVacancy.xaml
    /// </summary>
    public partial class CreateVacancy : Window
    {
        public CreateVacancy()
        {
            InitializeComponent();
        }
        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void bt_EditEmployer_Click(object sender, RoutedEventArgs e)
        {
            vacancy vacancy = new vacancy();

            string login = lb_Login.Content.ToString();

            var CurrentUser = AppData.db.vacancy.FirstOrDefault(u => u.Login == login);


            if (CurrentUser != null)
            {
                CurrentUser.city = tb_City.Text;
                CurrentUser.description = tb_Description.Text;
                CurrentUser.employment = tb_Employment.Text;
                CurrentUser.position = tb_Position.Text;
                CurrentUser.salary = tb_Salary.Text;

                AppData.db.SaveChanges();

                MessageBox.Show("Вакансію створено!");
            }
            else
            {
                MessageBox.Show("Помелка створення вакансії!");
            }
        }

        private void bt_PersonalEmployer_Click(object sender, RoutedEventArgs e)
        {
            Employer employer = new Employer();

            employer.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            employer.Show();
            employer.bt_PersonalEmployer.IsEnabled = false;

            employer.lb_Login.Content = lb_Login.Content;

            string login = lb_Login.Content.ToString();

            var CurrentUser = AppData.db.logpass.FirstOrDefault(u => u.Login == login);

            if (CurrentUser != null)
            {
                employer.WindowStartupLocation = WindowStartupLocation.CenterScreen;
                employer.Show();
                employer.bt_PersonalEmployer.IsEnabled = false;

                employer.lb_NameSurname.Content = CurrentUser.personalWorker.Name + " " + CurrentUser.personalWorker.Surname;
                employer.lb_Login.Content = CurrentUser.Login;
                employer.tb_NameEmployer.Text = CurrentUser.personalWorker.Name;
                employer.tb_SurnameEmployer.Text = CurrentUser.personalWorker.Surname;
                employer.tb_PatronymicEmployer.Text = CurrentUser.personalWorker.Patronymic;
                employer.tb_DataOfBirthEmployer.Text = CurrentUser.personalWorker.DataOfBirthWorker;
                employer.tb_Company.Text = CurrentUser.personalWorker.Company;

                //Close();
            }
        }

        private void bt_CreateVacancy_Click(object sender, RoutedEventArgs e)
        {

        }

        private void bt_DialoguesEmployer_Click(object sender, RoutedEventArgs e)
        {
            Dialogues dialogues = new Dialogues();
            dialogues.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            dialogues.Show();
            dialogues.bt_DialoguesWorker.IsEnabled = false;

            Close();
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
