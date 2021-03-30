using OrderAPi.Datos;
using OrdersApi.Contract;
using OrdersApi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdersApi.Control
{
    public class ControlClient : IControlClient
    {
        IDataClient data;

        public ControlClient()
        {
            data = new DataClient();
        }

        public void AddClient(Client client)
        {
            data.AddClient(client);
        }

        public Client SearchClient(long id)
        {
            return data.SearchClient(id);
        }
        public void DeleteClient(long id)
        {
            data.DeleteClient(id);
        }

        public List<Client> ListClient()
        {
            return data.ListClient();
        }

        
    }
}
