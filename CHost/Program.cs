using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using job_finder;
using Newtonsoft.Json;
using System.IO;

namespace CHost
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var host = new ServiceHost(typeof(SChat)))
            {
                host.Open();

                Console.WriteLine("Host started!");
                Console.ReadLine();
            }
        }
    }

    class Json: ISChatCallBack
    {
        public void MsgCallBack(string msg)
        {
            var listmsg = new ListMSG();

            listmsg.list.Add(msg);
            var listjson = JsonConvert.SerializeObject(listmsg, Formatting.Indented);

            File.WriteAllText("C:/Users/maksy/OneDrive/Рабочий стол/student3.0/ІПЗ/program/json.txt", listjson);
        }
    }

    class ListMSG
    {
        public List<string> list = new List<string>();
    }
}
