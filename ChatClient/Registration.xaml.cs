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
using System.Data.SqlClient;
using ChatClient.DataBase;

namespace ChatClient
{
    /// <summary>
    /// Логика взаимодействия для Registration.xaml
    /// </summary>
    public partial class Registration : Window
    {
        int rbCheckWorker = 0;
        int rbCheckEmployer = 0;

        public Registration()
        {
            InitializeComponent();
        }
        private void RadioButton_Worker(object sender, RoutedEventArgs e)
        {
            if (rbWorker.IsChecked == true)
            {
                rbCheckWorker = 3;
            }
        }
        private void RadioButton_Employer(object sender, RoutedEventArgs e)
        {
            if (rbEmployer.IsChecked == true)
            {
                rbCheckEmployer = 2;
            }
        }

        private void bt_RegisterDone_Click(object sender, RoutedEventArgs e)
        {
            logpass newuser = new logpass();
            personalWorker personal = new personalWorker();
            vacancy vacancy = new vacancy();

            if (rbCheckEmployer == 2)
            {
                newuser.RoleID = 2;

                newuser.Login = personal.Login = vacancy.Login = tb_LoginReg.Text;

                newuser.Password = tb_PassReg.Password;

                AppData.db.logpass.Add(newuser);
                AppData.db.personalWorker.Add(personal);
                AppData.db.vacancy.Add(vacancy);

                AppData.db.SaveChanges();


                MessageBox.Show("Ви успішно зареєструвлись!");

                Close();
            }
            else if (rbCheckWorker == 3)
            {
                newuser.RoleID = 3;

                newuser.Login = personal.Login = vacancy.Login = tb_LoginReg.Text;

                newuser.Password = tb_PassReg.Password;

                AppData.db.logpass.Add(newuser);
                AppData.db.personalWorker.Add(personal);
                AppData.db.vacancy.Add(vacancy);

                AppData.db.SaveChanges();


                MessageBox.Show("Ви успішно зареєструвлись!");

                Close();
            }
            else
            {
                MessageBox.Show("Оберіть роль!");
            }
        }
    }
}
