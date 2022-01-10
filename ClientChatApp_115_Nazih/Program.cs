using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using WCFService_2Way_115;

namespace ClientChatApp_115_Nazih
{
    class Program
    {
        static void Main(string[] args)
        {
            InstanceContext context = new InstanceContext(new ClientCallBack());
            ServiceReference1.ServiceCallbackClient server = new ServiceReference1.ServiceCallbackClient(context);

            Console.WriteLine("Enter username");
            string nama = Console.ReadLine();
            server.gabung(nama);

            Console.WriteLine("Kirim Pesan");
            string pesan = Console.ReadLine();
            
            //memeriksa apakah pesan null
            while(true)
            {
                if (!string.IsNullOrEmpty(pesan)) server.kirimPesan(pesan);
                Console.WriteLine("Kirim Pesan");
                pesan = Console.ReadLine();
            }
        }
    }
    public class ClientCallBack : ServiceReference1.IServiceCallbackCallback
    {
        public void pesanKirim(string user, string pesan)
        {
            Console.WriteLine("{0}: {1}", user, pesan);
        }
    }
}
