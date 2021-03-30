
using OrdersApi.Contract;
using OrdersApi.Model;
using System.Collections.Generic;
using System.Linq;

namespace OrderAPi.Datos
{
    public class DataClient : IDataClient
    {
        OrderDBEntities Db;
        public DataClient()
        {
            Db = new OrderDBEntities();
        }

        public void AddClient(Client client)
        {
            Db.Client.Add(client);
            Db.SaveChanges();
        }

        public Client SearchClient(long id)
        {
            return Db.Client.Find(id);
        }

        public void DeleteClient(long id)
        {
            var client = SearchClient(id);

            if(client != null)
            {
                Db.Client.Remove(client);
                Db.SaveChanges();
            }
        }

        public List<Client> ListClient()
        {
            return Db.Client.ToList();
        }

        
    }
}
