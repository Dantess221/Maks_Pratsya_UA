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
using ChatClient.ServiceChat;
using ChatClient.DataBase;
using ChatClient;
using System.Data.SqlClient;

namespace ChatClient
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void btVhid(object sender, RoutedEventArgs e)
        {
            tbLoginMW.MaxLength = 50;
            tbPassMW.MaxLength = 50;

            Worker worker = new Worker();
            Employer employer = new Employer();

            var CurrentUser = AppData.db.logpass.FirstOrDefault(u => u.Login == tbLoginMW.Text && u.Password == tbPassMW.Password);

            if (CurrentUser != null)
            {
                if (CurrentUser.RoleID == 2)
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
                else if (CurrentUser.RoleID == 3)
                {
                    worker.WindowStartupLocation = WindowStartupLocation.CenterScreen;
                    worker.Show();
                    worker.bt_PersonalWorker.IsEnabled = false;

                    worker.lb_LoginW.Content = CurrentUser.Login;
                    worker.lb_ActivityWorker.Content = CurrentUser.personalWorker.ActivityWorker;
                    worker.tb_NameWorker.Text = CurrentUser.personalWorker.Name;
                    worker.tb_SurnameWorker.Text = CurrentUser.personalWorker.Surname;
                    worker.tb_PatronymicWorker.Text = CurrentUser.personalWorker.Patronymic;
                    worker.tb_EducationWorker.Text = CurrentUser.personalWorker.EducationWorker;
                    worker.tb_DataOfBirthWorker.Text = CurrentUser.personalWorker.DataOfBirthWorker;
                    worker.tb_ActivityWorker.Text = CurrentUser.personalWorker.ActivityWorker;

                    //Close();
                }
            }
            else
            {
                MessageBox.Show("Введені дані не вірні!");
            }
        }

        private void bt_RegistrationMW_Click(object sender, RoutedEventArgs e)
        {
            Registration registration = new Registration();
            registration.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            registration.Show();
        }
    }
}
