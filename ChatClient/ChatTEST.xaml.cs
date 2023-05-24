using System;
using System.Collections.Generic;
using System.IO;
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
using ChatClient.ServiceChat;
using Newtonsoft.Json;

namespace ChatClient
{
    /// <summary>
    /// Логика взаимодействия для Chat.xaml
    /// </summary>
    public partial class Chat : Window, ISChatCallback
    {
        bool isConnected = false;
        int ID;
        SChatClient client;

        //MainWindow mainWindow = new MainWindow();
        //DiscConn disccon = new DiscConn();

        public Chat()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            
        }

        public void ConnectUser()
        {
            if (!isConnected)
            {
                client = new SChatClient(new System.ServiceModel.InstanceContext(this));
                ID = client.Connect(tbUserNameChat.Text);
                bConnDisc.Content = "Disconnect";
                isConnected = true;
            }
        }

        public void DisconectUser()
        {
            if (isConnected)
            {
                client.Disconnect(ID);
                client = null;
                bConnDisc.Content = "Connect";
                isConnected = false;
            }
        }

        public void MsgCallBack(string msg)
        {
            lbChat.Items.Add(msg);
            lbChat.ScrollIntoView(lbChat.Items[lbChat.Items.Count - 1]);

            //Console.WriteLine("зашел");
            //var listmsg = new ListMSG();

            //listmsg.list.Add(msg);
            //var listjson = JsonConvert.SerializeObject(listmsg, Formatting.Indented);

            //File.WriteAllText("C:/Users/maksy/OneDrive/Рабочий стол/student3.0/ІПЗ/program/json.txt", listjson);
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            DisconectUser();
        }

        private void tbMsg_KeyDown(object sender, KeyEventArgs e)
        {
            
            if (e.Key == Key.Enter)
            {
                if (client != null)
                {
                    client.SendMsg(tbMsg.Text, ID);
                    tbMsg.Text = string.Empty;
                }
            }
        }

        private void bConnDisc_Click(object sender, RoutedEventArgs e)
        {
            if (isConnected)
            {
                DisconectUser();
            }
            else
            {
                ConnectUser();
            }
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
            Dialogues dialogues = new Dialogues();
            dialogues.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            dialogues.Show();
            dialogues.bt_DialoguesWorker.IsEnabled = false;

            Close();
        }
    }
    //class ListMSG
    //{
    //    public List<string> list = new List<string>();
    //}
}

