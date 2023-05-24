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
    /// Логика взаимодействия для ListVacancy.xaml
    /// </summary>
    public partial class ListVacancy : Window
    {
        public ListVacancy()
        {
            InitializeComponent();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            var list = AppData.db.vacancy.ToList();
            dataGridVacancy.ItemsSource = list.Where(x => !string.IsNullOrEmpty(x.Login));
        }

        private void bt_PersonalWorker_Click(object sender, RoutedEventArgs e)
        {
            Worker worker = new Worker();
            worker.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            worker.Show();
            worker.bt_PersonalWorker.IsEnabled = false;

            worker.lb_LoginW.Content = lb_LoginW.Content;
            worker.lb_NameSurname.Content = lb_NameSurname.Content;

            Close();
        }

        private void bt_SearchVacancies_Click(object sender, RoutedEventArgs e)
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

        private void bt_MainWindow_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();

            mainWindow.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            mainWindow.Show();

            mainWindow.tbLoginMW.Text = "";
            mainWindow.tbPassMW.Password = "";

            Close();
        }

        private void bt_Podrobici_Click(object sender, RoutedEventArgs e)
        {
            VacancyMore vacancyMore = new VacancyMore();

            

            string position = datagridPosition.ToString();
            string salary = datagridSalary.ToString();
            string city = datagridCity.ToString();

            vacancy CurrentID = ((sender as Button)?.DataContext as vacancy);

            if (CurrentID != null)
            {
                vacancyMore.WindowStartupLocation = WindowStartupLocation.CenterScreen;
                vacancyMore.Show();

                vacancyMore.lb_Login = lb_LoginW;
                vacancyMore.lb_NameSurname.Content = lb_NameSurname.Content;

                vacancyMore.tb_City.Text = CurrentID.city;
                vacancyMore.tb_Description.Text = CurrentID.description;
                vacancyMore.tb_Employment.Text = CurrentID.employment;
                vacancyMore.tb_Position.Text = CurrentID.position;
                vacancyMore.tb_Salary.Text = CurrentID.salary;

                Close();
            }
            else
            {
                MessageBox.Show("Помелка!");
            }
        }
    }
}
