using OrdersApi.Model;
using System.Collections.Generic;

namespace OrdersApi.Contract
{
    public interface IDataClient
    {
        void AddClient(Client client);

        Client SearchClient(long id);

        List<Client> ListClient();

        void DeleteClient(long id);
    }
}
