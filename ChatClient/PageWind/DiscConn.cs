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


namespace ChatClient
{

    //public partial class DiscConn: ISChatCallback
    //{
    //    public bool isConnected = false;
    //    public SChatClient client;
    //    public int ID;

    //    public void ConnectUser()
    //    {
    //        if (!isConnected)
    //        {
    //            client = new SChatClient(new System.ServiceModel.InstanceContext(this));
    //            isConnected = true;
    //        }

    //    }

    //    public void DisconectUser()
    //    {
    //        if (isConnected)
    //        {
    //            client = new SChatClient(new System.ServiceModel.InstanceContext(this));
    //            isConnected = false;

    //            client.Disonnect(ID);
    //            client = null;
    //        }
    //    }

    //    public void MsgCallBack(string msg)
    //    {
    //        Chat chat = new Chat();
    //        chat.lbChat.Items.Add(msg);
    //        chat.lbChat.ScrollIntoView(chat.lbChat.Items[chat.lbChat.Items.Count - 1]);
    //    }
    //}
}
